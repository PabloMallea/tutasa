using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class HojaRutaTransporte
    {
        public int NumeroHDRTransporte { get; set; }

        public int IdServicio { get; set; }

        public EstadoHDRTransporteEnum EstadoHDR { get; set; }

        public List<int> Guias { get; set; } // = new List<int>();

        public HojaRutaTransporte()
        {
            Guias = new List<int>();
        }
    }
}
