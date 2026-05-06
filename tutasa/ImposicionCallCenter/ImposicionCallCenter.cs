namespace tutasa.ImposicionCallCenter
{

    public partial class ImposicionCallCenter : Form
    {
        //NO se toca!!
        public ImposicionCallCenter()
        {
            InitializeComponent();

        }

        // Instancia del modelo de imposición
        private ImposicionCallCenterModelo modelo = new ImposicionCallCenterModelo();
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

    }
}
