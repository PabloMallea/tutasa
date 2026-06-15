using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static tutasa.RendicionHDRtransporte.RendicionHDRtransporteModelo;

namespace tutasa.RendicionHDRtransporte
{
    public partial class RendicionHDRtransporte : Form
    {
        public RendicionHDRtransporte()
        {
            InitializeComponent();
        }


        private RendicionHDRtransporteModelo modelo = new RendicionHDRtransporteModelo();

        private void RendicionHDRtransporte_Load(object sender, EventArgs e)
        {
            // Simulación de usuario logueado

            label_cd.Text = modelo.ObtenerCDActual(modelo.IdCdActual);


            List<string> empresas = modelo.ObtenerEmpresas();

            foreach (string empresa in empresas)
            {
                cbox_empresa.Items.Add(empresa);
            }


            listview_hdr_emitidas.MultiSelect = true;
            listview_hdr_rendidas.MultiSelect = true;

            listview_hdr_emitidas.FullRowSelect = true;
            listview_hdr_rendidas.FullRowSelect = true;
        }

        private void cbox_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_servicio.Items.Clear();
            cbox_servicio.SelectedIndex = -1;

            if (cbox_empresa.SelectedIndex != -1)
            {
                string nombreEmpresa = cbox_empresa.SelectedItem.ToString();

                List<string> serviciosFiltrados = modelo.ObtenerServiciosPorEmpresa(nombreEmpresa);

                foreach (string servicio in serviciosFiltrados)
                {
                    cbox_servicio.Items.Add(servicio);
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbox_empresa.Text))
            {
                MessageBox.Show(
                    "Por favor, seleccione o ingrese una empresa.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cbox_servicio.SelectedItem == null)
            {
                MessageBox.Show(
                    "Por favor, seleccione un servicio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string nombreServicio = cbox_servicio.SelectedItem.ToString();

            List<HDRtransporte> resultadosFiltrados = modelo.ObtenerHdrTransporteEmitidas(nombreServicio);

            if (resultadosFiltrados.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron resultados.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            cbox_empresa.Enabled = false;

            foreach (HDRtransporte hdr in resultadosFiltrados)
            {
                bool yaExisteEnEmitidas = false;

                foreach (ListViewItem existingItem in listview_hdr_emitidas.Items)
                {
                    HDRtransporte hdrExistente = (HDRtransporte)existingItem.Tag;

                    if (hdrExistente.NumeroHdrTransporte == hdr.NumeroHdrTransporte)
                    {
                        yaExisteEnEmitidas = true;
                        break;
                    }
                }

                bool yaExisteEnRendidas = false;

                foreach (ListViewItem rendidasItem in listview_hdr_rendidas.Items)
                {
                    HDRtransporte hdrExistente = (HDRtransporte)rendidasItem.Tag;

                    if (hdrExistente.NumeroHdrTransporte == hdr.NumeroHdrTransporte)
                    {
                        yaExisteEnRendidas = true;
                        break;
                    }
                }

                if (!yaExisteEnEmitidas && !yaExisteEnRendidas)
                {
                    listview_hdr_emitidas.Items.Add(CrearItemHDR(hdr));
                }
            }
        }

        private ListViewItem CrearItemHDR(HDRtransporte hdr)
        {
            ListViewItem item = new ListViewItem(hdr.NumeroHdrTransporte.ToString());

            item.SubItems.Add(hdr.NombreEmpresa);

            item.SubItems.Add(hdr.EstadoHdr);

            item.SubItems.Add(hdr.Servicio.NombreServicio);

            item.Tag = hdr;

            return item;
        }

        private void btn_agregar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasArendicion();
        }

        private void btn_agregar_todo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_hdr_emitidas.Items)
            {
                item.Selected = true;
            }

            MoverHDRSeleccionadasArendicion();
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasAEmitidas();
        }

        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                item.Selected = true;
            }

            MoverHDRSeleccionadasAEmitidas();
        }

        private void MoverHDRSeleccionadasArendicion()
        {
            if (listview_hdr_emitidas.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una HDR.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_emitidas.SelectedItems)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdr.EstadoHdr = "Rendida";

                listview_hdr_rendidas.Items.Add(CrearItemHDR(hdr));

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_emitidas.Items.Remove(item);
            }
        }

        private void MoverHDRSeleccionadasAEmitidas()
        {
            if (listview_hdr_rendidas.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una HDR.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_rendidas.SelectedItems)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdr.EstadoHdr = "Emitida";

                listview_hdr_emitidas.Items.Add(CrearItemHDR(hdr));

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_rendidas.Items.Remove(item);
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count == 0)
            {
                MessageBox.Show(
                    "No hay HDR rendidas para confirmar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<HDRtransporte> hdrRendidas = new();

            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdrRendidas.Add(hdr);
            }

            bool resultadoConfirmacion = modelo.ActualizarEstadoHDR(hdrRendidas);

            if (!resultadoConfirmacion)
            {
                MessageBox.Show(
                    "Ocurrió un error al confirmar la rendición.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                $"Se confirmaron {hdrRendidas.Count} HDR.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            limpiarCampos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea cancelar? Se perderán los cambios no confirmados.",
                    "Confirmación de Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            MessageBox.Show(
                "Cerrará la pantalla de rendición HDR Transporte.",
                "Cancelación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void btn_limpiar_campos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            cbox_empresa.Enabled = true;

            cbox_empresa.SelectedIndex = -1;

            cbox_servicio.SelectedIndex = -1;
            cbox_servicio.Text = "";
            cbox_servicio.Items.Clear();

            listview_hdr_emitidas.Items.Clear();
            listview_hdr_rendidas.Items.Clear();
        }
    }
}

