using System;
using System.Collections.Generic;
using System.Linq;

namespace tutasa.EmisionHojasRuta
{
    internal class EmisionHojasRutaModelo
    {
        // =====================================
        // FLETERO
        // =====================================

        public class Fletero
        {
            public string Nombre { get; set; }
        }

        // =====================================
        // GUIA
        // =====================================

        public class Guia
        {
            public string Numero { get; set; }

            public string Cliente { get; set; }

            public string Direccion { get; set; }


            public string Dimension { get; set; }

            public string Estado { get; set; }
        }

        // =====================================
        // HDR
        // =====================================

        public class HojaRuta
        {
            public string Numero { get; set; }

            public string Tipo { get; set; }

            public string Fletero { get; set; }

            public string Direccion { get; set; }

            public string Estado { get; set; }
        }

        // =====================================
        // RELACION HDR - GUIA
        // =====================================

        public class GuiaHDR
        {
            public string NumeroHDR { get; set; }

            public string NumeroGuia { get; set; }
        }

        // =====================================
        // FLETEROS
        // =====================================

        private List<Fletero> fleteros =
            new List<Fletero>
        {
            new Fletero
            {
                Nombre = "Juan Perez"
            },

            new Fletero
            {
                Nombre = "Logistica Sur"
            },

            new Fletero
            {
                Nombre = "Distribuciones Norte"
            }
        };

        // =====================================
        // GUIAS
        // =====================================

        private List<Guia> guias =
            new List<Guia>
        {
            new Guia
            {
                Numero = "0001",
                Cliente = "ACME",
                Direccion = "Av Siempre Viva 123",
                Dimension = "S",
                Estado = "Pendiente de impresión"
            },

            new Guia
            {
                Numero = "0002",
                Cliente = "Tech SA",
                Direccion = "San Martin 456",
                Dimension = "M",
                Estado = "Pendiente de impresión"
            },

            new Guia
            {
                Numero = "0003",
                Cliente = "Mercurio",
                Direccion = "Belgrano 789",
                Dimension = "L",
                Estado = "Pendiente de impresión"
            },

            new Guia
            {
                Numero = "0004",
                Cliente = "Farmacia Central",
                Direccion = "Mitre 1200",
                Dimension = "S",
                Estado = "Pendiente de impresión"
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
                Estado = "Pendiente de impresión"
            },

            new Guia
            {
                Numero = "0007",
                Cliente = "Distribuidora Sur",
                Direccion = "Colon 350",
                Dimension = "L",
                Estado = "Pendiente de impresión"
            }
        };

        // =====================================
        // HDR
        // =====================================

        private List<HojaRuta> hdrs =
            new List<HojaRuta>
        {
            new HojaRuta
            {
                Numero = "HDR0001",
                Tipo = "Distribución",
                Fletero = "Juan Perez",
                Direccion = "Zona Centro",
                Estado = "Pendiente de Emisión"
            },

            new HojaRuta
            {
                Numero = "HDR0002",
                Tipo = "Distribución",
                Fletero = "Juan Perez",
                Direccion = "Zona Norte",
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

        // =====================================
        // RELACIONES
        // =====================================

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

        // =====================================
        // METODOS
        // =====================================

        public List<string> ObtenerFleteros()
        {
            List<string> resultado =
                new List<string>();

            foreach (Fletero fletero in fleteros)
            {
                resultado.Add(
                    fletero.Nombre);
            }

            return resultado;
        }

        public List<HojaRuta> BuscarHDRPendientes(
            string fletero,
            string tipo)
        {
            return hdrs.Where(
                h => h.Fletero == fletero
                && h.Tipo == tipo
                && h.Estado == "Pendiente de Emisión")
                .ToList();
        }

        public List<Guia> ObtenerGuiasHDR(
            string numeroHDR)
        {
            List<Guia> resultado =
                new List<Guia>();

            foreach (GuiaHDR relacion
                in guiasHDR)
            {
                if (relacion.NumeroHDR
                    == numeroHDR)
                {
                    Guia guia =
                        guias.FirstOrDefault(
                            g => g.Numero ==
                            relacion.NumeroGuia);

                    if (guia != null)
                    {
                        resultado.Add(
                            guia);
                    }
                }
            }

            return resultado;
        }

        public void EmitirHDR(
            string numeroHDR)
        {
            HojaRuta hdr =
                hdrs.FirstOrDefault(
                    h => h.Numero ==
                    numeroHDR);

            if (hdr != null)
            {
                hdr.Estado =
                    "Emitida";
            }
        }

        public void ActualizarEstadoGuias(
            string numeroHDR)
        {
            foreach (GuiaHDR relacion
                in guiasHDR)
            {
                if (relacion.NumeroHDR
                    == numeroHDR)
                {
                    Guia guia =
                        guias.FirstOrDefault(
                            g => g.Numero ==
                            relacion.NumeroGuia);

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