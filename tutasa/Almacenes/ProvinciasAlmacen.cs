using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class ProvinciaAlmacen
    {
        // Usamos la clase Provincia de este mismo namespace, NO la del Modelo
        public static List<Provincia> provincias = new();

        static ProvinciaAlmacen()
        {
            if (File.Exists(@"Datos\Provincias.json"))
            {
                string json = File.ReadAllText(@"Datos\Provincias.json");
                // Deserializamos usando la entidad correcta
                provincias = JsonSerializer.Deserialize<List<Provincia>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(ProvinciaAlmacen)}");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(provincias, Program.jsonOptions);
            File.WriteAllText(@"Datos\Provincias.json", json);
        }
    }
}