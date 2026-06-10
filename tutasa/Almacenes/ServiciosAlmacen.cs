using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class ServiciosAlmacen
    {
        public static List<Servicio> servicio = new();
        static ServiciosAlmacen()
        {
            
            if (File.Exists(@"..\..\..\Datos\Servicios.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\Servicios.json");
                servicio = JsonSerializer.Deserialize<List<Servicio>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(servicio);
            File.WriteAllText(@"..\..\..\Datos\Servicios.json", json);
        }
    }
}
