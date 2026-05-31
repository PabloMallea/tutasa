using System;
using System.Collections.Generic;

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

            if (cuit == "30-12345678-9")
            {
                return new Cliente
                {
                    CUIT = "30-12345678-9",
                    Nombre = "Pepe",
                    Apellido = "Sanchez",
                    Direccion = "Av. Libertador 1500"
                };
            }
            else if (cuit == "27-98765432-1")
            {
                return new Cliente
                {
                    CUIT = "27-98765432-1",
                    Nombre = "Maria",
                    Apellido = "Lopez",
                    Direccion = "Calle 9 de Julio 450"
                };
            }

            return null;
        }

        // Método que busca una guía en el almacén por su número
        // TODO: Implementar lógica real de búsqueda en almacén
        public Guia BuscarGuiaPorNumero(int numeroGuia)
        {
            // Aquí se buscaría en el almacén real (GuiaAlmacen)
            // Por ahora retorna datos mock para pruebas

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

        // Método que obtiene las dimensiones disponibles desde el almacén
        // TODO: Implementar lógica real de búsqueda en almacén
        public List<Dimension> ObtenerDimensiones()
        {
            // Aquí se buscarían en el almacén real
            // Por ahora retorna datos mock para pruebas

            return new List<Dimension>
            {
                new Dimension { Tipo = "S", PesoDesde = 0, PesoHasta = 5 },
                new Dimension { Tipo = "M", PesoDesde = 5.01m, PesoHasta = 15 },
                new Dimension { Tipo = "L", PesoDesde = 15.01m, PesoHasta = 30 },
                new Dimension { Tipo = "XL", PesoDesde = 30.01m, PesoHasta = 100 }
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

            // Actualizar datos de la guía
            guia.Peso = peso;
            guia.Dimension = dimension;

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
