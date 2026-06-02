using System;
using System.Collections.Generic;
using System.Linq;
using static tutasa.RuteoUltimaMilla.RuteoUltimaMillaModelo;

namespace tutasa.EmisionHojasRuta
{
    internal partial class EmisionHojasRutaModelo
    {



        private List<Fletero> fleteros =
            new List<Fletero>
        {
            new Fletero
            {
                Nombre = "Juan Perez"
            },

            new Fletero
            {
                Nombre = "Nicolas Martinez"
            },

            new Fletero
            {
                Nombre = "Jesica Lopez"
            }
        };



        private List<Guia> guias =
            new List<Guia>
        {
            new Guia
            {
                Numero = "0001",
                Cliente = "ACME",
                Direccion = "Av Siempre Viva 123",
                Dimension = "S",
                Estado = ""
            },

            new Guia
            {
                Numero = "0002",
                Cliente = "Tech SA",
                Direccion = "Av Siempre Viva 123",
                Dimension = "M",
                Estado = ""
            },

            new Guia
            {
                Numero = "0003",
                Cliente = "Mercurio",
                Direccion = "Belgrano 789",
                Dimension = "L",
                Estado = ""
            },

            new Guia
            {
                Numero = "0004",
                Cliente = "Farmacia Central",
                Direccion = "Belgrano 789",
                Dimension = "S",
                Estado = ""
            },

            new Guia
            {
                Numero = "0005",
                Cliente = "Electro SRL",
                Direccion = "Rivadavia 900",
                Dimension = "XL",
                Estado = "Pendiente de impresión"
            },

            new Guia
            {
                Numero = "0006",
                Cliente = "Supermercado Norte",
                Direccion = "Sarmiento 150",
                Dimension = "M",
                Estado = ""
            },

            new Guia
            {
                Numero = "0007",
                Cliente = "Distribuidora Sur",
                Direccion = "Colon 350",
                Dimension = "L",
                Estado = ""
            }
        };



        private List<HojaRuta> hdrs =
            new List<HojaRuta>
        {
            new HojaRuta
            {
                Numero = "HDR0001",
                Tipo = "Distribución",
                Fletero = "Juan Perez",
                Direccion = "Av Siempre Viva 123",
                Estado = "Pendiente de Emisión"
            },

            new HojaRuta
            {
                Numero = "HDR0002",
                Tipo = "Distribución",
                Fletero = "Juan Perez",
                Direccion = "Belgrano 789",
                Estado = "Pendiente de Emisión"
            },

            new HojaRuta
            {
                Numero = "HDR0003",
                Tipo = "Retiro",
                Fletero = "Logistica Sur",
                Direccion = "Zona Sur",
                Estado = "Pendiente de Emisión"
            },

            new HojaRuta
            {
                Numero = "HDR0004",
                Tipo = "Retiro",
                Fletero = "Logistica Sur",
                Direccion = "Zona Oeste",
                Estado = "Pendiente de Emisión"
            }
        };



        private List<GuiaHDR> guiasHDR =
            new List<GuiaHDR>
        {
            new GuiaHDR
            {
                NumeroHDR = "HDR0001",
                NumeroGuia = "0001"
            },

            new GuiaHDR
            {
                NumeroHDR = "HDR0001",
                NumeroGuia = "0002"
            },

            new GuiaHDR
            {
                NumeroHDR = "HDR0002",
                NumeroGuia = "0003"
            },

            new GuiaHDR
            {
                NumeroHDR = "HDR0002",
                NumeroGuia = "0004"
            },

            new GuiaHDR
            {
                NumeroHDR = "HDR0003",
                NumeroGuia = "0005"
            },

            new GuiaHDR
            {
                NumeroHDR = "HDR0003",
                NumeroGuia = "0006"
            },

            new GuiaHDR
            {
                NumeroHDR = "HDR0004",
                NumeroGuia = "0007"
            }
        };



        public List<string> ObtenerFleteros()
        {
            List<string> resultado =
                new List<string>();

            foreach (Fletero fletero in fleteros)
            {
                resultado.Add(fletero.Nombre);
            }

            return resultado;
        }

        public List<HojaRuta> BuscarHDRPendientes(string fletero, string tipo)
        {
            return hdrs.Where(h => h.Fletero == fletero && h.Tipo == tipo && h.Estado == "Pendiente de Emisión").ToList();
        }

        public List<Guia> ObtenerGuiasHDR(string numeroHDR)
        {
            List<Guia> resultado = new List<Guia>();

            foreach (GuiaHDR relacion in guiasHDR)
            {
                if (relacion.NumeroHDR == numeroHDR)
                {
                    Guia guia = guias.FirstOrDefault(g => g.Numero == relacion.NumeroGuia);

                    if (guia != null)
                    {
                        resultado.Add(guia);
                    }
                }
            }

            return resultado;
        }

        public void EmitirHDR(string numeroHDR)
        {
            HojaRuta hdr = hdrs.FirstOrDefault(h => h.Numero == numeroHDR);

            if (hdr != null)
            {
                hdr.Estado = "Emitida";
            }
        }

        public void ActualizarEstadoGuias(string numeroHDR)
        {
            foreach (GuiaHDR relacion in guiasHDR)
            {
                if (relacion.NumeroHDR == numeroHDR)
                {
                    Guia guia = guias.FirstOrDefault(g => g.Numero == relacion.NumeroGuia);

                    if (guia != null)
                    {
                        guia.Estado =
                            "Pendiente de distribución";
                    }
                }
            }
        }
    }
}