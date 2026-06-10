using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class MovimientoCuentaCorrienteEntidad
    {
        public int IdFactura { get; set; }

        public DateTime Fecha { get; set; }

        public decimal MontoPago { get; set; }

        public decimal Saldo { get; set; }
    }
}
