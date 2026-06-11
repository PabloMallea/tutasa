namespace tutasa.Almacenes
{
    public class ServicioEntidad
    {
        public int IdServicio { get; set; }

        public int IdEmpresa { get; set; }

        public string? NombreServicio { get; set; }

        public EstadoServicioEnum EstadoServicio { get; set; }

        public DateTime FechaSalida { get; set; }

        public DateTime FechaLlegada { get; set; }

        public int IdCDOrigen { get; set; }

        public int IdCDDestino { get; set; }
    }
}
