using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutasa.CuentaCorriente
{
    public partial class CuentaCorriente : Form
    {
        private CuentaCorrienteModelo modelo = new CuentaCorrienteModelo();

        private CuentaCorrienteModelo.Cliente clienteActual;
        private List<CuentaCorrienteModelo.MovimientoCuentaCorriente> movimientosActuales = new List<CuentaCorrienteModelo.MovimientoCuentaCorriente>();

        public CuentaCorriente()
        {
            InitializeComponent();
        }

        private void CuentaCorriente_Load(object sender, EventArgs e)
        {
            LimpiarResultados();

            FechaDesde.Value = DateTime.Today.AddMonths(-1);
            FechaHasta.Value = DateTime.Today;
        }


        private void BotonBuscarCuit_Click(object sender, EventArgs e)
        {
            // Limpiar datos previos al buscar otro cliente

            LimpiarResultados();

            // Obtener CUIT ingresado. El trim elimina espacios al inicio y al final

            string cuit = TextCuit.Text.Trim();

            // Validar obligatorio

            if (string.IsNullOrEmpty(cuit))
            {
                MessageBox.Show(
                    "Debe ingresar un CUIT/CUIL.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar numérico

            long cuitNumerico;

            if (!long.TryParse(cuit, out cuitNumerico))
            {
                MessageBox.Show(
                    "El CUIT/CUIL debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Buscar cliente

            clienteActual = modelo.BuscarCliente(cuitNumerico);

            // Validar existencia

            if (clienteActual == null)
            {
                MessageBox.Show(
                    "No se encontró el cliente.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            LabelNombreCliente.Text = clienteActual.Nombre;
        }


        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            // Limpiar listado previo

            LvEstadoCuenta.Items.Clear();

            // Obtener CUIT

            string cuit = TextCuit.Text.Trim();

            // Validar cliente cargado

            if (clienteActual == null)
            {
                MessageBox.Show(
                    "Debe buscar un cliente primero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Obtener fechas

            DateTime fechaDesde = FechaDesde.Value;

            DateTime fechaHasta = FechaHasta.Value;

            // Validar rango

            if (fechaDesde.Date > fechaHasta.Date)
            {
                MessageBox.Show(
                    "La fecha desde no puede ser mayor a la fecha hasta.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            movimientosActuales = modelo.ObtenerMovimientos(clienteActual.Cuit, fechaDesde, fechaHasta);

            // Mostrar movimientos

            foreach (CuentaCorrienteModelo.MovimientoCuentaCorriente movimiento in movimientosActuales)
            {
                //Siempre el primer subitem es el texto del item, por eso se asigna la fecha al constructor
                ListViewItem item = new ListViewItem(movimiento.Fecha.ToString("dd/MM/yyyy"));

                item.SubItems.Add(movimiento.NumeroFactura);

                item.SubItems.Add(movimiento.Monto.ToString("C", new CultureInfo("es-AR")));

                item.SubItems.Add(movimiento.Pago ? "Realizado" : "Pendiente");

                LvEstadoCuenta.Items.Add(item);
            }

            // Validar movimientos encontrados

            labelImporteSaldo.Text = modelo.ObtenerSaldoPendiente(movimientosActuales).ToString("C", new CultureInfo("es-AR"));

            if (movimientosActuales.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron movimientos para el rango de fechas seleccionado.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void LimpiarPantalla()
        {
            TextCuit.Text = "";
            TextCuit.Enabled = true;

            LimpiarResultados();
        }

        private void LimpiarResultados()
        {
            LabelNombreCliente.Text = "";

            LvEstadoCuenta.Items.Clear();

            labelImporteSaldo.Text =
                0.ToString("C", new CultureInfo("es-AR"));

            clienteActual = null;

            movimientosActuales.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cerrará la pantalla de Cuenta Corriente.",
                "Cancelación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}