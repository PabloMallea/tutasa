using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.Admision
{
    internal class AdmisionModelo
    {
        public Cliente BuscarClientePorCuit(long cuit)
        {
            ClienteEntidad clienteAlmacen = ClientesAlmacen.clientes.FirstOrDefault(c => c.CuitCliente == cuit);

            if (clienteAlmacen == null) return null;
            

            return new Cliente
            {
                CUIT = clienteAlmacen.CuitCliente,
                Nombre = clienteAlmacen.Nombre,
                Apellido = clienteAlmacen.Apellido,
                Direccion = $"{clienteAlmacen.Calle} {clienteAlmacen.Altura}"
            };
        }

        public bool EsPendienteAdmision(int numeroGuia)
        {
            GuiaEntidad guiaAlmacen = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);
            if (guiaAlmacen == null) return false;
            return guiaAlmacen.EstadoActual == EstadoGuiaEnum.PendienteAdmision;
        }
        public Guia BuscarGuiaPorIdentificador(int numeroGuia)
        {
            GuiaEntidad guiaAlmacen = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guiaAlmacen == null) return null;

            return new Guia
            {
                NumeroGuia = guiaAlmacen.NumeroGuia,
                CuitCliente = guiaAlmacen.CuitCliente,
                DireccionDestino = $"{guiaAlmacen.CalleDestino} {guiaAlmacen.AlturaDestino}",
                NombreDestinatario = guiaAlmacen.NombreDestinatario,
                ApellidoDestinatario = guiaAlmacen.ApellidoDestinatario,
                DniDestinatario = guiaAlmacen.DniDestinatario,
                Dimension = MapearDimensionAlmacenALocal(guiaAlmacen.Dimension)
            };
        }

        private DimensionEnum MapearDimensionAlmacenALocal(Almacenes.DimensionEnum dimensionAlmacen)
        {
            // Mapear del enum del almacén al enum local
            // Como ambos tienen los mismos valores, podemos usar ToString y Parse
            if (Enum.TryParse<DimensionEnum>(dimensionAlmacen.ToString(), out DimensionEnum dimensionLocal))
            {
                return dimensionLocal;
            }
            else throw new Exception("No se pudo convertir a DimensionEnum.");
        }

        public string CalcularDimension(decimal peso)
        {
            if (peso >= 0 && peso <= 2.5m)
                return "S";
            else if (peso > 2.5m && peso <= 5m)
                return "M";
            else if (peso > 5m && peso <= 10m)
                return "L";
            else if (peso > 10m && peso <= 20)
                return "XL";
            else
                return "XL"; // Si supera 20kg, se considera XL
        }

        public (bool exito, string mensajeError) RegistrarAdmision(Guia guia, decimal peso, string dimension)
        {
            if (guia == null)
            {
                return (false, "La guía no puede ser nula.");
            }

            // Buscar la GuiaEntidad en el almacén
            GuiaEntidad guiaAlmacen = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == guia.NumeroGuia);

            if (guiaAlmacen == null)
            {
                return (false, "No se encontró la guía en el almacén.");
            }

            if (guiaAlmacen.EstadoActual != EstadoGuiaEnum.PendienteAdmision)
            {
                return (false, $"La guía no puede ser admitida porque su estado actual es: {guiaAlmacen.EstadoActual}");
            }

            if (!Enum.TryParse<Almacenes.DimensionEnum>(dimension, out Almacenes.DimensionEnum dimensionEnum))
            {
                return (false, "La dimensión especificada no es válida.");
            }

            // Actualizar dimensión
            guiaAlmacen.Dimension = dimensionEnum;

            decimal tarifaBase = CalcularTarifaBase(guiaAlmacen.IdCDOrigen, guiaAlmacen.IdCDDestino, dimensionEnum);

            decimal extras = CalcularExtras(guiaAlmacen.TipoRetiro, guiaAlmacen.Destino);

            //Monto a facturar
            guiaAlmacen.MontoFacturar = tarifaBase + extras;

            CalcularYAsignarComisiones(guiaAlmacen, dimensionEnum);

            // Actualizar estado actual
            guiaAlmacen.EstadoActual = EstadoGuiaEnum.Admitida;

            // Crear movimiento de estado para la admisión
            MovimientoEstadoDto movimiento = new MovimientoEstadoDto
            {
                FechaHora = DateTime.Now,
                Estado = EstadoGuiaEnum.Admitida,
                Ubicacion = Program.IdCDActual.ToString(),
            };

            // Agregar el movimiento al historial de la guía
            if (guiaAlmacen.Historial == null)
            {
                guiaAlmacen.Historial = new List<MovimientoEstadoDto>();
            }
            guiaAlmacen.Historial.Add(movimiento);

            // Guardar los cambios en el almacén
            

            return (true, null);
        }

        private decimal CalcularTarifaBase(int idCDOrigen, int idCDDestino, Almacenes.DimensionEnum dimension)
        {
            // Obtener localidades de los CDs
            var cdOrigen = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(c => c.IdCD == idCDOrigen);
            var cdDestino = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(c => c.IdCD == idCDDestino);

            if (cdOrigen == null || cdDestino == null)
            {
                throw new Exception("No se encontraron los Centros de Distribución especificados.");
            }

            // Buscar tarifa en el almacén
            var tarifa = TarifasAlmacen.Tarifas.FirstOrDefault(t =>
                t.IdLocalidadOrigen == cdOrigen.IdLocalidad &&
                t.IdLocalidadDestino == cdDestino.IdLocalidad &&
                t.Dimension == dimension);

            if (tarifa == null)
            {
                throw new Exception($"No se encontró tarifa para Origen: {cdOrigen.IdLocalidad}, Destino: {cdDestino.IdLocalidad}, Dimensión: {dimension}");
            }

            return tarifa.Precio;
        }

        private decimal CalcularExtras(TipoRetiroEnum tipoRetiro, DestinoGuiaEnum destino)
        {
            decimal totalExtras = 0;

            // Extra por retiro a domicilio
            if (tipoRetiro == TipoRetiroEnum.EnDomicilio)
            {
                var extraRetiro = ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == TipoExtraEnum.Retiro);
                if (extraRetiro != null)
                {
                    totalExtras += extraRetiro.Precio;
                }
            }

            // Extra por entrega a domicilio
            if (destino == DestinoGuiaEnum.Domicilio)
            {
                var extraEntrega = ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == TipoExtraEnum.Entrega);
                if (extraEntrega != null)
                {
                    totalExtras += extraEntrega.Precio;
                }
            }
            // Extra por entrega en agencia
            else if (destino == DestinoGuiaEnum.Agencia)
            {
                var extraEntrega = ExtrasAlmacen.Extras.FirstOrDefault(e => e.Tipo == TipoExtraEnum.EntregaEnAgencia);
                if (extraEntrega != null)
                {
                    totalExtras += extraEntrega.Precio;
                }
            }

            return totalExtras;
        }

        private void CalcularYAsignarComisiones(GuiaEntidad guia, Almacenes.DimensionEnum dimension)
        {
            guia.ComisionesAgenciaOrigen = 0;
            guia.ComisionesAgenciaDestino = 0;
            guia.ComisionesFleteroOrigen = 0;
            guia.ComisionesFleteroDestino = 0;

            // COMISIÓN AGENCIA ORIGEN: Solo si el retiro es en agencia
            if (guia.TipoRetiro == TipoRetiroEnum.EnAgencia)
            {
                var comisionAgencia = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Agencia &&
                    c.Dimension == dimension);

                guia.ComisionesAgenciaOrigen = comisionAgencia?.Precio ?? 0;
            }

            // COMISIÓN AGENCIA DESTINO: Solo si el destino es agencia
            if (guia.Destino == DestinoGuiaEnum.Agencia)
            {
                var comisionAgencia = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Agencia &&
                    c.Dimension == dimension);

                guia.ComisionesAgenciaDestino = comisionAgencia?.Precio ?? 0;
            }

            // COMISIÓN FLETERO ORIGEN: Solo si el retiro es a domicilio o en agencia (NO si es recibido en CD)
            if (guia.TipoRetiro == TipoRetiroEnum.EnDomicilio || guia.TipoRetiro == TipoRetiroEnum.EnAgencia)
            {
                var comisionFletero = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Fletero &&
                    c.Dimension == dimension);

                guia.ComisionesFleteroOrigen = comisionFletero?.Precio ?? 0;
            }

            // COMISIÓN FLETERO DESTINO: Solo si el destino es domicilio o agencia (NO si es CD)
            if (guia.Destino == DestinoGuiaEnum.Domicilio || guia.Destino == DestinoGuiaEnum.Agencia)
            {
                var comisionFletero = ComisionesAlmacen.comisiones.FirstOrDefault(c =>
                    c.Tipo == TipoComisionEnum.Fletero &&
                    c.Dimension == dimension);

                guia.ComisionesFleteroDestino = comisionFletero?.Precio ?? 0;
            }
        }
    }
}
