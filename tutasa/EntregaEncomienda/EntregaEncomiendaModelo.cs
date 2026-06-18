using System;
using System.Collections.Generic;
using System.Linq;
using tutasa.Almacenes;

namespace tutasa.EntregaEncomienda
{
    internal class EntregaEncomiendaModelo
    {
        public Guia BuscarGuia(int nroGuia)
        {
            // Buscamos en la base de datos central
            var guiaEntidad = tutasa.Almacenes.GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == nroGuia);
            if (guiaEntidad == null) return null;

            // REGLA 2: Validar estados permitidos para entrega en mostrador
            bool estadoValido = guiaEntidad.EstadoActual == EstadoGuiaEnum.PendienteDeEntrega ||
                               (guiaEntidad.Destino == DestinoGuiaEnum.CD && guiaEntidad.EstadoActual == EstadoGuiaEnum.EnDestino);

            if (!estadoValido) return null;

            // Armamos el nombre del Cliente (buscándolo por CUIT)
            var cliente = ClientesAlmacen.clientes.FirstOrDefault(c => c.CuitCliente == guiaEntidad.CuitCliente);
            string nombreCliente = cliente != null ? $"{cliente.Nombre} {cliente.Apellido}" : "Cliente Desconocido";

            // Retornamos el objeto respetando los tipos de datos originales (convirtiendo números a string)
            return new Guia
            {
                NroGuia = guiaEntidad.NumeroGuia.ToString(),
                Cliente = nombreCliente,
                Destinatario = $"{guiaEntidad.NombreDestinatario} {guiaEntidad.ApellidoDestinatario}",
                DniDestinatario = guiaEntidad.DniDestinatario,
                EstadoActual = guiaEntidad.EstadoActual.ToString()
            };
        }

        // Ahora devuelve un string para comunicarle a la interfaz dónde se entregó
        public string ActualizarEstado(int nroGuia)
        {
            var guiaEntidad = tutasa.Almacenes.GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == nroGuia);
            if (guiaEntidad == null) throw new Exception("Error crítico: La guía desapareció de la base de datos.");

            // REGLA 5: Resolver dinámicamente el nombre de la sucursal
            string nombreUbicacion = "Sucursal Desconocida";
            if (guiaEntidad.Destino == DestinoGuiaEnum.Agencia)
            {
                var agencia = AgenciasAlmacen.agencias.FirstOrDefault(a => a.IdAgencia == guiaEntidad.IdAgenciaDestino);
                if (agencia != null) nombreUbicacion = $"{agencia.NombreAgencia}";
            }
            else if (guiaEntidad.Destino == DestinoGuiaEnum.CD)
            {
                var cd = CentroDistribucionAlmacen.CentrosDistribucion.FirstOrDefault(c => c.IdCD == guiaEntidad.IdCDDestino);
                if (cd != null) nombreUbicacion = $"CD {cd.NombreCD}";
            }

            // REGLA 4: Actualizar estado general y agregar trazabilidad
            guiaEntidad.EstadoActual = EstadoGuiaEnum.Entregada;

            guiaEntidad.Historial.Add(new MovimientoEstadoDto
            {
                Estado = EstadoGuiaEnum.Entregada,
                FechaHora = DateTime.Now,
                Ubicacion = nombreUbicacion
            });

            // Retornamos el nombre hacia la capa visual
            return nombreUbicacion;
        }
    }
}