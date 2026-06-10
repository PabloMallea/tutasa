using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class FleteroAlmacen
    {
        public static List<Fletero> fleteros = new();
        static FleteroAlmacen()
        {

            if (File.Exists(@"Datos\Fletero.json"))
            {
                string json = File.ReadAllText(@"Datos\Fletero.json");
                fleteros = JsonSerializer.Deserialize<List<Fletero>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(FleteroAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(fleteros);
            File.WriteAllText(@"Datos\Fletero.json", json);
        }
    }
}
