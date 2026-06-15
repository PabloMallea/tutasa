
using tutasa.Almacenes;

namespace tutasa.ResultadosCostos
{
    internal class ResultadoCostosModelo
    {
        public List<string> ObtenerEmpresasTransporte()
        {
            return EmpresaTransporteAlmacen.empresas
                .Select(e => e.NombreEmpresa)
                .ToList();
        }

        public List<Guia> ObtenerGuias(string nombreEmpresa, int mes, int anio)
        {
            var empresa = EmpresaTransporteAlmacen.empresas
                .FirstOrDefault(e => e.NombreEmpresa == nombreEmpresa);

            if (empresa == null)
            {
                return new List<Guia>();
            }

            var serviciosDelPeriodo = ServiciosAlmacen.servicio
                .Where(s => s.IdEmpresa == empresa.IdEmpresa
                            && s.FechaSalida.Month == mes
                            && s.FechaSalida.Year == anio)
                .Select(s => s.IdServicio)
                .ToList();

            if (!serviciosDelPeriodo.Any())
            {
                return new List<Guia>();
            }

            var hdrsDelPeriodo = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte
                .Where(hdr => serviciosDelPeriodo.Contains(hdr.IdServicio))
                .ToList();

            var numerosGuia = hdrsDelPeriodo
                .SelectMany(hdr => hdr.Guias)
                .Distinct()
                .ToList();

            if (!numerosGuia.Any())
            {
                return new List<Guia>();
            }

            var guiasCompletas = GuiaAlmacen.guias
                .Where(g => numerosGuia.Contains(g.NumeroGuia)
                            && g.EstadoActual.ToString() == "Facturada")
                .ToList();

            var guiasResultado = guiasCompletas
                .Select(g => new Guia
                {
                    NumeroGuia = g.NumeroGuia,
                    Dimension = g.Dimension.ToString(),
                    ImporteGuia = g.MontoFacturar
                })
                .ToList();

            return guiasResultado;
        }

        public decimal ObtenerCostoMensual(string nombreEmpresa)
        {
            var empresa = EmpresaTransporteAlmacen.empresas
                .FirstOrDefault(e => e.NombreEmpresa == nombreEmpresa);

            return empresa?.TarifaMensual ?? 0;
        }
    }
}

