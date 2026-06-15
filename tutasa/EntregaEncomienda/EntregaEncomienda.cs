using System;
using System.Linq;
using System.Windows.Forms;

namespace tutasa.EntregaEncomienda
{
    public partial class EntregaEncomienda : Form
    {
        // Instancia del modelo (El Cerebro)
        private EntregaEncomiendaModelo modelo = new EntregaEncomiendaModelo();

        public EntregaEncomienda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1. CAPA VISUAL: Recolección y limpieza
            string nroGuiaTexto = txtNumeroGuia.Text.Trim();

            // 2. CAPA VISUAL: Validación de nulos o vacíos
            if (string.IsNullOrWhiteSpace(nroGuiaTexto))
            {
                MessageBox.Show("El campo Nº Guía debe ser completado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. CAPA VISUAL: Validación estricta de formato (solo números)
            if (!nroGuiaTexto.All(char.IsDigit))
            {
                MessageBox.Show("El Nº Guía debe contener únicamente números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. CAPA VISUAL: Conversión a tipo de dato fuerte (int)
            int numeroGuiaValidado = int.Parse(nroGuiaTexto);

            // 5. DELEGACIÓN AL MODELO: Le pasamos el int limpio
            Guia guia = modelo.BuscarGuia(numeroGuiaValidado);

            // Verificamos la respuesta de las reglas de negocio
            if (guia == null)
            {
                MessageBox.Show("El Nº Guía ingresado no corresponde a una guía registrada o no está habilitada para ser entregada.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                return;
            }

            // 6. CARGA DE UI: Limpiamos y llenamos la lista
            lvDetalle.Items.Clear();
            ListViewItem item = new ListViewItem(guia.Cliente);

            // Guardamos el objeto original en el bolsillo secreto
            item.Tag = guia;

            item.SubItems.Add(guia.Destinatario);
            item.SubItems.Add(guia.DniDestinatario);

            lvDetalle.Items.Add(item);
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            // Validamos que exista una fila seleccionable y que tenga el objeto secreto
            if (lvDetalle.Items.Count == 0 || lvDetalle.Items[0].Tag == null)
            {
                MessageBox.Show("Debe buscar y visualizar una guía válida antes de confirmar la entrega.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recuperamos la guía respetando tu clase original (que tiene el NroGuia como string)
            Guia guia = (Guia)lvDetalle.Items[0].Tag;

            try
            {
                // Convertimos el string a int para mandárselo al cerebro
                int numeroAActualizar = int.Parse(guia.NroGuia);

                // El modelo actualiza, guarda el historial y nos devuelve en qué sucursal se hizo la entrega
                string ubicacionEntrega = modelo.ActualizarEstado(numeroAActualizar);

                // Mostramos el mensaje dinámico
                MessageBox.Show($"Entrega registrada correctamente en {ubicacionEntrega} y se actualizó el estado a Entregada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                // El escudo protector contra reglas de negocio rotas o caídas de base de datos
                MessageBox.Show(ex.Message, "Error de Regla de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            // this.Close(); 
        }

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