using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace tutasa.RendicionHDRultimaMilla
{
    internal partial class RendicionHDRultimaMillaModelo
    {
        public List<string> tipos = new List<string> { "Retiro", "Distribución" };

        public List<string> fleteros = new List<string> { "Fletero A", "Fletero B", "Fletero C" };

        public List<HDRultimaMilla> HDRultimaMillaList { get; private set; }

        public static RendicionHDRultimaMillaModelo ObtenerMockHDRAsignadas()
        {
            return new RendicionHDRultimaMillaModelo
            {
                HDRultimaMillaList = new List<HDRultimaMilla>
                {
                    new HDRultimaMilla { n_hdr = 1, fletero = "Fletero A", estado = "Asignada", tipo = "Retiro", fecha = DateTime.Now },
                    new HDRultimaMilla { n_hdr = 2, fletero = "Fletero B", estado = "Asignada", tipo = "Distribución", fecha = DateTime.Now.AddDays(-1) },
                    new HDRultimaMilla { n_hdr = 3, fletero = "Fletero C", estado = "Asignada", tipo = "Retiro", fecha = DateTime.Now.AddDays(-2) }
                }
            };
        }

        
    }
}
