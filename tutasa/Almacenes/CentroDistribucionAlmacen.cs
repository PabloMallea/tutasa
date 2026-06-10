using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucion> CentrosDistribucion = new();
        static CentroDistribucionAlmacen()
        {
            //Acá cargamos los clientes con un archivo txt.
            if (File.Exists(@"Datos\CentrosDistribucion.json"))
            {
                string json = File.ReadAllText(@"Datos\CentrosDistribucion.json");
                CentrosDistribucion = JsonSerializer.Deserialize<List<CentroDistribucion>>(json);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(CentroDistribucionAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(CentrosDistribucion);
            File.WriteAllText(@"Datos\CentrosDistribucion.json", json);
        }
    }
}
