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

            List<RuteoUltimaMillaModelo.Encomienda>
                encomiendasEncontradas =
                    modelo.BuscarEncomiendas(
                        localidad,
                        cuit
                    );

            // Limpiar ListView antes de mostrar los resultados. Sino si aplicamos devuelta el buscar se acumularían los viejos
            LvGuiasDisponibles.Items.Clear();

            foreach (
                RuteoUltimaMillaModelo.Encomienda encomienda
                in encomiendasEncontradas)
            {
                ListViewItem item =
                    new ListViewItem(encomienda.Numero);

                item.Tag = encomienda;

                item.SubItems.Add(encomienda.Cliente);
                item.SubItems.Add(encomienda.Cuit);
                item.SubItems.Add(encomienda.Localidad);
                item.SubItems.Add(encomienda.Direccion);
                item.SubItems.Add(encomienda.Dimension);

                LvGuiasDisponibles.Items.Add(item);
            }

            if (encomiendasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron encomiendas con los criterios ingresados.",
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
            // Validación: debe seleccionarse al menos una encomienda
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

            // Recorrer encomiendas seleccionadas
            foreach (
                ListViewItem itemSeleccionado
                in LvGuiasDisponibles.SelectedItems)
            {
                // Recuperamos la encomienda real guardada previamente en el Tag del ListViewItem.
                // Acá el Tag funciona como un "contenedor oculto" asociado a cada fila visual,
                // permitiéndonos mantener referencia al objeto Encomienda original y no depender únicamente de los textos visibles en pantalla.
                // Sino tendrías que agregarles index a cada columna y hacer algo como itemSeleccionado.SubItems[0].Text para recuperar el
                // número de encomienda, lo cual es más frágil y propenso a errores si luego cambias el orden de las columnas o agregas nuevas.
                RuteoUltimaMillaModelo.Encomienda encomienda =
                    (RuteoUltimaMillaModelo.Encomienda)
                    itemSeleccionado.Tag;

                // Validar duplicados
                bool existe = false;

                foreach (ListViewItem itemExistente
                    in LvSeleccion.Items)
                {
                    RuteoUltimaMillaModelo.Encomienda
                        encomiendaExistente =
                        (RuteoUltimaMillaModelo.Encomienda)
                        itemExistente.Tag;

                    // Si el número de encomienda ya existe, marcar duplicado
                    if (encomiendaExistente.Numero
                        == encomienda.Numero)
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
                        new ListViewItem(encomienda.Numero);

                    nuevoItem.SubItems.Add(
                        encomienda.Cliente);

                    nuevoItem.SubItems.Add(
                        encomienda.Direccion);

                    nuevoItem.SubItems.Add(
                        tipoRuteo);

                    nuevoItem.SubItems.Add(
                        encomienda.Dimension);

                    // Guardamos nuevamente la encomienda en el Tag de la nueva fila.
                    // Esto permite recuperar posteriormente el objeto completo
                    // para validaciones, eliminación de elementos o confirmación del ruteo.
                    nuevoItem.Tag = encomienda;

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

            // Recorremos todas las filas del ListView de encomiendas disponibles.
            // A diferencia del botón "Agregar selección", donde utilizábamos
            // SelectedItems (únicamente las filas marcadas por el usuario),
            // acá utilizamos Items para incorporar todas las encomiendas mostradas
            // en el resultado de búsqueda. Es casi igual.
            foreach (
                ListViewItem itemDisponible
                in LvGuiasDisponibles.Items)
            {
                // Obtener encomienda desde el Tag
                RuteoUltimaMillaModelo.Encomienda encomienda =
                    (RuteoUltimaMillaModelo.Encomienda)
                    itemDisponible.Tag;

                // Validar duplicados
                bool existe = false;

                foreach (ListViewItem itemExistente
                    in LvSeleccion.Items)
                {
                    RuteoUltimaMillaModelo.Encomienda
                        encomiendaExistente =
                        (RuteoUltimaMillaModelo.Encomienda)
                        itemExistente.Tag;

                    // Si ya existe el número de encomienda, marcar duplicado
                    if (encomiendaExistente.Numero
                        == encomienda.Numero)
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
                        new ListViewItem(encomienda.Numero);

                    nuevoItem.SubItems.Add(
                        encomienda.Cliente);

                    nuevoItem.SubItems.Add(
                        encomienda.Direccion);

                    nuevoItem.SubItems.Add(
                        tipoRuteo);

                    nuevoItem.SubItems.Add(
                        encomienda.Dimension);

                    // Guardar encomienda en Tag
                    nuevoItem.Tag = encomienda;

                    // Agregar al ListView inferior
                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void BtnQuitar_Click(
            object sender,
            EventArgs e)
        {
            // Validación: debe seleccionarse al menos una encomienda
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

            // Validar que existan encomiendas seleccionadas
            if (LvSeleccion.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una encomienda al ruteo.",
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

            // Lista donde se guardarán las encomiendas de la hoja de ruta
            List<RuteoUltimaMillaModelo.Encomienda>
                encomiendasHojaRuta =
                    new List<RuteoUltimaMillaModelo.Encomienda>();

            // Recorrer encomiendas seleccionadas
            foreach (ListViewItem item in LvSeleccion.Items)
            {
                // Recuperar encomienda desde el Tag
                RuteoUltimaMillaModelo.Encomienda encomienda = (RuteoUltimaMillaModelo.Encomienda)item.Tag;

                // Agregar encomienda a la hoja de ruta
                encomiendasHojaRuta.Add(encomienda);
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

                    Encomiendas =
                        encomiendasHojaRuta
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