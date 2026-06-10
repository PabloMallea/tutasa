using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class ComisionesEntidad
    {
        public TipoComisionEnum Tipo { get; set; }

        public DimensionEnum Dimension { get; set; }

        public decimal Precio { get; set; }
    }
}
