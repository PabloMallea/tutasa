namespace tutasa.EmisionHojasRutaTransporte
{
    internal partial class EmisionHojasRutaTransporteModelo
    {
        public class HojaRutaTransporte
        {
            public int NumeroHDR { get; set; }

            public int IdServicio { get; set; }

            public string Empresa { get; set; }

            public string Servicio { get; set; }

            public string Estado { get; set; }

            public List<int> Guias { get; set; } =new List<int>();
        }





    }
}