using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucion> CentrosDistribucion = new();
        static CentroDistribucionAlmacen()
        {
            //Acá cargamos los clientes con un archivo txt.
            if (File.Exists(@"..\..\..\Datos\CentrosDistribucion.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\CentrosDistribucion.json");
                CentrosDistribucion = JsonSerializer.Deserialize<List<CentroDistribucion>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(CentrosDistribucion);
            File.WriteAllText(@"..\..\..\Datos\CentrosDistribucion.json", json);
        }
    }
}
