using System.Text.Json;
using System.Text.Json.Serialization;
using tutasa.Almacenes;

namespace tutasa
{
    internal static class Program
    {
        public static JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _ = AgenciasAlmacen.agencias;
            _ = CentroDistribucionAlmacen.CentrosDistribucion;
            _ = ClientesAlmacen.clientes;
            _ = ComisionesAlmacen.comisiones;
            _ = EmpresaTransporteAlmacen.empresas;
            _ = FacturaAlmacen.facturas;
            _ = GuiaAlmacen.guias;
            _ = HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla;
            _ = HojasDeRutaTransporteAlmacen.HojasDeRutaTransporte;
            _ = LocalidadAlmacen.localidades;
            _ = ServiciosAlmacen.servicio;
            _ = FleteroAlmacen.fleteros;

            ApplicationConfiguration.Initialize();
            //Aca se instancia el formulario correspondiente y se lo establece como formulario principal de ejecuci�n de la aplicaci�n.
            Application.Run(new tutasa.RendicionHDRultimaMilla.RendicionHDRultimaMilla());

            AgenciasAlmacen.Guardar();
            CentroDistribucionAlmacen.Guardar();
            ClientesAlmacen.Guardar();
            ComisionesAlmacen.Guardar();
            EmpresaTransporteAlmacen.Guardar();
            FacturaAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            HojaDeRutaUltimaMillaAlmacen.Guardar();
            HojasDeRutaTransporteAlmacen.Guardar();
            LocalidadAlmacen.Guardar();
            ServiciosAlmacen.Guardar();
            FleteroAlmacen.Guardar();
        }
    }
}
