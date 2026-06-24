using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using tutasa.Admision;
using tutasa.Almacenes;
namespace tutasa.RuteoTransporte
{
    internal partial class FormRuteoTransporteModelo
    {
        private int idCDActual = Program.IdCDActual;

        public List<CD> ObtenerCDs()
        {
            List<CD> resultado = new List<CD>();

            foreach (CentroDistribucion entidad in CentroDistribucionAlmacen.CentrosDistribucion)
            {
                CD cd = new CD();

                cd.Id = entidad.IdCD;
                cd.Nombre = entidad.NombreCD;

                resultado.Add(cd);
            }

            return resultado;
        }

        public List<Localidad> ObtenerLocalidades()
        {
            List<Localidad> resultado = new List<Localidad>();

            foreach (tutasa.Almacenes.Localidad entidad in LocalidadAlmacen.localidades)
            {
                Localidad localidad = new Localidad();

                localidad.Id = entidad.IdLocalidad;
                localidad.Nombre = entidad.NombreLocalidad;

                resultado.Add(localidad);
            }

            return resultado;
        }

        public List<Dimension> ObtenerDimensiones()
        {
            List<Dimension> resultado = new List<Dimension>();

            foreach (tutasa.Almacenes.DimensionEnum dimension in Enum.GetValues(typeof(tutasa.Almacenes.DimensionEnum)))
            {
                Dimension item = new Dimension();

                item.Nombre = dimension.ToString();

                resultado.Add(item);
            }

            return resultado;
        }

        public List<EmpresaTransporte> ObtenerEmpresas()
        {
            List<EmpresaTransporte> resultado = new List<EmpresaTransporte>();

            foreach (EmpresaTransporteEntidad entidad in EmpresaTransporteAlmacen.empresas)
            {
                EmpresaTransporte empresa = new EmpresaTransporte();

                empresa.Id = entidad.IdEmpresa;
                empresa.Nombre = entidad.NombreEmpresa;

                resultado.Add(empresa);
            }

            return resultado;
        }

        public List<Servicio> ObtenerServicios(int idEmpresa, int idCDDestino)
        {
            List<Servicio> resultado = new List<Servicio>();

            foreach (ServicioEntidad entidad in ServiciosAlmacen.servicio)
            {
                if (entidad.IdEmpresa != idEmpresa)
                {
                    continue;
                }

                if (entidad.IdCDOrigen != idCDActual)
                {
                    continue;
                }

                if (entidad.IdCDDestino != idCDDestino)
                {
                    continue;
                }

                // SOLO SERVICIOS PENDIENTES
                if (entidad.EstadoServicio != EstadoServicioEnum.Pendiente)
                {
                    continue;
                }

                // NO MOSTRAR SERVICIOS COMPLETOS
                if (entidad.Completo)
                {
                    continue;
                }

                if (entidad.FechaSalida.Date < DateTime.Today)
                {
                    continue;
                }

                Servicio servicio = new Servicio();

                servicio.Id = entidad.IdServicio;

                servicio.Descripcion =
                    entidad.NombreServicio + " - " +
                    entidad.FechaSalida.ToString("dd/MM/yyyy HH:mm") + " - " +
                    entidad.FechaLlegada.ToString("dd/MM/yyyy HH:mm");

                resultado.Add(servicio);
            }

            return resultado;
        }

