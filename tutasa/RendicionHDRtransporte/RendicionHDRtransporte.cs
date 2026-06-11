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
            
            label_cd.Text = modelo.NombreCdUsuario;

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

                int idEmpresa = modelo.empresas
                    .First(e => e.NombreEmpresa == empresaSeleccionada)
                    .IdEmpresa;

                List<Servicio> serviciosFiltrados = modelo.ObtenerServiciosPorEmpresa(idEmpresa);

                foreach (Servicio servicio in serviciosFiltrados)
                {
                    cbox_servicio.Items.Add(servicio.NombreServicio);
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

            RendicionHDRtransporteModelo resultado = RendicionHDRtransporteModelo.ObtenerMockHDRAsignadas();

            List<HDRtransporte> resultadosFiltrados = resultado.HDRtransporteList
                .Where(hdr =>
                    hdr.Servicio.NombreServicio == cbox_servicio.SelectedItem.ToString()
                    &&
                    hdr.EstadoHdr == EstadoHdrTransporte.Asignada)
                .ToList();

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
                bool yaExisteEnAsignadas = false;

                foreach (ListViewItem existingItem in listview_hdr_asignadas.Items)
                {
                    HDRtransporte hdrExistente = (HDRtransporte)existingItem.Tag;

                    if (hdrExistente.NumeroHdrTransporte == hdr.NumeroHdrTransporte)
                    {
                        yaExisteEnAsignadas = true;
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

                if (!yaExisteEnAsignadas && !yaExisteEnRendidas)
                {
                    listview_hdr_asignadas.Items.Add(CrearItemHDR(hdr));
                }
            }
        }

        private ListViewItem CrearItemHDR(HDRtransporte hdr)
        {
            ListViewItem item =
                new ListViewItem(hdr.NumeroHdrTransporte.ToString());

            item.SubItems.Add(
                modelo.empresas[hdr.Servicio.IdEmpresa - 1]);

            item.SubItems.Add(
                hdr.EstadoHdr.ToString());

            item.SubItems.Add(
                hdr.Servicio.NombreServicio);

            item.Tag = hdr;

            return item;
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
                item.Selected = true;
            }

            MoverHDRSeleccionadasAasignada();
        }

        private void MoverHDRSeleccionadasArendicion()
        {
            if (listview_hdr_asignadas.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una HDR.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<ListViewItem> itemsAMover = new();

            foreach (ListViewItem item in listview_hdr_asignadas.SelectedItems)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdr.EstadoHdr = EstadoHdrTransporte.Rendida;
                

                listview_hdr_rendidas.Items.Add(CrearItemHDR(hdr));

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

                hdr.EstadoHdr = EstadoHdrTransporte.Asignada;

                listview_hdr_asignadas.Items.Add(CrearItemHDR(hdr));

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

            List<int> hdr_rendidas = new();

            List<string> resultadoActualizacion = new();

            foreach (ListViewItem item in listview_hdr_rendidas.Items)
            {
                HDRtransporte hdr = (HDRtransporte)item.Tag;

                hdr_rendidas.Add(hdr.NumeroHdrTransporte);

                List<string> resultadoHdr = modelo.ActualizarEstadoGuias(hdr);

                resultadoActualizacion.AddRange(resultadoHdr);

                //Console.WriteLine($"HDR {hdr.NumeroHdrTransporte} confirmada.");
            }

            string mensajeFinal =
                $"Se han confirmado {hdr_rendidas.Count} HDR rendidas."
                + Environment.NewLine
                + Environment.NewLine
                + string.Join(Environment.NewLine, resultadoActualizacion);

            MessageBox.Show(
                mensajeFinal,
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

            listview_hdr_asignadas.Items.Clear();
            listview_hdr_rendidas.Items.Clear();
        }
    }
}

