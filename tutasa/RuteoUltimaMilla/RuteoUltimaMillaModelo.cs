namespace tutasa.RuteoUltimaMilla
{
    internal class RuteoUltimaMillaModelo
    {
        public List<string> ObtenerFleteros()
        {
            return new List<string>
            {
                "Juan Pérez",
                "Carlos Gómez",
                "María López"
            };
        }
        public List<string> ObtenerLocalidades()
        {
            return new List<string>
            {
                "Capital Federal",
                "Buenos Aires",
                "Córdoba"
            };
        }

        public class Guia
        {
            public string Numero { get; set; }
            public string Cliente { get; set; }
            public string Cuit { get; set; }
            public string Localidad { get; set; }
            public string Direccion { get; set; }
            public string Dimension { get; set; }
            public string TipoRuteo { get; set; }
            public string Fletero { get; set; }
        }





        private List<Guia> guias = new List<Guia>
        {
         new Guia
        {
        Numero = "0001",
        Cliente = "ACME",
        Cuit = "20333444556",
        Localidad = "Córdoba",
        Direccion = "Av. Siempre Viva 123",
        TipoRuteo = "",
        Dimension = "S"
        },

         new Guia
         {
        Numero = "0002",
        Cliente = "Tech SA",
        Cuit = "30777888999",
        Localidad = "Rosario",
        Direccion = "San Martín 456",
        TipoRuteo = "",
        Dimension = "M"

         },

         new Guia
         {
        Numero = "0003",
        Cliente = "ACME",
        Cuit = "20333444556",
        Localidad = "Córdoba",
        Direccion = "Belgrano 789",
        TipoRuteo = "",
        Dimension = "XL"
          }
        };


        public List<Guia> BuscarGuias(string localidad, string cuit)
            {
                // Comenzamos tomando todas las guías disponibles y creamos una variable para ir filtrando
                List<Guia> guiaFiltrada = guias;

                // Filtrar por localidad si el usuario seleccionó una. El ToList convierte el resultado de la consulta en una nueva lista. 
                if (!string.IsNullOrEmpty(localidad))
                {
                    guiaFiltrada = guiaFiltrada.Where(g => g.Localidad == localidad).ToList();
                }

                // Filtrar por CUIT si el usuario ingresó uno
                if (!string.IsNullOrEmpty(cuit))
                {
                    guiaFiltrada = guiaFiltrada.Where(g => g.Cuit == cuit).ToList();
                }

                // Retornar coincidencias encontradas
                return guiaFiltrada;
            }


    }
    }

