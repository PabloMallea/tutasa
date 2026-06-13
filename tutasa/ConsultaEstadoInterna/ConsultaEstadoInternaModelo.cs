
using tutasa.Almacenes;

namespace tutasa.ConsultaEstadoInterna
{
    internal class ConsultaEstadoInternaModelo
    {

        public GuiaEntidad BuscarGuiaPorIdentificador(int numeroGuia)
        {
            
            return GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);
        }
    }
}