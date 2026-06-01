

namespace tutasa.ConsultaEstadoInterna
{
    internal class ConsultaEstadoInternaModelo
    {

        public Guia BuscarGuiaPorIdentificador(int numeroGuia)
        {
            if (numeroGuia == 10001)
            {
                return new Guia
                {
                    NumeroGuia = 10001,
                    CuitCliente = "30-12345678-9",
                    DireccionDestino = "Av. Siempre Viva 742",
                    NombreDestinatario = "Juan",
                    ApellidoDestinatario = "Perez",
                    DniDestinatario = "12345678",
                    Dimension = "M",
                    Peso = 8.5m
                };
            }
            else if (numeroGuia == 10002)
            {
                return new Guia
                {
                    NumeroGuia = 10002,
                    CuitCliente = "27-98765432-1",
                    DireccionDestino = "Av Colon 951",
                    NombreDestinatario = "Carlos",
                    ApellidoDestinatario = "Gomez",
                    DniDestinatario = "87654321",
                    Dimension = "L",
                    Peso = 18.2m
                };
            }

            return null;
        
           
        }

        public List<MovimientoEstado> BuscarMovimientosPorGuia(int numeroGuia)
        {
            List<MovimientoEstado> movimientos = new List<MovimientoEstado>
        {
            // Historial para guía 10001
            new MovimientoEstado
            {
                NumeroGuia = 10001,
                FechaHora = new DateTime(2026, 5, 1, 10, 0, 0),
                Estado = "Impuesta",
                Ubicacion = "Agencia Flores"
            },
            new MovimientoEstado
            {
                NumeroGuia = 10001,
                FechaHora = new DateTime(2026, 5, 1, 11, 30, 0),
                Estado = "En distribución",
                Ubicacion = "Camino a CD Buenos Aires"
            },
            new MovimientoEstado
            {
                NumeroGuia = 10001,
                FechaHora = new DateTime(2026, 5, 1, 14, 30, 0),
                Estado = "Entregada esperando admisión",
                Ubicacion = "CD Buenos Aires"
            },
            new MovimientoEstado
            {
                NumeroGuia = 10001,
                FechaHora = new DateTime(2026, 5, 2, 8, 15, 0),
                Estado = "Admitida",
                Ubicacion = "CD Buenos Aires"
            },

            // Historial para guía 10002
            //new MovimientoEstado
            //{
            //    NumeroGuia = 10002,
            //    FechaHora = new DateTime(2026, 5, 3, 9, 0, 0),
            //    Estado = "Admitida",
            //    Ubicacion = "CD Córdoba"
            //},
            //new MovimientoEstado
            //{
            //    NumeroGuia = 10002,
            //    FechaHora = new DateTime(2026, 5, 3, 13, 45, 0),
            //    Estado = "En distribución",
            //    Ubicacion = "En camino a Agencia Villa Carlos Paz"
            //}
        };

            // Filtrar movimientos por número de guía y ordenar por fecha
            List<MovimientoEstado> historial = new List<MovimientoEstado>();

            foreach (MovimientoEstado movimiento in movimientos)
            {
                if (movimiento.NumeroGuia == numeroGuia)
                {
                    historial.Add(movimiento);
                }
            }

            // Ordenar por fecha (más antiguo a más reciente)
            historial.Sort((m1, m2) => m1.FechaHora.CompareTo(m2.FechaHora));

            return historial;
        }

        public MovimientoEstado ObtenerUltimoMovimiento(int numeroGuia)
        {
            // Obtener todos los movimientos de la guía
            List<MovimientoEstado> historial = BuscarMovimientosPorGuia(numeroGuia);

            // Si hay movimientos, retornar el último
            if (historial.Count > 0)
            {
                return historial[historial.Count - 1];
            }

            // Si no hay movimientos
            return null;
        }
    }
}