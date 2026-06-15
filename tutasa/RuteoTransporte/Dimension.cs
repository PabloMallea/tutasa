namespace tutasa.RuteoTransporte
{
    internal partial class FormRuteoTransporteModelo
    {
        public class Dimension
        {
            public string Nombre { get; set; }
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