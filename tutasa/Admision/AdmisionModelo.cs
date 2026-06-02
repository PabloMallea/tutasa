
namespace tutasa.Admision
{
    internal class AdmisionModelo
    {
        // Método que busca un cliente por CUIT
        // TODO: Implementar lógica real de búsqueda en almacén
        public Cliente BuscarClientePorCuit(string cuit)
        {
            // Aquí se buscaría en el almacén real (ClienteAlmacen)
            // Por ahora retorna datos mock para pruebas

            if (cuit == "30123456789")
            {
                return new Cliente
                {
                    CUIT = "30123456789",
                    Nombre = "Pepe",
                    Apellido = "Sanchez",
                    Direccion = "Av. Libertador 1500"
                };
            }
            else if (cuit == "27987654321")
            {
                return new Cliente
                {
                    CUIT = "27987654321",
                    Nombre = "Maria",
                    Apellido = "Lopez",
                    Direccion = "Calle 9 de Julio 450"
                };
            }

            return null;
        }

        // Método que busca una guía en el almacén por su identificador 
        // TODO: Implementar lógica real de búsqueda en almacén
        public Guia BuscarGuiaPorIdentificador(int numeroGuia)
        {
            // Aquí se buscaría en el almacén real (GuiaAlmacen)
            // Por ahora retorna datos mock para pruebas

            if (numeroGuia == 10001)
            {
                return new Guia
                {
                    NumeroGuia = 10001,
                    CuitCliente = "30123456789",
                    DireccionDestino = "Av. Siempre Viva 742",
                    NombreDestinatario = "Juan",
                    ApellidoDestinatario = "Perez",
                    DniDestinatario = "12345678",
                    Dimension = "L",
                    Peso = 8.5m
                };
            }
            else if (numeroGuia == 10002)
            {
                return new Guia
                {
                    NumeroGuia = 10002,
                    CuitCliente = "27987654321",
                    DireccionDestino = "Av Colon 951",
                    NombreDestinatario = "Carlos",
                    ApellidoDestinatario = "Gomez",
                    DniDestinatario = "87654321",
                    Dimension = "XL",
                    Peso = 18.2m
                };
            }

            return null;
        }

        // Método que obtiene las dimensiones disponibles desde el almacén
        // TODO: Implementar lógica real de búsqueda en almacén
        public List<Dimension> ObtenerDimensiones()
        {
            // Aquí se buscarían en el almacén real
            // Por ahora retorna datos mock para pruebas

            return new List<Dimension>
            {
                new Dimension { Tipo = "S", PesoDesde = 0, PesoHasta = 2.5m },
                new Dimension { Tipo = "M", PesoDesde = 2.51m, PesoHasta = 5 },
                new Dimension { Tipo = "L", PesoDesde = 5.01m, PesoHasta = 10 },
                new Dimension { Tipo = "XL", PesoDesde = 10.01m, PesoHasta = 20 }
            };
        }

        // Método que calcula la dimensión según el peso ingresado
        public string CalcularDimension(decimal peso)
        {
            List<Dimension> dimensiones = ObtenerDimensiones();

            foreach (Dimension dimension in dimensiones)
            {
                if (peso >= dimension.PesoDesde && peso <= dimension.PesoHasta)
                {
                    return dimension.Tipo;
                }
            }

            // Si el peso supera todos los rangos, retornar la máxima
            return "XL";
        }

        // Método que registra la admisión de una guía
        // TODO: Implementar persistencia en almacén
        public bool RegistrarAdmision(Guia guia, decimal peso, string dimension)
        {
            if (guia == null)
            {
                return false;
            }

            //TODO: Con CUIT de cliente y dimension voy al almacen de convenios y busco la tarifa. ConvenioCliente
            //Desarrollar lógica para obtener montoafacturar

            // Actualizar datos de la guía
            guia.Peso = peso;
            guia.Dimension = dimension;
            //guia.MontoAFacturar = montoAFacturar; 

            // Crear movimiento de estado para la admisión
            MovimientoEstado movimiento = new MovimientoEstado
            {
                NumeroGuia = guia.NumeroGuia,
                FechaHora = DateTime.Now,
                Estado = "Admitida",
                Ubicacion = "Agencia Origen"
            };

            // TODO: Guardar la guía actualizada en el almacén


            // TODO: Guardar el movimiento de estado en el almacén

            return true;
        }
    }
}
