using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutasa.RuteoTransporte
{
    public partial class FormRuteoTransporte : Form
    {
        private FormRuteoTransporteModelo modelo =
            new FormRuteoTransporteModelo();

        public FormRuteoTransporte()
        {
            InitializeComponent();
        }

        private void FormRuteoTransporte_Load(object sender,EventArgs e)
        {
            // Cargar combos

            ComboCDDestino.DataSource = modelo.ObtenerCDs();

            ComboCDDestino.DisplayMember = "Nombre";

            ComboCDDestino.ValueMember = "Id";

            foreach (FormRuteoTransporteModelo.Dimension dimension in modelo.ObtenerDimensiones())
            {
                ComboDimension.Items.Add(dimension.Nombre);
            }

            ComboEmpresa.DataSource = modelo.ObtenerEmpresas();

            ComboEmpresa.DisplayMember = "Nombre";

            ComboEmpresa.ValueMember = "Id";

            foreach (FormRuteoTransporteModelo.Localidad localidad in modelo.ObtenerLocalidades())
            {
                ComboLocalidad.Items.Add(localidad.Nombre);
            }
            ComboCDDestino.SelectedIndex = -1;
            ComboEmpresa.SelectedIndex = -1;
            ComboServicio.SelectedIndex = -1;
        }

        private void BtnAgregarTodos_Click(object sender,EventArgs e)
        {
            // Recorrer todas las encomiendas disponibles

            foreach (ListViewItem itemDisponible
                in LvGuiasDisponibles.Items)
            {
                // Recuperar encomienda desde el Tag

                FormRuteoTransporteModelo.Guia
                    guia =(FormRuteoTransporteModelo.Guia)itemDisponible.Tag;

                // Validar duplicados

                bool existe = false;

                foreach (ListViewItem itemExistente in LvSeleccion.Items)
                {
                    FormRuteoTransporteModelo.Guia
                        guiaExistente =
                        (FormRuteoTransporteModelo.Guia)itemExistente.Tag;

                    if (guiaExistente.Numero == guia.Numero)
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar solo si no existe

                if (!existe)
                {
                    ListViewItem nuevoItem =new ListViewItem(guia.Numero.ToString());

                    nuevoItem.SubItems.Add(guia.Localidad);

                    nuevoItem.SubItems.Add(guia.Direccion);

                    nuevoItem.SubItems.Add(guia.Dimension);

                    nuevoItem.SubItems.Add(guia.Cliente);

                    nuevoItem.SubItems.Add(guia.CdDestino);

                    nuevoItem.Tag = guia;

                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        

        private void BtnBuscar_Click(
            object sender,
            EventArgs e)
        {
            // Obtener filtros

            string cdDestino = "";

            string cuit = TxtCuit.Text.Trim();

            string localidad = "";

            string dimension = "";


            if (ComboLocalidad.SelectedItem != null)
            {
                localidad = ComboLocalidad.SelectedItem.ToString();
            }

            if (ComboDimension.SelectedItem != null)
            {
                dimension = ComboDimension.SelectedItem.ToString();
            }

            // Validar CUIT numérico si se ingresó

            if (!string.IsNullOrEmpty(cuit) && !cuit.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El CUIT debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<FormRuteoTransporteModelo.Guia>guiasEncontradas =modelo.BuscarGuias(cuit,localidad,dimension);

            // Limpiar listado previo

            LvGuiasDisponibles.Items.Clear();

            // Mostrar resultados

            foreach (FormRuteoTransporteModelo.Guia guia in guiasEncontradas)
            {
                ListViewItem item = new ListViewItem(guia.Numero.ToString());
                item.SubItems.Add(guia.Localidad);

                item.SubItems.Add(guia.Direccion);

                item.SubItems.Add(guia.Dimension);

                item.SubItems.Add(guia.Cliente);

                item.SubItems.Add(guia.CdDestino);

                item.Tag = guia;

                LvGuiasDisponibles.Items.Add(item);
            }

            if (guiasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron encomiendas.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void LvGuiasDisponibles_SelectedIndexChanged(object sender,EventArgs e)
        {

        }

        private void BtnAgregarSeleccion_Click(object sender,EventArgs e)
        {
            // Validar selección

            if (LvGuiasDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una encomienda.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            foreach (ListViewItem itemSeleccionado
                in LvGuiasDisponibles.SelectedItems)
            {
                FormRuteoTransporteModelo.Guia guia = (FormRuteoTransporteModelo.Guia)itemSeleccionado.Tag;

                // Validar duplicados

                bool existe = false;

                foreach (ListViewItem itemExistente in LvSeleccion.Items)
                {
                    FormRuteoTransporteModelo.Guia guiaExistente = (FormRuteoTransporteModelo.Guia)itemExistente.Tag;

                    if (guiaExistente.Numero == guia.Numero)
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar si no existe

                if (!existe)
                {
                    ListViewItem nuevoItem = new ListViewItem(guia.Numero.ToString());

                    nuevoItem.SubItems.Add(guia.Localidad);

                    nuevoItem.SubItems.Add(guia.Direccion);

                    nuevoItem.SubItems.Add(guia.Dimension);

                    nuevoItem.SubItems.Add(guia.Cliente);

                    nuevoItem.SubItems.Add(guia.CdDestino);

                    nuevoItem.Tag = guia;

                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender,EventArgs e)
        {

        }

        private void BtnQuitar_Click(
            object sender,
            EventArgs e)
        {
            // Validar selección

            if (LvSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una encomienda para quitar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Eliminar seleccionadas

            foreach (ListViewItem item in LvSeleccion.SelectedItems)
            {
                LvSeleccion.Items.Remove(item);
            }
        }

        private void ComboCDDestino_SelectedIndexChanged(object sender,EventArgs e)
        {

        }

        private void ComboEmpresa_SelectedIndexChanged(object sender,EventArgs e)
        {
            // Limpiar servicios previos

            ComboServicio.DataSource = null;

            ComboServicio.SelectedIndex = -1;

            // Validar empresa seleccionada

            if (ComboEmpresa.SelectedItem == null)
            {
                return;
            }

            // Obtener empresa seleccionada

            if (ComboCDDestino.SelectedValue == null)
            {
                return;
            }


            if (!(ComboEmpresa.SelectedValue is int idEmpresa))
            {
                return;
            }

            if (!(ComboCDDestino.SelectedValue is int idCDDestino))
            {
                return;
            }

            List<FormRuteoTransporteModelo.Servicio> servicios =modelo.ObtenerServicios(idEmpresa,idCDDestino);

            // Cargar combo de servicios

            ComboServicio.DataSource = servicios;

            ComboServicio.DisplayMember = "Descripcion";

            ComboServicio.ValueMember = "Id";

            ComboServicio.SelectedIndex = -1;
        }

        private void BtnConfirmar_Click(object sender,EventArgs e)
        {
            // Validar encomiendas seleccionadas

            if (LvSeleccion.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una encomienda.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar CD destino

            if (ComboCDDestino.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un CD destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar empresa

            if (ComboEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una empresa.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar servicio

            if (ComboServicio.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un servicio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Obtener datos seleccionados

            string cdDestino =ComboCDDestino.SelectedItem.ToString();

            string empresa = ComboEmpresa.SelectedItem.ToString();

            FormRuteoTransporteModelo.Servicio servicio =(FormRuteoTransporteModelo.Servicio)ComboServicio.SelectedItem;

            // Lista de encomiendas de la hoja de ruta

            List<FormRuteoTransporteModelo.Guia>guiasHojaRuta =new List<FormRuteoTransporteModelo.Guia>();

            // Recuperar encomiendas desde el ListView

            foreach (ListViewItem item in LvSeleccion.Items)
            {
                FormRuteoTransporteModelo.Guia guia =(FormRuteoTransporteModelo.Guia)item.Tag;

                guiasHojaRuta.Add(guia);
            }

            // Crear hoja de ruta final

            FormRuteoTransporteModelo.HojaRutaTransporte
                hojaRuta =
                new FormRuteoTransporteModelo.HojaRutaTransporte
                {
                    Numero = DateTime.Now.ToString("yyyyMMddHHmmss"),

                    Empresa = empresa,

                    IdServicio = servicio.Id,

                    CDDestino = cdDestino,

                    Guias = guiasHojaRuta
                };

            // Guardar hoja de ruta

            int numeroHDR =modelo.GuardarHojaRuta(hojaRuta);

            string guiasIncluidas =
    string.Join(
        ", ",
        guiasHojaRuta.Select(g => g.Numero));

            MessageBox.Show(
                "Hoja de ruta generada correctamente.\n" +
                "Número HDR: " + numeroHDR + "\n" +
                "CD Destino: " + ComboCDDestino.Text + "\n\n" +
                "Empresa: " + ComboEmpresa.Text + "\n" +
                "Servicio: " + ComboServicio.Text + "\n\n" +
                "Cantidad de guías: " + guiasHojaRuta.Count + "\n" +
                "Guías: " + guiasIncluidas,
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario

            LvGuiasDisponibles.Items.Clear();

            LvSeleccion.Items.Clear();

            TxtCuit.Clear();



            ComboLocalidad.SelectedIndex = -1;

            ComboDimension.SelectedIndex = -1;

            ComboCDDestino.SelectedIndex = -1;

            ComboEmpresa.SelectedIndex = -1;

            ComboServicio.DataSource = null;

            ComboServicio.SelectedIndex = -1;

            ComboServicio.Text = "";


        }
    }
}