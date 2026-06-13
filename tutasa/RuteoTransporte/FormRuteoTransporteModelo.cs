using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using tutasa.Admision;
using tutasa.Almacenes;

namespace tutasa.RuteoTransporte
{
    internal class FormRuteoTransporteModelo
    {
        private int idCDActual = 1;

        // CLASES DE PANTALLA

        public class Guia
        {
            public int Numero { get; set; }

            public string Localidad { get; set; }

            public string Direccion { get; set; }

            public string Dimension { get; set; }

            public string Cliente { get; set; }

            public string Cuit { get; set; }

            public string CdDestino { get; set; }

        }

        public class CD
        {
            public int Id { get; set; }

            public string Nombre { get; set; }

        }

        public class EmpresaTransporte
        {
            public int Id { get; set; }

            public string Nombre { get; set; }

        }

        public class Servicio
        {
            public int Id { get; set; }

            public string Descripcion { get; set; }

        }

        public class HojaRutaTransporte
        {
            public string Numero { get; set; }

            public string Empresa { get; set; }

            public string Servicio { get; set; }

            public string CDDestino { get; set; }

            public List<Guia> Guias { get; set; }

        }
        public class Localidad
        {
            public int Id { get; set; }

            public string Nombre { get; set; }
        }
        public class Dimension
        {
            public string Nombre { get; set; }
        }
        // COMBOS

        public List<CD> ObtenerCDs()
        {
            List<CD> resultado = new List<CD>();

            foreach (tutasa.Almacenes.CentroDistribucion entidad in CentroDistribucionAlmacen.CentrosDistribucion)
            {
                CD cd = new CD();

                cd.Id = entidad.IdCD;
                cd.Nombre = entidad.NombreCD;

                resultado.Add(cd);
            }

            return resultado;
        }

        public List<Localidad> ObtenerLocalidades()
        {
            List<Localidad> resultado = new List<Localidad>();

            foreach (tutasa.Almacenes.Localidad entidad
                in LocalidadAlmacen.localidades)
            {
                Localidad localidad = new Localidad();

                localidad.Id = entidad.IdLocalidad;
                localidad.Nombre = entidad.NombreLocalidad;

                resultado.Add(localidad);
            }

            return resultado;
        }

        public List<Dimension> ObtenerDimensiones()
        {
            List<Dimension> resultado = new List<Dimension>();

            foreach (DimensionEnum dimension
                in Enum.GetValues(typeof(DimensionEnum)))
            {
                Dimension item = new Dimension();

                item.Nombre = dimension.ToString();

                resultado.Add(item);
            }

            return resultado;
        }

        public List<EmpresaTransporte> ObtenerEmpresas()
        {
            List<EmpresaTransporte> resultado = new List<EmpresaTransporte>();

            foreach (EmpresaTransporteEntidad entidad in EmpresaTransporteAlmacen.empresas)
            {
                EmpresaTransporte empresa =new EmpresaTransporte();

                empresa.Id =entidad.IdEmpresa;

                empresa.Nombre =entidad.NombreEmpresa;

                resultado.Add(empresa);
            }

            return resultado;

        }

        public List<Servicio> ObtenerServicios(int idEmpresa,int idCDDestino)
        {
            List<Servicio> resultado =
            new List<Servicio>();

            foreach (ServicioEntidad entidad in ServiciosAlmacen.servicio)
            {
                if (entidad.IdEmpresa != idEmpresa)
                {
                    continue;
                }

                if (entidad.IdCDOrigen != idCDActual)
                {
                    continue;
                }

                if (entidad.IdCDDestino != idCDDestino)
                {
                    continue;
                }

                if (entidad.EstadoServicio!= EstadoServicioEnum.Pendiente)
                {
                    continue;
                }

                if (entidad.FechaSalida.Date < DateTime.Today)
                {
                    continue;
                }

                Servicio servicio =new Servicio();

                servicio.Id =entidad.IdServicio;

                servicio.Descripcion =entidad.NombreServicio + " - " + entidad.FechaSalida.ToString("dd/MM/yyyy HH:mm") + " - " + entidad.FechaLlegada.ToString("dd/MM/yyyy HH:mm");

                resultado.Add(servicio);
            }

            return resultado;

        }

