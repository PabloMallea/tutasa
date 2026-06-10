namespace tutasa.Almacenes
{
    public class MovimientoEstadoDto
    {
        public DateTime FechaHora { get; set; }

        public EstadoGuiaEnum Estado { get; set; }

        public string Ubicacion { get; set; }
    }
}
