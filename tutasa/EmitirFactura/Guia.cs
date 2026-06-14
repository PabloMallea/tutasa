namespace tutasa.EmitirFactura
{
    internal partial class EmitirFacturaModelo
    {
        public class Guia
        {
            public int NumeroGuia { get; set; }

            public long CuitCliente { get; set; }

            public decimal MontoFacturar { get; set; }

            public bool Facturada { get; set; }
        }

    }
}