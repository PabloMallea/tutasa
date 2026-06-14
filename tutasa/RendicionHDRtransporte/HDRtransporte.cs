using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.RendicionHDRtransporte
{
    internal partial class RendicionHDRtransporteModelo
    {
        public class HDRtransporte
        {
            public int NumeroHdrTransporte { get; set; }

            public string NombreEmpresa { get; set; }
            public string EstadoHdr { get; set; }
            public Servicio Servicio { get; set; } = new Servicio();

            public List<int> Guia { get; set; } = new List<int>();
        }
    }
}