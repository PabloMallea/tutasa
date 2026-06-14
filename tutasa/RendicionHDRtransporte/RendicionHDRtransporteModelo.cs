using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using tutasa.Almacenes;

namespace tutasa.RendicionHDRtransporte
{
    internal partial class RendicionHDRtransporteModelo
    {
        public int IdCdActual = Program.IdCDActual;

        public List<string> ObtenerEmpresas()
        {
            List<string> empresas = new List<string>();

            foreach (EmpresaTransporteEntidad empresa in EmpresaTransporteAlmacen.empresas)
            {
                empresas.Add(empresa.NombreEmpresa);
            }

            return empresas;
        }

        public List<string> ObtenerServiciosPorEmpresa(string nombreEmpresa)
        {
            int idEmpresa = EmpresaTransporteAlmacen.empresas.Find(e => e.NombreEmpresa == nombreEmpresa)?.IdEmpresa ?? -1;

            if (idEmpresa == -1)
            {
                return new List<string>();
            }

            List<string> servicios = new List<string>();

            foreach (ServicioEntidad servicio in ServiciosAlmacen.servicio)
            {
                if (servicio.IdEmpresa == idEmpresa && servicio.EstadoServicio == EstadoServicioEnum.EnRecorrido)
                {
                    servicios.Add(servicio.NombreServicio);
                }
            }

            return servicios;
        }

        public List<HDRtransporte> ObtenerHdrTransporteEmitidas(string nombreServicio)
        {
            List<HDRtransporte> hdrTransporteList = new List<HDRtransporte>();

            ServicioEntidad servicioEntidad = ServiciosAlmacen.servicio.Find(s => s.NombreServicio == nombreServicio);

            if (servicioEntidad == null)
            {
                return new List<HDRtransporte>();
            }

            int idServicio = servicioEntidad.IdServicio;

            foreach (HojaRutaDeTransporteEntidad hdr in HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte)
            {
                if (hdr.IdServicio == idServicio && hdr.EstadoHDR == EstadoHDRTransporteEnum.Emitida)
                {

                    hdrTransporteList.Add(new HDRtransporte()
                    {
                        NumeroHdrTransporte = hdr.NumeroHDRTransporte,
                        NombreEmpresa = EmpresaTransporteAlmacen.empresas.Find(e => e.IdEmpresa == servicioEntidad.IdEmpresa)?.NombreEmpresa ?? "Desconocida",
                        EstadoHdr = hdr.EstadoHDR.ToString(),
                        Servicio = MapearServicio(servicioEntidad),
                        Guia = new List<int>(hdr.Guias)

                    });
                }
            }
            return hdrTransporteList;
        }

        private Servicio MapearServicio(ServicioEntidad servicioEntidad)
        {
            return new Servicio()
            {
                IdServicio = servicioEntidad.IdServicio,
                IdEmpresa = servicioEntidad.IdEmpresa,
                NombreServicio = servicioEntidad.NombreServicio,
                FechaSalida = servicioEntidad.FechaSalida,
                FechaLlegada = servicioEntidad.FechaLlegada,
                IdCdOrigen = servicioEntidad.IdCDOrigen,
                IdCdDestino = servicioEntidad.IdCDDestino,
                EstadoServicio = servicioEntidad.EstadoServicio.ToString()
            };
        }

