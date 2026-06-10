using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    public class LocalidadAlmacen
    {
        public static List<Localidad> localidades = new();
        static LocalidadAlmacen()
        {
            
            if (File.Exists(@"..\..\..\Datos\Localidades.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\Localidades.json");
                localidades = JsonSerializer.Deserialize<List<Localidad>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(localidades);
            File.WriteAllText(@"..\..\..\Datos\Localidades.json", json);
        }
    }
}
