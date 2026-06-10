using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal static class HojasDeRutaTransporteAlmacen
    {

        public static List<HojaRutaDeTransporteEntidad> HojaDeRutaTransporte = new();
        static HojasDeRutaTransporteAlmacen()
        {
            
            if (File.Exists(@"..\..\..\Datos\HojasDeRutaTransporte.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\HojasDeRutaTransporte.json");
                HojaDeRutaTransporte = JsonSerializer.Deserialize<List<HojaRutaDeTransporteEntidad>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(HojaDeRutaTransporte);
            File.WriteAllText(@"..\..\..\Datos\HojasDeRutaTransporte.json", json);
        }
    }
}
