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

            List<FleteroHDRultimaMilla> fleteros = modelo.ObtenerFleteros(1);

            cbox_fletero.DisplayMember = "Nombre";

            foreach (FleteroHDRultimaMilla fletero in fleteros)
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

            listview_hdr_asignadas.MultiSelect = true;
            listview_hdr_rendidas.MultiSelect = true;

            listview_hdr_asignadas.FullRowSelect = true;
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

            int idFletero = ((FleteroHDRultimaMilla)cbox_fletero.SelectedItem).IdFletero;
            string tipoHdr = cbox_tipo.SelectedItem.ToString();

            List<HDRultimaMilla> hdrAsignadas = modelo.ObtenerHdrUltimaMillaAsignadas(idFletero, tipoHdr);

            if (hdrAsignadas.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cbox_fletero.Enabled = false;

            foreach (var hdr in hdrAsignadas)
            {
                // Verificar si ya existe en listview_hdr_asignadas
                bool yaExisteEnAsignadas = false;
                foreach (ListViewItem existingItem in listview_hdr_asignadas.Items)
                {
                    if (existingItem.Text == hdr.NumeroHDR.ToString())
                    {
                        yaExisteEnAsignadas = true;
                        break;
                    }
                }

                // Verificar también en listview_hdr_rendidas para no volver a cargarla
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
                    listview_hdr_asignadas.Items.Add(CrearItemHDR(hdr));
                }
            }
        }

        private string ObtenerNombreFletero(int idFletero)
        {
            Fletero fletero = FleteroAlmacen.fleteros
                .Find(f => f.IdFletero == idFletero);

            return fletero?.Nombre ?? "Desconocido";
        }

        private ListViewItem CrearItemHDR(HDRultimaMilla hdr)
        {
            ListViewItem item = new ListViewItem(hdr.NumeroHDR.ToString());

            item.SubItems.Add(ObtenerNombreFletero(hdr.IdFletero));

            item.SubItems.Add(hdr.Estado.ToString());

            item.SubItems.Add(hdr.Tipo.ToString());

            string cumplidaTexto = hdr.Cumplida switch
            {
                true => "Cumplida",
                false => "No Cumplida"
            };

            item.SubItems.Add(cumplidaTexto);

            item.Tag = hdr;

            return item;
        }
        private void btn_agregar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasArendicion(true);
        }

        private void btn_agregar_no_cumplida_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasArendicion(false);
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasAasignada();
        }


        private void MoverHDRSeleccionadasArendicion(bool cumplida)
        {
            if (listview_hdr_asignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.");
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_asignadas.SelectedItems)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdr.Cumplida = cumplida;
                hdr.Estado = EstadoHDRUltimaMilla.Rendida;

                listview_hdr_rendidas.Items.Add(CrearItemHDR(hdr));

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_asignadas.Items.Remove(item);
            }
        }

        private void MoverHDRSeleccionadasAasignada()
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

                hdr.Cumplida = false;
                hdr.Estado = EstadoHDRUltimaMilla.Asignada;

                listview_hdr_asignadas.Items.Add(CrearItemHDR(hdr));

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_rendidas.Items.Remove(item);
            }
        }

        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdr.Cumplida = false;
                hdr.Estado = EstadoHDRUltimaMilla.Asignada;

                listview_hdr_asignadas.Items.Add(CrearItemHDR(hdr));
            }

            listview_hdr_rendidas.Items.Clear();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count == 0)
            {
                MessageBox.Show("No hay HDR rendidas para confirmar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<int> hdrRendidas = new();

            string nombreFletero = cbox_fletero.Text;

            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                hdrRendidas.Add(hdr.NumeroHDR);

                Console.WriteLine(
                    $"HDR {hdr.NumeroHDR} | " +
                    $"Fletero: {ObtenerNombreFletero(hdr.IdFletero)} | " +
                    $"Estado: {hdr.Estado} | " +
                    $"Tipo: {hdr.Tipo} | " +
                    $"Cumplida: {hdr.Cumplida}"
                );
            }

            MessageBox.Show(
                $"Se confirmaron {hdrRendidas.Count} HDR del fletero '{nombreFletero}'.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            limpiarCampos_Click();
        }
        private void limpiarCampos_Click()
        {
            cbox_fletero.SelectedIndex = -1;
            cbox_fletero.Enabled = true;
            cbox_tipo.SelectedIndex = -1;
            listview_hdr_asignadas.Items.Clear();
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
