using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.RuteoUltimaMilla
{
    internal partial class RuteoUltimaMillaModelo
    {


        public List<Localidad> ObtenerLocalidades()
        {
            List<Localidad> resultado =
                new List<Localidad>();

            foreach (
                tutasa.Almacenes.Localidad entidad in LocalidadAlmacen.localidades)
            {
                Localidad localidad =new Localidad();

                localidad.IdLocalidad =entidad.IdLocalidad;

                localidad.NombreLocalidad =entidad.NombreLocalidad;

                resultado.Add(localidad);
            }   

            return resultado;
        }


        public List<Fletero> ObtenerFleteros()
        {
            List<Fletero> resultado = new List<Fletero>();

            foreach (
                tutasa.Almacenes.Fletero fleteroEntidad in FleteroAlmacen.fleteros)
            {
                if (fleteroEntidad.IdCD!= Program.IdCDActual)
                {
                    continue;
                }

                Fletero fletero =new Fletero();

                fletero.IdFletero =fleteroEntidad.IdFletero;

                fletero.Nombre =
                    fleteroEntidad.Nombre;

                resultado.Add(fletero);
            }

            return resultado;
        }


        public List<Guia> BuscarGuias(string localidad,string cuit,string tipoRuteo)
        {
            List<Guia> resultado =new List<Guia>();

            foreach (GuiaEntidad guiaEntidad in GuiaAlmacen.guias)
            {
                if (tipoRuteo == "Retiro")
                {
                    if (guiaEntidad.EstadoActual!= EstadoGuiaEnum.Impuesta)
                    {
                        continue;
                    }

                    if (guiaEntidad.IdCDOrigen!= Program.IdCDActual)
                    {
                        continue;
                    }

                    if (guiaEntidad.TipoRetiro!= TipoRetiroEnum.EnDomicilio && guiaEntidad.TipoRetiro != TipoRetiroEnum.EnAgencia)
                    {
                        continue;
                    }
                }

                if (tipoRuteo == "Entrega")
                {
                    if (guiaEntidad.EstadoActual != EstadoGuiaEnum.EnDestino)
                    {
                        continue;
                    }

                    if (guiaEntidad.IdCDDestino != Program.IdCDActual)
                    {
                        continue;
                    }
                    if (guiaEntidad.Destino == DestinoGuiaEnum.CD)
                    {
                        continue;
                    }
                }

                ClienteEntidad cliente = null;

                foreach (ClienteEntidad clienteEntidad in ClientesAlmacen.clientes)
                {
                    if (clienteEntidad.CuitCliente == guiaEntidad.CuitCliente)
                    {
                        cliente = clienteEntidad;
                        break;
                    }
                }

                if (cliente == null)
                {
                    continue;
                }

                CentroDistribucion cdReferencia = null;

                if (tipoRuteo == "Retiro")
                {
                    cdReferencia =CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(cd => cd.IdCD ==guiaEntidad.IdCDOrigen);
                }
                else
                {
                    cdReferencia =CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(cd => cd.IdCD == guiaEntidad.IdCDDestino);
                }

                string nombreLocalidad = "";

                if (cdReferencia != null)
                {
                    tutasa.Almacenes.Localidad localidadEntidad =LocalidadAlmacen.localidades.FirstOrDefault( l => l.IdLocalidad ==cdReferencia.IdLocalidad);

                    if (localidadEntidad != null)
                    {
                        nombreLocalidad =localidadEntidad.NombreLocalidad;
                    }
                }
                if (!string.IsNullOrEmpty(localidad))
                {
                    if (nombreLocalidad != localidad)
                    {
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(cuit))
                {
                    if (guiaEntidad.CuitCliente.ToString()!= cuit)
                    {
                        continue;
                    }
                }

                Guia guia = new Guia();

                guia.NumeroGuia = guiaEntidad.NumeroGuia;

                guia.Cliente = cliente.Nombre + " "+ cliente.Apellido;

                guia.Cuit = cliente.CuitCliente.ToString();

                guia.Localidad = nombreLocalidad;

                guia.DireccionOrigen = cliente.Calle + " " + cliente.Altura;

                guia.Direccion = guiaEntidad.CalleDestino + " " + guiaEntidad.AlturaDestino;

                guia.Dimension = guiaEntidad.Dimension.ToString();

                resultado.Add(guia);
            }

            return resultado;
        }


        public void GuardarHojaRuta(HojaRuta hojaRuta)
        {
            tutasa.Almacenes.Fletero fleteroSeleccionado = FleteroAlmacen.fleteros.FirstOrDefault(f => f.IdFletero == hojaRuta.IdFletero);

            if (fleteroSeleccionado == null)
            {
                return;
            }

            HojaDeRutaUltimaMilla hdr = new HojaDeRutaUltimaMilla();

            hdr.NumeroHDR = HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.Count + 1;

            hdr.IdFletero = fleteroSeleccionado.IdFletero;

            hdr.DireccionDestino = hojaRuta.Direccion;

            hdr.Cumplida = false;

            hdr.Estado = EstadoHDRUltimaMillaEnum.Asignada;

            if (hojaRuta.TipoRuteo == "Retiro")
            {
                hdr.Tipo = TipoHDREnum.Retiro;
            }
            else
            {
                hdr.Tipo = TipoHDREnum.Entrega;
            }

            foreach (Guia guiaPantalla in hojaRuta.Guias)
            {
                int numeroGuia =guiaPantalla.NumeroGuia;

                hdr.Guias.Add(numeroGuia);

                GuiaEntidad guiaEntidad =GuiaAlmacen.guias.FirstOrDefault(g =>g.NumeroGuia == numeroGuia);

                if (guiaEntidad == null)
                {
                    continue;
                }

                if (hojaRuta.TipoRuteo == "Retiro")
                {
                    guiaEntidad.EstadoActual = EstadoGuiaEnum.PlanificadaRetiro;

                    guiaEntidad.Historial.Add(new MovimientoEstadoDto
                        {
                            FechaHora =DateTime.Now,

                            Estado = EstadoGuiaEnum.PlanificadaRetiro,

                            Ubicacion = ObtenerCDActual(Program.IdCDActual)
                        });
                }
                else
                {
                    guiaEntidad.EstadoActual = EstadoGuiaEnum.PlanificadaDistribucion;

                    guiaEntidad.Historial.Add(new MovimientoEstadoDto
                        {
                            FechaHora = DateTime.Now,

                            Estado = EstadoGuiaEnum.PlanificadaDistribucion,

                            Ubicacion = ObtenerCDActual(Program.IdCDActual)
                        });
                }
            }

            HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.Add(hdr);

          //  GuiaAlmacen.Guardar();

            //HojaDeRutaUltimaMillaAlmacen.Guardar();
        }

        public int ObtenerProximoNumeroHojaRuta()
        {
            return HojaDeRutaUltimaMillaAlmacen.HojaDeRutaUltimaMilla.Count + 1;
        }

        public string ObtenerCDActual(int IdCdActual)
        {
            CentroDistribucion cd = CentroDistribucionAlmacen.CentrosDistribucion.Find(cd => cd.IdCD == IdCdActual);
            return cd != null ? cd.NombreCD : "Desconocido";

        }
    }
}

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
 public void ActualizarEstadoGuia(string numeroGuia,string tipoRuteo)
        {
            foreach (GuiaEntidad guia in GuiaAlmacen.guias)
            {
                if (guia.NumeroGuia.ToString() == numeroGuia)
                {
                    if (tipoRuteo == "Retiro")
                    {
                        guia.EstadoActual =EstadoGuiaEnum.PlanificadaRetiro;
                    }
                    else
                    {
                        guia.EstadoActual =EstadoGuiaEnum.PlanificadaDistribucion;
                    }

                    break;
                }
            }
*/