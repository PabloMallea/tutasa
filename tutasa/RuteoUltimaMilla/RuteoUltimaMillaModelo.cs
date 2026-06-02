using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        // Renombrado de Guia a Guia

        public class Guia
        {
            public string Numero { get; set; }

            public string Cliente { get; set; }

            public string Cuit { get; set; }

            public string Localidad { get; set; }

            public string Direccion { get; set; }

            public string Dimension { get; set; }
        }

        // Nueva clase HojaRuta para representar la salida final del proceso

        public class HojaRuta
        {
            public string Numero { get; set; }

            public string Fletero { get; set; }

            public string TipoRuteo { get; set; }

            public List<Guia> Guias { get; set; }
        }

        private List<Guia> Guias = new List<Guia>
        {
            new Guia
            {
                Numero = "0001",
                Cliente = "ACME",
                Cuit = "20333444556",
                Localidad = "Córdoba",
                Direccion = "Av. Siempre Viva 123",
                Dimension = "S"
            },

            new Guia
            {
                Numero = "0002",
                Cliente = "Tech SA",
                Cuit = "30777888999",
                Localidad = "Rosario",
                Direccion = "San Martín 456",
                Dimension = "M"
            },

            new Guia
            {
                Numero = "0003",
                Cliente = "ACME",
                Cuit = "20333444556",
                Localidad = "Córdoba",
                Direccion = "Belgrano 789",
                Dimension = "XL"
            }
        };

        // Lista donde se almacenan las hojas de ruta generadas

        private List<HojaRuta> hojasRuta =
            new List<HojaRuta>();

        public List<Guia> BuscarGuias(
            string localidad,
            string cuit)
        {
            // Comenzamos tomando todas las Guias disponibles y creamos una variable para ir filtrando
            List<Guia> GuiasFiltradas =
                Guias;

            // Filtrar por localidad si el usuario seleccionó una. El ToList convierte el resultado de la consulta en una nueva lista.
            if (!string.IsNullOrEmpty(localidad))
            {
                GuiasFiltradas =
                    GuiasFiltradas
                    .Where(e => e.Localidad == localidad)
                    .ToList();
            }

            // Filtrar por CUIT si el usuario ingresó uno
            if (!string.IsNullOrEmpty(cuit))
            {
                GuiasFiltradas =
                    GuiasFiltradas
                    .Where(e => e.Cuit == cuit)
                    .ToList();
            }

            // Retornar coincidencias encontradas
            return GuiasFiltradas;
        }

        // Método para guardar hoja de ruta generada

        public void GuardarHojaRuta(HojaRuta hojaRuta)
        {
            hojasRuta.Add(hojaRuta);
        }
    }
}