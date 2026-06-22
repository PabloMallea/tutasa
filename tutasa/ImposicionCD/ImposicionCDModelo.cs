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
            if (!long.TryParse(cuit, out long cuitNumerico)) return null;

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

        // --- NUEVOS MÉTODOS DE PROVINCIAS ---
        public List<Provincias> ObtenerProvincias()
        {
            List<Provincias> listaProvincias = new List<Provincias>();

            foreach (var provEntidad in ProvinciaAlmacen.provincias)
            {
                listaProvincias.Add(new Provincias
                {
                    idProvincia = provEntidad.idProvincia,
                    nombreProvincia = provEntidad.nombreProvincia
                });
            }
            return listaProvincias.OrderBy(p => p.nombreProvincia).ToList();
        }

        public List<Localidad> ObtenerLocalidadesPorProvincia(int idProvinciaSeleccionada)
        {
            List<Localidad> listaLocalidades = new List<Localidad>();

            var localidadesFiltradas = LocalidadAlmacen.localidades.Where(l => l.idProvincia == idProvinciaSeleccionada);

            foreach (var locEntidad in localidadesFiltradas)
            {
                listaLocalidades.Add(new Localidad
                {
                    Nombre = locEntidad.NombreLocalidad,
                    idProvincia = locEntidad.idProvincia
                });
            }
            return listaLocalidades.OrderBy(l => l.Nombre).ToList();
        }
        // ------------------------------------

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
            if (peso <= 2.5m) return DimensionEnum.S.ToString();
            if (peso <= 5m) return DimensionEnum.M.ToString();
            if (peso <= 10m) return DimensionEnum.L.ToString();

            return DimensionEnum.XL.ToString();
        }

        // ----------------------------------------------------------------------
        // 3. NÚCLEO DEL MODELO: GUARDADO Y GENERACIÓN
        // ----------------------------------------------------------------------
        public int GuardarGuia(Guia guiaLocal)
        {
            GuiaEntidad nuevaGuia = new GuiaEntidad();

            int ultimoNumero = GuiaAlmacen.guias.Count > 0 ? GuiaAlmacen.guias.Max(g => g.NumeroGuia) : 0;
            nuevaGuia.NumeroGuia = ultimoNumero + 1;

            nuevaGuia.FechaAlta = DateTime.Now;
            nuevaGuia.CuitCliente = long.Parse(guiaLocal.Cliente.Cuit);
            nuevaGuia.CalleDestino = guiaLocal.CalleDestino;
            nuevaGuia.AlturaDestino = guiaLocal.AlturaDestino;
            nuevaGuia.NombreDestinatario = guiaLocal.NombreDestinatario;
            nuevaGuia.ApellidoDestinatario = guiaLocal.ApellidoDestinatario;
            nuevaGuia.DniDestinatario = guiaLocal.DniDestinatario;
            nuevaGuia.TelefonoDestinatario = guiaLocal.TelefonoDestinatario;
            nuevaGuia.Dimension = (DimensionEnum)Enum.Parse(typeof(DimensionEnum), guiaLocal.Dimension);

            nuevaGuia.IdCDOrigen = tutasa.Program.IdCDActual;
            nuevaGuia.TipoRetiro = TipoRetiroEnum.RecibidoEnCD;
            nuevaGuia.IdAgenciaRetiro = 0;
            nuevaGuia.IntentosEntrega = 0;

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
                    else
                    {
                        throw new Exception($"Nuestra red logística aún no cuenta con un Centro de Distribución en {guiaLocal.LocalidadDestino} para procesar entregas a domicilio.");
                    }
                }
                else
                {
                    throw new Exception("Localidad de destino no encontrada en el sistema central.");
                }
            }
            else
            {
                var localidadEntidad = LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == guiaLocal.LocalidadDestino);

                if (localidadEntidad != null)
                {
                    var cdsEnLaLocalidad = CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);

                    var agenciaDestino = AgenciasAlmacen.agencias.Find(a =>
                        a.NombreAgencia == guiaLocal.Destino &&
                        cdsEnLaLocalidad.Any(cd => cd.IdCD == a.IdCD)
                    );

                    if (agenciaDestino != null)
                    {
                        nuevaGuia.Destino = DestinoGuiaEnum.Agencia;
                        nuevaGuia.IdAgenciaDestino = agenciaDestino.IdAgencia;
                        nuevaGuia.IdCDDestino = agenciaDestino.IdCD;
                    }
                    else
                    {
                        var cdDestino = cdsEnLaLocalidad.Find(cd => cd.NombreCD == guiaLocal.Destino);

                        if (cdDestino != null)
                        {
                            nuevaGuia.Destino = DestinoGuiaEnum.CD;
                            nuevaGuia.IdAgenciaDestino = 0;
                            nuevaGuia.IdCDDestino = cdDestino.IdCD;
                        }
                    }
                }
                else
                {
                    throw new Exception("Localidad de destino no encontrada en el sistema central.");
                }
            }

            decimal tarifaBase = CalcularTarifaBase(nuevaGuia.IdCDOrigen, nuevaGuia.IdCDDestino, nuevaGuia.Dimension);
            decimal extras = CalcularExtras(nuevaGuia.TipoRetiro, nuevaGuia.Destino);

            nuevaGuia.MontoFacturar = tarifaBase + extras;
            CalcularYAsignarComisiones(nuevaGuia, nuevaGuia.Dimension);

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
                FechaHora = DateTime.Now.AddSeconds(1),
                Ubicacion = nombreUbicacion
            });

            GuiaAlmacen.guias.Add(nuevaGuia);

            return nuevaGuia.NumeroGuia;
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

            if (destino == DestinoGuiaEnum.Agencia)
            {
                var extraEntregaAgencia = ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == TipoExtraEnum.EntregaEnAgencia);
                if (extraEntregaAgencia != null) totalExtras += extraEntregaAgencia.Precio;
            }
            else if (destino == DestinoGuiaEnum.Domicilio)
            {
                var extraEntregaDomicilio = ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == TipoExtraEnum.Entrega);
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

            if (guia.Destino == DestinoGuiaEnum.Agencia)
            {
                var comisionAgencia = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Agencia && c.Dimension == dimension);
                guia.ComisionesAgenciaDestino = comisionAgencia?.Precio ?? 0;
            }

            if (guia.Destino == DestinoGuiaEnum.Domicilio || guia.Destino == DestinoGuiaEnum.Agencia)
            {
                var comisionFletero = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Fletero && c.Dimension == dimension);
                guia.ComisionesFleteroDestino = comisionFletero?.Precio ?? 0;
            }
        }
    }
}