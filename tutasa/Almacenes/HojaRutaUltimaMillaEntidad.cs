using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Almacenes
{
    public class HojaRutaUltimaMilla
    {
        public int NumeroHDR { get; set; }

        public TipoHDREnum Tipo { get; set; }

        public string DireccionDestino { get; set; }

        public List<int> Guias { get; set; } = new List<int>();

        public bool Cumplida { get; set; }

        public int IdFletero { get; set; }

        public EstadoHDRUltimaMillaEnum Estado { get; set; }


    }
}
