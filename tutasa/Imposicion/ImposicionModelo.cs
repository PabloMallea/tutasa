using CAI_TP.Imposicion;
using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Imposicion
{
    internal class ImposicionModelo
    {
        //Aca voy a llamar y completar todos los datos de prueba.
        public List<Destino> Destino
        {
            get
            {
                return new List<Destino>
                {
                    new Destino { Id = 1, Descripcion = "Domicilio Destinatario" },
                    new Destino { Id = 2, Descripcion = "Agencia" },
                    new Destino { Id = 3, Descripcion = "Centro de Distribución" }
                };
            }
        }
        public List<TipoImposicion> TipoImposicion
        {
            get
            {
                return new List<TipoImposicion>
                {
                    new TipoImposicion { Id = 1, Descripcion = "Call Center" },
                    new TipoImposicion { Id = 2, Descripcion = "Agencia" },
                    new TipoImposicion { Id = 3, Descripcion = "Centro de Distribución" }
                };
            }
        }

        public List<Dimension> Dimension
        {
            get
            {
                return new List<Dimension>
                {
                    new Dimension { Id = 1, Descripcion = "S" },
                    new Dimension { Id = 2, Descripcion = "M" },
                    new Dimension { Id = 3, Descripcion = "L" },
                    new Dimension { Id = 3, Descripcion = "XL" }
                };
            }
        }
    }
}
