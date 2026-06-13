using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using tutasa.Almacenes;
using tutasa.RendicionHDRultimaMilla;
using static tutasa.RendicionHDRultimaMilla.RendicionHDRultimaMillaModelo;


namespace tutasa.RendicionHDRultimaMilla
{
    internal partial class RendicionHDRultimaMillaModelo
    {
        public int IdCdUsuario { get; set; } = 1;

        public string? NombreCdUsuario { get; set; } = "Buenos Aires";

        public List<FleteroHDRultimaMilla> ObtenerFleteros(int idCdUsuario)
        {
            List<FleteroHDRultimaMilla> fleteros = new List<FleteroHDRultimaMilla>();

            foreach (Fletero fletero in FleteroAlmacen.fleteros)
            {
                if(fletero.IdCD == idCdUsuario)
                {
                    fleteros.Add(new FleteroHDRultimaMilla
                    {
                        IdFletero = fletero.IdFletero,
                        Nombre = fletero.Nombre
                    });
                }
            }

            return fleteros;
        }

        public List<string> ObtenerTiposHDR()
        {
            List<string> tiposHDR = new List<string>();

            foreach (string tipo in Enum.GetNames(typeof(TipoHDREnum)))
            {
                tiposHDR.Add(tipo);
            } 
            
            return tiposHDR;
        }

        public List<HDRultimaMilla> ObtenerHdrUltimaMillaAsignadas(int idFletero, string tipoHDR)
        {
            List<HDRultimaMilla> hdrUltimaMillaList = new List<HDRultimaMilla>();
            foreach (HojaDeRutaUltimaMilla hdr in HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla)
            {
                if (hdr.IdFletero == idFletero && hdr.Tipo.ToString() == tipoHDR && hdr.Estado == EstadoHDRUltimaMillaEnum.Asignada)
                {
                    hdrUltimaMillaList.Add(new HDRultimaMilla
                    {
                        NumeroHDR = hdr.NumeroHDR,
                        IdFletero = hdr.IdFletero,
                        Estado = (EstadoHDRUltimaMilla)hdr.Estado,
                        Tipo = (TipoHDR)hdr.Tipo,
                        Cumplida = hdr.Cumplida,
                        Guias = new List<int>(hdr.Guias)
                    });
                }
            }
            return hdrUltimaMillaList;
        }



    }
}

 

/*
public List<string> tipos = new List<string> { "Retiro", "Distribución" };

public List<string> fleteros = new List<string> { "Fletero A", "Fletero B", "Fletero C" };

public List<HDRultimaMilla>? HDRultimaMillaList { get; private set; }

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
*/