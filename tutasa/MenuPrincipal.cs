using tutasa.RuteoTransporte;

namespace tutasa;

public partial class MenuPrincipal : Form
{
    public MenuPrincipal()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new FormRuteoTransporte().ShowDialog();
    }

    private void MenuPrincipal_Load(object sender, EventArgs e)
    {
        //cargas comboBox1 con los cds.
        //comboBox1.Items.Add ...
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Estableces Program.IdCDActual al valor del combo.
        Program.IdCDActual = 1;
    }
}
