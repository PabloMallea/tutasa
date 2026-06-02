using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutasa.RuteoUltimaMilla
{
    public partial class RuteoUltimaMilla : Form
    {
        private RuteoUltimaMillaModelo modelo =
            new RuteoUltimaMillaModelo();

        public RuteoUltimaMilla()
        {
            InitializeComponent();
        }

        private void RuteoUltimaMilla_Load(
            object sender,
            EventArgs e)
        {
            // Obtener fleteros desde el modelo
            List<string> fleteros =
                modelo.ObtenerFleteros();

            List<string> localidades =
                modelo.ObtenerLocalidades();

            // Se lo asignamos al Combobox de asignación de fletero. Acá ver si la opción óptima según Andrés es usar un foreach

            foreach (string localidad in localidades)
            {
                CmbLocalidad.Items.Add(localidad);
            }

            // Se lo asignamos al Combobox de asignación de fletero
            foreach (string fletero in fleteros)
            {
                ComboAsignarFletero.Items.Add(fletero);
            }
        }

        private void RbEntrega(
            object sender,
            EventArgs e)
        {

        }

        private void RbRetiro(
            object sender,
            EventArgs e)
        {

        }

        private void BtnCancelar_Click(
            object sender,
            EventArgs e)
        {

        }

        private void ComboAsignarFletero_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void BtnBuscar_Click(
            object sender,
            EventArgs e)
        {
            // Obtener valor ingresado en el campo CUIT (acá en realidad podríamos usar txtBoxCuit.Text directamente, pero lo asignamos a una variable para mayor claridad)
            string cuit = txtBoxCuit.Text.Trim();

            // Obtener localidad seleccionada
            string localidad = "";

            // Si el usuario seleccionó una localidad, la guardamos
            if (CmbLocalidad.SelectedItem != null)
            {
                localidad =
                    CmbLocalidad.SelectedItem.ToString();
            }

            // Validación: si se ingresó un CUIT, debe contener únicamente números. Noten que permitimos que el campo esté vacío, ya que la búsqueda podría realizarse sin filtrar por CUIT. Sin embargo, si se ingresa algo, debe ser numérico.
            if (!string.IsNullOrEmpty(cuit)
                && !cuit.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El CUIT del cliente debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<RuteoUltimaMillaModelo.Guia>
                GuiasEncontradas =
                    modelo.BuscarGuias(
                        localidad,
                        cuit
                    );

            // Limpiar ListView antes de mostrar los resultados. Sino si aplicamos devuelta el buscar se acumularían los viejos
            LvGuiasDisponibles.Items.Clear();

            foreach (
                RuteoUltimaMillaModelo.Guia Guia
                in GuiasEncontradas)
            {
                ListViewItem item =
                    new ListViewItem(Guia.Numero);

                item.Tag = Guia;

                item.SubItems.Add(Guia.Cliente);
                item.SubItems.Add(Guia.Cuit);
                item.SubItems.Add(Guia.Localidad);
                item.SubItems.Add(Guia.Direccion);
                item.SubItems.Add(Guia.Dimension);

                LvGuiasDisponibles.Items.Add(item);
            }

            if (GuiasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron Guias con los criterios ingresados.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void BtnAgregarSeleccion_Click(
            object sender,
            EventArgs e)
        {
            // Validación: debe seleccionarse al menos una Guia
            if (LvGuiasDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una Guia.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Determinar tipo de ruteo según radio button
            string tipoRuteo = "";

            if (RBEntrega.Checked)
            {
                tipoRuteo = "Entrega";
            }
            else if (RBRetiro.Checked)
            {
                tipoRuteo = "Retiro";
            }
            else
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de ruteo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Recorrer Guias seleccionadas
            foreach (
                ListViewItem itemSeleccionado
                in LvGuiasDisponibles.SelectedItems)
            {
                // Recuperamos la Guia real guardada previamente en el Tag del ListViewItem.
                // Acá el Tag funciona como un "contenedor oculto" asociado a cada fila visual,
                // permitiéndonos mantener referencia al objeto Guia original y no depender únicamente de los textos visibles en pantalla.
                // Sino tendrías que agregarles index a cada columna y hacer algo como itemSeleccionado.SubItems[0].Text para recuperar el
                // número de Guia, lo cual es más frágil y propenso a errores si luego cambias el orden de las columnas o agregas nuevas.
                RuteoUltimaMillaModelo.Guia Guia =
                    (RuteoUltimaMillaModelo.Guia)
                    itemSeleccionado.Tag;

                // Validar duplicados
                bool existe = false;

                foreach (ListViewItem itemExistente
                    in LvSeleccion.Items)
                {
                    RuteoUltimaMillaModelo.Guia
                        GuiaExistente =
                        (RuteoUltimaMillaModelo.Guia)
                        itemExistente.Tag;

                    // Si el número de Guia ya existe, marcar duplicado
                    if (GuiaExistente.Numero
                        == Guia.Numero)
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar únicamente si no existe previamente
                if (!existe)
                {
                    // Crear fila para el ListView inferior
                    ListViewItem nuevoItem =
                        new ListViewItem(Guia.Numero);

                    nuevoItem.SubItems.Add(
                        Guia.Cliente);

                    nuevoItem.SubItems.Add(
                        Guia.Direccion);

                    nuevoItem.SubItems.Add(
                        tipoRuteo);

                    nuevoItem.SubItems.Add(
                        Guia.Dimension);

                    // Guardamos nuevamente la Guia en el Tag de la nueva fila.
                    // Esto permite recuperar posteriormente el objeto completo
                    // para validaciones, eliminación de elementos o confirmación del ruteo.
                    nuevoItem.Tag = Guia;

                    // Agregar fila al listado seleccionado
                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void BtnAgregarTodos_Click_1(
            object sender,
            EventArgs e)
        {
            // Validación: debe seleccionarse tipo de ruteo
            string tipoRuteo = "";

            if (RBEntrega.Checked)
            {
                tipoRuteo = "Entrega";
            }
            else if (RBRetiro.Checked)
            {
                tipoRuteo = "Retiro";
            }
            else
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de ruteo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Recorremos todas las filas del ListView de Guias disponibles.
            // A diferencia del botón "Agregar selección", donde utilizábamos
            // SelectedItems (únicamente las filas marcadas por el usuario),
            // acá utilizamos Items para incorporar todas las Guias mostradas
            // en el resultado de búsqueda. Es casi igual.
            foreach (
                ListViewItem itemDisponible
                in LvGuiasDisponibles.Items)
            {
                // Obtener Guia desde el Tag
                RuteoUltimaMillaModelo.Guia Guia =
                    (RuteoUltimaMillaModelo.Guia)
                    itemDisponible.Tag;

                // Validar duplicados
                bool existe = false;

                foreach (ListViewItem itemExistente
                    in LvSeleccion.Items)
                {
                    RuteoUltimaMillaModelo.Guia
                        GuiaExistente =
                        (RuteoUltimaMillaModelo.Guia)
                        itemExistente.Tag;

                    // Si ya existe el número de Guia, marcar duplicado
                    if (GuiaExistente.Numero
                        == Guia.Numero)
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar únicamente si no existe
                if (!existe)
                {
                    // Crear fila para ListView inferior
                    ListViewItem nuevoItem =
                        new ListViewItem(Guia.Numero);

                    nuevoItem.SubItems.Add(
                        Guia.Cliente);

                    nuevoItem.SubItems.Add(
                        Guia.Direccion);

                    nuevoItem.SubItems.Add(
                        tipoRuteo);

                    nuevoItem.SubItems.Add(
                        Guia.Dimension);

                    // Guardar Guia en Tag
                    nuevoItem.Tag = Guia;

                    // Agregar al ListView inferior
                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void BtnQuitar_Click(
            object sender,
            EventArgs e)
        {
            // Validación: debe seleccionarse al menos una Guia
            if (LvSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una Guia para quitar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Recorremos las filas seleccionadas del ListView inferior
            foreach (
                ListViewItem itemSeleccionado
                in LvSeleccion.SelectedItems)
            {
                // Eliminamos la fila del listado seleccionado
                LvSeleccion.Items.Remove(
                    itemSeleccionado);
            }
        }

        private void BtnConfirmar_Click(
            object sender,
            EventArgs e)
        {
            // Validar fletero seleccionado
            if (ComboAsignarFletero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un fletero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar que existan Guias seleccionadas
            if (LvSeleccion.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una Guia al ruteo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Determinar tipo de ruteo según radio button
            string tipoRuteo = "";

            if (RBEntrega.Checked)
            {
                tipoRuteo = "Entrega";
            }
            else
            {
                tipoRuteo = "Retiro";
            }

            // Obtener fletero seleccionado
            string fletero = ComboAsignarFletero.SelectedItem.ToString();

            // Lista donde se guardarán las Guias de la hoja de ruta
            List<RuteoUltimaMillaModelo.Guia>
                GuiasHojaRuta =
                    new List<RuteoUltimaMillaModelo.Guia>();

            // Recorrer Guias seleccionadas
            foreach (ListViewItem item in LvSeleccion.Items)
            {
                // Recuperar Guia desde el Tag
                RuteoUltimaMillaModelo.Guia Guia = (RuteoUltimaMillaModelo.Guia)item.Tag;

                // Agregar Guia a la hoja de ruta
                GuiasHojaRuta.Add(Guia);
            }

            // Crear hoja de ruta final
            RuteoUltimaMillaModelo.HojaRuta hojaRuta =
                new RuteoUltimaMillaModelo.HojaRuta
                {
                    // Generación simple de número de hoja de ruta
                    Numero =
                        DateTime.Now
                        .ToString("yyyyMMddHHmmss"),

                    Fletero = fletero,

                    TipoRuteo = tipoRuteo,

                    Guias =
                        GuiasHojaRuta
                };

            // Guardar hoja de ruta generada
            modelo.GuardarHojaRuta(hojaRuta);

            MessageBox.Show(
                "Hoja de ruta generada correctamente.\n" +
                "Número: " + hojaRuta.Numero,
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario
            LvSeleccion.Items.Clear();
            txtBoxCuit.Clear();
            CmbLocalidad.SelectedIndex = -1;
            LvGuiasDisponibles.Items.Clear();
            ComboAsignarFletero.SelectedIndex = -1;
        }
    }
}