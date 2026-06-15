

namespace tutasa.ResultadosCostos
{
    public partial class ResultadoCostos : Form
    {
        private ResultadoCostosModelo modelo = new ResultadoCostosModelo();
        public ResultadoCostos()
        {
            InitializeComponent();
            List<string> empresas = modelo.ObtenerEmpresasTransporte();
            CargarMeses();
            CargarAnios();



            cmbEmpresa.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbAnio.SelectedIndex = -1;

            txtVentasMes.Text = "$0";
            txtCostoMensual.Text = "$0";
            txtMargen.Text = "0%";
            txtResultado.Text = "$0";

            foreach (string empresa in empresas)
            {
                cmbEmpresa.Items.Add(empresa);
            }

        }



        private void CargarMeses()
        {
            cmbMes.DataSource =
                new List<string>
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10",
                    "11",
                    "12"
                };
        }

        private void CargarAnios()
        {
            cmbAnio.DataSource =
                new List<string>
                {
                    "2024",
                    "2025",
                    "2026"
                };
        }


        // BOTON BUSCAR

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validaciones obligatorias

            if (cmbEmpresa.SelectedItem == null ||
                cmbMes.SelectedItem == null ||
                cmbAnio.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe completar todos los criterios de búsqueda para continuar",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEmpresa.SelectedIndex = -1;
                cmbMes.SelectedIndex = -1;
                cmbAnio.SelectedIndex = -1;

                dgvGuias.Items.Clear();

                txtVentasMes.Text = "";
                txtCostoMensual.Text = "";
                txtMargen.Text = "";
                txtResultado.Text = "";

                return;
            }



            string empresa =
                cmbEmpresa.SelectedItem.ToString();

            int mes =
                Convert.ToInt32(
                    cmbMes.SelectedItem.ToString());

            int anio =
                Convert.ToInt32(
                    cmbAnio.SelectedItem.ToString());

            // BUSCAR GUIAS

            List<Guia> guias = modelo.ObtenerGuias(empresa, mes, anio);


            // LIMPIAR LISTVIEW

            dgvGuias.Items.Clear();


            // CARGAR LISTVIEW


            foreach (Guia guia in guias)
            {
                ListViewItem item =
                    new ListViewItem(guia.NumeroGuia.ToString());

                item.SubItems.Add(
                    guia.Dimension);

                item.SubItems.Add(
                    guia.ImporteGuia.ToString("C"));

                dgvGuias.Items.Add(item);
            }

            // CALCULOS
            // =========================

            decimal ventasMes =
                guias.Sum(g => g.ImporteGuia);

            decimal costoMensual =
                modelo.ObtenerCostoMensual(
                    empresa);

            decimal resultado =
                ventasMes - costoMensual;

            decimal margen = 0;

            if (ventasMes > 0)
            {
                margen =
                    ((ventasMes - costoMensual)
                    / ventasMes) * 100;
            }


            // MOSTRAR RESULTADOS


            txtVentasMes.Text =
                ventasMes.ToString("C");

            txtCostoMensual.Text =
                costoMensual.ToString("C");

            txtMargen.Text =
                margen.ToString("0.00") + "%";

            txtResultado.Text =
                resultado.ToString("C");
        }

        // BOTON CONFIRMAR
        // =========================

        private void btnConfirmar_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Consulta realizada correctamente",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            cmbEmpresa.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbAnio.SelectedIndex = -1;

            dgvGuias.Items.Clear();

            txtVentasMes.Text = "";
            txtCostoMensual.Text = "";
            txtMargen.Text = "";
            txtResultado.Text = "";
        }

        // =========================
        // BOTON CANCELAR
        // =========================

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            cmbEmpresa.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbAnio.SelectedIndex = -1;

            dgvGuias.Items.Clear();

            txtVentasMes.Text = "";
            txtCostoMensual.Text = "";
            txtMargen.Text = "";
            txtResultado.Text = "";

            this.Close();
        }
    }
}


