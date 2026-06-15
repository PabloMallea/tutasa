using System.Diagnostics.Eventing.Reader;
using tutasa.Almacenes;
using static tutasa.RendicionHDRultimaMilla.RendicionHDRultimaMillaModelo;

namespace tutasa.RendicionHDRultimaMilla
{
    public partial class RendicionHDRultimaMilla : Form
    {
        public RendicionHDRultimaMilla()
        {
            InitializeComponent();
        }

        private RendicionHDRultimaMillaModelo modelo = new RendicionHDRultimaMillaModelo();

        private void RendicionHDRultimaMilla_Load(object sender, EventArgs e)
        {
            int IdCdActual = modelo.IdCdActual;

            List<string> fleteros = modelo.ObtenerFleteros(IdCdActual);

            foreach (string fletero in fleteros)
            {
                cbox_fletero.Items.Add(fletero);
            }

            List<string> tipos = modelo.ObtenerTiposHDR();

            foreach (string tipo in tipos)
            {
                cbox_tipo.Items.Add(tipo);
            }

            cbox_fletero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;

            listview_hdr_emitidas.MultiSelect = true;
            listview_hdr_rendidas.MultiSelect = true;

            listview_hdr_emitidas.FullRowSelect = true;
            listview_hdr_rendidas.FullRowSelect = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cbox_fletero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un fletero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cbox_tipo.SelectedItem == null || string.IsNullOrWhiteSpace(cbox_tipo.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un tipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fleteroSeleccionado = cbox_fletero.SelectedItem.ToString();
            string tipoHdr = cbox_tipo.SelectedItem.ToString();

            List<HDRultimaMilla> hdrAsignadas = modelo.ObtenerHdrUltimaMillaEmitida(fleteroSeleccionado, tipoHdr);

            if (hdrAsignadas.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cbox_fletero.Enabled = false;

            foreach (var hdr in hdrAsignadas)
            {
                bool yaExisteEnAsignadas = false;
                foreach (ListViewItem existingItem in listview_hdr_emitidas.Items)
                {
                    if (existingItem.Text == hdr.NumeroHDR.ToString())
                    {
                        yaExisteEnAsignadas = true;
                        break;
                    }
                }

                bool yaExisteEnRendidas = false;
                foreach (ListViewItem rendidasItem in listview_hdr_rendidas.Items)
                {
                    if (rendidasItem.Text == hdr.NumeroHDR.ToString())
                    {
                        yaExisteEnRendidas = true;
                        break;
                    }
                }

                if (!yaExisteEnAsignadas && !yaExisteEnRendidas)
                {
                    listview_hdr_emitidas.Items.Add(CrearItemHDR(hdr));
                }
            }
        }

        private ListViewItem CrearItemHDR(HDRultimaMilla hdr)
        {
            ListViewItem item = new ListViewItem(hdr.NumeroHDR.ToString());

            item.SubItems.Add(hdr.Fletero);

            item.SubItems.Add(hdr.Estado);

            item.SubItems.Add(hdr.Tipo);

            item.SubItems.Add(hdr.Cumplida);

            item.Tag = hdr;

            return item;
        }
        private void btn_agregar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasARendicion("Cumplida");
        }

        private void btn_agregar_no_cumplida_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasARendicion("No Cumplida");
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasAEmitida();
        }


        private void MoverHDRSeleccionadasARendicion(string cumplida)
        {
            if (listview_hdr_emitidas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.");
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_emitidas.SelectedItems)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdr.Cumplida = cumplida;
                hdr.Estado = "Rendida";

                listview_hdr_rendidas.Items.Add(CrearItemHDR(hdr));

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_emitidas.Items.Remove(item);
            }
        }

        private void MoverHDRSeleccionadasAEmitida()
        {
            if (listview_hdr_rendidas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.");
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_rendidas.SelectedItems)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdr.Cumplida = "";
                hdr.Estado = "Emitida";

                listview_hdr_emitidas.Items.Add(CrearItemHDR(hdr));

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_rendidas.Items.Remove(item);
            }

            listview_hdr_emitidas.SelectedItems.Clear();
            listview_hdr_rendidas.SelectedItems.Clear();
        }

        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdr.Cumplida = "";
                hdr.Estado = "Emitida";

                listview_hdr_emitidas.Items.Add(CrearItemHDR(hdr));
            }

            listview_hdr_rendidas.Items.Clear();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count == 0)
            {
                MessageBox.Show(
                    "No hay HDR rendidas para confirmar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<HDRultimaMilla> hdrRendidas = new();

            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdrRendidas.Add(hdr);
            }

            bool resultadoConfirmacion =
                modelo.ConfirmarRendicionHDR(hdrRendidas);

            if (!resultadoConfirmacion)
            {
                MessageBox.Show(
                    "Ocurrió un error al confirmar la rendición.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                $"Se confirmaron {hdrRendidas.Count} HDR.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            limpiarCampos_Click();
        }
        private void limpiarCampos_Click()
        {
            cbox_fletero.SelectedIndex = -1;
            cbox_fletero.Enabled = true;
            cbox_tipo.SelectedIndex = -1;
            listview_hdr_emitidas.Items.Clear();
            listview_hdr_rendidas.Items.Clear();
        }

        private void btn_limpiar_campos_Click(object sender, EventArgs e)
        {
            limpiarCampos_Click();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar? Se perderán los cambios no confirmados.", "Confirmación de Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            MessageBox.Show("Cerrara la pantalla de rendición HDR.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}