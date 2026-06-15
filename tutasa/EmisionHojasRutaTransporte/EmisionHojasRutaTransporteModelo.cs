using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.EmisionHojasRutaTransporte
{
    internal partial class EmisionHojasRutaTransporteModelo
    {


        public List<EmpresaTransporte> ObtenerEmpresas()
        {
            List<EmpresaTransporte> resultado = new List<EmpresaTransporte>();

            foreach (tutasa.Almacenes.EmpresaTransporteEntidad empresaEntidad in EmpresaTransporteAlmacen.empresas)
            {
                EmpresaTransporte empresa = new EmpresaTransporte();

                empresa.IdEmpresa = empresaEntidad.IdEmpresa;

                empresa.Nombre = empresaEntidad.NombreEmpresa;

                resultado.Add(empresa);
            }

            return resultado;
        }

        public List<ServicioTransporte> ObtenerServicios(int idEmpresa)
        {
            List<ServicioTransporte> resultado = new List<ServicioTransporte>();

            foreach (ServicioEntidad servicioEntidad in ServiciosAlmacen.servicio)
            {
                if (servicioEntidad.IdEmpresa != idEmpresa)
                {
                    continue;
                }

                if (servicioEntidad.IdCDOrigen!= Program.IdCDActual)
                {
                    continue;
                }

                if (servicioEntidad.EstadoServicio!= EstadoServicioEnum.ConAsignacion)
                {
                    continue;
                }

                ServicioTransporte servicio = new ServicioTransporte();

                servicio.IdServicio = servicioEntidad.IdServicio;

                servicio.Nombre = servicioEntidad.NombreServicio;

                servicio.IdEmpresa = servicioEntidad.IdEmpresa;

                resultado.Add(servicio);
            }

            return resultado;
        }



        public List<HojaRutaTransporte>
        BuscarHDRPendientes(int idEmpresa,int idServicio)
        {
            List<HojaRutaTransporte> resultado = new List<HojaRutaTransporte>();

            foreach (HojaRutaDeTransporteEntidad hdrEntidad in HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte)
            {
                if (hdrEntidad.EstadoHDR!= EstadoHDRTransporteEnum.Asignada)
                {
                    continue;
                }

                ServicioEntidad servicioEntidad = ServiciosAlmacen.servicio.FirstOrDefault(s => s.IdServicio== hdrEntidad.IdServicio);

                if (servicioEntidad == null)
                {
                    continue;
                }

                if (servicioEntidad.IdServicio!= idServicio)
                {
                    continue;
                }

                if (servicioEntidad.IdEmpresa!= idEmpresa)
                {
                    continue;
                }

                if (servicioEntidad.EstadoServicio!= EstadoServicioEnum.ConAsignacion)
                {
                    continue;
                }

                if (servicioEntidad.IdCDOrigen!= Program.IdCDActual)
                {
                    continue;
                }

                tutasa.Almacenes.EmpresaTransporteEntidad empresaEntidad =EmpresaTransporteAlmacen.empresas.FirstOrDefault(e => e.IdEmpresa == servicioEntidad.IdEmpresa);

                HojaRutaTransporte hdr =new HojaRutaTransporte();

                hdr.NumeroHDR = hdrEntidad.NumeroHDRTransporte;

                hdr.IdServicio = hdrEntidad.IdServicio;

                hdr.Empresa = empresaEntidad.NombreEmpresa;

                hdr.Servicio = servicioEntidad.NombreServicio;

                hdr.Estado = hdrEntidad.EstadoHDR.ToString();

                hdr.Guias = hdrEntidad.Guias;

                resultado.Add(hdr);
            }

            return resultado;
        }

        public List<Guia> ObtenerGuiasHDR(int numeroHDR)
        {
            List<Guia> resultado = new List<Guia>();

            HojaRutaDeTransporteEntidad hdr = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.FirstOrDefault( h => h.NumeroHDRTransporte == numeroHDR);

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

                guia.Direccion =guiaEntidad.CalleDestino + " " + guiaEntidad.AlturaDestino;

                guia.Dimension = guiaEntidad.Dimension.ToString();

                guia.Estado = guiaEntidad.EstadoActual.ToString();

                resultado.Add(guia);
            }

            return resultado;
        }

        public void EmitirHDR(int numeroHDR)
        {
            HojaRutaDeTransporteEntidad hdr =HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.FirstOrDefault
                (h => h.NumeroHDRTransporte == numeroHDR);

            if (hdr == null)
            {
                return;
            }

            hdr.EstadoHDR =EstadoHDRTransporteEnum.Emitida;

            ServicioEntidad servicio = ServiciosAlmacen.servicio.FirstOrDefault(s => s.IdServicio== hdr.IdServicio);

            if (servicio != null)
            {
                servicio.EstadoServicio = EstadoServicioEnum.EnRecorrido;
            }

           // HojasDeRutaTransporteAlmacen.Guardar();

            //ServiciosAlmacen.Guardar();
        }

        public void ActualizarEstadoGuias(int numeroHDR)
        {
            HojaRutaDeTransporteEntidad hdr = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.FirstOrDefault
                ( h => h.NumeroHDRTransporte == numeroHDR);

            if (hdr == null)
            {
                return;
            }

            CentroDistribucion cdActual =CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(cd => cd.IdCD == Program.IdCDActual);

            string ubicacion =cdActual != null? cdActual.NombreCD: "Desconocido";

            foreach (int numeroGuia in hdr.Guias)
            {
                GuiaEntidad guia =GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                if (guia == null)
                {
                    continue;
                }

                guia.EstadoActual = EstadoGuiaEnum.EnTransporte;

                guia.Historial.Add(new MovimientoEstadoDto
                    {
                        FechaHora = DateTime.Now,

                        Estado =EstadoGuiaEnum.EnTransporte,

                        Ubicacion = ubicacion
                    });
            }

            //GuiaAlmacen.Guardar();
        }





    }
}