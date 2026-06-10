using System.Text.Json;

namespace tutasa.Almacenes
{
    public class ExtrasAlmacen
    {
        public static List<ExtrasEntidad> Extras = new();

        static ExtrasAlmacen()
        {
            //Acá cargamos los clientes con un archivo txt.
            if (File.Exists(@"Datos\Extras.json"))
            {
                string json = File.ReadAllText(@"Datos\Extras.json");
                Extras = JsonSerializer.Deserialize<List<ExtrasEntidad>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(ExtrasAlmacen)}");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(Extras);
            File.WriteAllText(@"Datos\Extras.json", json);
        }
    }
}
