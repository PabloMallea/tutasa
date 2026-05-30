namespace tutasa.EntregaEncomienda
{
    internal enum ResultadoBusqueda
    {
        Encontrada,
        NoExiste,
        EstadoInvalido
    }

    internal class EntregaEncomiendaModelo
    {
        // Aca voy a llamar y completar todos los datos de prueba.
        private List<Guia> Guias = new List<Guia>
        {
            new Guia { NroGuia = "AG001-0001", Cliente = "Juan Perez",    Destinatario = "Maria Lopez",  DniDestinatario = "30123456", Estado = new Estado { Id = 1, Descripcion = "Pendiente de entrega" } },
            new Guia { NroGuia = "AG001-0002", Cliente = "Carlos Gomez",  Destinatario = "Ana Martinez", DniDestinatario = "28654321", Estado = new Estado { Id = 1, Descripcion = "Pendiente de entrega" } },
            new Guia { NroGuia = "CD001-0001", Cliente = "Laura Sanchez", Destinatario = "Pedro Ruiz",   DniDestinatario = "35987654", Estado = new Estado { Id = 3, Descripcion = "Admitida" } }
        };

        public ResultadoBusqueda BuscarGuia(string nroGuia, TipoEntrega tipo, out Guia? guiaEncontrada)
        {
            guiaEncontrada = null;

            foreach (Guia guia in Guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    bool estadoValido = tipo == TipoEntrega.Agencia
                        ? guia.Estado.Id == 1   // Pendiente de entrega
                        : guia.Estado.Id == 3;  // Admitida

                    if (!estadoValido)
                    {
                        return ResultadoBusqueda.EstadoInvalido;
                    }

                    guiaEncontrada = guia;
                    return ResultadoBusqueda.Encontrada;
                }
            }
            return ResultadoBusqueda.NoExiste;
        }

        public void ActualizarEstadoEntregada(string nroGuia, TipoEntrega tipo)
        {
            foreach (Guia guia in Guias)
            {
                if (guia.NroGuia == nroGuia)
                {
                    string descripcion = tipo == TipoEntrega.Agencia
                        ? "Entregada en agencia"
                        : "Entregada en CD";

                    guia.Estado = new Estado { Id = 2, Descripcion = descripcion };
                    return;
                }
            }
        }
    }
}