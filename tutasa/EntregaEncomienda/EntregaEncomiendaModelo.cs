using System.Collections.Generic;

namespace tutasa.EntregaEncomienda
{
    internal class EntregaEncomiendaModelo
    {
        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                NroGuia = "G001",
                Cliente = "Juan Perez",
                Destinatario = "Carlos Lopez",
                DniDestinatario = "32111222",
                EstadoActual = "Admitida"
            },

            new Guia
            {
                NroGuia = "G002",
                Cliente = "Maria Gomez",
                Destinatario = "Ana Torres",
                DniDestinatario = "28444555",
                EstadoActual = "Admitida"
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

        public Guia BuscarGuia(string nroGuia)
        {
            foreach (Guia guia in guias)
            {
                if (guia.NroGuia == nroGuia &&
                    guia.EstadoActual == "Admitida")
                {
                    return guia;
                }
            }

            return null;
        }

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