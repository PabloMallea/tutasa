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
        // Buscamos en la base de datos el CD que coincide con el ID fijo de Program.cs
        var cdActual = tutasa.Almacenes.CentroDistribucionAlmacen.CentrosDistribucion
            .FirstOrDefault(cd => cd.IdCD == Program.IdCDActual);

        if (cdActual != null)
        {
            // Dibujamos SOLO el nombre, porque tu diseño ya tiene el texto "CD Actual:"
            LabelCDActual.Text = cdActual.NombreCD;
        }
        else
        {
            LabelCDActual.Text = "No encontrado";
        }
    }

    private void ImposiciónEnAgenciaBtn_Click(object sender, EventArgs e)
    {
        new tutasa.Imposicion_Agencia.Imposicion_Agencia().ShowDialog();
    }

    private void ImposicionEnCallCenterBtn_Click(object sender, EventArgs e)
    {
        new tutasa.ImposicionCallCenter.ImposicionCallCenter().ShowDialog();
    }

    private void ImposicionEnCDBtn_Click(object sender, EventArgs e)
    {
        new tutasa.Imposicion_CD.Impiscion_CD().ShowDialog();
    }

    private void AdmisionBtn_Click(object sender, EventArgs e)
    {
        new tutasa.Admision.Admision().ShowDialog();
    }

    private void RuteoUltimaMillaBtn_Click(object sender, EventArgs e)
    {
        new tutasa.RuteoUltimaMilla.RuteoUltimaMilla().ShowDialog();
    }

    private void EmisionUltimaMillaBtn_Click(object sender, EventArgs e)
    {
        new tutasa.EmisionHojasRuta.EmisonHojasRuta().ShowDialog();
    }

    private void RendicionUltimaMillaBtn_Click(object sender, EventArgs e)
    {
        new tutasa.RendicionHDRultimaMilla.RendicionHDRultimaMilla().ShowDialog();
    }

    private void EmisionTransporteBtn_Click(object sender, EventArgs e)
    {
        new tutasa.EmisionHojasRutaTransporte.EmisionHojasRutaTransporte().ShowDialog();
    }

    private void RendicionTransporteBtn_Click(object sender, EventArgs e)
    {
        new tutasa.RendicionHDRtransporte.RendicionHDRtransporte().ShowDialog();
    }

    private void EntregaEncomiendaBtn_Click(object sender, EventArgs e)
    {
        new tutasa.EntregaEncomienda.EntregaEncomienda().ShowDialog();
    }

    private void ConsultaEstadoBtn_Click(object sender, EventArgs e)
    {
        new tutasa.ConsultaEstadoInterna.ConsultaEstadoInterna().ShowDialog();
    }

    private void CuentaCorrienteBtn_Click(object sender, EventArgs e)
    {
        new tutasa.CuentaCorriente.CuentaCorriente().ShowDialog();
    }

    private void EmitirFacturaBtn_Click(object sender, EventArgs e)
    {
        new tutasa.EmitirFactura.EmitirFactura().ShowDialog();
    }

    private void RdoCostosVsVentasBtn_Click(object sender, EventArgs e)
    {
        new tutasa.ResultadosCostos.ResultadoCostos().ShowDialog();
    }
}
