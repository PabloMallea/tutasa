using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tutasa.Almacenes;
using static System.Net.WebRequestMethods;

namespace tutasa.EmisionHojasRuta
{
    public partial class EmisonHojasRuta : Form
    {
        private EmisionHojasRutaModelo modelo =
            new EmisionHojasRutaModelo();

        public EmisonHojasRuta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboFletero.Items.Clear();

            foreach (EmisionHojasRutaModelo.Fletero fletero in modelo.ObtenerFleteros())
            {
                ComboFletero.Items.Add(fletero.Nombre);
            }

            ComboTipo.Items.Clear();

            ComboTipo.Items.Add("Distribución");

            ComboTipo.Items.Add("Retiro");
        }

        private void ComboFletero_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (ComboFletero.SelectedItem == null
                || ComboTipo.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar fletero y tipo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            EmisionHojasRutaModelo.Fletero fletero =modelo.ObtenerFleteros()[ComboFletero.SelectedIndex];

            string tipo = ComboTipo.SelectedItem.ToString();

            List<EmisionHojasRutaModelo.HojaRuta> hdrs =modelo.BuscarHDRPendientes(fletero.IdFletero, tipo);

            if (hdrs.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR pendientes.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            foreach (
                EmisionHojasRutaModelo.HojaRuta hdr in hdrs)
            {
                ListViewItem item = new ListViewItem(hdr.NumeroHDR.ToString());
                item.SubItems.Add(hdr.Tipo);

                item.SubItems.Add(hdr.Fletero);



                item.SubItems.Add(hdr.Direccion);

                item.SubItems.Add(modelo.ObtenerGuiasHDR(hdr.NumeroHDR).Count.ToString());

                item.Tag = hdr;

                ListViewRutasPendientes.Items.Add(item);
            }
        }

        private void ListViewRutasPendientes_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ListViewGuias.Items.Clear();

            foreach (ListViewItem itemHDR in ListViewRutasPendientes.SelectedItems)
            {
                EmisionHojasRutaModelo.HojaRuta hdr = (EmisionHojasRutaModelo.HojaRuta)itemHDR.Tag;

                List<EmisionHojasRutaModelo.Guia> guias =modelo.ObtenerGuiasHDR(hdr.NumeroHDR);

                foreach (EmisionHojasRutaModelo.Guia guia in guias)
                {
                    ListViewItem fila = new ListViewItem(guia.Numero.ToString());

                    fila.SubItems.Add(guia.Cliente);

                    fila.SubItems.Add(guia.Direccion);

                    fila.SubItems.Add(hdr.Tipo);

                    fila.SubItems.Add(guia.Dimension);

                    fila.Tag = guia;

                    ListViewGuias.Items.Add(fila);
                }
            }
        }

        private void BtnSeleccionarTodas_Click(
            object sender,
            EventArgs e)
        {
            if (ListViewRutasPendientes.Items.Count == 0)
            {
                MessageBox.Show(
                    "No existen HDR para seleccionar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            foreach (ListViewItem item in ListViewRutasPendientes.Items)
            {
                item.Selected = true;
            }
        }

        private void BtnDeseleccionar_Click(object sender, EventArgs e)
        {
            foreach (
                ListViewItem item
                in ListViewRutasPendientes.Items)
            {
                item.Selected = false;
            }

            ListViewGuias.Items.Clear();
        }

        private void BtnEmitirHojasRuta_Click(object sender, EventArgs e)
        {
            if (ListViewRutasPendientes.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR seleccionadas.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string mensaje =
                "EMISIÓN DE HOJAS DE RUTA\n\n";

            foreach (ListViewItem item in ListViewRutasPendientes.SelectedItems)
            {
                EmisionHojasRutaModelo.HojaRuta hdr = (EmisionHojasRutaModelo.HojaRuta)item.Tag;

                modelo.EmitirHDR(hdr.NumeroHDR);
                modelo.ActualizarEstadoGuias(hdr.NumeroHDR);
                hdr.Estado = "Emitida";

                mensaje +=
                    "====================================\n";

                mensaje +=
                    "Hoja de Ruta: " +
                    hdr.NumeroHDR + "\n";

                mensaje +=
                    "Tipo: " +
                    hdr.Tipo + "\n";

                mensaje +=
                    "Fletero: " +
                    hdr.Fletero + "\n\n";

                mensaje +=
                    "Detalle de Guías:\n\n";

                List<EmisionHojasRutaModelo.Guia> guias = modelo.ObtenerGuiasHDR(hdr.NumeroHDR);

                foreach (EmisionHojasRutaModelo.Guia guia in guias)
                {
                    mensaje += "Número: " + guia.Numero + "\n";

                    mensaje += "Cliente: " + guia.Cliente + "\n";

                    mensaje += "Dirección: " + guia.Direccion + "\n\n";

                }
            }

            MessageBox.Show(
                mensaje,
                "Emisión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnImprimirResumen_Click(object sender, EventArgs e)
        {
            if (ListViewRutasPendientes.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR seleccionadas.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            foreach(ListViewItem item in ListViewRutasPendientes.SelectedItems)
              {
                EmisionHojasRutaModelo.HojaRuta hdr =(EmisionHojasRutaModelo.HojaRuta)item.Tag;

                if (hdr.Estado != "Emitida")
                {
                    MessageBox.Show(
                        "Todas las hojas de ruta seleccionadas deben estar emitidas antes de imprimir el resumen.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            
        }

            string mensaje = "RESUMEN DE HOJAS DE RUTA\n\n";

            foreach (ListViewItem item in ListViewRutasPendientes.SelectedItems)
            {
                EmisionHojasRutaModelo.HojaRuta hdr = (EmisionHojasRutaModelo.HojaRuta)item.Tag;

             

                List<EmisionHojasRutaModelo.Guia> guias = modelo.ObtenerGuiasHDR(hdr.NumeroHDR);

                mensaje += "====================================\n";

                mensaje += "Hoja de Ruta: " + hdr.NumeroHDR + "\n";

                mensaje += "Tipo: " + hdr.Tipo + "\n";

                mensaje += "Fletero: " + hdr.Fletero + "\n";

                mensaje += "Cantidad de Guías: " + guias.Count + "\n";

                mensaje += "Dirección: " + hdr.Direccion + "\n\n";
            }

            MessageBox.Show(
                mensaje,
                "Resumen Impreso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ComboFletero.SelectedIndex = -1;

            ComboTipo.SelectedIndex = -1;

            ListViewRutasPendientes.Items.Clear();

            ListViewGuias.Items.Clear();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            ComboFletero.SelectedIndex = -1;

            ComboTipo.SelectedIndex = -1;

            ListViewRutasPendientes.Items.Clear();

            ListViewGuias.Items.Clear();
        }
    }
}