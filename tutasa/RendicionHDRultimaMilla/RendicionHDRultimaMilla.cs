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
            listview_hdr_asignadas.Items.Clear();

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
            
            if(resultadosFiltrados.Count == 0)
                {
                   MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            foreach (var hdr in resultadosFiltrados)
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
}
