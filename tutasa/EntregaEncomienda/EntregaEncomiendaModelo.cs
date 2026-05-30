using System;
using System.Collections.Generic;

namespace tutasa.EntregaEncomienda
{
    internal class EntregaEncomiendaModelo
    {
        // Lista de guías de ejemplo (simula almacén <Guías>)
        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                NroGuia = "G001",
                Cliente = "Juan Perez",
                Destinatario = "Carlos Lopez",
                DniDestinatario = "32111222",
                EstadoActual = "Pendiente de retiro"
            },

            new Guia
            {
                NroGuia = "G002",
                Cliente = "Maria Gomez",
                Destinatario = "Ana Torres",
                DniDestinatario = "28444555",
                EstadoActual = "Pendiente de retiro"
            },

            new Guia
            {
                NroGuia = "G003",
                Cliente = "Roberto Diaz",
                Destinatario = "Luis Fernandez",
                DniDestinatario = "35777888",
                EstadoActual = "Entregada"
            }
        };

        // Busca una guía por NroGuia y devuelve solo si está en estado "Pendiente de retiro"
        public Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia guia in guias)
            {
                if (guia.NroGuia == nroGuia &&
                    guia.EstadoActual == "Pendiente de retiro")
                {
                    return guia;
                }
            }

            return null;
        }

        // Actualiza el estado de la guía identificada por nroGuia a "Entregada"
        public void ActualizarEstado(string nroGuia)
        {
            foreach (Guia guia in guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    guia.EstadoActual = "Entregada";
                    break;
                }
            }
        }
    }
}