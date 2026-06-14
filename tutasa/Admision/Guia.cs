using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Admision
{
    internal class Guia
    {
        public int NumeroGuia { get; set; }

        public long CuitCliente { get; set; }

        public string DireccionDestino { get; set; } = string.Empty;

        public string NombreDestinatario { get; set; } = string.Empty;

        public string ApellidoDestinatario { get; set; } = string.Empty;

        public string DniDestinatario { get; set; } = string.Empty;

        public DimensionEnum Dimension { get; set; }
    }
}
