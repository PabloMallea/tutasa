using System.Text.Json;

namespace tutasa.Almacenes
{
    public class TarifasAlmacen
    {
        public static List<FacturaEntidad> Tarifas = new();
        static TarifasAlmacen()
        {
            if (File.Exists(@"Datos\Tarifas.json"))
            {
                string json = File.ReadAllText(@"Datos\Tarifas.json");
                Tarifas = JsonSerializer.Deserialize<List<FacturaEntidad>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(TarifasAlmacen)}");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(Tarifas);
            File.WriteAllText(@"Datos\Tarifas.json", json);
        }
    }
}
