using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class ServiciosAlmacen
    {
        public static List<ServicioEntidad> servicio = new();
        static ServiciosAlmacen()
        {

            if (File.Exists(@"Datos\Servicios.json"))
            {
                string json = File.ReadAllText(@"Datos\Servicios.json");
                servicio = JsonSerializer.Deserialize<List<ServicioEntidad>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(ServiciosAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(servicio, Program.jsonOptions);
            File.WriteAllText(@"Datos\Servicios.json", json);
        }
    }
}
