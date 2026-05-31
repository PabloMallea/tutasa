using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.ImposicionCallCenter
{
    internal partial class ImposicionCallCenterModelo
    {

        private List<Agencia> agencias = new List<Agencia>
        {
            new Agencia
            {
                Nombre = "Agencia San Rafael - Centro",
                Calle = "Calle Falsa",
                Altura = 37,
                Localidad = "San Rafael",
            }
        };

        private List <CentroDistribucion> centrosdistrucion = new List <CentroDistribucion>
        {
            new CentroDistribucion
            {
                Nombre = "CD  San Rafael - Centro",
                Calle = "Calle Re Falsa",
                Altura = 38,
                Localidad = "San Rafael",
            }
        };

        //Clientes de ejemplo

        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente
            {
                Cuit = "20333444556",
                Nombre = "Juan",
                Apellido = "Perez",
                Telefono = "1122334455",
                Calle = "Calle Falsa",
                Altura = "123",
                Localidad = "Tandil"
            },

            new Cliente
            {
                Cuit = "30777888999",
                Nombre = "Maria",
                Apellido = "Lopez",
                Telefono = "1166677788",
                Calle = "San Martin",
                Altura = "456",
                Localidad = "Villa Carlos Paz"
            }
        };

        private List<Localidad> localidades = new List<Localidad>
        {
            new Localidad
            {
                Nombre = "San Rafael",
            },

            new Localidad
            {
                Nombre = "Mar del Plata",
            }
        };

        // Acá hice un método para obtener las dimensiones creando la lista directamente,
        // ya que no se especificó una clase para eso, y es un dato fijo.

        public List<string> ObtenerDimensiones()
        {
            return new List<string>
            {
                "S",
                "M",
                "L",
                "XL"
            };
        }

        // Lista donde se almacenan las encomiendas generadas

        private List<Encomienda> encomiendas = new List<Encomienda>();

        public Cliente BuscarCliente(string cuit)
        {
            // Recorrer lista de clientes
            foreach (Cliente cliente in clientes)
            {
                // Si el CUIT coincide, retornar cliente encontrado
                if (cliente.Cuit == cuit)
                {
                    return cliente;
                }
            }

            // Si no se encontró coincidencia, retornar null
            return null;
        }

        public Localidad BuscarLocalidad(string nombre)
        {
            // Recorrer lista de localidades
            foreach (Localidad localidad in localidades)
            {
                // Si coincide nombre, retornar localidad
                if (localidad.Nombre == nombre)
                {
                    return localidad;
                }
            }

            // Si no se encontró coincidencia
            return null;
        }

        // Método para devolver Agencias
        public List <Agencia> ObtenerAgencias(string localidad)
        {
            List<Agencia> resultado = new List<Agencia>();
            foreach (Agencia agencia in agencias)
            {
                if (agencia.Localidad == localidad)
                {
                    resultado.Add (agencia);
                }
            }
            return resultado;
        }

        // Método para devolver CD
        public List<CentroDistribucion> ObtenerCD(string localidad)
        {
            List<CentroDistribucion> resultado = new List<CentroDistribucion>();
            foreach (CentroDistribucion CD in centrosdistrucion)
            {
                if (CD.Localidad == localidad)
                {
                    resultado.Add(CD);
                }
            }
            return resultado;
        }

        // Guardar encomienda generada
        public void GuardarEncomienda(Encomienda encomienda)
        {
            //Por el momento no me preocupo de esto

            // 1. Asignamos el estado inicial que pide el caso de uso
            // encomienda.Estado = "Impuesta";
            // 2. Generamos el tracking correlativo. Contamos cuántas hay en la lista y le sumamos 1.
            // int numeroCorrelativo = encomiendas.Count + 1;
            // Decimos que va a ser impuesta en CD porque el fletero lo lleva a alguno -> ¿¿¿¿¿¿¿¿¿¿¿No va así!!!!!!¿?
            // encomienda.Tracking = "CD - " + numeroCorrelativo.ToString();
            
            // 3. Finalmente, la guardamos en la lista
            encomiendas.Add(encomienda);
        }
    }
}