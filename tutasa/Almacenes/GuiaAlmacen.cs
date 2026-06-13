using System.Text.Json;
using System.IO;

namespace tutasa.Almacenes
{
    internal class GuiaAlmacen
    {
        public static List<GuiaEntidad> guias = new();
        static GuiaAlmacen()
        {

            if (File.Exists(@"Datos\Guias.json"))
            {
                string json = File.ReadAllText(@"Datos\Guias.json");
                guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(GuiaAlmacen)}");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(guias, Program.jsonOptions);
            File.WriteAllText(@"Datos\Guias.json", json);
        }
    }
}
