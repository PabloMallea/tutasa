using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.Imposicion_CD
{
    internal partial class ImposicionCDModelo
    {
        // ----------------------------------------------------------------------
        // 1. MÉTODOS DE BÚSQUEDA Y LECTURA
        // ----------------------------------------------------------------------
        public Cliente BuscarCliente(string cuit)
        {
            long cuitNumerico = long.Parse(cuit);
            var clienteDelJson = ClientesAlmacen.clientes.Find(c => c.CuitCliente == cuitNumerico);
            if (clienteDelJson == null) return null;

            return new Cliente
            {
                Cuit = clienteDelJson.CuitCliente.ToString(),
                Nombre = clienteDelJson.Nombre,
                Apellido = clienteDelJson.Apellido,
                Telefono = clienteDelJson.Telefono
            };
        }

        public Localidad BuscarLocalidad(string nombre)
        {
            var localidadEntidad = LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == nombre);
            if (localidadEntidad == null) return null;
            return new Localidad { Nombre = localidadEntidad.NombreLocalidad };
        }

        public List<CentroDistribucion> ObtenerCD(string localidad)
        {
            List<CentroDistribucion> resultado = new List<CentroDistribucion>();
            var localidadEntidad = LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == localidad);
            if (localidadEntidad == null) return resultado;

            var cdsJson = CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);
            foreach (var cdJson in cdsJson)
            {
                long alturaCd = 0;
                long.TryParse(cdJson.Altura, out alturaCd);
                resultado.Add(new CentroDistribucion { Nombre = cdJson.NombreCD, Calle = cdJson.Calle, Altura = alturaCd });
            }
            return resultado;
        }

        public List<Agencia> ObtenerAgencias(string localidad)
        {
            List<Agencia> resultado = new List<Agencia>();
            var localidadEntidad = LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == localidad);
            if (localidadEntidad == null) return resultado;

            foreach (var agenciaJson in AgenciasAlmacen.agencias)
            {
                var cdDeLaAgencia = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == agenciaJson.IdCD);
                if (cdDeLaAgencia != null && cdDeLaAgencia.IdLocalidad == localidadEntidad.IdLocalidad)
                {
                    long alturaAgencia = 0;
                    long.TryParse(agenciaJson.Altura, out alturaAgencia);
                    resultado.Add(new Agencia { Nombre = agenciaJson.NombreAgencia, Calle = agenciaJson.Calle, Altura = alturaAgencia });
                }
            }
            return resultado;
        }

        public string CalcularDimension(decimal peso)
        {
            // Usamos el Enum de los almacenes y lo convertimos a texto de forma segura
            if (peso <= 2.5m) return tutasa.Almacenes.DimensionEnum.S.ToString();
            if (peso <= 5m) return tutasa.Almacenes.DimensionEnum.M.ToString();
            if (peso <= 10m) return tutasa.Almacenes.DimensionEnum.L.ToString();

            return tutasa.Almacenes.DimensionEnum.XL.ToString();
        }

        // ----------------------------------------------------------------------
        // 3. NÚCLEO DEL MODELO: GUARDADO Y GENERACIÓN
        // ----------------------------------------------------------------------
        public void GuardarGuia(Guia guiaLocal)
        {
            GuiaEntidad nuevaGuia = new GuiaEntidad();

            // 1. Autoincremental
            int ultimoNumero = GuiaAlmacen.guias.Count > 0 ? GuiaAlmacen.guias.Max(g => g.NumeroGuia) : 0;
            nuevaGuia.NumeroGuia = ultimoNumero + 1;

            // 2. Transcripción de datos
            nuevaGuia.FechaAlta = DateTime.Now;
            nuevaGuia.CuitCliente = long.Parse(guiaLocal.Cliente.Cuit);
            nuevaGuia.CalleDestino = guiaLocal.CalleDestino;
            nuevaGuia.AlturaDestino = guiaLocal.AlturaDestino;
            nuevaGuia.NombreDestinatario = guiaLocal.NombreDestinatario;
            nuevaGuia.ApellidoDestinatario = guiaLocal.ApellidoDestinatario;
            nuevaGuia.DniDestinatario = guiaLocal.DniDestinatario;
            nuevaGuia.TelefonoDestinatario = guiaLocal.TelefonoDestinatario;
            nuevaGuia.Dimension = (DimensionEnum)Enum.Parse(typeof(DimensionEnum), guiaLocal.Dimension);

            // 3. Reglas Fijas del Negocio (Estamos en un mostrador de CD)
            nuevaGuia.IdCDOrigen = tutasa.Program.IdCDActual;
            nuevaGuia.TipoRetiro = TipoRetiroEnum.RecibidoEnCD;
            nuevaGuia.IdAgenciaRetiro = 0;
            nuevaGuia.IntentosEntrega = 0;

            // 4. Enrutamiento Inteligente del Destino
            if (guiaLocal.Destino == "Domicilio Destinatario")
            {
                nuevaGuia.Destino = DestinoGuiaEnum.Domicilio;
                nuevaGuia.IdAgenciaDestino = 0;
                var localidadEntidad = LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == guiaLocal.LocalidadDestino);
                if (localidadEntidad != null)
                {
                    var cdsEnLocalidad = CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);
                    if (cdsEnLocalidad.Count > 0)
                    {
                        nuevaGuia.IdCDDestino = cdsEnLocalidad.OrderBy(cd => cd.IdCD).First().IdCD;
                    }
                }
            }
            else
            {
                var agenciaDestino = AgenciasAlmacen.agencias.Find(a => a.NombreAgencia == guiaLocal.Destino);
                if (agenciaDestino != null)
                {
                    nuevaGuia.Destino = DestinoGuiaEnum.Agencia;
                    nuevaGuia.IdAgenciaDestino = agenciaDestino.IdAgencia;
                    nuevaGuia.IdCDDestino = agenciaDestino.IdCD;
                }
                else
                {
                    var cdDestino = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.NombreCD == guiaLocal.Destino);
                    if (cdDestino != null)
                    {
                        nuevaGuia.Destino = DestinoGuiaEnum.CD;
                        nuevaGuia.IdAgenciaDestino = 0;
                        nuevaGuia.IdCDDestino = cdDestino.IdCD;
                    }
                }
            }

            // 5. Cálculos Económicos (Fusión)
            decimal tarifaBase = CalcularTarifaBase(nuevaGuia.IdCDOrigen, nuevaGuia.IdCDDestino, nuevaGuia.Dimension);
            decimal extras = CalcularExtras(nuevaGuia.TipoRetiro, nuevaGuia.Destino);

            nuevaGuia.MontoFacturar = tarifaBase + extras;
            CalcularYAsignarComisiones(nuevaGuia, nuevaGuia.Dimension);

            // 6. Historial de Trazabilidad (Impuesta y Admitida instantáneamente)
            nuevaGuia.EstadoActual = EstadoGuiaEnum.Admitida;
            var cdOrigen = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == tutasa.Program.IdCDActual);
            string nombreUbicacion = cdOrigen != null ? cdOrigen.NombreCD : "Centro de Distribución";

            nuevaGuia.Historial.Add(new MovimientoEstadoDto
            {
                Estado = EstadoGuiaEnum.Impuesta,
                FechaHora = DateTime.Now,
                Ubicacion = nombreUbicacion
            });

            nuevaGuia.Historial.Add(new MovimientoEstadoDto
            {
                Estado = EstadoGuiaEnum.Admitida,
                FechaHora = DateTime.Now.AddSeconds(1), // Retraso de un segundo visual para ordenamiento
                Ubicacion = nombreUbicacion
            });

            // 7. Impacto en Memoria
            GuiaAlmacen.guias.Add(nuevaGuia);
        }

        // ----------------------------------------------------------------------
        // 4. MÉTODOS PRIVADOS FINANCIEROS (Acoplados de Admisión)
        // ----------------------------------------------------------------------
        private decimal CalcularTarifaBase(int idCDOrigen, int idCDDestino, DimensionEnum dimension)
        {
            var cdOrigen = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(c => c.IdCD == idCDOrigen);
            var cdDestino = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(c => c.IdCD == idCDDestino);

            if (cdOrigen == null || cdDestino == null) throw new Exception("Error interno: No se encontraron los Centros de Distribución origen o destino.");

            var tarifa = TarifasAlmacen.Tarifas.FirstOrDefault(t =>
                t.IdLocalidadOrigen == cdOrigen.IdLocalidad &&
                t.IdLocalidadDestino == cdDestino.IdLocalidad &&
                t.Dimension == dimension);

            if (tarifa == null) throw new Exception($"No se encontró tarifa en el sistema para esta ruta y dimensión ({dimension}).");

            return tarifa.Precio;
        }

        private decimal CalcularExtras(TipoRetiroEnum tipoRetiro, DestinoGuiaEnum destino)
        {
            decimal totalExtras = 0;

            // Extra por tipo de entrega (Recordemos que el retiro extra en este caso no aplica porque es en mostrador CD)
            if (destino == DestinoGuiaEnum.Agencia)
            {
                var extraEntregaAgencia = tutasa.Almacenes.ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == tutasa.Almacenes.TipoExtraEnum.EntregaEnAgencia);
                if (extraEntregaAgencia != null) totalExtras += extraEntregaAgencia.Precio;
            }
            else if (destino == DestinoGuiaEnum.Domicilio)
            {
                // Agregamos el cobro extra por llevar el paquete hasta la puerta de la casa
                var extraEntregaDomicilio = tutasa.Almacenes.ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == tutasa.Almacenes.TipoExtraEnum.Entrega);
                if (extraEntregaDomicilio != null) totalExtras += extraEntregaDomicilio.Precio;
            }

            return totalExtras;
        }

        private void CalcularYAsignarComisiones(GuiaEntidad guia, DimensionEnum dimension)
        {
            guia.ComisionesAgenciaOrigen = 0;
            guia.ComisionesAgenciaDestino = 0;
            guia.ComisionesFleteroOrigen = 0;
            guia.ComisionesFleteroDestino = 0;

            // Solo cobramos comisión de agencia de destino si el paquete termina allí
            if (guia.Destino == DestinoGuiaEnum.Agencia)
            {
                var comisionAgencia = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Agencia && c.Dimension == dimension);
                guia.ComisionesAgenciaDestino = comisionAgencia?.Precio ?? 0;
            }

            // Comisión de Fletero de destino si se reparte por la ciudad o agencia
            if (guia.Destino == DestinoGuiaEnum.Domicilio || guia.Destino == DestinoGuiaEnum.Agencia)
            {
                var comisionFletero = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Fletero && c.Dimension == dimension);
                guia.ComisionesFleteroDestino = comisionFletero?.Precio ?? 0;
            }
        }
    }
}