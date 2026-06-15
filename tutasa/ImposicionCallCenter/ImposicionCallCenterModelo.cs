using System;
using System.Collections.Generic;
using System.Text;
using tutasa.Almacenes;

namespace tutasa.ImposicionCallCenter
{
    internal partial class ImposicionCallCenterModelo
    {
        public int idCDActual = Program.IdCDActual; //Asi tengo en mi modelo el CD donde estoy parado

        public List<string> ObtenerDimensiones()
        {
            List<string> resultado = new List<string>();

            // Leemos dinámicamente los valores del DimensionEnum que está en los Almacenes
            foreach (string nombreDimension in Enum.GetNames(typeof(tutasa.Almacenes.DimensionEnum)))
            {
                resultado.Add(nombreDimension);
            }

            return resultado;
        }

        public Cliente BuscarCliente(string cuit)
        {
            // EL FIX: Usamos TryParse para prevenir el Crash por formato inválido o campo vacío
            if (!long.TryParse(cuit, out long cuitNumerico)) return null;

            var clienteDelJson = tutasa.Almacenes.ClientesAlmacen.clientes.Find(c => c.CuitCliente == cuitNumerico);

            if (clienteDelJson == null) return null;

            var localidadDelJson = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.IdLocalidad == clienteDelJson.IdLocalidad);
            string nombreLocalidad = localidadDelJson != null ? localidadDelJson.NombreLocalidad : "Desconocida";

            return new Cliente
            {
                Cuit = clienteDelJson.CuitCliente.ToString(),
                Nombre = clienteDelJson.Nombre,
                Apellido = clienteDelJson.Apellido,
                Telefono = clienteDelJson.Telefono,
                Calle = clienteDelJson.Calle,
                Altura = clienteDelJson.Altura,
                Localidad = nombreLocalidad
            };
        }

