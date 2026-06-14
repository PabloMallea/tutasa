using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using tutasa.Admision;
using static tutasa.EmitirFactura.EmitirFacturaModelo;

namespace tutasa.EmitirFactura
{
    public partial class EmitirFactura : Form
    {
        // Instancia del modelo
        private EmitirFacturaModelo modelo = new EmitirFacturaModelo();

        private List<EmitirFacturaModelo.Guia> guiasActuales = new List<EmitirFacturaModelo.Guia>();

        private EmitirFacturaModelo.Cliente clienteActual;

        public EmitirFactura()
        {
            InitializeComponent();
        }

        private void EmitirFactura_Load(object sender, EventArgs e)
        {
            LimpiarPantalla();

        }

        private void BotonBuscarCliente_Click(object sender, EventArgs e)
        {
            // Validar CUIT
            if (!long.TryParse(txtCuit.Text, out long cuit))
            {
                MessageBox.Show(
                    "El CUIT ingresado no es válido. Debe ser un número sin guiones ni espacios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            // Buscar cliente
            clienteActual = modelo.BuscarCliente(cuit);
            if (clienteActual == null)
            {
                MessageBox.Show(
                    "No se encontró un cliente con el CUIT ingresado.",
                    "Resultado de búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LabelNombreCliente.Text = "";
                return;
            }
            // Mostrar nombre del cliente
            LabelNombreCliente.Text = clienteActual.Nombre;

            guiasActuales = modelo.BuscarGuiasAFacturar(cuit);


            ListViewFacturacion.Items.Clear();

            decimal total = 0;

            foreach (EmitirFacturaModelo.Guia guia in guiasActuales)
            {

                ListViewItem item = new ListViewItem(guia.NumeroGuia.ToString());

                item.SubItems.Add(guia.MontoFacturar.ToString("C", new CultureInfo("es-AR")));

                ListViewFacturacion.Items.Add(item);

                total += guia.MontoFacturar;
            }
            LabelTotal.Text = total.ToString("C", new CultureInfo("es-AR"));

        }

        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            // validar cliente seleccionado
            if (clienteActual == null)
            {
                MessageBox.Show(
                    "Debe buscar y seleccionar un cliente antes de emitir la factura.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            //validar que existan guias para facturar
            if (ListViewFacturacion.Items.Count == 0)
            {
                MessageBox.Show(
                    "El cliente no posee guías pendientes de facturar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            long cuit = long.Parse(txtCuit.Text);

            Factura factura = modelo.EmitirFactura(cuit, guiasActuales);

            MessageBox.Show(
                "Factura emitida correctamente.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimpiarPantalla();

        }

        private void LimpiarPantalla()
        {
            txtCuit.Text = "";
            txtCuit.Enabled = true;

            LabelNombreCliente.Text = "";

            LabelTotal.Text = 0.ToString("C", new CultureInfo("es-AR"));

            ListViewFacturacion.Items.Clear();

            clienteActual = null;

            guiasActuales.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (ListViewFacturacion.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea cancelar? Se perderán los cambios no confirmados.",
                    "Confirmación de Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            MessageBox.Show(
                "Cerrará la pantalla de Emitir Factura.",
                "Cancelación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}

/*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar selección
            if (ComboCliente.SelectedIndex == -1)
            {
                return;
            }

            // Obtener clientes. Acá hacemos esto para obtener el objeto completo del cliente seleccionado, ya que el combo solo tiene el nombre.
            List<EmitirFacturaModelo.Cliente> clientes = modelo.ObtenerClientes();

            // Obtener cliente seleccionado
            EmitirFacturaModelo.Cliente cliente =
                clientes[ComboCliente.SelectedIndex];

            // Completar labels
            LabelCuit.Text = cliente.Cuit;

            LabelNombre.Text = cliente.Nombre;

            // Obtener encomiendas pendientes
            List<EmitirFacturaModelo.Encomienda> encomiendas = modelo.ObtenerEncomiendasPendientes(cliente.Cuit);

            // Limpiar listado previo
            ListViewFacturacion.Items.Clear();

            // Variable acumuladora
            decimal total = 0;

            // Recorrer encomiendas
            foreach (
                EmitirFacturaModelo.Encomienda encomienda in encomiendas)
            {
                // Crear fila
                ListViewItem item = new ListViewItem(encomienda.NumeroGuia);

                // Agregar concepto
                item.SubItems.Add(encomienda.TipoEntrega);

                // Agregar monto. El "C" formatea el número como moneda.
                item.SubItems.Add(encomienda.MontoFacturar.ToString("C"));

                // Agregar fila al ListView
                ListViewFacturacion.Items.Add(item);

                // Acumular total
                total += encomienda.MontoFacturar;
            }

            // Mostrar total
            LabelTotal.Text = total.ToString("C");
        }

        private void BotonConfirmar_Click(object sender, EventArgs e)
        {
            // Validar cliente seleccionado
            if (ComboCliente.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Obtener clientes
            List<EmitirFacturaModelo.Cliente> clientes = modelo.ObtenerClientes();

            // Obtener cliente seleccionado
            EmitirFacturaModelo.Cliente cliente = clientes[ComboCliente.SelectedIndex];

            // Obtener encomiendas pendientes
            List<EmitirFacturaModelo.Encomienda> encomiendas = modelo.ObtenerEncomiendasPendientes(cliente.Cuit);

            // Validar pendientes
            if (encomiendas.Count == 0)
            {
                MessageBox.Show(
                    "El cliente no posee encomiendas pendientes de facturar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Calcular total
            decimal total = 0;

            foreach (
                EmitirFacturaModelo.Encomienda encomienda
                in encomiendas)
            {
                total += encomienda.MontoFacturar;

                // Marcar encomienda como facturada
                encomienda.Facturada = true;
            }

            // Crear factura
            EmitirFacturaModelo.Factura factura =
                new EmitirFacturaModelo.Factura
                {
                    NumeroFactura = modelo.GenerarNumeroFactura(),
                    FechaEmision = DateTime.Now,
                    Cliente = cliente,
                    Encomiendas = encomiendas,
                    Total = total
                };

            string detalleFactura = modelo.ObtenerDetalleFactura(factura);

            MessageBox.Show(detalleFactura, "EMISIÓN DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            MessageBox.Show(
                "Factura emitida correctamente.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar listado
            ListViewFacturacion.Items.Clear();

            // Limpiar labels
            LabelCuit.Text = "";

            LabelNombre.Text = "";

            LabelTotal.Text = "$0";

            // Reiniciar combo
            ComboCliente.SelectedIndex = -1;
        }

*/