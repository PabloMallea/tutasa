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

        private void FormRuteoTransporte_Load(
            object sender,
            EventArgs e)
        {
            // Cargar combos

            foreach (string cd in modelo.ObtenerCDs())
            {
                ComboCDDestinoBusqueda.Items.Add(cd);

                ComboCDDestino.Items.Add(cd);
            }

            foreach (string dimension
                in modelo.ObtenerDimensiones())
            {
                ComboDimension.Items.Add(dimension);
            }

            foreach (string empresa
                in modelo.ObtenerEmpresas())
            {
                ComboEmpresa.Items.Add(empresa);
            }

            foreach (string localidad
                 in modelo.ObtenerLocalidades())
            {
                ComboLocalidad.Items.Add(localidad);
            }
        }

        private void BtnAgregarTodos_Click(
            object sender,
            EventArgs e)
        {
            // Recorrer todas las encomiendas disponibles

            foreach (ListViewItem itemDisponible
                in LvGuiasDisponibles.Items)
            {
                // Recuperar encomienda desde el Tag

                FormRuteoTransporteModelo.Encomienda
                    encomienda =
                    (FormRuteoTransporteModelo.Encomienda)
                    itemDisponible.Tag;

                // Validar duplicados

                bool existe = false;

                foreach (ListViewItem itemExistente
                    in LvSeleccion.Items)
                {
                    FormRuteoTransporteModelo.Encomienda
                        encomiendaExistente =
                        (FormRuteoTransporteModelo.Encomienda)
                        itemExistente.Tag;

                    if (encomiendaExistente.Numero
                        == encomienda.Numero)
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar solo si no existe

                if (!existe)
                {
                    ListViewItem nuevoItem =
                        new ListViewItem(encomienda.Numero);

                    nuevoItem.SubItems.Add(
                        encomienda.Localidad);

                    nuevoItem.SubItems.Add(
                        encomienda.Direccion);

                    nuevoItem.SubItems.Add(
                        encomienda.Dimension);

                    nuevoItem.SubItems.Add(
                        encomienda.Peso);

                    nuevoItem.SubItems.Add(
                        encomienda.Cliente);

                    nuevoItem.SubItems.Add(
                        encomienda.CDDestino);

                    nuevoItem.Tag = encomienda;

                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void groupBox3_Enter(
            object sender,
            EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void BtnBuscar_Click(
            object sender,
            EventArgs e)
        {
            // Obtener filtros

            string cdDestino = "";

            string cuit =
                TxtCuit.Text.Trim();

            string localidad = "";

            string dimension = "";

            if (ComboCDDestinoBusqueda.SelectedItem != null)
            {
                cdDestino =
                    ComboCDDestinoBusqueda
                    .SelectedItem
                    .ToString();
            }

            if (ComboLocalidad.SelectedItem != null)
            {
                localidad =
                    ComboLocalidad
                    .SelectedItem
                    .ToString();
            }

            if (ComboDimension.SelectedItem != null)
            {
                dimension =
                    ComboDimension
                    .SelectedItem
                    .ToString();
            }

            // Validar CUIT numérico si se ingresó

            if (!string.IsNullOrEmpty(cuit)
                && !cuit.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El CUIT debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<FormRuteoTransporteModelo.Encomienda>
                encomiendasEncontradas =
                    modelo.BuscarEncomiendas(
                        cdDestino,
                        cuit,
                        localidad,
                        dimension
                    );

            // Limpiar listado previo

            LvGuiasDisponibles.Items.Clear();

            // Mostrar resultados

            foreach (
                FormRuteoTransporteModelo.Encomienda
                encomienda
                in encomiendasEncontradas)
            {
                ListViewItem item =
                    new ListViewItem(encomienda.Numero);

                item.SubItems.Add(
                    encomienda.Localidad);

                item.SubItems.Add(
                    encomienda.Direccion);

                item.SubItems.Add(
                    encomienda.Dimension);

                item.SubItems.Add(
                    encomienda.Peso);

                item.SubItems.Add(
                    encomienda.Cliente);

                item.SubItems.Add(
                    encomienda.CDDestino);

                item.Tag = encomienda;

                LvGuiasDisponibles.Items.Add(item);
            }

            if (encomiendasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron encomiendas.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void LvGuiasDisponibles_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void BtnAgregarSeleccion_Click(
            object sender,
            EventArgs e)
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
                FormRuteoTransporteModelo.Encomienda
                    encomienda =
                    (FormRuteoTransporteModelo.Encomienda)
                    itemSeleccionado.Tag;

                // Validar duplicados

                bool existe = false;

                foreach (ListViewItem itemExistente
                    in LvSeleccion.Items)
                {
                    FormRuteoTransporteModelo.Encomienda
                        encomiendaExistente =
                        (FormRuteoTransporteModelo.Encomienda)
                        itemExistente.Tag;

                    if (encomiendaExistente.Numero
                        == encomienda.Numero)
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar si no existe

                if (!existe)
                {
                    ListViewItem nuevoItem =
                        new ListViewItem(encomienda.Numero);

                    nuevoItem.SubItems.Add(
                        encomienda.Localidad);

                    nuevoItem.SubItems.Add(
                        encomienda.Direccion);

                    nuevoItem.SubItems.Add(
                        encomienda.Dimension);

                    nuevoItem.SubItems.Add(
                        encomienda.Peso);

                    nuevoItem.SubItems.Add(
                        encomienda.Cliente);

                    nuevoItem.SubItems.Add(
                        encomienda.CDDestino);

                    nuevoItem.Tag = encomienda;

                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void listView1_SelectedIndexChanged(
            object sender,
            EventArgs e)
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

            foreach (ListViewItem item
                in LvSeleccion.SelectedItems)
            {
                LvSeleccion.Items.Remove(item);
            }
        }

        private void ComboCDDestino_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void ComboEmpresa_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Limpiar servicios previos

            ComboServicio.Items.Clear();

            ComboServicio.SelectedIndex = -1;

            // Validar empresa seleccionada

            if (ComboEmpresa.SelectedItem == null)
            {
                return;
            }

            // Obtener empresa seleccionada

            string empresa =
                ComboEmpresa.SelectedItem.ToString();

            // Obtener servicios correspondientes

            List<string> servicios =
                modelo.ObtenerServicios(empresa);

            // Cargar combo de servicios

            foreach (string servicio in servicios)
            {
                ComboServicio.Items.Add(servicio);
            }
        }

        private void BtnConfirmar_Click(
            object sender,
            EventArgs e)
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

            string cdDestino =
                ComboCDDestino.SelectedItem.ToString();

            string empresa =
                ComboEmpresa.SelectedItem.ToString();

            string servicio =
                ComboServicio.SelectedItem.ToString();

            // Lista de encomiendas de la hoja de ruta

            List<FormRuteoTransporteModelo.Encomienda>
                encomiendasHojaRuta =
                    new List<FormRuteoTransporteModelo.Encomienda>();

            // Recuperar encomiendas desde el ListView

            foreach (ListViewItem item
                in LvSeleccion.Items)
            {
                FormRuteoTransporteModelo.Encomienda
                    encomienda =
                    (FormRuteoTransporteModelo.Encomienda)
                    item.Tag;

                encomiendasHojaRuta.Add(encomienda);
            }

            // Crear hoja de ruta final

            FormRuteoTransporteModelo.HojaRutaTransporte
                hojaRuta =
                new FormRuteoTransporteModelo.HojaRutaTransporte
                {
                    Numero =
                        DateTime.Now
                        .ToString("yyyyMMddHHmmss"),

                    Empresa = empresa,

                    Servicio = servicio,

                    CDDestino = cdDestino,

                    Encomiendas =
                        encomiendasHojaRuta
                };

            // Guardar hoja de ruta

            modelo.GuardarHojaRuta(hojaRuta);

            MessageBox.Show(
                "Hoja de ruta generada correctamente.\n" +
                "Número: " + hojaRuta.Numero,
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario

            LvGuiasDisponibles.Items.Clear();

            LvSeleccion.Items.Clear();

            TxtCuit.Clear();

            ComboCDDestinoBusqueda.SelectedIndex = -1;

            ComboLocalidad.SelectedIndex = -1;

            ComboDimension.SelectedIndex = -1;

            ComboCDDestino.SelectedIndex = -1;

            ComboEmpresa.SelectedIndex = -1;

            ComboServicio.Items.Clear();

            ComboServicio.SelectedIndex = -1;
            ComboServicio.Text = "";


        }
    }
}