        public List<Guia> BuscarGuias(string cuit, string localidad, string dimension)
        {
            List<Guia> resultado = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                //Valido que la gua no este asignada a otra hoja de ruta
                bool guiaYaAsignada = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Any(h => h.Guias.Contains(guiaEntidad.NumeroGuia));

                if (guiaYaAsignada)
                {
                    continue;
                }

                bool mostrarGuia = false;

                if (guiaEntidad.EstadoActual == EstadoGuiaEnum.Admitida)
                {
                    if (guiaEntidad.IdCDOrigen == Program.IdCDActual)
                    {
                        mostrarGuia = true;
                    }
                }

                if (guiaEntidad.EstadoActual == EstadoGuiaEnum.EnDestino)
                {
                    HojaRutaDeTransporteEntidad ultimaHDR =
                        HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte
                        .Where(h => h.Guias.Contains(guiaEntidad.NumeroGuia))
                        .OrderByDescending(h => h.NumeroHDRTransporte)
                        .FirstOrDefault();

                    if (ultimaHDR != null)
                    {
                        ServicioEntidad servicio = ServiciosAlmacen.servicio.FirstOrDefault(s => s.IdServicio == ultimaHDR.IdServicio);

                        if (servicio != null)
                        {
                            if (servicio.IdCDDestino == Program.IdCDActual)
                            {
                                mostrarGuia = true;
                            }
                        }
                    }
                }

                if (!mostrarGuia)
                {
                    continue;
                }

                ClienteEntidad cliente =ClientesAlmacen.clientes.FirstOrDefault(c => c.CuitCliente == guiaEntidad.CuitCliente);

                if (cliente == null)
                {
                    continue;
                }

                CentroDistribucion cdDestino = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(cd => cd.IdCD == guiaEntidad.IdCDDestino);

                if (cdDestino == null)
                {
                    continue;
                }

                tutasa.Almacenes.Localidad localidadDestino = LocalidadAlmacen.localidades.FirstOrDefault(l => l.IdLocalidad == cdDestino.IdLocalidad);

                string nombreLocalidad = "";

                if (localidadDestino != null)
                {
                    nombreLocalidad = localidadDestino.NombreLocalidad;
                }

                if (!string.IsNullOrEmpty(cuit))
                {
                    if (cliente.CuitCliente.ToString() != cuit)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(localidad))
                {
                    if (nombreLocalidad != localidad)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(dimension))
                {
                    if (guiaEntidad.Dimension.ToString() != dimension)
                    {
                        continue;
                    }
                }

                Guia guia = new Guia();

                guia.Numero = guiaEntidad.NumeroGuia;
                guia.Localidad = nombreLocalidad;
                guia.Direccion = guiaEntidad.CalleDestino + " " + guiaEntidad.AlturaDestino;
                guia.Dimension = guiaEntidad.Dimension.ToString();
                guia.Cliente = cliente.Nombre + " " + cliente.Apellido;
                guia.Cuit = cliente.CuitCliente.ToString();
                guia.CdDestino = cdDestino.NombreCD;

                resultado.Add(guia);
            }

            return resultado;
        }

        // CONFIRMACION
        public int GuardarHojaRuta(HojaRutaTransporte hojaRuta)
        {
            ServicioEntidad servicioSeleccionado = ServiciosAlmacen.servicio.FirstOrDefault(s => s.IdServicio == hojaRuta.IdServicio);

            if (servicioSeleccionado == null)
            {
                return 0;
            }

            // VALIDAR SI EL SERVICIO YA ESTA COMPLETO

            if (servicioSeleccionado.Completo)
            {
                return -1;
            }

            // VALIDACION CAPACIDAD

            decimal capacidadMaxima = ObtenerCapacidadServicio(servicioSeleccionado);

            decimal ocupacionActual = 0;

            List<HojaRutaDeTransporteEntidad> hdrsServicio =
                HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte
                .Where(h => h.IdServicio == servicioSeleccionado.IdServicio)
                .ToList();

            foreach (HojaRutaDeTransporteEntidad hdrExistente in hdrsServicio)
            {
                foreach (int numeroGuia in hdrExistente.Guias)
                {
                    GuiaEntidad guiaExistente = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                    if (guiaExistente != null)
                    {
                        ocupacionActual += ObtenerEquivalenteXL(guiaExistente.Dimension);
                    }
                }
            }

            decimal ocupacionNueva = 0;

            foreach (Guia guiaPantalla in hojaRuta.Guias)
            {
                bool guiaYaAsignada = hdrsServicio.Any(h => h.Guias.Contains(guiaPantalla.Numero));

                if (guiaYaAsignada)
                {
                    continue;
                }

                GuiaEntidad guiaEntidad = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == guiaPantalla.Numero);

                if (guiaEntidad != null)
                {
                    ocupacionNueva += ObtenerEquivalenteXL(guiaEntidad.Dimension);
                }
            }

            // VALIDAR CAPACIDAD

            if (ocupacionActual + ocupacionNueva > capacidadMaxima)
            {
                return -2;
            }

            // CREACION HDR
            HojaRutaDeTransporteEntidad hdr = new HojaRutaDeTransporteEntidad();

            hdr.NumeroHDRTransporte = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Count + 1;

            hdr.IdServicio = servicioSeleccionado.IdServicio;

            hdr.EstadoHDR = EstadoHDRTransporteEnum.Asignada;

            foreach (Guia guiaPantalla in hojaRuta.Guias)
            {
                int numeroGuia = guiaPantalla.Numero;

                bool guiaYaAsignada = hdrsServicio.Any(h => h.Guias.Contains(numeroGuia));

                if (guiaYaAsignada)
                {
                    continue;
                }

                hdr.Guias.Add(numeroGuia);

                GuiaEntidad guiaEntidad = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                if (guiaEntidad != null)
                {
                    guiaEntidad.EstadoActual = EstadoGuiaEnum.PlanificadaTransporte;

                    guiaEntidad.Historial.Add(
                        new MovimientoEstadoDto
                        {
                            FechaHora = DateTime.Now,

                            Estado =
                                EstadoGuiaEnum.PlanificadaTransporte,

                            Ubicacion =
                                ObtenerCDActual(Program.IdCDActual)
                        });
                }
            }

            // VALIDAR HDR VACIA

