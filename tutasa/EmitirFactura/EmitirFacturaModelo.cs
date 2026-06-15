using System;
using System.Collections.Generic;
using System.Text;
using tutasa.Almacenes;

namespace tutasa.EmitirFactura
{
    internal partial class EmitirFacturaModelo
    {
        public Cliente BuscarCliente(long cuit)
        {

            ClienteEntidad clienteAlmacen = ClientesAlmacen.clientes.FirstOrDefault(c => c.CuitCliente == cuit);

            if (clienteAlmacen == null)
            {
                return null;
            }

            if (clienteAlmacen != null)
            {
                Cliente cliente = new Cliente();
                cliente.Cuit = clienteAlmacen.CuitCliente;
                cliente.Nombre = clienteAlmacen.Nombre;

                return cliente;
            }

            return null;
        }

        public List<Guia> BuscarGuiasAFacturar(long cuit)
        {
            List<Guia> guiasAFacturar = new List<Guia>();

            foreach (GuiaEntidad guia in GuiaAlmacen.guias)
            {
                if (guia.CuitCliente == cuit && guia.EstadoActual == EstadoGuiaEnum.Entregada)
                {
                    if (FacturaAlmacen.facturas.All(f => !f.Guias.Contains(guia.NumeroGuia)))
                    {
                        guiasAFacturar.Add(new Guia
                        {
                            NumeroGuia = guia.NumeroGuia,
                            CuitCliente = guia.CuitCliente,
                            MontoFacturar = guia.MontoFacturar,
                            Facturada = false
                        });
                    }
                }
            }
            return guiasAFacturar;
        }

        public Factura EmitirFactura(long cuit, List<Guia> guias)
        {
            FacturaEntidad factura = new FacturaEntidad();
            factura.NumeroFactura = ObtenerSiguienteNumeroFactura();
            factura.CuitCliente = cuit;
            factura.FechaEmision = DateTime.Now;
            factura.Guias = guias.Select(g => g.NumeroGuia).ToList();
            factura.Total = CalcularTotal(guias);
            factura.Paga = false;

            FacturaAlmacen.facturas.Add(factura);

            return new Factura
            {
                NumeroFactura = factura.NumeroFactura,
                CuitCliente = factura.CuitCliente,
                FechaEmision = factura.FechaEmision,
                Guias = factura.Guias,
                Total = factura.Total
            };
        }

        public int ObtenerSiguienteNumeroFactura()
        {
            if (FacturaAlmacen.facturas.Count == 0)
            {
                return 1;
            }
            else
            {
                return FacturaAlmacen.facturas.Max(f => f.NumeroFactura) + 1;
            }
        }

        public decimal CalcularTotal(List<Guia> guias)
        {
            decimal total = 0;
            foreach (Guia guia in guias)
            {
                total += guia.MontoFacturar;
            }
            return total;
        }
    }
}

/*

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
            public string NumeroFactura { get; set; }

            public DateTime FechaEmision { get; set; }

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


        //Correlativo Factura
        private static int ultimoNumeroFactura = 1;

        public string GenerarNumeroFactura()
        {
            string numero = ultimoNumeroFactura
                .ToString()
                .PadLeft(8, '0');

            ultimoNumeroFactura++;

            return numero;
        }


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


        public string ObtenerDetalleFactura(Factura factura)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EMISIÓN DE FACTURA");
            sb.AppendLine("================================================");
            sb.AppendLine();

            sb.AppendLine("Factura N°: " + factura.NumeroFactura);

            sb.AppendLine(
                "Fecha: " +
                factura.FechaEmision.ToString("dd/MM/yyyy"));

            sb.AppendLine();

            sb.AppendLine(
                "Cliente: " +
                factura.Cliente.Nombre);

            sb.AppendLine(
                "CUIT: " +
                factura.Cliente.Cuit);

            sb.AppendLine();

            sb.AppendLine("Conceptos Facturados");
            sb.AppendLine("------------------------------------------------");

            sb.AppendLine(
                String.Format(
                    "{0,-12}{1,-25}{2,12}",
                    "N° Guía",
                    "Concepto",
                    "Importe"));

            sb.AppendLine("------------------------------------------------");

            foreach (Encomienda e in factura.Encomiendas)
            {
                sb.AppendLine(
                    String.Format(
                        "{0,-12}{1,-25}{2,12}",
                        e.NumeroGuia,
                        e.TipoEntrega,
                        e.MontoFacturar.ToString("C")));
            }

            sb.AppendLine();
            sb.AppendLine("------------------------------------------------");

            sb.AppendLine(
                "TOTAL FACTURADO: " +
                factura.Total.ToString("C"));

            sb.AppendLine("================================================");

            return sb.ToString();
        }
*/