        // BUSQUEDA

        public List<Guia> BuscarGuias(string cuit,string localidad,string dimension)
        {
            List<Guia> resultado = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (guiaEntidad.EstadoActual != EstadoGuiaEnum.Admitida)
                {
                    continue;
                }

                ClienteEntidad cliente = ClientesAlmacen.clientes.FirstOrDefault(c => c.CuitCliente ==guiaEntidad.CuitCliente);

                if (cliente == null)
                {
                    continue;
                }

                CentroDistribucion cdDestino = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(cd =>cd.IdCD == guiaEntidad.IdCDDestino);

                if (cdDestino == null)
                {
                    continue;
                }

                Almacenes.Localidad localidadDestino =LocalidadAlmacen.localidades.FirstOrDefault(l =>l.IdLocalidad ==cdDestino.IdLocalidad);

                string nombreLocalidad = "";

                if (localidadDestino != null)
                {
                    nombreLocalidad = localidadDestino.NombreLocalidad;
                }

                if (!string.IsNullOrEmpty(cuit))
                {
                    if (cliente.CuitCliente.ToString()!= cuit)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(localidad))
                {
                    if (nombreLocalidad!= localidad)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(dimension))
                {
                    if (guiaEntidad.Dimension.ToString()!= dimension)
                    {
                        continue;
                    }
                }

                Guia guia =new Guia();

                guia.Numero = guiaEntidad.NumeroGuia;

                guia.Localidad =nombreLocalidad;

                guia.Direccion =guiaEntidad.CalleDestino + " "+ guiaEntidad.AlturaDestino;

                guia.Dimension = guiaEntidad.Dimension.ToString();

                guia.Cliente =cliente.Nombre+ " " + cliente.Apellido;

                guia.Cuit = cliente.CuitCliente.ToString();

                guia.CdDestino = cdDestino.NombreCD;

                resultado.Add(guia);
            }

            return resultado;

        }

        // CONFIRMACION

