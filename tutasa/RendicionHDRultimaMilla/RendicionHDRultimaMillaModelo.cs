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
        public int IdCdActual = Program.IdCDActual;

        public List<string> ObtenerFleteros(int IdCdActual)
        {
            List<string> fleteros = new List<string>();

            foreach (Fletero fletero in FleteroAlmacen.fleteros)
            {
                if (fletero.IdCD == IdCdActual)
                {
                    fleteros.Add(fletero.Nombre);
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

        public List<HDRultimaMilla> ObtenerHdrUltimaMillaEmitida(string fleteroSeleccionado, string tipoHDR)
        {
            List<HDRultimaMilla> hdrUltimaMillaList = new();

            Fletero fletero = FleteroAlmacen.fleteros.Find(f => f.Nombre == fleteroSeleccionado);

            if (fletero == null)
            {
                return hdrUltimaMillaList;
            }

            foreach (HojaDeRutaUltimaMilla hdr in HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla)
            {
                if (hdr.IdFletero == fletero.IdFletero && hdr.Tipo.ToString() == tipoHDR && hdr.Estado.ToString() == "Emitida")
                {

                    hdrUltimaMillaList.Add(new HDRultimaMilla
                    {
                        NumeroHDR = hdr.NumeroHDR,

                        Fletero = fletero.Nombre,

                        Estado = hdr.Estado.ToString(),

                        Tipo = hdr.Tipo.ToString(),

                        Cumplida = ""
                    });
                }
            }

            return hdrUltimaMillaList;
        }

        public bool ConfirmarRendicionHDR(List<HDRultimaMilla> hdrRendidas)
        {

            foreach (HDRultimaMilla hdr in hdrRendidas)
            {
                HojaDeRutaUltimaMilla hdrAlmacen = HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.Find(h => h.NumeroHDR == hdr.NumeroHDR);

                if (hdrAlmacen == null)
                {
                    continue;
                }

                hdrAlmacen.Estado = (EstadoHDRUltimaMillaEnum)Enum.Parse(typeof(EstadoHDRUltimaMillaEnum), hdr.Estado);

                hdrAlmacen.Cumplida = hdr.Cumplida == "Cumplida";

                string tipoHdr = hdr.Tipo;

                List<int> guias = hdrAlmacen.Guias;

                foreach (int guia in guias)
                {
                    GuiaEntidad guiaAlmacen = GuiaAlmacen.guias.Find(g => g.NumeroGuia == guia);

                    if (guiaAlmacen != null)
                    {
                        EstadoGuiaEnum nuevoEstado;
                        if (hdrAlmacen.Cumplida)
                        {
                            if (tipoHdr == nameof(TipoHDREnum.Retiro))
                            {
                                nuevoEstado = EstadoGuiaEnum.PendienteAdmision;
                            }
                            else
                            {
                                nuevoEstado = EstadoGuiaEnum.PendienteDeEntrega;
                            }

                        }
                        else
                        {
                            if (tipoHdr == nameof(TipoHDREnum.Retiro))
                            {
                                nuevoEstado = EstadoGuiaEnum.Impuesta;
                            }
                            else
                            {
                                nuevoEstado = EstadoGuiaEnum.EnDestino;
                                guiaAlmacen.IntentosEntrega += 1;
                            }
                        }

                        guiaAlmacen.EstadoActual = nuevoEstado;

                        guiaAlmacen.Historial.Add(new MovimientoEstadoDto()
                        {
                            FechaHora = DateTime.Now,
                            Estado = guiaAlmacen.EstadoActual,
                            Ubicacion = ObtenerCDActual(IdCdActual)
                        });
                    }
                }

            }
            return true;
        }

        public string ObtenerCDActual(int IdCdActual)
        {
            CentroDistribucion cd = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == IdCdActual);
            return cd != null ? cd.NombreCD : "Desconocido";

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