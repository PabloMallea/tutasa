 using System.Text.Json;

namespace tutasa.Almacenes
{
    internal static class ClientesAlmacen
    {
        public static List<ClienteEntidad> clientes = new();

        static ClientesAlmacen()
        {
            //Acá cargamos los clientes con un archivo txt.
            if (File.Exists(@"Datos\Clientes.json"))
            {
                string json = File.ReadAllText(@"Datos\Clientes.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(ClientesAlmacen)}");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes, Program.jsonOptions);
            File.WriteAllText(@"Datos\Clientes.json", json);
        }
    }
}