using System.Text.Json;

namespace tutasa.Almacenes
{

    internal static class HojaDeRutaUltimaMillaAlmacen
    {
        public static List<HojaDeRutaUltimaMilla> HojaDeRutaUltimaMilla = new();

        static HojaDeRutaUltimaMillaAlmacen()
        {
            if (File.Exists(@"Datos\HojaDeRutaUltimaMilla.json"))
            {
                string json = File.ReadAllText(@"Datos\HojaDeRutaUltimaMilla.json");
                HojaDeRutaUltimaMilla = JsonSerializer.Deserialize<List<HojaDeRutaUltimaMilla>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(HojaDeRutaUltimaMillaAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(HojaDeRutaUltimaMilla, Program.jsonOptions);
            File.WriteAllText(@"Datos\HojaDeRutaUltimaMilla.json", json);
        }
    }

}
