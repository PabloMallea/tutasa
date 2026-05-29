namespace tutasa.EntregaEncomienda
{
    internal class EntregaEncomiendaModelo
    {
        // Aca voy a llamar y completar todos los datos de prueba.
        public Guia? BuscarGuia(string nroGuia)
        {
            var guias = new List<Guia>
            {
                new Guia { NroGuia = "AG001-0001", Cliente = "Juan Perez",    Destinatario = "Maria Lopez",  DniDestinatario = "30123456" },
                new Guia { NroGuia = "AG001-0002", Cliente = "Carlos Gomez",  Destinatario = "Ana Martinez", DniDestinatario = "28654321" },
                new Guia { NroGuia = "CD001-0001", Cliente = "Laura Sanchez", Destinatario = "Pedro Ruiz",   DniDestinatario = "35987654" }
            };

            return guias.Find(g => g.NroGuia == nroGuia);
        }
    }
}