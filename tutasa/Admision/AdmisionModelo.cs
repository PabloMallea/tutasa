using System;
using System.Collections.Generic;
using System.Text;
using static tutasa.ConsultaEstadoInterna.ConsultaEstadoInternaModelo;

namespace tutasa.Admision
{
    internal class AdmisionModelo
    {
        // Método que busca una guía en el almacén por su número
        // TODO: Implementar lógica real de búsqueda en almacén
        public Guia BuscarGuiaPorNumero(string numeroGuia)
        {
            // Aquí se buscaría en el almacén real
            // Por ahora retorna datos mock para pruebas

            if (numeroGuia == 10001.ToString())
            {
                return new Guia
                {
                    NumeroGuia = 10001,
                    Cliente = new Cliente
                    {
                        CUIT = "30-12345678-9",
                        Nombre = "Pepe",
                        Apellido = "Sanchez",
                        Direccion = "Calle Falsa 1234, Tandil"
                    },
                    DireccionDestino = "Av. Siempre Viva 742",
                    NombreDestinatario = "Juan",
                    ApellidoDestinatario = "Perez",
                    DniDestinatario = "12345678",
                    Dimension = "M",
                    Peso = 8.5m
                };
            }
            else if (numeroGuia == 10002.ToString())
            {
                return new Guia
                {
                    NumeroGuia = 10002,
                    Cliente = new Cliente
                    {
                        CUIT = "27-98765432-1",
                        Nombre = "Maria",
                        Apellido = "Lopez",
                        Direccion = "Av. Principal 456, Mar del Plata"
                    },
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
                new Dimension { Tipo = "M", PesoDesde = 5.01m, PesoHasta = 10 },
                new Dimension { Tipo = "L", PesoDesde = 10.01m, PesoHasta = 15 },
                new Dimension { Tipo = "XL", PesoDesde = 15.01m, PesoHasta = 20 }
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

            //TODO: Calcular el costo de envío según la dimensión y guardar en almacén


            // TODO: Guardar la guía actualizada en el almacén

            // TODO: Guardar el movimiento de estado en el almacén

            return true;
        }

      
    }
}
