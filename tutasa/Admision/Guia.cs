using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Admision
{
    internal class Guia
    {
        public int NumeroGuia { get; set; }

        public Cliente Cliente { get; set; }

        public string DireccionDestino { get; set; } = string.Empty;

        public string NombreDestinatario { get; set; } = string.Empty;

        public string ApellidoDestinatario { get; set; } = string.Empty;

        public string DniDestinatario { get; set; } = string.Empty;

        public string Dimension { get; set; } = string.Empty;

        public decimal Peso { get; set; }
    }
}
