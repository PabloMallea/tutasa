using System.Text.Json;

namespace tutasa.Almacenes
{
    internal static class HojasDeRutaTransporteAlmacen
    {

        public static List<HojaRutaDeTransporteEntidad> HojasDeRutaTransporte = new();
        static HojasDeRutaTransporteAlmacen()
        {
            if (File.Exists(@"Datos\HojasDeRutaTransporte.json"))
            {
                string json = File.ReadAllText(@"Datos\HojasDeRutaTransporte.json");
                HojasDeRutaTransporte = JsonSerializer.Deserialize<List<HojaRutaDeTransporteEntidad>>(json, Program.jsonOptions);
            }
            else
            {
                throw new ApplicationException($"No se encontro el almacen {nameof(HojasDeRutaTransporteAlmacen)}");
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(HojasDeRutaTransporte, Program.jsonOptions);
            File.WriteAllText(@"Datos\HojasDeRutaTransporte.json", json);
        }
    }
}
