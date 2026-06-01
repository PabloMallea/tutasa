using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.RendicionHDRtransporte
{
    internal partial class RendicionHDRtransporteModelo
    {
        public class HDRtransporte
        {
            public int n_hdr { get; set; }
            public string estado { get; set; }
            public Servicio servicio { get; set; } = new Servicio();
            public DateTime fecha { get; set; }
        }
    }
}