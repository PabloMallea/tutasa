namespace tutasa.EntregaEncomienda
{
    public enum TipoEntrega
    {
        Agencia,
        CentroDeDistribucion
    }

    public partial class EntregaEncomienda : Form
    {
        // NO se toca!!
        public EntregaEncomienda()
        {
            InitializeComponent();
        }

        private TipoEntrega tipoEntrega;

        public EntregaEncomienda(TipoEntrega tipo) : this()
        {
            tipoEntrega = tipo;
        }

        // Instancia del modelo de entrega de encomienda
        private EntregaEncomiendaModelo modelo = new EntregaEncomiendaModelo();

        private void EntregaEncomienda_Load(object sender, EventArgs e)
        {
            lvDetalle.FullRowSelect = true;
            lvDetalle.MultiSelect = false;

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
                MessageBox.Show("El campo Nº Guía debe ser completado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResultadoBusqueda resultado = modelo.BuscarGuia(nroGuia, tipoEntrega, out Guia? guia);

            if (resultado == ResultadoBusqueda.NoExiste)
            {
                MessageBox.Show("El Nº Guía ingresado no corresponde a una guía registrada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroGuia.Clear();
                return;
            }

            if (resultado == ResultadoBusqueda.EstadoInvalido)
            {
                MessageBox.Show("El Nº Guía ingresado no se encuentra en un estado válido para la entrega.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroGuia.Clear();
                return;
            }

            // Verificar si la guía ya fue cargada en el detalle
            bool yaExiste = false;
            foreach (ListViewItem itemExistente in lvDetalle.Items)
            {
                Guia guiaExistente = (Guia)itemExistente.Tag;
                if (guiaExistente.NroGuia == guia!.NroGuia)
                {
                    yaExiste = true;
                    break;
                }
            }

            if (yaExiste)
            {
                MessageBox.Show("La guía ya fue cargada en el detalle.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroGuia.Clear();
                return;
            }

            // Autocompleta el ListView con los datos de la guía encontrada
            ListViewItem item = new ListViewItem(guia!.Cliente);
            item.Tag = guia;
            item.SubItems.Add(guia.Destinatario);
            item.SubItems.Add(guia.DniDestinatario);
            lvDetalle.Items.Add(item);

            txtNumeroGuia.Clear();
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            if (lvDetalle.Items.Count == 0)
            {
                MessageBox.Show("No hay guías cargadas para confirmar la entrega.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modelo.ActualizarEstadoEntregada(txtNumeroGuia.Text.Trim(), tipoEntrega);

            MessageBox.Show("Entrega confirmada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNumeroGuia.Clear();
            lvDetalle.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumeroGuia.Clear();
            lvDetalle.Items.Clear();
        }
    }
}