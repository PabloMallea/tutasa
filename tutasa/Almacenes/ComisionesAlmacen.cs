using System.Text.Json;

namespace tutasa.Almacenes
{
    public class ComisionesAlmacen
    {
        public static List<ComisionesEntidad> comisiones = new();

        static ComisionesAlmacen()
        {
            //Acá cargamos los clientes con un archivo txt.
            if (File.Exists(@"Datos\Comisiones.json"))
            {
                string json = File.ReadAllText(@"Datos\Comisiones.json");
                comisiones = JsonSerializer.Deserialize<List<ComisionesEntidad>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(ComisionesAlmacen)}");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(comisiones, Program.jsonOptions);
            File.WriteAllText(@"Datos\Comisiones.json", json);
        }
    }
}
