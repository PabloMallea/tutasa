using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using tutasa.Imposicion;

namespace imposicion
{

    public partial class Imposicion : Form
    {
        //NO se toca!!
        public Imposicion()
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
            var tipoimposicion = modelo.TipoImposicion;
            var dimension = modelo.Dimension;

            ComboDestino.DisplayMember = "Descripcion";
            ComboDestino.Items.Clear();

            ComboTipoImposicion.DisplayMember = "Descripcion";
            ComboTipoImposicion.Items.Clear();

            ComboDimension.DisplayMember = "Descripcion";
            ComboDimension.Items.Clear();

            foreach (var item in destino)
            {
                ComboDestino.Items.Add(item);
            }

            foreach (var item in tipoimposicion)
            {
                ComboTipoImposicion.Items.Add(item);
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
    }
}
