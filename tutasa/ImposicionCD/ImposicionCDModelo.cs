using System;
using System.Collections.Generic;

namespace tutasa.Imposicion_CD
{
    internal partial class ImposicionCDModelo
    {

        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente
            {
                Cuit = "20333444556",
                Nombre = "Juan",
                Apellido = "Perez",
                Telefono = "1122334455"
            },
            new Cliente
            {
                Cuit = "30777888999",
                Nombre = "Maria",
                Apellido = "Lopez",
                Telefono = "1166677788"
            }
        };

        private List<Localidad> localidades = new List<Localidad>
        {
            new Localidad
            {
                Nombre = "San Rafael"
            },
            new Localidad
            {
                Nombre = "Mar del Plata"
            }
        };

        private List<Agencia> agencias = new List<Agencia>
        {
            new Agencia
            {
                Nombre = "Agencia San Rafael - Centro",
                Calle = "Av Belgrano",
                Altura = 123,
                Localidad = "San Rafael"
            },
            new Agencia
            {
                Nombre = "Agencia Mar del Plata",
                Calle = "Av Colon",
                Altura = 123,
                Localidad = "Mar del Plata"
            }
        };

        private List<CentroDistribucion> centrosdistrucion = new List<CentroDistribucion>
        {
            new CentroDistribucion
            {
                Nombre = "CD San Rafael - Centro",
                Calle = "Av Pergollini",
                Altura = 5122,
                Localidad = "San Rafael"
            },
            new CentroDistribucion
            {
                Nombre = "CD Mar del Plata",
                Calle = "Av Independencia",
                Altura = 456,
                Localidad = "Mar del Plata"
            }
        };

        private List<Guia> Guias = new List<Guia>();

        public Cliente BuscarCliente(string cuit)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Cuit == cuit) return cliente;
            }
            return null;
        }

        public Localidad BuscarLocalidad(string nombre)
        {
            foreach (Localidad localidad in localidades)
            {
                if (localidad.Nombre == nombre) return localidad;
            }
            return null;
        }

        public List<Agencia> ObtenerAgencias(string localidad)
        {
            List<Agencia> resultado = new List<Agencia>();
            foreach (Agencia agencia in agencias)
            {
                if (agencia.Localidad == localidad) resultado.Add(agencia);
            }
            return resultado;
        }

        public List<CentroDistribucion> ObtenerCD(string localidad)
        {
            List<CentroDistribucion> resultado = new List<CentroDistribucion>();
            foreach (CentroDistribucion CD in centrosdistrucion)
            {
                if (CD.Localidad == localidad) resultado.Add(CD);
            }
            return resultado;
        }

        // Método para calcular la dimensión según el peso
        public string CalcularDimension(decimal peso)
        {
            if (peso <= 2.5m) return "S";
            if (peso <= 5m) return "M";
            if (peso <= 10m) return "L";

            // Si el peso supera los 10kg, retorna XL por defecto (incluso si son más de 20kg)
            return "XL";
        }

        public void GuardarGuia(Guia Guia)
        {
            Guias.Add(Guia);
        }
    }
}