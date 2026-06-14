namespace tutasa.EmitirFactura
{
    internal partial class EmitirFacturaModelo
    {
        public class Factura
        {
            public int NumeroFactura { get; set; }

            public DateTime FechaEmision { get; set; }

            public long CuitCliente { get; set; }

            public List<int> Guias { get; set; }

            public decimal Total { get; set; }
        }

    }
}