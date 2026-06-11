using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class EmpresaTransporteAlmacen
    {
        public static List<EmpresaTransporteEntidad> empresas = new();
        static EmpresaTransporteAlmacen()
        {

            if (File.Exists(@"Datos\EmpresasTransporte.json"))
            {
                string json = File.ReadAllText(@"Datos\EmpresasTransporte.json");
                empresas = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(EmpresaTransporteAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(empresas, Program.jsonOptions);
            File.WriteAllText(@"Datos\EmpresasTransporte.json", json);
        }
    }
}
