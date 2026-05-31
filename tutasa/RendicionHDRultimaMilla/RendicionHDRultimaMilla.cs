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

            List<string> fleteros = modelo.fleteros;
            foreach (string fletero in fleteros)
            {
                cbox_fletero.Items.Add(fletero);
            }

            List<string> tipos = modelo.tipos;
            foreach (string tipo in tipos)
            {
                cbox_tipo.Items.Add(tipo);
            }

            listview_hdr_asignadas.MultiSelect = true;
            listview_hdr_rendidas.MultiSelect = true;

            listview_hdr_asignadas.FullRowSelect = true;
            listview_hdr_rendidas.FullRowSelect = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbox_fletero.Text))
            {
                MessageBox.Show("Por favor, seleccione o ingrese un fletero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbox_tipo.SelectedItem == null || string.IsNullOrWhiteSpace(cbox_tipo.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un tipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RendicionHDRultimaMillaModelo resultado = RendicionHDRultimaMillaModelo.ObtenerMockHDRAsignadas();

            List<HDRultimaMilla> resultadosFiltrados = resultado.HDRultimaMillaList.Where(
                    hdr => hdr.fletero.Equals(cbox_fletero.Text, StringComparison.OrdinalIgnoreCase)
                    &&
                    hdr.tipo.Equals(cbox_tipo.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultadosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cbox_fletero.Enabled = false;

            foreach (var hdr in resultadosFiltrados)
            {
                // Verificar si ya existe en listview_hdr_asignadas
                bool yaExisteEnAsignadas = false;
                foreach (ListViewItem existingItem in listview_hdr_asignadas.Items)
                {
                    if (existingItem.Text == hdr.n_hdr.ToString())
                    {
                        yaExisteEnAsignadas = true;
                        break;
                    }
                }

                // Verificar también en listview_hdr_rendidas para no volver a cargarla
                bool yaExisteEnRendidas = false;
                foreach (ListViewItem rendidasItem in listview_hdr_rendidas.Items)
                {
                    if (rendidasItem.Text == hdr.n_hdr.ToString())
                    {
                        yaExisteEnRendidas = true;
                        break;
                    }
                }

                if (!yaExisteEnAsignadas && !yaExisteEnRendidas)
                {
                    var item = new ListViewItem(hdr.n_hdr.ToString());

                    item.SubItems.Add(hdr.fletero);
                    item.SubItems.Add(hdr.estado);
                    item.SubItems.Add(hdr.tipo);
                    item.SubItems.Add(hdr.fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(hdr.cumplida);

                    // GUARDAMOS EL OBJETO COMPLETO
                    item.Tag = hdr;

                    listview_hdr_asignadas.Items.Add(item);
                }
            }
        }

        private void btn_agregar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasArendicion("Cumplida");
        }

        private void btn_agregar_no_cumplida_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasArendicion("No Cumplida");
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasAasignada();
        }


        private void MoverHDRSeleccionadasArendicion(string estadoCumplimiento)
        {
            if (listview_hdr_asignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_asignadas.SelectedItems)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                // Actualizo el objeto
                hdr.cumplida = estadoCumplimiento;
                hdr.estado = "Rendida";
                hdr.fecha = DateTime.Now; // fecha actual al rendir

                // Creo el item para la lista de rendidas
                ListViewItem nuevoItem = new ListViewItem(hdr.n_hdr.ToString());

                nuevoItem.SubItems.Add(hdr.fletero);
                nuevoItem.SubItems.Add(hdr.estado);
                nuevoItem.SubItems.Add(hdr.fecha.ToString("dd/MM/yyyy HH:mm"));
                nuevoItem.SubItems.Add(hdr.tipo);
                nuevoItem.SubItems.Add(hdr.cumplida);

                nuevoItem.Tag = hdr;

                listview_hdr_rendidas.Items.Add(nuevoItem);

                itemsAMover.Add(item);
            }

            // Eliminar de HDR Asignadas
            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_asignadas.Items.Remove(item);
            }
        }

        private void MoverHDRSeleccionadasAasignada()
        {
            if (listview_hdr_rendidas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_rendidas.SelectedItems)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;

                // Actualizo el objeto
                hdr.cumplida = "";
                hdr.estado = "Asignada";

                // Creo el item para la lista de asignadas
                ListViewItem nuevoItem = new ListViewItem(hdr.n_hdr.ToString());

                nuevoItem.SubItems.Add(hdr.fletero);
                nuevoItem.SubItems.Add(hdr.estado);
                nuevoItem.SubItems.Add(hdr.fecha.ToString("dd/MM/yyyy"));
                nuevoItem.SubItems.Add(hdr.tipo);
                nuevoItem.SubItems.Add(hdr.cumplida);

                nuevoItem.Tag = hdr;

                listview_hdr_asignadas.Items.Add(nuevoItem);

                itemsAMover.Add(item);
            }

            // Eliminar de HDR Rendidas
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
                // Actualizo el objeto
                hdr.cumplida = "";
                hdr.estado = "Asignada";
                // Creo el item para la lista de asignadas
                ListViewItem nuevoItem = new ListViewItem(hdr.n_hdr.ToString());
                nuevoItem.SubItems.Add(hdr.fletero);
                nuevoItem.SubItems.Add(hdr.estado);
                nuevoItem.SubItems.Add(hdr.fecha.ToString("dd/MM/yyyy"));
                nuevoItem.SubItems.Add(hdr.tipo);
                nuevoItem.SubItems.Add(hdr.cumplida);
                nuevoItem.Tag = hdr;
                listview_hdr_asignadas.Items.Add(nuevoItem);
            }
            listview_hdr_rendidas.Items.Clear();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count == 0)
            {
                MessageBox.Show("No hay HDR rendidas para confirmar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> hdr_rendidas = new();
            string fletero = cbox_fletero.Text;

            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRultimaMilla hdr = (HDRultimaMilla)item.Tag;
                // Aquí podrías agregar la lógica para guardar los cambios en una base de datos o realizar otras acciones necesarias.
                hdr_rendidas.Add(hdr.n_hdr);
                Console.WriteLine($"HDR {hdr.n_hdr} - Fletero: {hdr.fletero}, Estado: {hdr.estado}, Tipo: {hdr.tipo}, Cumplida: {hdr.cumplida}");
            }

            MessageBox.Show($"Se han confirmado {hdr_rendidas.Count} HDR rendidas. Del fletero '{fletero}'", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar las listas y los filtros después de confirmar
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
            if(listview_hdr_rendidas.Items.Count > 0)
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
