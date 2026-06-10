using System;
using System.Collections.Generic;
using System.Text;
using static tutasa.CuentaCorriente.CuentaCorrienteModelo;

namespace tutasa.Almacenes
{
    public class ClienteEntidad
    {
        public long CuitCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public int IdLocalidad { get; set; }

        public string Calle { get; set; }

        public string Altura { get; set; }

        public List<MovimientoCuentaCorrienteDto> Movimientos { get; set; } = new List<MovimientoCuentaCorrienteDto>();


    }
}

