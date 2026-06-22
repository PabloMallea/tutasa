using System;
using System.Collections.Generic;
using System.Linq;

namespace tutasa.Imposicion_Agencia
{
    internal partial class ImposicionAgenciaModelo
    {
        // ----------------------------------------------------------------------
        // 1. MÉTODOS DE LECTURA Y BÚSQUEDA
        // ----------------------------------------------------------------------
        public List<string> ObtenerDimensiones()
        {
            List<string> resultado = new List<string>();
            foreach (string nombreDimension in Enum.GetNames(typeof(tutasa.Almacenes.DimensionEnum)))
            {
                resultado.Add(nombreDimension);
            }
            return resultado;
        }

        public Cliente BuscarCliente(string cuit)
        {
            // Blindaje contra "Cajero Arrepentido" (Evita Exception si llega vacío)
            if (!long.TryParse(cuit, out long cuitNumerico)) return null;

            var clienteDelJson = tutasa.Almacenes.ClientesAlmacen.clientes.Find(c => c.CuitCliente == cuitNumerico);
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
            var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == nombre);
            if (localidadEntidad == null) return null;
            return new Localidad { Nombre = localidadEntidad.NombreLocalidad };
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
                    resultado.Add(new Agencia { Nombre = agenciaJson.NombreAgencia, Calle = agenciaJson.Calle, Altura = alturaAgencia, Localidad = localidadEntidad.NombreLocalidad });
                }
            }
            return resultado;
        }

        // -------------------------------------------------------------------------
        // NUEVOS MÉTODOS PARA MANEJO DE PROVINCIAS Y LOCALIDADES (UI DESPLEGABLES)
        // -------------------------------------------------------------------------

        public List<Provincias> ObtenerProvincias()
        {
            List<Provincias> listaProvincias = new List<Provincias>();

            // 1. Vamos al Almacén y traemos todas las entidades
            foreach (var provEntidad in tutasa.Almacenes.ProvinciaAlmacen.provincias)
            {
                // 2. Mapeamos (traducimos) la entidad de BD a tu clase local del modelo
                Provincias provLocal = new Provincias
                {
                    idProvincia = provEntidad.idProvincia,
                    nombreProvincia = provEntidad.nombreProvincia
                };

                listaProvincias.Add(provLocal);
            }

            // 3. Devolvemos la lista ordenada alfabéticamente
            return listaProvincias.OrderBy(p => p.nombreProvincia).ToList();
        }

        public List<Localidad> ObtenerLocalidadesPorProvincia(int idProvinciaSeleccionada)
        {
            List<Localidad> listaLocalidades = new List<Localidad>();

            // 1. Filtramos en el Almacén solo las localidades de la provincia elegida
            var localidadesFiltradas = tutasa.Almacenes.LocalidadAlmacen.localidades
                                       .Where(l => l.idProvincia == idProvinciaSeleccionada);

            // 2. Recorremos y mapeamos
            foreach (var locEntidad in localidadesFiltradas)
            {
                Localidad locLocal = new Localidad
                {
                    // Ojo acá: mapeamos 'NombreLocalidad' del JSON al atributo 'Nombre' de tu clase local
                    Nombre = locEntidad.NombreLocalidad,
                    idProvincia = locEntidad.idProvincia
                };

                listaLocalidades.Add(locLocal);
            }

            // 3. Devolvemos ordenadas alfabéticamente
            return listaLocalidades.OrderBy(l => l.Nombre).ToList();
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
                resultado.Add(new CentroDistribucion { Nombre = cdJson.NombreCD, Calle = cdJson.Calle, Altura = alturaCd, Localidad = localidadEntidad.NombreLocalidad });
            }
            return resultado;
        }

        // ----------------------------------------------------------------------
        // 2. NÚCLEO: CREACIÓN DE LA GUÍA (Ahora devuelve numero de guía)
        // ----------------------------------------------------------------------
        public int GuardarGuia(Guia guiaLocal)
        {
            tutasa.Almacenes.GuiaEntidad nuevaGuia = new tutasa.Almacenes.GuiaEntidad();

            // 1. Autoincremental
            int ultimoNumero = tutasa.Almacenes.GuiaAlmacen.guias.Count > 0 ? tutasa.Almacenes.GuiaAlmacen.guias.Max(g => g.NumeroGuia) : 0;
            nuevaGuia.NumeroGuia = ultimoNumero + 1;

            // 2. Transcripción directa
            nuevaGuia.FechaAlta = DateTime.Now;
            nuevaGuia.CuitCliente = long.Parse(guiaLocal.Cliente.Cuit);
            nuevaGuia.CalleDestino = guiaLocal.CalleDestino;
            nuevaGuia.AlturaDestino = guiaLocal.AlturaDestino;
            nuevaGuia.NombreDestinatario = guiaLocal.NombreDestinatario;
            nuevaGuia.ApellidoDestinatario = guiaLocal.ApellidoDestinatario;
            nuevaGuia.DniDestinatario = guiaLocal.DniDestinatario;
            nuevaGuia.TelefonoDestinatario = guiaLocal.TelefonoDestinatario;
            nuevaGuia.Dimension = (tutasa.Almacenes.DimensionEnum)Enum.Parse(typeof(tutasa.Almacenes.DimensionEnum), guiaLocal.Dimension);

            // 3. Reglas de Origen (¡La Clave de esta pantalla!)
            nuevaGuia.TipoRetiro = tutasa.Almacenes.TipoRetiroEnum.EnAgencia;
            nuevaGuia.IdAgenciaRetiro = tutasa.Program.IdAgenciaActual;

            // Buscamos la agencia actual para saber a qué CD enviar el camión a retirar
            var agenciaOrigen = tutasa.Almacenes.AgenciasAlmacen.agencias.Find(a => a.IdAgencia == tutasa.Program.IdAgenciaActual);
            if (agenciaOrigen != null)
            {
                nuevaGuia.IdCDOrigen = agenciaOrigen.IdCD;
            }
            else
            {
                throw new Exception("Error de configuración: La Agencia actual no existe en el sistema."); //Esto pasa si pongo una agencia en el program que no existe en el json
            }

            nuevaGuia.IntentosEntrega = 0;

            // 4. Enrutamiento del Destino (Con blindaje lógico)
            if (guiaLocal.Destino == "Domicilio Destinatario")
            {
                nuevaGuia.Destino = tutasa.Almacenes.DestinoGuiaEnum.Domicilio;
                nuevaGuia.IdAgenciaDestino = 0;
                var localidadEntidad = tutasa.Almacenes.LocalidadAlmacen.localidades.Find(l => l.NombreLocalidad == guiaLocal.LocalidadDestino);
                if (localidadEntidad != null)
                {
                    var cdsEnLocalidad = tutasa.Almacenes.CentroDistribucionAlmacen.CentrosDistribucion.FindAll(cd => cd.IdLocalidad == localidadEntidad.IdLocalidad);
                    if (cdsEnLocalidad.Count > 0)
                    {
                        nuevaGuia.IdCDDestino = cdsEnLocalidad.OrderBy(cd => cd.IdCD).First().IdCD;
                    }
                    else
                    {
                        throw new Exception($"Nuestra red logística aún no cuenta con un Centro de Distribución en {guiaLocal.LocalidadDestino} para procesar entregas a domicilio.");
                    }
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
                        nuevaGuia.Destino = tutasa.Almacenes.DestinoGuiaEnum.Agencia;
                        nuevaGuia.IdAgenciaDestino = agenciaDestino.IdAgencia;
                        nuevaGuia.IdCDDestino = agenciaDestino.IdCD;
                    }
                    else
                    {
                        // 3. Si no es agencia, verificamos si es un CD de esa misma ciudad local
                        var cdDestino = cdsEnLaLocalidad.Find(cd => cd.NombreCD == guiaLocal.Destino);
                        if (cdDestino != null)
                        {
                            nuevaGuia.Destino = tutasa.Almacenes.DestinoGuiaEnum.CD;
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

            // 5. Cálculos Financieros Diferidos (Cobrarán en el CD cuando el fletero lo lleve)
            nuevaGuia.MontoFacturar = 0;
            nuevaGuia.ComisionesAgenciaOrigen = 0;
            nuevaGuia.ComisionesAgenciaDestino = 0;
            nuevaGuia.ComisionesFleteroOrigen = 0;
            nuevaGuia.ComisionesFleteroDestino = 0;

            // 6. Historial y Trazabilidad (Nace en el mostrador de la Agencia)
            nuevaGuia.EstadoActual = tutasa.Almacenes.EstadoGuiaEnum.Impuesta;
            string nombreUbicacion = agenciaOrigen != null ? agenciaOrigen.NombreAgencia : "Agencia Origen";

            nuevaGuia.Historial.Add(new tutasa.Almacenes.MovimientoEstadoDto
            {
                Estado = tutasa.Almacenes.EstadoGuiaEnum.Impuesta,
                FechaHora = DateTime.Now,
                Ubicacion = nombreUbicacion
            });

            // 7. Impacto en Memoria
            tutasa.Almacenes.GuiaAlmacen.guias.Add(nuevaGuia);

            return nuevaGuia.NumeroGuia; // Respondemos con el número de Tracking al Formulario
        }
    }
}