        public Localidad BuscarLocalidad(string nombre)
        {
            var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == nombre);
            if (localidadEntidad == null) return null;
            return new Localidad { Nombre = localidadEntidad.NombreLocalidad };
        }

        public List<CentroDistribucion> ObtenerCD(string localidad)
        {
            List<CentroDistribucion> resultado = new List<CentroDistribucion>();
            var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == localidad);
            if (localidadEntidad == null) return resultado;

            var cdsJson = tutasa.Almacenes.CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);

            foreach (var cdJson in cdsJson)
            {
                long alturaCd = 0;
                long.TryParse(cdJson.Altura, out alturaCd);

                resultado.Add(new CentroDistribucion
                {
                    IdCd = cdJson.IdCD,
                    Localidad = localidadEntidad.NombreLocalidad,
                    Nombre = cdJson.NombreCD,
                    Calle = cdJson.Calle,
                    Altura = alturaCd
                });
            }
            return resultado;
        }

        public List<Agencia> ObtenerAgencias(string localidad)
        {
            List<Agencia> resultado = new List<Agencia>();
            var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == localidad);
            if (localidadEntidad == null) return resultado;

            foreach (var agenciaJson in tutasa.Almacenes.AgenciasAlmacen.agencias)
            {
                var cdDeLaAgencia = tutasa.Almacenes.CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == agenciaJson.IdCD);

                if (cdDeLaAgencia != null && cdDeLaAgencia.IdLocalidad == localidadEntidad.IdLocalidad)
                {
                    long alturaAgencia = 0;
                    long.TryParse(agenciaJson.Altura, out alturaAgencia);

                    resultado.Add(new Agencia
                    {
                        IdAgencia = agenciaJson.IdAgencia,
                        IdCd = agenciaJson.IdCD,
                        Localidad = localidadEntidad.NombreLocalidad,
                        Nombre = agenciaJson.NombreAgencia,
                        Calle = agenciaJson.Calle,
                        Altura = alturaAgencia
                    });
                }
            }
            return resultado;
        }

        // Guardar Guia generada
        public int GuardarGuia(Guia guiaLocal)
        {
            // 1. Instanciamos la entidad oficial que va a viajar al JSON
            GuiaEntidad nuevaGuia = new GuiaEntidad();

            // 2. AUTOINCREMENTAL: Buscamos el último número de guía y le sumamos 1
            int ultimoNumero = 0;
            if (tutasa.Almacenes.GuiaAlmacen.guias.Count > 0)
            {
                ultimoNumero = tutasa.Almacenes.GuiaAlmacen.guias.Max(g => g.NumeroGuia);
            }
            nuevaGuia.NumeroGuia = ultimoNumero + 1;

            // 3. TRADUCCIÓN DIRECTA: Datos que pasan tal cual
            nuevaGuia.FechaAlta = DateTime.Now;
            nuevaGuia.CuitCliente = long.Parse(guiaLocal.Cliente.Cuit);
            nuevaGuia.CalleDestino = guiaLocal.CalleDestino;
            nuevaGuia.AlturaDestino = guiaLocal.AlturaDestino;
            nuevaGuia.NombreDestinatario = guiaLocal.NombreDestinatario;
            nuevaGuia.ApellidoDestinatario = guiaLocal.ApellidoDestinatario;
            nuevaGuia.DniDestinatario = guiaLocal.DniDestinatario;
            nuevaGuia.TelefonoDestinatario = guiaLocal.TelefonoDestinatario;

            // 4. ADAPTADOR DE ENUMS: Convertimos textos a Tipos Oficiales
            nuevaGuia.Dimension = (DimensionEnum)Enum.Parse(typeof(DimensionEnum), guiaLocal.Dimension);
            nuevaGuia.EstadoActual = EstadoGuiaEnum.Impuesta; // El estado inicial al crear

            // 5. INTELIGENCIA RELACIONAL: ¿A dónde va la encomienda?
            if (guiaLocal.Destino == "Domicilio Destinatario")
            {
                nuevaGuia.Destino = DestinoGuiaEnum.Domicilio;
                nuevaGuia.IdAgenciaDestino = 0; // Aseguramos que inicie en 0

                var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == guiaLocal.LocalidadDestino);
                if (localidadEntidad != null)
                {
                    var cdsEnLocalidad = tutasa.Almacenes.CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);

                    if (cdsEnLocalidad.Count > 0)
                    {
                        var cdDestino = cdsEnLocalidad.OrderBy(cd => cd.IdCD).First();
                        nuevaGuia.IdCDDestino = cdDestino.IdCD;
                    }
                    else
                    {
                        // FIX LOGICO: Controlar si no hay galpones en la ciudad para entregar a domicilio
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
                // FIX NACIONAL: Filtramos estrictamente por la localidad de destino
                var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == guiaLocal.LocalidadDestino);

                if (localidadEntidad != null)
                {
                    // 1. Aislamos solo los CDs que pertenecen a esa ciudad
                    var cdsEnLaLocalidad = tutasa.Almacenes.CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);

                    // 2. Buscamos la Agencia que se llame igual Y que pertenezca a la red de esos CDs locales
                    var agenciaDestino = tutasa.Almacenes.AgenciasAlmacen.agencias.Find(a =>
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
                        // 3. Si no es agencia, verificamos si es un CD de esa misma ciudad local
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

            // ----------------------------------------------------------------------
            // 🛡️ INICIALIZACIÓN DEFENSIVA
            // ----------------------------------------------------------------------

            // 1. DATOS DE ORIGEN Y RETIRO
            // ¡Aca usamos la variable global que vi en tu Program.cs! 
            // Como el Call Center siempre impone en un CD, tomamos el CD en el que está logueado el sistema.
            nuevaGuia.IdCDOrigen = tutasa.Program.IdCDActual; //¡¡OJO!! Bajo esta idea una guía podría ser impuesta y admitida en dos CD distintos

            // Si el Call Center toma el pedido, generalmente es para buscar por la casa del cliente.
            // (Asegurate de que el Enum se llame así en tu archivo de Almacenes, si no, cambialo por el correcto).
            nuevaGuia.TipoRetiro = TipoRetiroEnum.EnDomicilio;

            // Como se retira por domicilio, no hay agencia de retiro involucrada (nace en 0).
            nuevaGuia.IdAgenciaRetiro = 0;

            // 2. DATOS DE DISTRIBUCIÓN
            // Recién nace la guía, así que nadie intentó entregarla todavía.
            nuevaGuia.IntentosEntrega = 0;

            // 3. DATOS DE FACTURACIÓN Y CUENTA CORRIENTE (Los inicializamos en 0)
            // Cuando el paquete llegue a la sucursal, lo pesarán y le calcularán el precio real.
            nuevaGuia.MontoFacturar = 0;

            // 4. DATOS DE COMISIONES (Para que no explote el módulo de Transporte)
            nuevaGuia.ComisionesAgenciaOrigen = 0;
            nuevaGuia.ComisionesAgenciaDestino = 0;
            nuevaGuia.ComisionesFleteroOrigen = 0;
            nuevaGuia.ComisionesFleteroDestino = 0;

            // ----------------------------------------------------------------------

            // 6. HISTORIAL: Agregamos el primer movimiento (Nacimiento de la guía)

            // 6. HISTORIAL: Agregamos el primer movimiento (Nacimiento de la guía)

            // Como la guía nace por un pedido telefónico del cliente, la ubicación física real del paquete en este instante es su domicilio.
            nuevaGuia.Historial.Add(new MovimientoEstadoDto
            {
                Estado = EstadoGuiaEnum.Impuesta,
                FechaHora = DateTime.Now,
                Ubicacion = "Domicilio del Cliente"
            });

            // 7. EL IMPACTO EN LA MEMORIA RAM
            // Solo agregamos a la lista. El método .Guardar() lo va a ejecutar Program.cs al final.
            tutasa.Almacenes.GuiaAlmacen.guias.Add(nuevaGuia);

            //Retornamos el número que acabamos de crear hacia el formulario
            return nuevaGuia.NumeroGuia;
        }
    }
}