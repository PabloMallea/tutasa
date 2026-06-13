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

using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.RuteoTransporte
{
    internal class FormRuteoTransporteModelo
    {
        private int idCDActual = 1;

        public class Guia
        {
            public string Numero { get; set; }

            public string Localidad { get; set; }

            public string Direccion { get; set; }

            public string Dimension { get; set; }

            public string Cliente { get; set; }

            public string Cuit { get; set; }
        }

        public class HojaRutaTransporte
        {
            public string Numero { get; set; }

            public string Empresa { get; set; }

            public string Servicio { get; set; }

            public string CDDestino { get; set; }

            public List<Guia> Guias { get; set; }
        }

        public List<string> ObtenerCDs()
        {
            List<string> resultado = new List<string>();

            foreach (CentroDistribucion cd
                in CentroDistribucionAlmacen.CentrosDistribucion)
            {
                resultado.Add(cd.NombreCD);
            }

            return resultado;
        }

        public List<string> ObtenerLocalidades()
        {
            List<string> resultado = new List<string>();

            foreach (Localidad localidad
                in LocalidadAlmacen.localidades)
            {
                resultado.Add(localidad.NombreLocalidad);
            }

            return resultado;
        }

        public List<string> ObtenerEmpresas()
        {
            List<string> resultado = new List<string>();

            foreach (EmpresaTransporteEntidad empresa
                in EmpresaTransporteAlmacen.empresas)
            {
                resultado.Add(empresa.NombreEmpresa);
            }

            return resultado;
        }

        public List<string> ObtenerServicios(
            string nombreEmpresa,
            string nombreCDDestino)
        {
            List<string> resultado = new List<string>();

            EmpresaTransporteEntidad empresa =
                EmpresaTransporteAlmacen.empresas
                .FirstOrDefault(e =>
                    e.NombreEmpresa == nombreEmpresa);

            if (empresa == null)
            {
                return resultado;
            }

            CentroDistribucion cdDestino =
                CentroDistribucionAlmacen.CentrosDistribucion
                .FirstOrDefault(cd =>
                    cd.NombreCD == nombreCDDestino);

            if (cdDestino == null)
            {
                return resultado;
            }

            foreach (ServicioEntidad servicio
                in ServiciosAlmacen.servicio)
            {
                if (servicio.IdEmpresa != empresa.IdEmpresa)
                {
                    continue;
                }

                if (servicio.IdCDOrigen != idCDActual)
                {
                    continue;
                }

                if (servicio.IdCDDestino != cdDestino.IdCD)
                {
                    continue;
                }

                if (servicio.EstadoServicio
                    != EstadoServicioEnum.Pendiente)
                {
                    continue;
                }

                if (servicio.FechaSalida.Date
                    < DateTime.Today)
                {
                    continue;
                }

                resultado.Add(
                    servicio.NombreServicio
                    + " - "
                    + servicio.FechaSalida.ToString("dd/MM/yyyy HH:mm")
                    + " - "
                    + servicio.FechaLlegada.ToString("dd/MM/yyyy HH:mm"));
            }

            return resultado;
        }

        public List<Guia> BuscarGuias(
            string cuit,
            string localidad,
            string dimension)
        {
            List<Guia> resultado =
                new List<Guia>();

            foreach (GuiaEntidad guiaEntidad
                in GuiaAlmacen.guias)
            {
                if (guiaEntidad.EstadoActual
                    != EstadoGuiaEnum.Admitida)
                {
                    continue;
                }

                ClienteEntidad cliente =
                    ClientesAlmacen.clientes
                    .FirstOrDefault(c =>
                        c.CuitCliente ==
                        guiaEntidad.CuitCliente);

                if (cliente == null)
                {
                    continue;
                }

                CentroDistribucion cdDestino =
                    CentroDistribucionAlmacen.CentrosDistribucion
                    .FirstOrDefault(cd =>
                        cd.IdCD ==
                        guiaEntidad.IdCDDestino);

                if (cdDestino == null)
                {
                    continue;
                }

                Localidad localidadDestino =
                    LocalidadAlmacen.localidades
                    .FirstOrDefault(l =>
                        l.IdLocalidad ==
                        cdDestino.IdLocalidad);

                string nombreLocalidad = "";

                if (localidadDestino != null)
                {
                    nombreLocalidad =
                        localidadDestino.NombreLocalidad;
                }

                if (!string.IsNullOrEmpty(cuit))
                {
                    if (cliente.CuitCliente.ToString()
                        != cuit)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(localidad))
                {
                    if (nombreLocalidad
                        != localidad)
                    {
                        continue;
                    }
                }

                Guia guia =
                    new Guia();

                guia.Numero =
                    guiaEntidad.NumeroGuia.ToString();

                guia.Localidad =
                    nombreLocalidad;

                guia.Direccion =
                    guiaEntidad.CalleDestino
                    + " "
                    + guiaEntidad.AlturaDestino;

                guia.Dimension =
                    guiaEntidad.Dimension.ToString();

                guia.Cliente =
                    cliente.Nombre
                    + " "
                    + cliente.Apellido;

                guia.Cuit =
                    cliente.CuitCliente.ToString();

                resultado.Add(guia);
            }

            return resultado;
        }
        public List<string> ObtenerDimensiones()
        {
            List<string> resultado = new List<string>();

            foreach (DimensionEnum dimension
                in Enum.GetValues(typeof(DimensionEnum)))
            {
                resultado.Add(dimension.ToString());
            }

            return resultado;
        }
        public void GuardarHojaRuta(
            HojaRutaTransporte hojaRuta)
        {
            ServicioEntidad servicioSeleccionado = null;

            foreach (ServicioEntidad servicio
                in ServiciosAlmacen.servicio)
            {
                string descripcion =
                    servicio.NombreServicio
                    + " - "
                    + servicio.FechaSalida.ToString("dd/MM/yyyy HH:mm")
                    + " - "
                    + servicio.FechaLlegada.ToString("dd/MM/yyyy HH:mm");

                if (descripcion == hojaRuta.Servicio)
                {
                    servicioSeleccionado = servicio;
                    break;
                }
            }

            if (servicioSeleccionado == null)
            {
                return;
            }

            HojaRutaDeTransporteEntidad hdr =
                new HojaRutaDeTransporteEntidad();

            hdr.NumeroHDRTransporte =
                HojasDeRutaTransporteAlmacen
                .HojasDeRutaTransporte
                .Count + 1;

            hdr.IdServicio =
                servicioSeleccionado.IdServicio;

            hdr.EstadoHDR =
                EstadoHDRTransporteEnum.Asignada;

            foreach (Guia guiaPantalla
                in hojaRuta.Guias)
            {
                int numeroGuia =
                    Convert.ToInt32(
                        guiaPantalla.Numero);

                hdr.Guias.Add(numeroGuia);

                GuiaEntidad guiaEntidad =
                    GuiaAlmacen.guias
                    .FirstOrDefault(g =>
                        g.NumeroGuia ==
                        numeroGuia);

                if (guiaEntidad != null)
                {
                    guiaEntidad.EstadoActual =
                        EstadoGuiaEnum.PlanificadaTransporte;

                    guiaEntidad.Historial.Add(
                        new MovimientoEstadoDto
                        {
                            FechaHora =
                                DateTime.Now,

                            Estado =
                                EstadoGuiaEnum.PlanificadaTransporte,

                            Ubicacion =
                                "CD Buenos Aires"
                        });
                }
            }



            servicioSeleccionado.EstadoServicio =
                EstadoServicioEnum.ConAsignacion;

            HojasDeRutaTransporteAlmacen
                .HojasDeRutaTransporte
                .Add(hdr);

            GuiaAlmacen.Guardar();
            ServiciosAlmacen.Guardar();
            HojasDeRutaTransporteAlmacen.Guardar();
        }
    }
}