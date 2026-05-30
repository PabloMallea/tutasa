namespace tutasa.EntregaEncomienda
{
    internal class Guia
    {
        public string NroGuia { get; set; }
        public string Cliente { get; set; }
        public string Destinatario { get; set; } 
        public string DniDestinatario { get; set; }
        public Estado Estado { get; set; } = new Estado { Id = 1, Descripcion = "Pendiente de entrega" };
    }
}