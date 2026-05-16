using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tutasa.EmitirFactura
{
    public partial class EmitirFactura : Form
    {
        // Instancia del modelo
        private EmitirFacturaModelo modelo = new EmitirFacturaModelo();

        public EmitirFactura()
        {
            InitializeComponent();
        }

        private void EmitirFactura_Load(object sender, EventArgs e)
        {
            // Obtener clientes
            List<EmitirFacturaModelo.Cliente> clientes = modelo.ObtenerClientes();

            // Limpiar combo
            ComboCliente.Items.Clear();

            // Cargar clientes
            foreach (EmitirFacturaModelo.Cliente cliente in clientes)
            {
                ComboCliente.Items.Add(cliente.Nombre);
            }
        }

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
                    Cliente = cliente,
                    Encomiendas = encomiendas,
                    Total = total
                };

            MessageBox.Show(
                "Factura emitida correctamente.\n" +
                "Total facturado: " +
                factura.Total.ToString("C"),
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


    }
}