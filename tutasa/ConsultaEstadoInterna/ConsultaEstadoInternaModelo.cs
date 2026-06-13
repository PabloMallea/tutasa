
using tutasa.Almacenes;

namespace tutasa.ConsultaEstadoInterna
{
    internal class ConsultaEstadoInternaModelo
    {

        public Guia? BuscarGuiaPorIdentificador(int numeroGuia)
        {
            GuiaEntidad guiaEncontrada = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            return guiaEncontrada != null ? new Guia
            {
                NumeroGuia = guiaEncontrada.NumeroGuia,
                Historial = guiaEncontrada.Historial.Select(h => new MovimientoEstado
                {
                    FechaHora = h.FechaHora,
                    Estado = h.Estado.ToString(),
                    Ubicacion = h.Ubicacion.ToString(),
                }).ToList()
            } : null;
        }
    }
}