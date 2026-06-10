using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class AgenciasAlmacen
    {
        public static List<Agencia> agencias = new();
        static AgenciasAlmacen()
        {

            if (File.Exists(@"Datos\Agencias.json"))
            {
                string json = File.ReadAllText(@"Datos\Agencias.json");
                agencias = JsonSerializer.Deserialize<List<Agencia>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(AgenciasAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(agencias);
            File.WriteAllText(@"Datos\Agencias.json", json);
        }
    }
}
