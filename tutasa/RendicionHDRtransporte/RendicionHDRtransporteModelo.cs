using System;
using System.Collections.Generic;
using tutasa.Almacenes;

namespace tutasa.RendicionHDRtransporte
{
    internal partial class RendicionHDRtransporteModelo
    {
        public int IdCdUsuario { get; set; } = 1;
        public string? NombreCdUsuario { get; set; } = "Buenos Aires";

        public List<EmpresaTransporteEntidad> ObtenerEmpresas()
        {
            return EmpresaTransporteAlmacen.empresas;
        }

        public List<ServicioEntidad> ObtenerServiciosPorEmpresa(int idEmpresa)
        {
            return ServiciosAlmacen.servicio.Where(s => s.IdEmpresa == idEmpresa).ToList();
        }

        public List<HojaRutaDeTransporteEntidad>
            ObtenerHDRAsignadas(int idServicio)
        {
            return HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte
                .Where(h =>
                    h.IdServicio == idServicio
                    &&
                    h.EstadoHDR ==
                        EstadoHDRTransporteEnum.Asignada)
                .ToList();
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