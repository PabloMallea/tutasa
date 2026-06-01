using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            label_cd.Text = "Buenos Aires";

            List<string> empresas = modelo.empresas;
            foreach (string empresa in empresas)
            {
                cbox_empresa.Items.Add(empresa);
            }

            listview_hdr_asignadas.MultiSelect = true;
            listview_hdr_rendidas.MultiSelect = true;

            listview_hdr_asignadas.FullRowSelect = true;
            listview_hdr_rendidas.FullRowSelect = true;
        }

        private void cbox_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_servicio.Items.Clear();
            cbox_servicio.SelectedIndex = -1;

            if (cbox_empresa.SelectedIndex != -1)
            {
                string empresaSeleccionada = cbox_empresa.SelectedItem.ToString();

                List<Servicio> serviciosFiltrados = modelo.servicios.Where(s => s.empresa.Equals(empresaSeleccionada, StringComparison.OrdinalIgnoreCase)).ToList();

                foreach (Servicio servicio in serviciosFiltrados)
                {
                    string servicioTexto = $"{servicio.cd_destino} - {servicio.horario_llegada}";
                    cbox_servicio.Items.Add(servicioTexto);
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbox_empresa.Text))
            {
                MessageBox.Show("Por favor, seleccione o ingrese una empresa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbox_servicio.SelectedItem == null || string.IsNullOrWhiteSpace(cbox_servicio.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un servicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RendicionHDRtransporteModelo resultado = RendicionHDRtransporteModelo.ObtenerMockHDRAsignadas();

            List<HDRtransporte> resultadosFiltrados = resultado.HDRtransporteList.Where(
                    hdr => hdr.servicio.empresa.Equals(cbox_empresa.Text, StringComparison.OrdinalIgnoreCase)
                    &&
                    $"{hdr.servicio.cd_destino} - {hdr.servicio.horario_llegada}".Equals(cbox_servicio.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultadosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cbox_empresa.Enabled = false;

            foreach (var hdr in resultadosFiltrados)
            {
                bool yaExisteEnAsignadas = false;
                foreach (ListViewItem existingItem in listview_hdr_asignadas.Items)
                {
                    if (existingItem.Text == hdr.n_hdr.ToString())
                    {
                        yaExisteEnAsignadas = true;
                        break;
                    }
                }

                bool yaExisteEnRendidas = false;
                foreach (ListViewItem rendidasItem in listview_hdr_rendidas.Items)
                {
                    if (rendidasItem.Text == hdr.n_hdr.ToString())
                    {
                        yaExisteEnRendidas = true;
                        break;
                    }
                }

                if (!yaExisteEnAsignadas && !yaExisteEnRendidas)
                {
                    var item = new ListViewItem(hdr.n_hdr.ToString());

                    item.SubItems.Add(hdr.servicio.empresa);
                    item.SubItems.Add(hdr.estado);
                    item.SubItems.Add($"{hdr.servicio.cd_destino} - {hdr.servicio.horario_llegada}");

                    item.Tag = hdr;

                    listview_hdr_asignadas.Items.Add(item);
                }
            }
        }

        private void btn_agregar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasArendicion();
        }

        private void btn_agregar_todo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_hdr_asignadas.Items)
            {
                item.Selected = true;
            }
            MoverHDRSeleccionadasArendicion();
        }

        private void btn_quitar_seleccion_Click(object sender, EventArgs e)
        {
            MoverHDRSeleccionadasAasignada();
        }

        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;
                hdr.estado = "Asignada";

                ListViewItem nuevoItem = new ListViewItem(hdr.n_hdr.ToString());
                nuevoItem.SubItems.Add(hdr.servicio.empresa);
                nuevoItem.SubItems.Add(hdr.estado);
                nuevoItem.SubItems.Add($"{hdr.servicio.cd_destino} - {hdr.servicio.horario_llegada}");
                nuevoItem.Tag = hdr;
                listview_hdr_asignadas.Items.Add(nuevoItem);
            }
            listview_hdr_rendidas.Items.Clear();
        }

        private void MoverHDRSeleccionadasArendicion()
        {
            if (listview_hdr_asignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_asignadas.SelectedItems)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdr.estado = "Rendida";
                hdr.fecha = DateTime.Now;

                ListViewItem nuevoItem = new ListViewItem(hdr.n_hdr.ToString());

                nuevoItem.SubItems.Add(hdr.servicio.empresa);
                nuevoItem.SubItems.Add(hdr.estado);
                nuevoItem.SubItems.Add($"{hdr.servicio.cd_destino} - {hdr.servicio.horario_llegada}");

                nuevoItem.Tag = hdr;

                listview_hdr_rendidas.Items.Add(nuevoItem);

                itemsAMover.Add(item);
            }

            foreach (ListViewItem item in itemsAMover)
            {
                listview_hdr_asignadas.Items.Remove(item);
            }
        }

        private void MoverHDRSeleccionadasAasignada()
        {
            if (listview_hdr_rendidas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una HDR.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_rendidas.SelectedItems)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdr.estado = "Asignada";

                ListViewItem nuevoItem = new ListViewItem(hdr.n_hdr.ToString());

                nuevoItem.SubItems.Add(hdr.servicio.empresa);
                nuevoItem.SubItems.Add(hdr.estado);
                nuevoItem.SubItems.Add($"{hdr.servicio.cd_destino} - {hdr.servicio.horario_llegada}");

                nuevoItem.Tag = hdr;

                listview_hdr_asignadas.Items.Add(nuevoItem);

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
                MessageBox.Show("No hay HDR rendidas para confirmar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> hdr_rendidas = new();
            string empresa = cbox_empresa.Text;

            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;
                hdr_rendidas.Add(hdr.n_hdr);
                Console.WriteLine($"HDR {hdr.n_hdr} - Empresa: {hdr.servicio.empresa}, Estado: {hdr.estado}, Servicio: {hdr.servicio.cd_destino} - {hdr.servicio.horario_llegada}");
            }

            MessageBox.Show($"Se han confirmado {hdr_rendidas.Count} HDR rendidas. De la empresa '{empresa}'", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarCampos();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (listview_hdr_rendidas.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar? Se perderán los cambios no confirmados.", "Confirmación de Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            MessageBox.Show("Cerrará la pantalla de rendición HDR Transporte.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            listview_hdr_asignadas.Items.Clear();
            listview_hdr_rendidas.Items.Clear();
        }


    }
}