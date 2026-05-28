using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.ResultadosCostos
{
    internal class ResultadoCostosModelo
    {
        // CLASE GUIA

        public class Guia
        {
            public string NumeroGuia { get; set; }

            public string Tamanio { get; set; }

            public decimal ImporteGuia { get; set; }

            public string EmpresaTransporte { get; set; }

            public int Mes { get; set; }

            public int Anio { get; set; }
        }
        // DATOS MOCK

        private List<Guia> guias =
            new List<Guia>
            {
                new Guia
                {
                    NumeroGuia = "0001",
                    Tamanio = "S",
                    ImporteGuia = 15000,
                    EmpresaTransporte = "Via Cargo",
                    Mes = 5,
                    Anio = 2025
                },

                new Guia
                {
                    NumeroGuia = "0002",
                    Tamanio = "M",
                    ImporteGuia = 30000,
                    EmpresaTransporte = "Via Cargo",
                    Mes = 5,
                    Anio = 2025
                },

                new Guia
                {
                    NumeroGuia = "0003",
                    Tamanio = "XL",
                    ImporteGuia = 45000,
                    EmpresaTransporte = "Chevallier",
                    Mes = 5,
                    Anio = 2025
                }
            };

       
        // EMPRESAS
        

        public List<string> ObtenerEmpresasTransporte()
        {
            return new List<string>
            {
                "Via Cargo",
                "Chevallier",
                "Flechabus"
            };
        }

       
        // BUSCAR GUIAS
        

        public List<Guia> ObtenerGuias(
            string empresa,
            int mes,
            int anio)
        {
            return guias
                .Where(g =>
                    g.EmpresaTransporte == empresa
                    &&
                    g.Mes == mes
                    &&
                    g.Anio == anio)
                .ToList();
        }

        
        // COSTO MENSUAL
        

        public decimal ObtenerCostoMensual(
            string empresa)
        {
            if (empresa == "Via Cargo")
            {
                return 10000;
            }

            if (empresa == "Chevallier")
            {
                return 20000;
            }

            if (empresa == "Flechabus")
            {
                return 15000;
            }

            return 0;
        }
    }
}
