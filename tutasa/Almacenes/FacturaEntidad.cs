using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class FacturaEntidad
    {
        public int NumeroFactura { get; set; }

        public long CuitCliente { get; set; }

        public DateTime FechaEmision { get; set; }

        public decimal Total { get; set; }
        public bool Paga { get; set; }

        public List<int> Guias { get; set; } = new List<int>();
    }
}
