using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using tutasa.Almacenes;

namespace tutasa.RendicionHDRtransporte
{
    internal partial class RendicionHDRtransporteModelo
    {
        public int IdCdUsuario { get; set; } = 1;

        public string? NombreCdUsuario { get; set; } = "Buenos Aires";

        public List<EmpresaTransporte> ObtenerEmpresas()
        {
            List<EmpresaTransporte> empresas = new List<EmpresaTransporte>();

            foreach (EmpresaTransporteEntidad empresa in EmpresaTransporteAlmacen.empresas)
            {
                empresas.Add(new EmpresaTransporte()
                {
                    IdEmpresa = empresa.IdEmpresa,
                    Nombre = empresa.NombreEmpresa
                });
            }

            return empresas;
        }

        public List<Servicio> ObtenerServiciosPorEmpresa(int idEmpresa)
        {
            List<Servicio> servicios = new List<Servicio>();

            foreach (ServicioEntidad servicio in ServiciosAlmacen.servicio)
            {
                if (servicio.IdEmpresa == idEmpresa && servicio.EstadoServicio == EstadoServicioEnum.EnRecorrido)
                {
                    servicios.Add(MapearServicio(servicio));
                }
            }

            return servicios;
        }

        public List<HDRtransporte> ObtenerHdrTransporteAsignadas(int idServicio)
        {
            List<HDRtransporte> hdrTransporteList = new List<HDRtransporte>();

            ServicioEntidad servicioEntidad = ServiciosAlmacen.servicio.Find(s => s.IdServicio == idServicio);

            if (servicioEntidad == null)
            {
                return new List<HDRtransporte>();
            }

            foreach (HojaRutaDeTransporteEntidad hdr in HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte)
            {
                if (hdr.IdServicio == idServicio && hdr.EstadoHDR == EstadoHDRTransporteEnum.Asignada)
                {

                    hdrTransporteList.Add(new HDRtransporte()
                    {
                        NumeroHdrTransporte = hdr.NumeroHDRTransporte,
                        EstadoHdr = (EstadoHdrTransporte)hdr.EstadoHDR,
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
                EstadoServicio = (EstadoServicio)servicioEntidad.EstadoServicio
            };
        }

        public (bool, List<int>) ActualizarEstadoHDR(List<HDRtransporte> hdrRendidas)
        {
            bool exito = false;

            List<int> guiasActualizadas = new List<int>();

            foreach (HDRtransporte hdr in hdrRendidas)
            {
                HojaRutaDeTransporteEntidad hdrEntidad = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Find(h => h.NumeroHDRTransporte == hdr.NumeroHdrTransporte);

                if (hdrEntidad != null)
                {
                    hdrEntidad.EstadoHDR = (EstadoHDRTransporteEnum)hdr.EstadoHdr;

                    guiasActualizadas.AddRange(ActualizarEstadoGuias(hdr));

                    exito = true;
                }
            }

            return (exito, guiasActualizadas);
        }

        public List<int> ActualizarEstadoGuias(HDRtransporte hdr)
        {
            List<int> resultado = new List<int>();

            foreach (int numeroGuia in hdr.Guia)
            {
                GuiaEntidad guiaEntidad = GuiaAlmacen.guias.Find(g => g.NumeroGuia == numeroGuia);
                if (guiaEntidad != null)
                {
                    EstadoGuiaEnum nuevoEstado;

                    if (guiaEntidad.IdCDDestino == IdCdUsuario)
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
                            Ubicacion = NombreCdUsuario
                        });

                    resultado.Add(guiaEntidad.NumeroGuia);
                }
            }
            return resultado;

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