using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.ConsultaEstadoInterna
{
    internal class ConsultaEstadoInternaModelo
    {
  

        public class MovimientoEstado
        {
            public DateTime FechaHora { get; set; }

            public string Estado { get; set; }

            public string Ubicacion { get; set; }
        }

        public class Encomienda
        {
            public string NumeroGuia { get; set; }

            public List<MovimientoEstado> Historial { get; set; }
        }


        private List<Encomienda> encomiendas =
            new List<Encomienda>
        {
            new Encomienda
            {
                NumeroGuia = "0001",

                Historial = new List<MovimientoEstado>
                {
                    new MovimientoEstado
                    {
                        FechaHora = new DateTime(2026, 5, 1, 10, 0, 0),
                        Estado = "Impuesta",
                        Ubicacion = "Agencia Flores"
                    },
                    new MovimientoEstado
                    {
                        FechaHora = new DateTime(2026, 5, 1, 11, 30, 0),
                        Estado = "En distribución",
                        Ubicacion = "Camino a CD Buenos Aires"
                    },

                    new MovimientoEstado
                    {
                        FechaHora = new DateTime(2026, 5, 1, 14, 30, 0),
                        Estado = "Entregada esperando admisión",
                        Ubicacion = "CD Buenos Aires"
                    },

                    new MovimientoEstado
                    {
                        FechaHora = new DateTime(2026, 5, 2, 8, 15, 0),
                        Estado = "Admitida",
                        Ubicacion = "CD Buenos Aires"
                    }
                }
            },

            new Encomienda
            {
                NumeroGuia = "0002",

                Historial = new List<MovimientoEstado>
                {
                    new MovimientoEstado
                    {
                        FechaHora = new DateTime(2026, 5, 3, 9, 0, 0),
                        Estado = "Admitida",
                        Ubicacion = "CD Córdoba"
                    },

                    new MovimientoEstado
                    {
                        FechaHora = new DateTime(2026, 5, 3, 13, 45, 0),
                        Estado = "En distribución",
                        Ubicacion = "En camino a Agencia Villa Carlos Paz"
                    }
                }
            }
        };

    

        public Encomienda BuscarEncomienda(string numeroGuia)
        {
            // Recorrer lista de encomiendas
            foreach (Encomienda encomienda in encomiendas)
            {
                // Si coincide número de guía
                if (encomienda.NumeroGuia == numeroGuia)
                {
                    return encomienda;
                }
            }

            // Si no se encontró coincidencia
            return null;
        }
    }
}