            if (hdr.Guias.Count == 0)
            {
                return -3;
            }

            // ACTUALIZAR SERVICIO COMPLETO = TRUE
            decimal ocupacionFinal = ocupacionActual + ocupacionNueva;

            servicioSeleccionado.Completo = ocupacionFinal >= capacidadMaxima;

            HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Add(hdr);

            //GuiaAlmacen.Guardar();
            //ServiciosAlmacen.Guardar();
            //HojasDeRutaTransporteAlmacen.Guardar();

            return hdr.NumeroHDRTransporte;
        }

        // CAPACIDAD POR TIPO SERVICIO
        private decimal ObtenerCapacidadServicio(ServicioEntidad servicio)
        {
            switch (servicio.TipoServicio)
            {
                case TipoServicioEnum.A:
                    return 20m;

                case TipoServicioEnum.B:
                    return 10m;

                case TipoServicioEnum.C:
                    return 7m;

                case TipoServicioEnum.D:
                    return 3m;

                default:
                    return 0m;
            }
        }

        // EQUIVALENCIA DIMENSIONES
        private decimal ObtenerEquivalenteXL(
            tutasa.Almacenes.DimensionEnum dimension)
        {
            switch (dimension)
            {
                case tutasa.Almacenes.DimensionEnum.S:
                    return 0.25m;

                case tutasa.Almacenes.DimensionEnum.M:
                    return 0.50m;

                case tutasa.Almacenes.DimensionEnum.L:
                    return 0.75m;

                case tutasa.Almacenes.DimensionEnum.XL:
                    return 1m;

                default:
                    return 1m;
            }
        }

        public string ObtenerCDActual(int IdCdActual)
        {
            CentroDistribucion cd = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == IdCdActual);

            return cd != null
                ? cd.NombreCD
                : "Desconocido";
        }
    }
}


