using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class FacturaEntidad
    {
        public int NumeroFactura { get; set; }

        public DateTime FechaEmision { get; set; }

        public decimal Total { get; set; }

        public List<int> Guias { get; set; } // = new List<int>();

        public FacturaEntidad()
        {
            Guias = new List<int>();
        }
    }
}