        public bool ActualizarEstadoHDR(List<HDRtransporte> hdrRendidas)
        {

            foreach (HDRtransporte hdr in hdrRendidas)
            {
                HojaRutaDeTransporteEntidad hdrAlmacen = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Find(h => h.NumeroHDRTransporte == hdr.NumeroHdrTransporte);

                if (hdrAlmacen != null)
                {
                    hdrAlmacen.EstadoHDR = (EstadoHDRTransporteEnum)Enum.Parse(typeof(EstadoHDRTransporteEnum), hdr.EstadoHdr);

                    foreach (int numeroGuia in hdr.Guia)
                    {
                        GuiaEntidad guiaEntidad = GuiaAlmacen.guias.Find(g => g.NumeroGuia == numeroGuia);

                        if (guiaEntidad != null)
                        {
                            EstadoGuiaEnum nuevoEstado;

                            if (guiaEntidad.IdCDDestino == IdCdActual)
                            {
                                nuevoEstado = EstadoGuiaEnum.EnDestino;
                            }
                            else
                            {
                                nuevoEstado = EstadoGuiaEnum.Admitida;

                            }

                            guiaEntidad.EstadoActual = nuevoEstado;

                            guiaEntidad.Historial.Add(
                                new MovimientoEstadoDto()
                                {
                                    FechaHora = DateTime.Now,
                                    Estado = nuevoEstado,
                                    Ubicacion = ObtenerCDActual(IdCdActual)
                                }
                            );
                        }
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
public List<string> empresas { get; set; } = new List<string>
        {
            "Plusmar",
            "Flecha Bus",
            "Chevallier",
            "Via Bariloche",
            "Condor Estrella"
        };

        public List<Servicio> servicios { get; set; } = new List<Servicio>
        {
            new Servicio
            {
                IdServicio = 1,
                IdEmpresa = 1,
                NombreServicio = "Buenos Aires - 08:30",
                FechaSalida = DateTime.Today.AddHours(2),
                FechaLlegada = DateTime.Today.AddHours(8).AddMinutes(30),
                IdCdOrigen = 1,
                IdCdDestino = 2,
                EstadoServicio = EstadoServicio.ConAsignacion,
                
            },

            new Servicio
            {
                IdServicio = 2,
                IdEmpresa = 2,
                NombreServicio = "Buenos Aires - 10:15",
                FechaSalida = DateTime.Today.AddHours(4),
                FechaLlegada = DateTime.Today.AddHours(10).AddMinutes(15),
                IdCdOrigen = 1,
                IdCdDestino = 2,
                EstadoServicio = EstadoServicio.ConAsignacion,
                
            },
            new Servicio
            {
                IdServicio = 3,
                IdEmpresa = 2,
                NombreServicio = "Rosario - 10:15",
                FechaSalida = DateTime.Today.AddHours(4),
                FechaLlegada = DateTime.Today.AddHours(10).AddMinutes(15),
                IdCdOrigen = 1,
                IdCdDestino = 2,
                EstadoServicio = EstadoServicio.ConAsignacion,

            }
        };

        public List<HDRtransporte> HDRtransporteList { get; private set; }

        public static RendicionHDRtransporteModelo ObtenerMockHDRAsignadas()
        {
            RendicionHDRtransporteModelo modelo = new();

            Servicio servicio1 = modelo.servicios[0];
            Servicio servicio2 = modelo.servicios[1];

            modelo.HDRtransporteList = new List<HDRtransporte>
            {
                new HDRtransporte
                {
                    NumeroHdrTransporte = 1001,
                    EstadoHdr = EstadoHdrTransporte.Asignada,
                    Servicio = servicio1,
                    Guia = new List<Guia> 
                    { 
                        new Guia { NumeroGuia = 50001, IdCdDestino = 1 }, 
                        new Guia { NumeroGuia = 50002, IdCdDestino = 1 }, 
                        new Guia { NumeroGuia = 50003, IdCdDestino = 1 } 
                    }

                },

                new HDRtransporte
                {
                    NumeroHdrTransporte = 1002,
                    EstadoHdr = EstadoHdrTransporte.Asignada,
                    Servicio = servicio1,
                    Guia = new List<Guia> 
                    { 
                        new Guia { NumeroGuia = 60001, IdCdDestino = 2 }, 
                        new Guia { NumeroGuia = 60002, IdCdDestino = 2 }, 
                        new Guia { NumeroGuia = 60003, IdCdDestino = 2 } 
                    }

                },
                new HDRtransporte
                {
                    NumeroHdrTransporte = 1003,
                    EstadoHdr = EstadoHdrTransporte.Asignada,
                    Servicio = servicio2,
                    Guia = new List<Guia>
                    {
                        new Guia { NumeroGuia = 50001, IdCdDestino = 3 },
                        new Guia { NumeroGuia = 50002, IdCdDestino = 3 },
                        new Guia { NumeroGuia = 50003, IdCdDestino = 3 }
                    }

                },
            };

            return modelo;
        }

        public List<string> ActualizarEstadoGuias(HDRtransporte hdr) 
        { 
            List<string> resultado = new(); 
            foreach (Guia guia in hdr.Guia) 
            { 
                if (guia.IdCdDestino == IdCdUsuario) 
                { 
                    guia.EstadoGuia = EstadoGuia.EnDestino; 
                } 
                else 
                { 
                    guia.EstadoGuia = EstadoGuia.Admitida; 
                } 
                string mensaje = $"Guía {guia.NumeroGuia} actualizada a estado '{guia.EstadoGuia}'"; 
                //Console.WriteLine(mensaje);
                resultado.Add(mensaje); 
            }
            return resultado; 
        }*/