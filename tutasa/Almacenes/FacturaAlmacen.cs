using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class FacturaAlmacen
    {
        public static List<FacturaEntidad> facturas = new();
        static FacturaAlmacen()
        {

            if (File.Exists(@"Datos\Facturas.json"))
            {
                string json = File.ReadAllText(@"Datos\Facturas.json");
                facturas = JsonSerializer.Deserialize<List<FacturaEntidad>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(FacturaAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(facturas);
            File.WriteAllText(@"Datos\Facturas.json", json);
        }
    }
}
