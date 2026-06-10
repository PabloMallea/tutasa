using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.RendicionHDRtransporte {
    public enum EstadoGuia { Admitida, EnDestino }

    internal class Guia 
    { 
        public int NumeroGuia { get; set; } 
        public int IdCdDestino { get; set; } 
        public EstadoGuia EstadoGuia { get; set; } 
    }
}