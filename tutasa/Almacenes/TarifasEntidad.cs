using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class TarifasEntidad
    {
        public int IdLocalidadOrigen { get; set; }

        public int IdLocalidadDestino { get; set; }

        public DimensionEnum Dimension { get; set; }

        public decimal Precio { get; set; }
    }
}
