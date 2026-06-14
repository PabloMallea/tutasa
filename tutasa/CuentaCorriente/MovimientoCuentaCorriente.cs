namespace tutasa.CuentaCorriente
{
    internal partial class CuentaCorrienteModelo
    {
        public class MovimientoCuentaCorriente
        {
            public string CuitCliente { get; set; }

            public DateTime Fecha { get; set; }

            public string NumeroFactura { get; set; }

            public decimal Monto { get; set; }

            public bool Pago { get; set; }

        }
    }
}