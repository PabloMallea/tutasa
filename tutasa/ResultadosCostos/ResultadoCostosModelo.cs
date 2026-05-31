using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

            //DateTime FechaAlta { get; set; }

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
                //    FechaAlta = new DateTime(2025, 5, 1),
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

        //Clase empresa transporte
        //Lista de empresa transporte
        //Obtener empresas transporte

        public class EmpresaTransporte
        {
            public string Nombre { get; set; }
            public decimal CostoMensual { get; set; }
        }

        private List<EmpresaTransporte> empresasTransporte = new List<EmpresaTransporte>

         {
              new EmpresaTransporte { Nombre = "Via Cargo", CostoMensual = 10000 },
              new EmpresaTransporte { Nombre = "Chevallier", CostoMensual = 20000 },
              new EmpresaTransporte { Nombre = "Flechabus", CostoMensual = 15000 }
         };


        public List<string> ObtenerEmpresasTransporte()
        {
            List<string> nombresEmpresas = new List<string>();
            foreach (EmpresaTransporte empresa in empresasTransporte)
            {
                nombresEmpresas.Add(empresa.Nombre);
            }
            return nombresEmpresas.ToList();
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


        public decimal ObtenerCostoMensual(string empresa)
        {
            var empresaTransporte = empresasTransporte.FirstOrDefault(e => e.Nombre == empresa);
            if (empresaTransporte != null)
            {
                return empresaTransporte.CostoMensual;
            }
            return 0;
        }

    }
}

