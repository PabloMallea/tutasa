using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutasa.CuentaCorriente
{
    internal partial class CuentaCorrienteModelo
    {
        public class Cliente
        {
            public long Cuit { get; set; }

            public string Nombre { get; set; }
        }
    }
}