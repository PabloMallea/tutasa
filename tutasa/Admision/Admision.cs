using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tutasa.Admision
{
    public partial class Admision : Form
    {

        public Admision()
        {
            InitializeComponent();
        }

        private AdmisionModelo modelo = new();

        private void Admision_Load(object sender, EventArgs e)
        {
            // Limpio todos los campos al cargar la pantalla
            txtNombreRemitente.Text = "";
            txtCUITCliente.Text = "";
            txtNGuia.Text = "";
            txtNombreDestinatario.Text = "";
            txtDireccionDestino.Text = "";
            txtDimension.Text = "";
            txtFleteroAsignado.Text = "";
            intPeso.Text = "";


        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(intNroGuia.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un número de guía válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos mockeados del modelo
            modelo = AdmisionModelo.ObtenerDatosMock();

            // Simular validación del número de guía ingresado con el del modelo
            if (intNroGuia.Text == modelo.NumeroGuia)
            {
                // Cargar los campos con los datos del modelo
                txtNombreRemitente.Text = modelo.NombreRemitente;
                txtCUITCliente.Text = modelo.DireccionOrigen;
                txtNGuia.Text = modelo.CPOrigen;

                txtNombreDestinatario.Text = modelo.NombreDestinatario;
                txtDireccionDestino.Text = modelo.DireccionDestino;
                txtCPdestino.Text = modelo.CPDestino;

                txtFleteroAsignado.Text = modelo.FleteroAsignado;

                txtDimension.Text = modelo.DimensionSeleccionada;

                intPeso.Text = modelo.Peso.ToString();
                intAlto.Text = modelo.Alto.ToString();
                intAncho.Text = modelo.Ancho.ToString();
                intLargo.Text = modelo.Largo.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró ninguna guía con ese número.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GrupoDatosGuia_Enter(object sender, EventArgs e)
        {

        }
    }
}

