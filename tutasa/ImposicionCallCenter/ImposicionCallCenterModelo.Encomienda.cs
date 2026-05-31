namespace tutasa.ImposicionCallCenter
{
    internal partial class ImposicionCallCenterModelo
    {
        public class Encomienda
        {
            public Cliente Cliente { get; set; }

            public string LocalidadDestino { get; set; }

            public string Destino { get; set; }

            public string CalleDestino { get; set; }

            public string AlturaDestino { get; set; }

            public string NombreDestinatario { get; set; }

            public string ApellidoDestinatario { get; set; }

            public string DniDestinatario { get; set; }

            public string TelefonoDestinatario { get; set; }

            public string Dimension { get; set; }
        }
    }
}