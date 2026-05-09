namespace tutasa.RuteoUltimaMilla
{
    public partial class RuteoUltimaMilla : Form
    {
        private RuteoUltimaMillaModelo modelo = new RuteoUltimaMillaModelo();

        public RuteoUltimaMilla()
        {
            InitializeComponent();
        }

        private void RuteoUltimaMilla_Load(object sender, EventArgs e)
        {
            // Obtener fleteros desde el modelo
            List<string> fleteros = modelo.ObtenerFleteros();
            List<string> localidades = modelo.ObtenerLocalidades();

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

        private void RbEntrega(object sender, EventArgs e)
        {

        }

        private void RbRetiro(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ComboAsignarFletero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener valor ingresado en el campo CUIT (acá en realidad podríamos usar txtBoxCuit.Text directamente, pero lo asignamos a una variable para mayor claridad)
            string cuit = txtBoxCuit.Text.Trim();

            // Obtener localidad seleccionada
            string localidad = "";

            // Si el usuario seleccionó una localidad, la guardamos
            if (CmbLocalidad.SelectedItem != null)
            {
                localidad = CmbLocalidad.SelectedItem.ToString();
            }

            // Validación: si se ingresó un CUIT, debe contener únicamente números. Noten que permitimos que el campo esté vacío, ya que la búsqueda podría realizarse sin filtrar por CUIT. Sin embargo, si se ingresa algo, debe ser numérico.
            if (!string.IsNullOrEmpty(cuit) && !cuit.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El CUIT del cliente debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            List<RuteoUltimaMillaModelo.Guia> guiasEncontradas = modelo.BuscarGuias(localidad, cuit);

            // Limpiar ListView antes de mostrar los resultados. Sino si aplicamos devuelta el buscar se acumularían los viejos
            LvGuiasDisponibles.Items.Clear();

            foreach (RuteoUltimaMillaModelo.Guia guia in guiasEncontradas)
            {
                ListViewItem item = new ListViewItem(guia.Numero);

                item.Tag = guia;

                item.SubItems.Add(guia.Cliente);
                item.SubItems.Add(guia.Cuit);
                item.SubItems.Add(guia.Localidad);
                item.SubItems.Add(guia.Direccion);
                item.SubItems.Add(guia.Dimension);
                item.SubItems.Add(guia.TipoRuteo);

                LvGuiasDisponibles.Items.Add(item);
            }

            if (guiasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron guías con los criterios ingresados.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void BtnAgregarSeleccion_Click(object sender, EventArgs e)
        {
            // Validación: debe seleccionarse al menos una guía
            if (LvGuiasDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una guía.",
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

            // Recorrer guías seleccionadas
            foreach (ListViewItem itemSeleccionado in LvGuiasDisponibles.SelectedItems)
            {
                // Recuperamos la guía real guardada previamente en el Tag del ListViewItem.
                // Acá el Tag funciona como un "contenedor oculto" asociado a cada fila visual,
                // permitiéndonos mantener referencia al objeto Guia original y no depender únicamente de los textos visibles en pantalla.
                // Sino tendrías que agregarles index a cada columna y hacer algo como itemSeleccionado.SubItems[0].Text para recuperar el
                // número de guía, lo cual es más frágil y propenso a errores si luego cambias el orden de las columnas o agregas nuevas.
                RuteoUltimaMillaModelo.Guia guia =
                    (RuteoUltimaMillaModelo.Guia)itemSeleccionado.Tag;

                // Validar duplicados
                bool existe = false;

                foreach (ListViewItem itemExistente in LvSeleccion.Items)
                {
                    RuteoUltimaMillaModelo.Guia guiaExistente =
                        (RuteoUltimaMillaModelo.Guia)itemExistente.Tag;

                    // Si el número de guía ya existe, marcar duplicado
                    if (guiaExistente.Numero == guia.Numero)
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
                        new ListViewItem(guia.Numero);

                    nuevoItem.SubItems.Add(guia.Cliente);
                    nuevoItem.SubItems.Add(guia.Direccion);

                    // Acá le asignamos el tipo de ruteo a la guía en el modelo,
                    // para que quede guardado en el objeto y no solo en la fila visual.
                    guia.TipoRuteo = tipoRuteo;

                    nuevoItem.SubItems.Add(tipoRuteo);
                    nuevoItem.SubItems.Add(guia.Dimension);

                    // Guardamos nuevamente la guía en el Tag de la nueva fila.
                    // Esto permite recuperar posteriormente el objeto completo
                    // para validaciones, eliminación de elementos o confirmación del ruteo.
                    nuevoItem.Tag = guia;

                    // Agregar fila al listado seleccionado
                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void BtnAgregarTodos_Click_1(object sender, EventArgs e)
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

            // Recorremos todas las filas del ListView de guías disponibles.
            // A diferencia del botón "Agregar selección", donde utilizábamos
            // SelectedItems (únicamente las filas marcadas por el usuario),
            // acá utilizamos Items para incorporar todas las guías mostradas
            // en el resultado de búsqueda. Es casi igual.
            foreach (ListViewItem itemDisponible in LvGuiasDisponibles.Items)
            {
                // Obtener guía desde el Tag
                RuteoUltimaMillaModelo.Guia guia =
                    (RuteoUltimaMillaModelo.Guia)itemDisponible.Tag;

                // Validar duplicados
                bool existe = false;

                foreach (ListViewItem itemExistente in LvSeleccion.Items)
                {
                    RuteoUltimaMillaModelo.Guia guiaExistente =
                        (RuteoUltimaMillaModelo.Guia)itemExistente.Tag;

                    // Si ya existe el número de guía, marcar duplicado
                    if (guiaExistente.Numero == guia.Numero)
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
                        new ListViewItem(guia.Numero);

                    nuevoItem.SubItems.Add(guia.Cliente);
                    nuevoItem.SubItems.Add(guia.Direccion);

                    //acá le asigno el tipo de ruteo a la guía en el modelo,
                    //para que quede guardado en el objeto y no solo en la fila visual.
                    //Esto es importante para luego recuperar esta información al confirmar el ruteo o si queremos mostrarla en algún detalle.
                    guia.TipoRuteo = tipoRuteo;

                    nuevoItem.SubItems.Add(tipoRuteo);
                    nuevoItem.SubItems.Add(guia.Dimension);

                    // Guardar guía en Tag
                    nuevoItem.Tag = guia;

                    // Agregar al ListView inferior
                    LvSeleccion.Items.Add(nuevoItem);
                }
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            // Validación: debe seleccionarse al menos una guía
            if (LvSeleccion.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una guía para quitar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Recorremos las filas seleccionadas del ListView inferior
            foreach (ListViewItem itemSeleccionado in LvSeleccion.SelectedItems)
            {
                // Eliminamos la fila del listado seleccionado
                LvSeleccion.Items.Remove(itemSeleccionado);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
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

            // Validar que existan guías seleccionadas
            if (LvSeleccion.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una guía al ruteo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Obtener fletero seleccionado
            string fletero =
                ComboAsignarFletero.SelectedItem.ToString();

            // Recorrer guías seleccionadas
            foreach (ListViewItem item in LvSeleccion.Items)
            {
                // Recuperar guía desde el Tag
                RuteoUltimaMillaModelo.Guia guia =
                    (RuteoUltimaMillaModelo.Guia)item.Tag;

                // Guardar fletero asignado en la guía
                guia.Fletero = fletero;
            }

            MessageBox.Show(
                "Ruteo generado correctamente.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario
            LvSeleccion.Items.Clear();
            LvGuiasDisponibles.Items.Clear();
            ComboAsignarFletero.SelectedIndex = -1;
        }
    }
}