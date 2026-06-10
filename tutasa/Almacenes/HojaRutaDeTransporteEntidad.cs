using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class HojaRutaDeTransporteEntidad
    {
        public int NumeroHDRTransporte { get; set; }

        public int IdServicio { get; set; }

        public EstadoHDRTransporteEnum EstadoHDR { get; set; }

        public List<int> Guias { get; set; } // = new List<int>();

        public HojaRutaDeTransporteEntidad()
        {
            Guias = new List<int>();
        }
    }
}
