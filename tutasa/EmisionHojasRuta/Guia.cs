using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.EmisionHojasRuta
{
    internal partial class EmisionHojasRutaModelo
    {
        public class Guia
        {
            public int Numero { get; set; }

            public string Cliente { get; set; }

            public string Direccion { get; set; }


            public string Dimension { get; set; }

            public string Estado { get; set; }
        }
    }
}