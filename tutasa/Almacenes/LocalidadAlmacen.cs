using System.Text.Json;

namespace tutasa.Almacenes
{
    public class LocalidadAlmacen
    {
        public static List<Localidad> localidades = new();
        static LocalidadAlmacen()
        {

            if (File.Exists(@"Datos\Localidades.json"))
            {
                string json = File.ReadAllText(@"Datos\Localidades.json");
                localidades = JsonSerializer.Deserialize<List<Localidad>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(LocalidadAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(localidades);
            File.WriteAllText(@"Datos\Localidades.json", json);
        }
    }
}
