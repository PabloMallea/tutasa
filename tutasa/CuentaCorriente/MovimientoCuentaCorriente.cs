namespace tutasa.CuentaCorriente
{
    internal partial class CuentaCorrienteModelo
    {
        public class MovimientoCuentaCorriente
        {
            public string Cuit { get; set; }

            public DateTime Fecha { get; set; }

            public string NumeroComprobante { get; set; }

            public decimal Monto { get; set; }

            public decimal Pago { get; set; }

            public decimal Saldo { get; set; }
        }
    }
}