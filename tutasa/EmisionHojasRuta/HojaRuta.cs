namespace tutasa.EmisionHojasRuta
{
    internal partial class EmisionHojasRutaModelo
    {
        public class HojaRuta
        {
            public int NumeroHDR { get; set; }

            public string Tipo { get; set; }

            public int IdFletero { get; set; }

            public string Fletero { get; set; }

            public string Direccion { get; set; }

            public string Estado { get; set; }

            public List<int> Guias { get; set; } = new List<int>();
        }
    }
}