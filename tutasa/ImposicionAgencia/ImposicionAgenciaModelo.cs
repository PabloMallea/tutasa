using System;
using System.Collections.Generic;
using System.Text;

namespace tutasa.Imposicion_Agencia
{
    internal class ImposicionAgenciaModelo
    {
    

        public class Cliente
        {
            public string Cuit { get; set; }

            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public string Telefono { get; set; }
        }

 

        public class Destino
        {
            public string Nombre { get; set; }

            public string Calle { get; set; }

            public string Altura { get; set; }
        }


        public class Localidad
        {
            public string Nombre { get; set; }

            public List<Destino> Destinos { get; set; }
        }

        public class Encomienda
        {
            public Cliente Cliente { get; set; }

            public string LocalidadDestino { get; set; }

            public string Destino { get; set; }

            public string CalleDestino { get; set; }

            public string AlturaDestino { get; set; }

            public string NombreDestinatario { get; set; }

            public string ApellidoDestinatario { get; set; }

            public string DniDestinatario { get; set; }

            public string TelefonoDestinatario { get; set; }

            public string Dimension { get; set; }
        }

   

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
                Nombre = "San Rafael",

                Destinos = new List<Destino>
                {
                    new Destino
                    {
                        Nombre = "Domicilio Destinatario",
                        Calle = "",
                        Altura = ""
                    },

                    new Destino
                    {
                        Nombre = "Agencia San Rafael",
                        Calle = "Av Belgrano",
                        Altura = "123"
                    },

                    new Destino
                    {
                        Nombre = "Centro de Distribución San Rafael",
                        Calle = "Av Pergollini",
                        Altura = "5122"
                    }
                }
            },

            new Localidad
            {
                Nombre = "Mar del Plata",

                Destinos = new List<Destino>
                {
                    new Destino
                    {
                        Nombre = "Domicilio Destinatario",
                        Calle = "",
                        Altura = ""
                    },

                    new Destino
                    {
                        Nombre = "Agencia Mar del Plata",
                        Calle = "Av Colon",
                        Altura = "123"
                    },

                    new Destino
                    {
                        Nombre = "Centro de Distribución Mar del Plata",
                        Calle = "Av Independencia",
                        Altura = "456"
                    }
                }
            }
        };


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
    }
}