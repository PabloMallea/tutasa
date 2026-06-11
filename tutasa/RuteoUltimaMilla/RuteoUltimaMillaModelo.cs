/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutasa.RuteoUltimaMilla
{
    internal class RuteoUltimaMillaModelo
    {
        public class Fletero
        {
            public int Id { get; set; }

            public string Nombre { get; set; }
        }

        private List<Fletero> fleteros = new List<Fletero>
{
    new Fletero
    {
        Id = 1,
        Nombre = "Juan Pérez"
    },

    new Fletero
    {
        Id = 2,
        Nombre = "Carlos Gómez"
    },

    new Fletero
    {
        Id = 3,
        Nombre = "María López"
    }
};


        public List<Fletero> ObtenerFleteros()
        {
            return fleteros;
        }



        public class CentroDistribucion
        {
            public int Id { get; set; }

            public string Nombre { get; set; }
        }


        public List<string> ObtenerLocalidades()
        {
            return new List<string>
            {
                "Capital Federal",
                "Buenos Aires",
                "Córdoba"
            };
        }

        // Renombrado de Guia a Guia

        public class Guia
        {
            public string Numero { get; set; }

            public string Cliente { get; set; }

            public string Cuit { get; set; }

            public string Localidad { get; set; }
            public string DireccionOrigen { get; set; }
            public string Direccion { get; set; }

            public string Dimension { get; set; }
        }

        // Nueva clase HojaRuta para representar la salida final del proceso

        public class HojaRuta
        {
            public string Numero { get; set; }

            public string Fletero { get; set; }

            public string TipoRuteo { get; set; }

            public string Direccion { get; set; }

            public List<Guia> Guias { get; set; }
        }

        private List<Guia> Guias = new List<Guia>
        {
            new Guia
            {
                Numero = "0001",
                Cliente = "ACME",
                Cuit = "20333444556",
                Localidad = "Córdoba",
                DireccionOrigen = "Av Rivadavia 1500",
                Direccion = "Av. Siempre Viva 123",
                Dimension = "S"
            },

            new Guia
            {
                Numero = "0002",
                Cliente = "Tech SA",
                Cuit = "30777888999",
                Localidad = "Rosario",
                DireccionOrigen = "Av Rivadavia 1500",
                Direccion = "San Martín 456",
                Dimension = "M"
            },

            new Guia
            {
                Numero = "0003",
                Cliente = "ACME",
                Cuit = "20333444556",
                Localidad = "Córdoba",
                DireccionOrigen = "Av Rivadavia 182",
                Direccion = "Belgrano 789",
                Dimension = "XL"
            },
            new Guia
            {
                Numero = "0004",
                Cliente = "ACME",
                Cuit = "20333444556",
                Localidad = "Córdoba",
                DireccionOrigen = "Av Juan b Justo 1000",
                Direccion = "Belgrano 789",
                Dimension = "XL"
            }
        };

        // Lista donde se almacenan las hojas de ruta generadas

        private List<HojaRuta> hojasRuta =
            new List<HojaRuta>();

        public List<Guia> BuscarGuias(
            string localidad,
            string cuit)
        {
            // Comenzamos tomando todas las Guias disponibles y creamos una variable para ir filtrando
            List<Guia> GuiasFiltradas =
                Guias;

            // Filtrar por localidad si el usuario seleccionó una. El ToList convierte el resultado de la consulta en una nueva lista.
            if (!string.IsNullOrEmpty(localidad))
            {
                GuiasFiltradas =
                    GuiasFiltradas
                    .Where(e => e.Localidad == localidad)
                    .ToList();
            }

            // Filtrar por CUIT si el usuario ingresó uno
            if (!string.IsNullOrEmpty(cuit))
            {
                GuiasFiltradas =
                    GuiasFiltradas
                    .Where(e => e.Cuit == cuit)
                    .ToList();
            }

            // Retornar coincidencias encontradas
            return GuiasFiltradas;
        }

        // Método para guardar hoja de ruta generada

        public void GuardarHojaRuta(HojaRuta hojaRuta)
        {
            hojasRuta.Add(hojaRuta);
        }
        public int ObtenerProximoNumeroHojaRuta()
        {
            return hojasRuta.Count + 1;
        }
    }
}

*/

