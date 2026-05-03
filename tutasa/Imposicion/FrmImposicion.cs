namespace tutasa.Imposicion
{

    public partial class FrmImposicion : Form
    {
        //NO se toca!!
        public FrmImposicion()
        {
            InitializeComponent();

        }

        // Instancia del modelo de imposición
        private ImposicionModelo modelo = new ImposicionModelo();
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imposición confirmada.");
        }

        private void Imposicion_Load(object sender, EventArgs e)
        {
            var destino = modelo.Destino;
            var dimension = modelo.Dimension;

            ComboDestino.DisplayMember = "Descripcion";
            ComboDestino.Items.Clear();

            ComboDimension.DisplayMember = "Descripcion";
            ComboDimension.Items.Clear();

            foreach (var item in destino)
            {
                ComboDestino.Items.Add(item);
            }

            foreach (var item in dimension)
            {
                ComboDimension.Items.Add(item);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void LabelCliente_Click(object sender, EventArgs e)
        {

        }

        private void LabelDestino_Click(object sender, EventArgs e)
        {

        }
    }
}
