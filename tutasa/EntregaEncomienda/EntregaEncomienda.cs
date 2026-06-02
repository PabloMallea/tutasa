using System;
using System.Windows.Forms;

namespace tutasa.EntregaEncomienda
{
    public partial class EntregaEncomienda : Form
    {
        private EntregaEncomiendaModelo modelo =
            new EntregaEncomiendaModelo();

        // NO se toca!!
        public EntregaEncomienda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroGuia = txtNumeroGuia.Text.Trim();

            if (string.IsNullOrEmpty(nroGuia))
            {
                MessageBox.Show(
                    "El campo Nº Guía debe ser completado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Guia guia = modelo.BuscarGuia(nroGuia);

            if (guia == null)
            {
                MessageBox.Show(
                    "El Nº Guía ingresado no corresponde a una guía registrada o no se encuentra en estado Admitida.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtNumeroGuia.Clear();

                return;
            }

            lvDetalle.Items.Clear();

            ListViewItem item = new ListViewItem(guia.Cliente);

            item.Tag = guia;

            item.SubItems.Add(guia.Destinatario);
            item.SubItems.Add(guia.DniDestinatario);

            lvDetalle.Items.Add(item);
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            if (lvDetalle.Items.Count == 0)
            {
                MessageBox.Show(
                    "Todos los campos y desplegables obligatorios deben ser completados.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Guia guia = (Guia)lvDetalle.Items[0].Tag;

            modelo.ActualizarEstado(guia.NroGuia);

            MessageBox.Show(
                "Estado de guía actualizado a Entregada.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            this.Close();
        }

        private void LimpiarFormulario()
        {
            txtNumeroGuia.Clear();
            lvDetalle.Items.Clear();
        }
    }
}