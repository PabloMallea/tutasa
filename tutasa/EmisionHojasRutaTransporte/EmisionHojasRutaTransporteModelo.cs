using System;
using System.Collections.Generic;
using System.Linq;

namespace tutasa.EmisionHojasRutaTransporte
{
    internal class EmisionHojasRutaTransporteModelo
    {
        // =====================================
        // EMPRESA
        // =====================================

        public class EmpresaTransporte
        {
            public string Nombre { get; set; }
        }

        // =====================================
        // SERVICIO
        // =====================================

        public class ServicioTransporte
        {
            public string Nombre { get; set; }

            public string Empresa { get; set; }
        }

        // =====================================
        // GUIA
        // =====================================

        public class Guia
        {
            public string Numero { get; set; }

            public string Cliente { get; set; }

            public string Direccion { get; set; }

            public string Tipo { get; set; }

            public string Dimension { get; set; }

            public string Estado { get; set; }
        }


        public class MovimientoGuia
        {
            public int Id { get; set; }

            public DateTime Fecha { get; set; }

            public string Estado { get; set; }
        }

            public class GuiaMovimiento
            {
                public string NumeroGuia { get; set; }

                public int IdMovimiento { get; set; }
            }
            // =====================================
            // HDR
            // =====================================

            public class HojaRutaTransporte
            {
                public string Numero { get; set; }

                public string Empresa { get; set; }

                public string Servicio { get; set; }

                public string Estado { get; set; }
            }

            // =====================================
            // RELACION HDR - GUIA
            // =====================================

            public class GuiaHDRTransporte
            {
                public string NumeroHDR { get; set; }

                public string NumeroGuia { get; set; }
            }

            // =====================================
            // EMPRESAS
            // =====================================

            private List<EmpresaTransporte> empresas =
                new List<EmpresaTransporte>
            {
            new EmpresaTransporte
            {
                Nombre = "Transportes SRL"
            },

            new EmpresaTransporte
            {
                Nombre = "Logística Express"
            },

            new EmpresaTransporte
            {
                Nombre = "Vía Cargo"
            }
            };

            // =====================================
            // SERVICIOS
            // =====================================

            private List<ServicioTransporte> servicios =
                new List<ServicioTransporte>
            {
            new ServicioTransporte
            {
                Nombre = "Córdoba - 21:30",
                Empresa = "Transportes SRL"
            },

            new ServicioTransporte
            {
                Nombre = "Rosario - 18:00",
                Empresa = "Transportes SRL"
            },

            new ServicioTransporte
            {
                Nombre = "Buenos Aires - 20:00",
                Empresa = "Transportes SRL"
            },

            new ServicioTransporte
            {
                Nombre = "Mendoza - 22:00",
                Empresa = "Logística Express"
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
                Tipo = "Transporte",
                Dimension = "S",
                Estado =
                    "Pendiente de impresión para chofer"
            },

            new Guia
            {
                Numero = "0002",
                Cliente = "Tech SA",
                Direccion = "San Martín 456",
                Tipo = "Transporte",
                Dimension = "XL",
                Estado =
                    "Pendiente de impresión para chofer"
            },

            new Guia
            {
                Numero = "0003",
                Cliente = "Mercurio",
                Direccion = "Belgrano 789",
                Tipo = "Transporte",
                Dimension = "M",
                Estado =
                    "Pendiente de impresión para chofer"
            }
            };

            // =====================================
            // HDR
            // =====================================

            private List<HojaRutaTransporte> hdrs =
                new List<HojaRutaTransporte>
            {
            new HojaRutaTransporte
            {
                Numero = "HDR0001",
                Empresa = "Transportes SRL",
                Servicio = "Córdoba - 21:30",
                Estado = "Pendiente de Emisión"
            },

            new HojaRutaTransporte
            {
                Numero = "HDR0002",
                Empresa = "Transportes SRL",
                Servicio = "Rosario - 18:00",
                Estado = "Pendiente de Emisión"
            }
            };

            // =====================================
            // RELACIONES
            // =====================================

            private List<GuiaHDRTransporte>guiasHDR = new List<GuiaHDRTransporte>
            {
            new GuiaHDRTransporte
            {
                NumeroHDR = "HDR0001",
                NumeroGuia = "0001"
            },

            new GuiaHDRTransporte
            {
                NumeroHDR = "HDR0001",
                NumeroGuia = "0002"
            },

            new GuiaHDRTransporte
            {
                NumeroHDR = "HDR0002",
                NumeroGuia = "0003"
            }
            };

            // =====================================
            // METODOS
            // =====================================

            public List<string> ObtenerEmpresas()
            {
                List<string> resultado =
                    new List<string>();

                foreach (EmpresaTransporte empresa
                    in empresas)
                {
                    resultado.Add(
                        empresa.Nombre);
                }

                return resultado;
            }

            public List<string>
                ObtenerServicios(string empresa)
            {
                List<string> resultado =
                    new List<string>();

                foreach (
                    ServicioTransporte servicio
                    in servicios)
                {
                    if (servicio.Empresa
                        == empresa)
                    {
                        resultado.Add(
                            servicio.Nombre);
                    }
                }

                return resultado;
            }

            public List<HojaRutaTransporte>
                BuscarHDRPendientes(string empresa,string servicio)
            {
                return hdrs.Where(h =>h.Empresa == empresa && h.Servicio == servicio && h.Estado == "Pendiente de Emisión").ToList();
            }

            public List<Guia>
                ObtenerGuiasHDR(string numeroHDR)
            {
                List<Guia> resultado = new List<Guia>();

                foreach (GuiaHDRTransporte relacion in guiasHDR)
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
                HojaRutaTransporte hdr = hdrs.FirstOrDefault(h => h.Numero == numeroHDR);

                if (hdr != null)
                {
                    hdr.Estado = "Emitida";
                }
            }

            public void ActualizarEstadoGuias(string numeroHDR)
            {
                foreach (GuiaHDRTransporte relacion in guiasHDR)
                {
                    if (relacion.NumeroHDR == numeroHDR)
                    {
                        Guia guia = guias.FirstOrDefault(g => g.Numero == relacion.NumeroGuia);

                        if (guia != null)
                        {
                            guia.Estado = "Pendiente de transporte a CD";
                        }
                    }
                }
            }
        }
    }
