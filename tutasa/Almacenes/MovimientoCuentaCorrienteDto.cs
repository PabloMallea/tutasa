namespace tutasa.Almacenes
{
    public class MovimientoCuentaCorrienteDto
    {
        public int IdFactura { get; set; }

        public DateTime Fecha { get; set; }

        public decimal MontoPago { get; set; }

        public decimal Pago { get; set; }

        public decimal Saldo { get; set; }
    }
}
