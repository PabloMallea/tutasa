using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class GuiaAlmacen
    {
        public static List<GuiaEntidad> guias = new();
        static GuiaAlmacen()
        {
            
            if (File.Exists(@"..\..\..\Datos\Guias.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\Guias.json");
                guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(guias);
            File.WriteAllText(@"..\..\..\Datos\Guias.json", json);
        }
    }
}
