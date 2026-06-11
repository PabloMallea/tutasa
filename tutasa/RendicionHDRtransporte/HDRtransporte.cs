using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.RendicionHDRtransporte
{
    public enum EstadoHdrTransporte
    {
        Asignada,
        Emitida,
        Rendida
    }
    internal partial class RendicionHDRtransporteModelo
    {
        public class HDRtransporte
        {
            public int NumeroHdrTransporte { get; set; }
            public EstadoHdrTransporte EstadoHdr { get; set; }
            public Servicio Servicio { get; set; } = new Servicio();

            public List<int> Guia { get; set; } = new List<int>();
        }
    }
}