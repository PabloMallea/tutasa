using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class HojaDeRutaUltimaMillaAlmacen
    {
        internal static class HojasDeRutaTransporteAlmacen
        {

            public static List<HojaDeRutaUltimaMilla> HojaDeRutaUltimaMilla = new();
            static HojasDeRutaTransporteAlmacen()
            {
                
                if (File.Exists(@"..\..\..\Datos\HojaDeRutaUltimaMilla.json"))
                {
                    string json = File.ReadAllText(@"..\..\..\Datos\HojaDeRutaUltimaMilla.json");
                    HojaDeRutaUltimaMilla = JsonSerializer.Deserialize<List<HojaDeRutaUltimaMilla>>(json);
                }
            }
            public static void Guardar()
            {
                string json = JsonSerializer.Serialize(HojaDeRutaUltimaMilla);
                File.WriteAllText(@"..\..\..\Datos\HojaDeRutaUltimaMilla.json", json);
            }
        }
    }
}