        public int GuardarHojaRuta(HojaRutaTransporte hojaRuta)
        {
            ServicioEntidad servicioSeleccionado =null;

            foreach (ServicioEntidad servicio in ServiciosAlmacen.servicio)
            {
                string descripcion =servicio.NombreServicio + " - " + servicio.FechaSalida.ToString("dd/MM/yyyy HH:mm") + " - " + servicio.FechaLlegada.ToString("dd/MM/yyyy HH:mm");

                if (descripcion == hojaRuta.Servicio)
                {
                    servicioSeleccionado = servicio;

                    break;
                }
            }

            if (servicioSeleccionado == null)
            {
                return 0;
            }

            HojaRutaDeTransporteEntidad hdr = new HojaRutaDeTransporteEntidad();

            hdr.NumeroHDRTransporte =HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Count + 1;

            hdr.IdServicio =servicioSeleccionado.IdServicio;

            hdr.EstadoHDR = EstadoHDRTransporteEnum.Asignada;

            foreach (Guia guiaPantalla in hojaRuta.Guias)
            {
                int numeroGuia = guiaPantalla.Numero;

                hdr.Guias.Add(numeroGuia);

                GuiaEntidad guiaEntidad = GuiaAlmacen.guias.FirstOrDefault(g =>g.NumeroGuia ==numeroGuia);

                if (guiaEntidad != null)
                {
                    guiaEntidad.EstadoActual =EstadoGuiaEnum.PlanificadaTransporte;

                    guiaEntidad.Historial.Add(
                        new MovimientoEstadoDto
                        {
                            FechaHora = DateTime.Now,

                            Estado = EstadoGuiaEnum.PlanificadaTransporte,

                            Ubicacion = "CD Buenos Aires"
                        });
                }
            }

            servicioSeleccionado.EstadoServicio = EstadoServicioEnum.ConAsignacion;

            HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Add(hdr);

            GuiaAlmacen.Guardar();
            ServiciosAlmacen.Guardar();
            HojasDeRutaTransporteAlmacen.Guardar();

            return hdr.NumeroHDRTransporte;
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutasa.RuteoTransporte
{
    internal class FormRuteoTransporteModelo
    {
        public List<string> ObtenerCDs()
        {
            return new List<string>
            {
                "CD Buenos Aires",
                "CD Córdoba",
                "CD Rosario"
            };
        }

        public List<string> ObtenerLocalidades()
        {
            return new List<string>
            {
                "Buenos Aires",
                "Córdoba",
                "Rosario"
            };
        }

        public List<string> ObtenerDimensiones()
        {
            return new List<string>
            {
                "S",
                "M",
                "L",
                "XL"
            };
        }

        public List<string> ObtenerEmpresas()
        {
            return new List<string>
            {
                "Transportes SRL",
                "Logística Express",
                "Vía Cargo"
            };
        }

        // Servicios disponibles según empresa seleccionada

        public List<string> ObtenerServicios(string empresa)
        {
            if (empresa == "Transportes SRL")
            {
                return new List<string>
                {
                    "Córdoba - 21:30hs",
                    "Rosario - 18:00hs",
                    "Buenos Aires - 20:00hs"
                };
            }

            if (empresa == "Logística Express")
            {
                return new List<string>
                {
                    "Córdoba - 19:00hs",
                    "Mendoza - 22:00hs"
                };
            }

            if (empresa == "Vía Cargo")
            {
                return new List<string>
                {
                    "Buenos Aires - 23:00hs",
                    "Rosario - 17:30hs"
                };
            }

            return new List<string>();
        }

        public class Guia
        {
            public string Numero { get; set; }

            public string Localidad { get; set; }

            public string Direccion { get; set; }

            public string Dimension { get; set; }

            public string Peso { get; set; }

            public string Cliente { get; set; }

            public string Cuit { get; set; }

        }

        // Salida final del proceso

        public class HojaRutaTransporte
        {
            public string Numero { get; set; }

            public string Empresa { get; set; }

            public string Servicio { get; set; }

            public string CDDestino { get; set; }

            public List<Guia> Guias { get; set; }
        }

        private List<Guia> Guias =
            new List<Guia>
        {
            new Guia
            {
                Numero = "0001",
                Localidad = "Córdoba",
                Direccion = "Av Siempre Viva 123",
                Dimension = "S",
                Peso = "2",
                Cliente = "ACME",
                Cuit = "20333444556",
            },

            new Guia
            {
                Numero = "0002",
                Localidad = "Rosario",
                Direccion = "San Martín 456",
                Dimension = "XL",
                Peso = "18",
                Cliente = "Tech SA",
                Cuit = "30777888999",

            },

            new Guia
            {
                Numero = "0003",
                Localidad = "Buenos Aires",
                Direccion = "Belgrano 789",
                Dimension = "M",
                Peso = "6",
                Cliente = "ACME",
                Cuit = "20333444556",

            }
        };

        // Lista donde se almacenan las hojas de ruta generadas

        private List<HojaRutaTransporte> hojasRuta =
            new List<HojaRutaTransporte>();

        public List<Guia> BuscarGuias(
            string cuit,
            string localidad,
            string dimension)
        {
            // Tomamos todas las guías inicialmente

            List<Guia> guiasFiltradas =
                Guias;

            // Todos los filtros son opcionales



            if (!string.IsNullOrEmpty(cuit))
            {
                guiasFiltradas =
                    guiasFiltradas
                    .Where(e => e.Cuit == cuit)
                    .ToList();
            }

            if (!string.IsNullOrEmpty(localidad))
            {
                guiasFiltradas =
                    guiasFiltradas
                    .Where(e => e.Localidad == localidad)
                    .ToList();
            }

            if (!string.IsNullOrEmpty(dimension))
            {
                guiasFiltradas =
                    guiasFiltradas
                    .Where(e => e.Dimension == dimension)
                    .ToList();
            }

            return guiasFiltradas;
        }

        // Guardar hoja de ruta generada

        public void GuardarHojaRuta(
            HojaRutaTransporte hojaRuta)
        {
            hojasRuta.Add(hojaRuta);
        }
    }
}*/