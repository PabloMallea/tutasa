using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Admision
{
    internal class Guia
    {
        public int NumeroGuia { get; set; }

        public string Cuit { get; set; } = string.Empty;

        public string LocalidadDestino { get; set; } = string.Empty;

        public string Destino { get; set; } = string.Empty;

        public string CalleDestino { get; set; } = string.Empty;

        public string AlturaDestino { get; set; } = string.Empty;

        public string NombreDestinatario { get; set; } = string.Empty;

        public string ApellidoDestinatario { get; set; } = string.Empty;

        public string DniDestinatario { get; set; } = string.Empty;

        public string TelefonoDestinatario { get; set; } = string.Empty;

        public string Dimension { get; set; } = string.Empty;

        public decimal Peso { get; set; }

        public decimal MontoFacturar { get; set; }

        public DateTime FechaAlta { get; set; }

        public int IntentosEntrega { get; set; }

        public bool Facturada { get; set; }
    }
}
