using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutasa.CuentaCorriente
{
    public partial class CuentaCorriente : Form
    {
        private CuentaCorrienteModelo modelo = new CuentaCorrienteModelo();

        public CuentaCorriente()
        {
            InitializeComponent();
        }

        private void CuentaCorriente_Load( object sender, EventArgs e)
        {

        }


        private void BotonBuscarCuit_Click( object sender, EventArgs e)
        {
            // Limpiar datos previos al buscar otro cliente

            LabelNombreCliente.Text = "";

            LvEstadoCuenta.Items.Clear();

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

            CuentaCorrienteModelo.Cliente cliente = modelo.BuscarCliente(cuitNumerico);

            // Validar existencia

            if (cliente == null)
            {
                MessageBox.Show(
                    "No se encontró el cliente.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Mostrar nombre cliente

            LabelNombreCliente.Text = cliente.Nombre;
        }


        private void BotonConfirmar_Click(
            object sender,
            EventArgs e)
        {
            // Limpiar listado previo

            LvEstadoCuenta.Items.Clear();

            // Obtener CUIT

            string cuit = TextCuit.Text.Trim();

            // Validar cliente cargado

            if (string.IsNullOrEmpty(LabelNombreCliente.Text))
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

            // Obtener movimientos

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

            List<CuentaCorrienteModelo.MovimientoCuentaCorriente> movimientos = modelo.ObtenerMovimientos(cuitNumerico, fechaDesde, fechaHasta);

            // Mostrar movimientos

            foreach (CuentaCorrienteModelo.MovimientoCuentaCorriente movimiento in movimientos)
            {
                //Siempre el primer subitem es el texto del item, por eso se asigna la fecha al constructor
                ListViewItem item = new ListViewItem(movimiento.Fecha.ToString("dd/MM/yyyy"));

                item.SubItems.Add(movimiento.NumeroComprobante);

                item.SubItems.Add(movimiento.Concepto);
                //Acá la "C" formatea el número como moneda, agregando el símbolo correspondiente y dos decimales
                item.SubItems.Add(movimiento.Monto.ToString("C"));

                item.SubItems.Add(movimiento.Pago.ToString("C"));

                item.SubItems.Add(movimiento.Saldo.ToString("C"));

                LvEstadoCuenta.Items.Add(item);
            }

            // Validar movimientos encontrados

            if (movimientos.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron movimientos para el rango de fechas seleccionado.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}