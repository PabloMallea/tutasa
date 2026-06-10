using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tutasa.Almacenes
{
    internal class EmpresaTransporteAlmacen
    {
        public static List<EmpresaTransporteEntidad> empresas = new();
        static EmpresaTransporteAlmacen()
        {
            
            if (File.Exists(@"..\..\..\Datos\EmpresasTransporte.json"))
            {
                string json = File.ReadAllText(@"..\..\..\Datos\EmpresasTransporte.json");
                empresas = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json);
            }
        }
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(empresas);
            File.WriteAllText(@"..\..\..\Datos\EmpresasTransporte.json", json);
        }
    }
}
