using System;
using System.Collections.Generic;

namespace tutasa.Almacenes
{
    public class GuiaEntidad
    {
        public int NumeroGuia { get; set; }

        public DateTime FechaAlta { get; set; }

        public long CuitCliente { get; set; }

        public int IdCDOrigen { get; set; }

        public TipoRetiroEnum TipoRetiro { get; set; }

        public int IdAgenciaRetiro { get; set; }

        public int IdCDDestino { get; set; }

        public int IdAgenciaDestino { get; set; }

        public DestinoGuiaEnum Destino { get; set; }

        public string CalleDestino { get; set; }

        public string AlturaDestino { get; set; }

        public string DniDestinatario { get; set; }

        public string TelefonoDestinatario { get; set; }

        public string NombreDestinatario { get; set; }

        public string ApellidoDestinatario { get; set; }

        public DimensionEnum Dimension { get; set; }

        public int IntentosEntrega { get; set; }

        public EstadoGuiaEnum EstadoActual { get; set; }

        public List<MovimientoEstadoDto> Historial { get; set; }

        public decimal MontoFacturar { get; set; }

        public decimal ComisionesAgenciaOrigen { get; set; }

        public decimal ComisionesAgenciaDestino { get; set; }

        public decimal ComisionesFleteroOrigen { get; set; }

        public decimal ComisionesFleteroDestino { get; set; }

        public GuiaEntidad()
        {
            Historial = new List<MovimientoEstadoDto>();
        }
    }
}