/*
namespace tutasa.RuteoTransporte
{
    internal partial class FormRuteoTransporteModelo
    {
        private int idCDActual = Program.IdCDActual;
        // COMBOS

        public List<CD> ObtenerCDs()
        {
            List<CD> resultado = new List<CD>();

            foreach (tutasa.Almacenes.CentroDistribucion entidad in CentroDistribucionAlmacen.CentrosDistribucion)
            {
                CD cd = new CD();

                cd.Id = entidad.IdCD;
                cd.Nombre = entidad.NombreCD;

                resultado.Add(cd);
            }

            return resultado;
        }

        public List<Localidad> ObtenerLocalidades()
        {
            List<Localidad> resultado = new List<Localidad>();

            foreach (tutasa.Almacenes.Localidad entidad
                in LocalidadAlmacen.localidades)
            {
                Localidad localidad = new Localidad();

                localidad.Id = entidad.IdLocalidad;
                localidad.Nombre = entidad.NombreLocalidad;

                resultado.Add(localidad);
            }

            return resultado;
        }

        public List<Dimension> ObtenerDimensiones()
        {
            List<Dimension> resultado = new List<Dimension>();

            foreach (tutasa.Almacenes.DimensionEnum dimension in Enum.GetValues(typeof(tutasa.Almacenes.DimensionEnum)))
            {
                Dimension item = new Dimension();

                item.Nombre = dimension.ToString();

                resultado.Add(item);
            }

            return resultado;
        }

        public List<EmpresaTransporte> ObtenerEmpresas()
        {
            List<EmpresaTransporte> resultado = new List<EmpresaTransporte>();

            foreach (EmpresaTransporteEntidad entidad in EmpresaTransporteAlmacen.empresas)
            {
                EmpresaTransporte empresa = new EmpresaTransporte();

                empresa.Id = entidad.IdEmpresa;

                empresa.Nombre = entidad.NombreEmpresa;

                resultado.Add(empresa);
            }

            return resultado;

        }

        public List<Servicio> ObtenerServicios(int idEmpresa, int idCDDestino)
        {
            List<Servicio> resultado =
            new List<Servicio>();

            foreach (ServicioEntidad entidad in ServiciosAlmacen.servicio)
            {
                if (entidad.IdEmpresa != idEmpresa)
                {
                    continue;
                }

                if (entidad.IdCDOrigen != idCDActual)
                {
                    continue;
                }

                if (entidad.IdCDDestino != idCDDestino)
                {
                    continue;
                }

                if (entidad.EstadoServicio != EstadoServicioEnum.Pendiente)
                {
                    continue;
                }

                if (entidad.FechaSalida.Date < DateTime.Today)
                {
                    continue;
                }

                Servicio servicio = new Servicio();

                servicio.Id = entidad.IdServicio;

                servicio.Descripcion = entidad.NombreServicio + " - " + entidad.FechaSalida.ToString("dd/MM/yyyy HH:mm") + " - " + entidad.FechaLlegada.ToString("dd/MM/yyyy HH:mm");

                resultado.Add(servicio);
            }

            return resultado;

        }

        // BUSQUEDA

        public List<Guia> BuscarGuias(string cuit, string localidad, string dimension)
        {
            List<Guia> resultado = new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {

                bool mostrarGuia = false;


                if (guiaEntidad.EstadoActual== EstadoGuiaEnum.Admitida)
                {
                    if (guiaEntidad.IdCDOrigen== Program.IdCDActual)
                    {
                        mostrarGuia = true;
                    }
                }


                if (guiaEntidad.EstadoActual== EstadoGuiaEnum.EnDestino)
                {
                    HojaRutaDeTransporteEntidad ultimaHDR = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Where
                        (h => h.Guias.Contains(guiaEntidad.NumeroGuia)).OrderByDescending(h =>h.NumeroHDRTransporte).FirstOrDefault();

                    if (ultimaHDR != null)
                    {
                        ServicioEntidad servicio =ServiciosAlmacen.servicio.FirstOrDefault(s =>s.IdServicio ==ultimaHDR.IdServicio);

                        if (servicio != null)
                        {
                            if (servicio.IdCDDestino== Program.IdCDActual)
                            {
                                mostrarGuia = true;
                            }
                        }
                    }
                }

                if (!mostrarGuia)
                {
                    continue;
                }

                ClienteEntidad cliente = ClientesAlmacen.clientes.FirstOrDefault(c => c.CuitCliente == guiaEntidad.CuitCliente);

                if (cliente == null)
                {
                    continue;
                }

                CentroDistribucion cdDestino = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(cd => cd.IdCD == guiaEntidad.IdCDDestino);

                if (cdDestino == null)
                {
                    continue;
                }

                Almacenes.Localidad localidadDestino = LocalidadAlmacen.localidades.FirstOrDefault(l => l.IdLocalidad == cdDestino.IdLocalidad);

                string nombreLocalidad = "";

                if (localidadDestino != null)
                {
                    nombreLocalidad = localidadDestino.NombreLocalidad;
                }

                if (!string.IsNullOrEmpty(cuit))
                {
                    if (cliente.CuitCliente.ToString() != cuit)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(localidad))
                {
                    if (nombreLocalidad != localidad)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(dimension))
                {
                    if (guiaEntidad.Dimension.ToString() != dimension)
                    {
                        continue;
                    }
                }

                Guia guia = new Guia();

                guia.Numero = guiaEntidad.NumeroGuia;

                guia.Localidad = nombreLocalidad;

                guia.Direccion = guiaEntidad.CalleDestino + " " + guiaEntidad.AlturaDestino;

                guia.Dimension = guiaEntidad.Dimension.ToString();

                guia.Cliente = cliente.Nombre + " " + cliente.Apellido;

                guia.Cuit = cliente.CuitCliente.ToString();

                guia.CdDestino = cdDestino.NombreCD;

                resultado.Add(guia);
            }

            return resultado;

        }

        // CONFIRMACION

        public int GuardarHojaRuta(HojaRutaTransporte hojaRuta)
        {
            ServicioEntidad servicioSeleccionado = ServiciosAlmacen.servicio.FirstOrDefault(s => s.IdServicio ==hojaRuta.IdServicio);

            if (servicioSeleccionado == null)
            {
                return 0;
            }

            HojaRutaDeTransporteEntidad hdr = new HojaRutaDeTransporteEntidad();

            hdr.NumeroHDRTransporte = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Count + 1;

            hdr.IdServicio = servicioSeleccionado.IdServicio;

            hdr.EstadoHDR = EstadoHDRTransporteEnum.Asignada;

            foreach (Guia guiaPantalla in hojaRuta.Guias)
            {
                int numeroGuia = guiaPantalla.Numero;

                hdr.Guias.Add(numeroGuia);

                GuiaEntidad guiaEntidad = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                if (guiaEntidad != null)
                {
                    guiaEntidad.EstadoActual = EstadoGuiaEnum.PlanificadaTransporte;

                    
                    guiaEntidad.Historial.Add(new MovimientoEstadoDto
                        {
                            FechaHora = DateTime.Now,

                            Estado = EstadoGuiaEnum.PlanificadaTransporte,

                            Ubicacion = ObtenerCDActual(Program.IdCDActual)
                    });
                }
            }

            servicioSeleccionado.EstadoServicio = EstadoServicioEnum.ConAsignacion;

            HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte.Add(hdr);

            //GuiaAlmacen.Guardar();
            //ServiciosAlmacen.Guardar();
            //HojasDeRutaTransporteAlmacen.Guardar();

            return hdr.NumeroHDRTransporte;
        }
        public string ObtenerCDActual(int IdCdActual)
        {
            CentroDistribucion cd = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == IdCdActual);
            return cd != null ? cd.NombreCD : "Desconocido";

        }

    }

}*/
