using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.RendicionHDRtransporte
{
    internal partial class RendicionHDRtransporteModelo
    {
        public List<string> empresas { get; set; } = new List<string> { "Plusmar", "Flecha Bus", "Chevallier", "Via Bariloche", "Condor Estrella" };
        public List<Servicio> servicios { get; set; } = new List<Servicio>
        {
            new Servicio { empresa = "Plusmar", cd_destino = "Buenos Aires", horario_llegada = "08:30" },
            new Servicio { empresa = "Plusmar", cd_destino = "Buenos Aires", horario_llegada = "18:30" },
            new Servicio { empresa = "Flecha Bus", cd_destino = "Buenos Aires", horario_llegada = "10:15" },
            new Servicio { empresa = "Chevallier", cd_destino = "Buenos Aires", horario_llegada = "14:00" },
            new Servicio { empresa = "Via Bariloche", cd_destino = "Buenos Aires", horario_llegada = "18:45" },
            new Servicio { empresa = "Condor Estrella", cd_destino = "Buenos Aires", horario_llegada = "22:30" }
        };
        public List<HDRtransporte>? HDRtransporteList { get; private set; }

        public static RendicionHDRtransporteModelo ObtenerMockHDRAsignadas()
        {
            return new RendicionHDRtransporteModelo
            {
                HDRtransporteList = new List<HDRtransporte>
                {
                    new HDRtransporte { n_hdr = 1001, estado = "Asignada", servicio = new Servicio { empresa = "Plusmar", cd_destino = "Buenos Aires", horario_llegada = "08:30" }, fecha = DateTime.Now.AddDays(-1) },
                    new HDRtransporte { n_hdr = 1002,  estado = "Asignada", servicio = new Servicio { empresa = "Flecha Bus", cd_destino = "Buenos Aires", horario_llegada = "10:15" }, fecha = DateTime.Now.AddDays(-2) },
                    new HDRtransporte { n_hdr = 1003, estado = "Asignada", servicio = new Servicio { empresa = "Plusmar", cd_destino = "Buenos Aires", horario_llegada = "08:30" }, fecha = DateTime.Now },
                    new HDRtransporte { n_hdr = 1004, estado = "Asignada", servicio = new Servicio { empresa = "Chevallier", cd_destino = "Buenos Aires", horario_llegada = "14:00" }, fecha = DateTime.Now.AddDays(-3) },
                    new HDRtransporte { n_hdr = 1005, estado = "Asignada", servicio = new Servicio { empresa = "Via Bariloche", cd_destino = "Buenos Aires", horario_llegada = "18:45" }, fecha = DateTime.Now.AddDays(-1) },
                    new HDRtransporte { n_hdr = 1006, estado = "Asignada", servicio = new Servicio { empresa = "Condor Estrella", cd_destino = "Buenos Aires", horario_llegada = "22:30" }, fecha = DateTime.Now }
                }
            };
        }
    }
}