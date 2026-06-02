using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tutasa.EmisionHojasRutaTransporte
{
    public partial class EmisionHojasRutaTransporte : Form
    {
        // Modelo que contiene los datos y lógica de negocio
        private EmisionHojasRutaTransporteModelo modelo =
            new EmisionHojasRutaTransporteModelo();

        public EmisionHojasRutaTransporte()
        {
            InitializeComponent();
        }

        private void EmisionHojasRutaTransporte_Load(
            object sender,
            EventArgs e)
        {
            // Cargar empresas al iniciar pantalla

            ComboEmpresa.Items.Clear();

            foreach (string empresa
                in modelo.ObtenerEmpresas())
            {
                ComboEmpresa.Items.Add(
                    empresa);
            }
        }

        private void ComboEmpresa_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Cargar servicios de la empresa seleccionada

            ComboServicio.Items.Clear();
            ComboServicio.Text = "";


            if (ComboEmpresa.SelectedItem == null)
            {
                return;
            }

            string empresa = ComboEmpresa.SelectedItem.ToString();

            foreach (string servicio in modelo.ObtenerServicios(empresa))
            {
                ComboServicio.Items.Add(servicio);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Validar filtros obligatorios

            if (ComboEmpresa.SelectedItem == null
                || ComboServicio.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar empresa y servicio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string empresa = ComboEmpresa.SelectedItem.ToString();

            string servicio = ComboServicio.SelectedItem.ToString();

            // Limpiar resultados anteriores

            ListViewRutasPendientes.Items.Clear();

            ListViewGuias.Items.Clear();

            // Buscar HDR pendientes

            List<EmisionHojasRutaTransporteModelo.HojaRutaTransporte> hdrs = modelo.BuscarHDRPendientes(empresa, servicio);

            if (hdrs.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR Pendientes para los criterios de búsqueda seleccionados.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Mostrar HDR encontradas

            foreach (EmisionHojasRutaTransporteModelo.HojaRutaTransporte hdr in hdrs)
            {
                ListViewItem item = new ListViewItem(hdr.Numero);

                item.SubItems.Add(hdr.Empresa);

                item.SubItems.Add(hdr.Servicio);

                item.SubItems.Add(modelo.ObtenerGuiasHDR(hdr.Numero).Count.ToString());

                // Guardamos la HDR real
                item.Tag = hdr;

                ListViewRutasPendientes.Items.Add(item);
            }
        }

        private void ListViewRutasPendientes_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Mostrar detalle de guías
            // asociadas a las HDR seleccionadas

            ListViewGuias.Items.Clear();

            foreach (ListViewItem itemHDR in ListViewRutasPendientes.SelectedItems)
            {
                EmisionHojasRutaTransporteModelo.HojaRutaTransporte hdr = (EmisionHojasRutaTransporteModelo.HojaRutaTransporte)itemHDR.Tag;

                List<EmisionHojasRutaTransporteModelo.Guia> guias = modelo.ObtenerGuiasHDR(hdr.Numero);

                foreach (EmisionHojasRutaTransporteModelo.Guia guia in guias)
                {
                    ListViewItem fila = new ListViewItem(guia.Numero);

                    fila.SubItems.Add(guia.Cliente);

                    fila.SubItems.Add(guia.Direccion);


                    fila.SubItems.Add(guia.Dimension);

                    fila.Tag = guia;

                    ListViewGuias.Items.Add(fila);
                }
            }
        }

        private void BotonSeleccionar_Click(object sender, EventArgs e)
        {
            // Seleccionar todas las HDR

            if (ListViewRutasPendientes.Items.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR seleccionadas.",
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
            // Deseleccionar todas las HDR

            foreach (ListViewItem item in ListViewRutasPendientes.Items)
            {
                item.Selected = false;
            }

            ListViewGuias.Items.Clear();
        }

        private void BtnEmitirHojasRuta_Click(object sender, EventArgs e)
        {
            // Validar selección

            if (ListViewRutasPendientes.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR seleccionadas.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string mensaje = "EMISIÓN DE HOJAS DE RUTA\n\n";

            foreach (ListViewItem item in ListViewRutasPendientes.SelectedItems)
            {
                EmisionHojasRutaTransporteModelo.HojaRutaTransporte hdr = (EmisionHojasRutaTransporteModelo.HojaRutaTransporte)item.Tag;

                // Emitir HDR

                modelo.EmitirHDR(hdr.Numero);

                mensaje += "====================================\n";
                mensaje += "Hoja de Ruta: " + hdr.Numero + "\n";
                mensaje += "Empresa: " + hdr.Empresa + "\n";
                mensaje += "Servicio: " + hdr.Servicio + "\n\n";

                mensaje += "Detalle de Guías:\n\n";

                List<EmisionHojasRutaTransporteModelo.Guia> guias = modelo.ObtenerGuiasHDR(hdr.Numero);

                foreach (EmisionHojasRutaTransporteModelo.Guia guia in guias)
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

        private void BtnImprimirResumen_Click(
    object sender,
    EventArgs e)
        {
            // Validar selección

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
                "RESUMEN DE HOJAS DE RUTA\n\n";

            foreach (ListViewItem item in ListViewRutasPendientes.SelectedItems)
            {
                EmisionHojasRutaTransporteModelo.HojaRutaTransporte hdr =
                    (EmisionHojasRutaTransporteModelo.HojaRutaTransporte)item.Tag;

                // Emitir HDR

                modelo.EmitirHDR(
                    hdr.Numero);

                // Actualizar estado de guías

                modelo.ActualizarEstadoGuias(
                    hdr.Numero);

                List<EmisionHojasRutaTransporteModelo.Guia> guias =
                    modelo.ObtenerGuiasHDR(
                        hdr.Numero);

                mensaje += "====================================\n";
                mensaje += "Hoja de Ruta: " + hdr.Numero + "\n";
                mensaje += "Empresa: " + hdr.Empresa + "\n";
                mensaje += "Servicio: " + hdr.Servicio + "\n";
                mensaje += "Cantidad de Guías: " + guias.Count + "\n\n";
            }

            MessageBox.Show(
                mensaje,
                "Resumen Impreso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BotonCancelar_Click(
            object sender,
            EventArgs e)
        {
            // Limpiar formulario

            ComboEmpresa.SelectedIndex = -1;

            ComboServicio.Items.Clear();

            ComboServicio.SelectedIndex = -1;

            ListViewRutasPendientes.Items.Clear();

            ListViewGuias.Items.Clear();


        }

        private void ComboServicio_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void ListViewGuias_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void LbServicio_Click(
            object sender,
            EventArgs e)
        {
        }

        private void LbEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}