using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.EmitirFactura
{
    internal class EmitirFacturaModelo
    {


        public class Cliente
        {
            public string Cuit { get; set; }

            public string Nombre { get; set; }
        }


        public class Encomienda
        {
            public string NumeroGuia { get; set; }

            public Cliente Cliente { get; set; }

            public string TipoEntrega { get; set; }

            public decimal MontoFacturar { get; set; }

            public bool Facturada { get; set; }
        }


        public class Factura
        {
            public Cliente Cliente { get; set; }

            public List<Encomienda> Encomiendas { get; set; }

            public decimal Total { get; set; }
        }



        private List<Cliente> clientes =
            new List<Cliente>
        {
            new Cliente
            {
                Cuit = "30234567890",
                Nombre = "Empresa SA"
            },

            new Cliente
            {
                Cuit = "30777888999",
                Nombre = "Nike"
            }
        };

 

        private List<Encomienda> encomiendas =
            new List<Encomienda>
        {
            new Encomienda
            {
                NumeroGuia = "0001",

                Cliente = new Cliente
                {
                    Cuit = "30234567890",
                    Nombre = "Empresa SA"
                },

                TipoEntrega = "Entrega a domicilio",

                MontoFacturar = 3500,

                Facturada = false
            },

            new Encomienda
            {
                NumeroGuia = "0002",

                Cliente = new Cliente
                {
                    Cuit = "30234567890",
                    Nombre = "Empresa SA"
                },

                TipoEntrega = "Entrega en agencia",

                MontoFacturar = 2000,

                Facturada = false
            },

            new Encomienda
            {
                NumeroGuia = "0100",

                Cliente = new Cliente
                {
                    Cuit = "30777888999",
                    Nombre = "Nike"
                },

                TipoEntrega = "Entrega a domicilio",

                MontoFacturar = 4200,

                Facturada = false
            },
             new Encomienda
            {
                NumeroGuia = "0102",

                Cliente = new Cliente
                {
                    Cuit = "30777888999",
                    Nombre = "Nike"
                },

                TipoEntrega = "Entrega en agencia",

                MontoFacturar = 3200,

                Facturada = false
            }
        };


        //Obtener clientes
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        // OBTENER ENCOMIENDAS
        // PENDIENTES DE FACTURAR


        public List<Encomienda>
            ObtenerEncomiendasPendientes(string cuit)
        {
            // Lista resultado
            List<Encomienda> pendientes = new List<Encomienda>();

            // Recorrer encomiendas
            foreach (Encomienda encomienda
                in encomiendas)
            {
                // Validar cliente y estado facturación
                if (encomienda.Cliente.Cuit == cuit
                    && encomienda.Facturada == false)
                {
                    pendientes.Add(encomienda);
                }
            }

            return pendientes;
        }
    }
}