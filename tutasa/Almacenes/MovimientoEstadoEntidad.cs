using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class MovimientoEstado
    {
        public DateTime FechaHora { get; set; }

        public EstadoGuiaEnum Estado { get; set; }

        public string Ubicacion { get; set; }
    }
}
