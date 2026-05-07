using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Admision
{
    internal class AdmisionModelo
    {
        public string NumeroGuia { get; set; }
        public string NombreRemitente { get; set; }
        public string DireccionOrigen { get; set; }
        public string CPOrigen { get; set; }
        public string NombreDestinatario { get; set; }
        public string DireccionDestino { get; set; }
        public string CPDestino { get; set; }
        public string DimensionSeleccionada { get; set; }
        public string FleteroAsignado { get; set; }
        public decimal Peso { get; set; }
        public decimal Alto { get; set; }
        public decimal Ancho { get; set; }
        public decimal Largo { get; set; }

        public static AdmisionModelo ObtenerDatosMock()
        {
            return new AdmisionModelo
            {
                NumeroGuia = "1",
                NombreRemitente = "Juan Pérez",
                DireccionOrigen = "Av. Siempre Viva 742",
                CPOrigen = "1000",
                NombreDestinatario = "María Gómez",
                DireccionDestino = "Calle Falsa 123",
                CPDestino = "2000",
                DimensionSeleccionada = "S",
                FleteroAsignado = "Fletero 1",
                Peso = 15,
                Alto = 10,
                Ancho = 5,
                Largo = 20
            };
        }

    }
}