using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.RuteoUltimaMilla
{
    internal class RuteoUltimaMillaModelo
    {
        #region Clases de pantalla

        public class Fletero
        {
            public int Id { get; set; }

            public string Nombre { get; set; }
        }

        public class Guia
        {
            public string Numero { get; set; }

            public string Cliente { get; set; }

            public string Cuit { get; set; }

            public string Localidad { get; set; }

            public string DireccionOrigen { get; set; }

            public string Direccion { get; set; }

            public string Dimension { get; set; }
        }

        public class HojaRuta
        {
            public string Numero { get; set; }

            public string Fletero { get; set; }

            public string TipoRuteo { get; set; }

            public string Direccion { get; set; }

            public List<Guia> Guias { get; set; }
        }

        #endregion

        public List<string> ObtenerLocalidades()
        {
            List<string> resultado =
                new List<string>();

            foreach (
                Localidad localidad
                in LocalidadAlmacen.localidades)
            {
                resultado.Add(
                    localidad.NombreLocalidad);
            }

            return resultado;
        }

        public List<Fletero> ObtenerFleteros()
        {
            List<Fletero> resultado =
                new List<Fletero>();

            foreach (
                tutasa.Almacenes.Fletero fleteroEntidad
                in FleteroAlmacen.fleteros)
            {
                Fletero fletero =
                    new Fletero();

                fletero.Id =
                    fleteroEntidad.IdFletero;

                fletero.Nombre =
                    fleteroEntidad.Nombre;

                resultado.Add(
                    fletero);
            }

            return resultado;
        }

        public List<Guia> BuscarGuias(
            string localidad,
            string cuit)
        {
            List<Guia> resultado =
                new List<Guia>();

            foreach (
                GuiaEntidad guiaEntidad
                in GuiaAlmacen.guias)
            {
                ClienteEntidad cliente =
                    null;

                foreach (
                    ClienteEntidad clienteEntidad
                    in ClientesAlmacen.clientes)
                {
                    if (
                        clienteEntidad.CuitCliente
                        ==
                        guiaEntidad.CuitCliente)
                    {
                        cliente =
                            clienteEntidad;

                        break;
                    }
                }

                if (cliente == null)
                {
                    continue;
                }

                Localidad localidadCliente =
                    null;

                foreach (
                    Localidad localidadEntidad
                    in LocalidadAlmacen.localidades)
                {
                    if (
                        localidadEntidad.IdLocalidad
                        ==
                        cliente.IdLocalidad)
                    {
                        localidadCliente =
                            localidadEntidad;

                        break;
                    }
                }

                string nombreLocalidad =
                    "";

                if (localidadCliente != null)
                {
                    nombreLocalidad =
                        localidadCliente
                        .NombreLocalidad;
                }

                if (!string.IsNullOrEmpty(localidad))
                {
                    if (nombreLocalidad
                        != localidad)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(cuit))
                {
                    if (
                        guiaEntidad.CuitCliente
                        .ToString()
                        != cuit)
                    {
                        continue;
                    }
                }

                Guia guia =
                    new Guia();

                guia.Numero =
                    guiaEntidad.NumeroGuia
                    .ToString();

                guia.Cliente =
                    cliente.Nombre
                    + " "
                    + cliente.Apellido;

                guia.Cuit =
                    cliente.CuitCliente
                    .ToString();

                guia.Localidad =
                    nombreLocalidad;

                guia.DireccionOrigen =
                    cliente.Calle
                    + " "
                    + cliente.Altura;

                guia.Direccion =
                    guiaEntidad.CalleDestino
                    + " "
                    + guiaEntidad.AlturaDestino;

                guia.Dimension =
                    guiaEntidad.Dimension
                    .ToString();

                resultado.Add(
                    guia);
            }

            return resultado;
        }

        public void GuardarHojaRuta(
            HojaRuta hojaRuta)
        {
            // TODO:
            // Crear HojaRutaEntidad
            // Agregar al HojaRutaAlmacen
            // Guardar JSON
        }

        public int ObtenerProximoNumeroHojaRuta()
        {
            return
                HojaDeRutaUltimaMillaAlmacen
                .HojaDeRutaUltimaMilla
                .Count
                + 1;
        }

        public void ActualizarEstadoGuia(
            string numeroGuia,
            string tipoRuteo)
        {
            foreach (
                GuiaEntidad guia
                in GuiaAlmacen.guias)
            {
                if (
                    guia.NumeroGuia
                    .ToString()
                    ==
                    numeroGuia)
                {
                    if (
                        tipoRuteo
                        ==
                        "Retiro")
                    {
                        guia.EstadoActual =
                            EstadoGuiaEnum
                            .PlanificadaRetiro;
                    }
                    else
                    {
                        guia.EstadoActual =
                            EstadoGuiaEnum
                            .PlanificadaDistribucion;
                    }

                    break;
                }
            }

            GuiaAlmacen.Guardar();
        }
    }
}