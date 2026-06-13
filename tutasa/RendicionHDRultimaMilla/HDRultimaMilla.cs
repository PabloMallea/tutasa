namespace tutasa.RendicionHDRultimaMilla
{
    internal partial class RendicionHDRultimaMillaModelo
    {
        public enum EstadoHDRUltimaMilla
        {
            Asignada,
            Emitida,
            Rendida
        }
        public enum TipoHDR
        {
            Entrega,
            Retiro
        }
        public class HDRultimaMilla
        {
            public int NumeroHDR { get; set; }
            public int IdFletero { get; set; }
            public EstadoHDRUltimaMilla Estado { get; set; }
            public TipoHDR Tipo { get; set; }
            public bool Cumplida { get; set; }

            public List<int> Guias { get; set; } = new List<int>();

        }
    }
}
