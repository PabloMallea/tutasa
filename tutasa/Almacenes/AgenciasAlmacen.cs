using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class AgenciasAlmacen
    {
        public static List<Agencia> agencias = new();
        static AgenciasAlmacen()
        {

            if (File.Exists(@"..\..\..\Datos\Agencias.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\Agencias.json");
                agencias = JsonSerializer.Deserialize<List<Agencia>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(agencias);
            File.WriteAllText(@"..\..\..\Datos\Agencias.json", json);
        }
    }
}
