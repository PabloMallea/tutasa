using tutasa.Almacenes;

namespace tutasa.CuentaCorriente
{
    internal partial class CuentaCorrienteModelo
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

        public List<MovimientoCuentaCorriente> ObtenerMovimientos(long cuit, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<MovimientoCuentaCorriente> movimientos = new List<MovimientoCuentaCorriente>();

            // Buscar las facturas del cliente en el almacén de facturas, filtrando por fecha y cuit
            List<FacturaEntidad> facturasCliente = FacturaAlmacen.facturas.Where(f => f.CuitCliente == cuit && f.FechaEmision.Date >= fechaDesde.Date && f.FechaEmision.Date <= fechaHasta.Date).ToList();

            foreach (FacturaEntidad factura in facturasCliente)
            {
                MovimientoCuentaCorriente movimiento = new MovimientoCuentaCorriente
                {
                    CuitCliente = factura.CuitCliente.ToString(),
                    Fecha = factura.FechaEmision,
                    NumeroFactura = factura.NumeroFactura.ToString(),
                    Monto = factura.Total,
                    Pago = factura.Paga
                };
                movimientos.Add(movimiento);
            }

            return movimientos;
        }

        public decimal ObtenerSaldoPendiente( List<MovimientoCuentaCorriente> movimientos)
        {
            decimal saldo = 0;

            foreach (MovimientoCuentaCorriente movimiento in movimientos)
            {
                if (!movimiento.Pago)
                {
                    saldo += movimiento.Monto;
                }
            }

            return saldo;
        }

    }
}
