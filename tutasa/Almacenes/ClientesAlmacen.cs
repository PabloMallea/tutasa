using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal static class ClientesAlmacen
    {// acá ver si es public o private la siguiente fila

        public static List<ClienteEntidad> clientes = new();
        static ClientesAlmacen()
        {


            //Acá cargamos los clientes con un archivo txt.
            if (File.Exists(@"..\..\..\Datos\Clientes.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\Clientes.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"..\..\..\Datos\Clientes.json", json);
        }
    }
} 
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal static class ClientesAlmacen
    {
        public static List<ClienteEntidad> clientes = new();

        static ClientesAlmacen()
        {
            string ruta =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\Datos\Clientes.json");

            ruta =
                Path.GetFullPath(ruta);

            if (File.Exists(ruta))
            {
                string json =
                    File.ReadAllText(ruta);

                clientes =
                    JsonSerializer.Deserialize<
                        List<ClienteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string ruta =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\Datos\Clientes.json");

            ruta =
                Path.GetFullPath(ruta);

            string json =
                JsonSerializer.Serialize(
                    clientes);

            File.WriteAllText(
                ruta,
                json);
        }
    }
}
*/