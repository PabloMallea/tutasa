

namespace tutasa.ConsultaEstadoInterna
{
    internal class MovimientoEstado
    {
        public int NumeroGuia { get; set; }

        public DateTime FechaHora { get; set; }

        public string Estado { get; set; } = string.Empty;

        public string Ubicacion { get; set; } = string.Empty;
    }
}
