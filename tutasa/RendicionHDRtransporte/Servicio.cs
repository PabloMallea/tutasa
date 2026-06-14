using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.RendicionHDRtransporte
{
    /*public enum EstadoServicio
    {
        Pendiente,
        ConAsignacion,
        EnRecorrido,
        Finalizado
    }*/
    internal class Servicio
    {
        public int IdServicio { get; set; }
        public int IdEmpresa { get; set; }
        public string? NombreServicio { get; set; }

        public DateTime FechaSalida { get; set; }

        public DateTime FechaLlegada { get; set; }

        public int IdCdOrigen { get; set; }

        public int IdCdDestino { get; set; }

        public string? EstadoServicio { get; set; } 
    }
}