using System;
using System.Windows.Forms;

namespace tutasa.EntregaEncomienda
{
    public partial class EntregaEncomienda : Form
    {
        // Instancia del modelo
        private EntregaEncomiendaModelo modelo =
            new EntregaEncomiendaModelo();

        // NO se toca!!
        public EntregaEncomienda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener Nº Guía ingresado
            string nroGuia = txtNumeroGuia.Text.Trim();

            // Validar que se haya ingresado Nº Guía
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

            // Buscar guía en el modelo (solo devuelve si está en estado "Admitida")
            Guia guia = modelo.BuscarGuia(nroGuia);

            // Validar existencia y estado de la guía
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

            // Limpiar ListView antes de cargar
            lvDetalle.Items.Clear();

            // Cargar datos de la guía en el ListView
            ListViewItem item = new ListViewItem(guia.Cliente);

            item.Tag = guia;

            item.SubItems.Add(guia.Destinatario);
            item.SubItems.Add(guia.DniDestinatario);
            item.SubItems.Add(guia.EstadoActual);

            lvDetalle.Items.Add(item);
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            // Validar que haya una guía cargada en el ListView
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

            // Recuperar la guía desde el Tag del item
            Guia guia = (Guia)lvDetalle.Items[0].Tag;

            // Actualizar estado de la guía a "Entregada en agencia"
            modelo.ActualizarEstado(guia.NroGuia);

            MessageBox.Show(
                "Entrega registrada correctamente.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Descartar entrega y volver al menú principal
            LimpiarFormulario();

            // Cerrar o navegar al menú principal según la arquitectura del sistema
            this.Close();
        }

        // Limpia todos los campos del formulario
        private void LimpiarFormulario()
        {
            txtNumeroGuia.Clear();
            lvDetalle.Items.Clear();
        }

        private void lvDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}