using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;
using static tutasa.RuteoUltimaMilla.RuteoUltimaMillaModelo;

namespace tutasa.EmisionHojasRuta
{
    internal partial class EmisionHojasRutaModelo
    {

        public List<string> ObtenerFleteros()
        {
            List<string> resultado =new List<string>();

            foreach (tutasa.Almacenes.Fletero fleteroEntidad in FleteroAlmacen.fleteros)
            {
                if (fleteroEntidad.IdCD!= Program.IdCDActual)
                {
                    continue;
                }

                resultado.Add(fleteroEntidad.Nombre);
            }

            return resultado;
        }


        public List<HojaRuta> BuscarHDRPendientes(string fletero,string tipo)
        {
            List<HojaRuta> resultado = new List<HojaRuta>();

            foreach (tutasa.Almacenes.HojaDeRutaUltimaMilla hdrEntidad in HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla)
            {
                if (hdrEntidad.Estado!= EstadoHDRUltimaMillaEnum.Asignada)
                {
                    continue;
                }

                tutasa.Almacenes.Fletero fleteroEntidad = FleteroAlmacen.fleteros.FirstOrDefault(f => f.IdFletero == hdrEntidad.IdFletero);

                if (fleteroEntidad == null)
                {
                    continue;
                }

                string tipoHDR = hdrEntidad.Tipo == TipoHDREnum.Entrega ? "Distribución": "Retiro";

                if (fleteroEntidad.Nombre!= fletero)
                {
                    continue;
                }

                if (tipoHDR!= tipo)
                {
                    continue;
                }

                HojaRuta item =new HojaRuta();

                item.NumeroHDR =hdrEntidad.NumeroHDR;

                item.Tipo =tipoHDR;

                item.IdFletero = hdrEntidad.IdFletero;

                item.Fletero = fleteroEntidad.Nombre;

                item.Direccion = hdrEntidad.DireccionDestino;

                item.Estado = hdrEntidad.Estado.ToString();

                item.Guias = hdrEntidad.Guias;

                resultado.Add(item);
            }

            return resultado;
        }

        public List<Guia> ObtenerGuiasHDR(int numeroHDR)
        {
            List<Guia> resultado = new List<Guia>();

            HojaDeRutaUltimaMilla hdr = HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.FirstOrDefault(h => h.NumeroHDR == numeroHDR);

            if (hdr == null)
            {
                return resultado;
            }

            foreach (int numeroGuia in hdr.Guias)
            {
                GuiaEntidad guiaEntidad = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                if (guiaEntidad == null)
                {
                    continue;
                }

                Guia guia = new Guia();

                guia.Numero = guiaEntidad.NumeroGuia;

                guia.Cliente = guiaEntidad.CuitCliente.ToString();

                guia.Direccion = guiaEntidad.CalleDestino + " " + guiaEntidad.AlturaDestino;

                guia.Dimension = guiaEntidad.Dimension.ToString();

                guia.Estado = guiaEntidad.EstadoActual.ToString();

                resultado.Add(guia);
            }

            return resultado;
        }


        public void EmitirHDR(int numeroHDR)
        {
            HojaDeRutaUltimaMilla hdr =HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.FirstOrDefault(h => h.NumeroHDR == numeroHDR);

            if (hdr == null)
            {
                return;
            }

            hdr.Estado = EstadoHDRUltimaMillaEnum.Emitida;

            HojaDeRutaUltimaMillaAlmacen.Guardar();
        }

        public void ActualizarEstadoGuias(int numeroHDR)
        {
            HojaDeRutaUltimaMilla hdr =HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.FirstOrDefault(h => h.NumeroHDR == numeroHDR);

            if (hdr == null)
            {
                return;
            }

            foreach (int numeroGuia in hdr.Guias)
            {
                GuiaEntidad guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                if (guia == null)
                {
                    continue;
                }

                EstadoGuiaEnum nuevoEstado;

                if (hdr.Tipo == TipoHDREnum.Retiro)
                {
                    nuevoEstado = EstadoGuiaEnum.EnProcesoRetiro;
                }
                else
                {
                    nuevoEstado = EstadoGuiaEnum.EnProcesoDistribucion;
                }

                guia.EstadoActual = nuevoEstado;

                guia.Historial.Add(new MovimientoEstadoDto
                    {
                        FechaHora =
                            DateTime.Now,

                        Estado =
                            nuevoEstado,

                        Ubicacion =
                            "CD Buenos Aires"
                    });
            }

        }

    }
}