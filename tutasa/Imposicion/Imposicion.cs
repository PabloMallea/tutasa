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
            // 1ero Valido y luego hago el codigo
            // hago las validaciones minimas, y luego en el modelo hago mi funcion Validar 

            // Aquí puedes agregar la lógica para confirmar la imposición
            MessageBox.Show("Imposición confirmada.");
        }

        private void Imposicion_Load(object sender, EventArgs e)
        {

        }
    }
}
