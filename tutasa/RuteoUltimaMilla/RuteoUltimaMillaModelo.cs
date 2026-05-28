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

        // Renombrado de Guia a Encomienda

        public class Encomienda
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

            public List<Encomienda> Encomiendas { get; set; }
        }

        private List<Encomienda> encomiendas = new List<Encomienda>
        {
            new Encomienda
            {
                Numero = "0001",
                Cliente = "ACME",
                Cuit = "20333444556",
                Localidad = "Córdoba",
                Direccion = "Av. Siempre Viva 123",
                Dimension = "S"
            },

            new Encomienda
            {
                Numero = "0002",
                Cliente = "Tech SA",
                Cuit = "30777888999",
                Localidad = "Rosario",
                Direccion = "San Martín 456",
                Dimension = "M"
            },

            new Encomienda
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

        public List<Encomienda> BuscarEncomiendas(
            string localidad,
            string cuit)
        {
            // Comenzamos tomando todas las encomiendas disponibles y creamos una variable para ir filtrando
            List<Encomienda> encomiendasFiltradas =
                encomiendas;

            // Filtrar por localidad si el usuario seleccionó una. El ToList convierte el resultado de la consulta en una nueva lista.
            if (!string.IsNullOrEmpty(localidad))
            {
                encomiendasFiltradas =
                    encomiendasFiltradas
                    .Where(e => e.Localidad == localidad)
                    .ToList();
            }

            // Filtrar por CUIT si el usuario ingresó uno
            if (!string.IsNullOrEmpty(cuit))
            {
                encomiendasFiltradas =
                    encomiendasFiltradas
                    .Where(e => e.Cuit == cuit)
                    .ToList();
            }

            // Retornar coincidencias encontradas
            return encomiendasFiltradas;
        }

        // Método para guardar hoja de ruta generada

        public void GuardarHojaRuta(HojaRuta hojaRuta)
        {
            hojasRuta.Add(hojaRuta);
        }
    }
}