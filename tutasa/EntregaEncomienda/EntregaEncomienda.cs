namespace tutasa.EntregaEncomienda
{
    public partial class EntregaEncomienda : Form
    {
        // NO se toca!!
        public EntregaEncomienda()
        {
            InitializeComponent();
        }

        // Instancia del modelo de entrega de encomienda
        private EntregaEncomiendaModelo modelo = new EntregaEncomiendaModelo();

        private void EntregaEncomienda_Load(object sender, EventArgs e)
        {
            // Configura las columnas del ListView Detalle de Guía
            lvDetalle.Columns.Clear();
            lvDetalle.Columns.Add("Cliente", "Cliente", 200);
            lvDetalle.Columns.Add("Destinatario", "Destinatario", 200);
            lvDetalle.Columns.Add("DniDestinatario", "DNI Destinatario", 150);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nroGuia = txtNumeroGuia.Text.Trim();

            if (string.IsNullOrEmpty(nroGuia))
            {
                MessageBox.Show("El campo Nº Guía debe ser completado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guia? guia = modelo.BuscarGuia(nroGuia);

            if (guia == null)
            {
                MessageBox.Show("El Nº Guía ingresado no corresponde a una guía registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroGuia.Clear();
                return;
            }

            // Autocompleta el ListView con los datos de la guía encontrada
            lvDetalle.Items.Clear();
            var item = new ListViewItem(guia.Cliente);
            item.SubItems.Add(guia.Destinatario);
            item.SubItems.Add(guia.DniDestinatario);
            lvDetalle.Items.Add(item);
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrega confirmada.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumeroGuia.Clear();
            lvDetalle.Items.Clear();
        }
    }
}