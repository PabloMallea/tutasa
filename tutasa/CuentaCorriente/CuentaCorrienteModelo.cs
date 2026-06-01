using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutasa.CuentaCorriente
{
    internal class CuentaCorrienteModelo
    {
        public class Cliente
        {
            public string Cuit { get; set; }

            public string Nombre { get; set; }
        }

        public class MovimientoCuentaCorriente
        {
            public string Cuit { get; set; }

            public DateTime Fecha { get; set; }

            public string NumeroComprobante { get; set; }

            public string Concepto { get; set; }

            public decimal Monto { get; set; }

            public decimal Pago { get; set; }

            public decimal Saldo { get; set; }
        }

        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente
            {
                Cuit = "20333444556",
                Nombre = "Juan Pérez"
            },

            new Cliente
            {
                Cuit = "30777888999",
                Nombre = "Empresa SA"
            }
        };

        // Simulación de movimientos de cuenta corriente.
        // Hay facturas pagas, parcialmente pagas e impagas.
        // prueba
        private List<MovimientoCuentaCorriente> movimientos = new List<MovimientoCuentaCorriente>
        {
            new MovimientoCuentaCorriente
            {
                Cuit = "20333444556",
                Fecha = new DateTime(2026, 5, 1),
                NumeroComprobante = "FAC0001",
                Concepto = "Entrega a domicilio",
                Monto = 12000,
                Pago = 12000,
                Saldo = 0
            },

            new MovimientoCuentaCorriente
            {
                Cuit = "20333444556",
                Fecha = new DateTime(2026, 5, 5),
                NumeroComprobante = "FAC0002",
                Concepto = "Entrega en agencia",
                Monto = 8500,
                Pago = 3000,
                Saldo = 5500
            },

            new MovimientoCuentaCorriente
            {
                Cuit = "20333444556",
                Fecha = new DateTime(2026, 5, 10),
                NumeroComprobante = "FAC0003",
                Concepto = "Entrega a domicilio",
                Monto = 15000,
                Pago = 0,
                Saldo = 15000
            },

            new MovimientoCuentaCorriente
            {
                Cuit = "30777888999",
                Fecha = new DateTime(2026, 5, 3),
                NumeroComprobante = "FAC0100",
                Concepto = "Entrega en agencia",
                Monto = 9500,
                Pago = 9500,
                Saldo = 0
            },

            new MovimientoCuentaCorriente
            {
                Cuit = "30777888999",
                Fecha = new DateTime(2026, 5, 8),
                NumeroComprobante = "FAC0101",
                Concepto = "Entrega a domicilio",
                Monto = 22000,
                Pago = 10000,
                Saldo = 12000
            }
        };

        public Cliente BuscarCliente(string cuit)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Cuit == cuit)
                {
                    return cliente;
                }
            }

            return null;
        }

        public List<MovimientoCuentaCorriente> ObtenerMovimientos( string cuit, DateTime fechaDesde, DateTime fechaHasta)
        {
            // Filtrar movimientos del cliente
            // y rango de fechas seleccionado
            //la m es cada movimiento de la lista movimientos, se filtra por cuit y fecha. Por las dudas, la m se crea
            //automáticamente por la expresión lambda, no es necesario declararla antes. El resultado se convierte a una lista con ToList() para facilitar su uso.

            return movimientos.Where(m =>m.Cuit == cuit && m.Fecha.Date >= fechaDesde.Date && m.Fecha.Date <= fechaHasta.Date).ToList();
        }
    }
}