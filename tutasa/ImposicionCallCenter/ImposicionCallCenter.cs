using static tutasa.ImposicionCallCenter.ImposicionCallCenterModelo;

namespace tutasa.ImposicionCallCenter
{
    public partial class ImposicionCallCenter : Form
    {
        // Instancia del modelo de imposición
        private ImposicionCallCenterModelo modelo = new ImposicionCallCenterModelo();

        // NO se toca!!!!!
        public ImposicionCallCenter()
        {
            InitializeComponent();
        }

        private void Imposicion_Load(object sender, EventArgs e)
        {
            // Obtener dimensiones desde el modelo
            List<string> dimensiones = modelo.ObtenerDimensiones();

            // Limpiar combo antes de cargar
            ComboDimension.Items.Clear();

            // Cargar dimensiones
            foreach (string dimension in dimensiones)
            {
                ComboDimension.Items.Add(dimension);
            }
        }

        private void LabelTamaño_Click(object sender, EventArgs e)
        {

        }

        private void ComboDimension_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDestino.SelectedItem == null)
            {
                return;
            }

            string destino = ComboDestino.SelectedItem.ToString();

            // Opción manual
            if (destino == "Domicilio Destinatario")
            {
                TextCalle.Enabled = true;
                TextAltura.Enabled = true;

                TextCalle.Clear();
                TextAltura.Clear();
                return;
            }

            string localidad = TextLocalidad.Text.Trim();

            List<ImposicionCallCenterModelo.Agencia> agencias = modelo.ObtenerAgencias(localidad);

            List<ImposicionCallCenterModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidad);

            // Buscar agencia
            foreach (ImposicionCallCenterModelo.Agencia agencia in agencias)
            {
                if (agencia.Nombre == destino)
                {
                    TextCalle.Text = agencia.Calle;

                    TextAltura.Text = agencia.Altura.ToString();

                    TextCalle.Enabled = false;
                    TextAltura.Enabled = false;
                    return;
                }
            }

            // Buscar CD
            foreach (
                ImposicionCallCenterModelo.CentroDistribucion cd in cds)
            {
                if (cd.Nombre == destino)
                {
                    TextCalle.Text = cd.Calle;

                    TextAltura.Text = cd.Altura.ToString();

                    TextCalle.Enabled = false;
                    TextAltura.Enabled = false;
                    return;
                }
            }
        }

        private void BotonBuscarC_Click(object sender, EventArgs e)
        {
            // Obtener CUIT ingresado
            string cuit = TxtCuit.Text.Trim();

            // 1. Validar que se haya ingresado CUIT (Excepciones 2.1 y 2.2)
            if (string.IsNullOrEmpty(cuit))
            {
                MessageBox.Show(
                    "Debe ingresar un CUIT.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Validar que sea numérico y tenga 11 dígitos (Excepción 3.1)
            if (cuit.Length != 11 || !cuit.All(char.IsDigit)) //Si es distinto de 11 elemtos y alguno no es número pincha
            {
                MessageBox.Show(
                    "El campo CUIT debe contener únicamente 11 valores numéricos",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Buscar cliente en el modelo
            ImposicionCallCenterModelo.Cliente cliente = modelo.BuscarCliente(cuit);

            // Validar existencia de cliente
            if (cliente == null) //Si no existe...
            {
                MessageBox.Show(
                    "El CUIT ingresado no corresponde a un cliente registrado.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // El CU dice en el paso 4.3 que se debe limpiar el valor del CUIT
                TxtCuit.Clear();
                return; //Si existe lo devuelve
            }

            // Completar datos del cliente
            LabelNombre.Text = cliente.Nombre;
            LabelApellido.Text = cliente.Apellido;
            LabelTelefono.Text = cliente.Telefono;
            LabelCalle.Text = cliente.Calle;
            LabelAltura.Text = cliente.Altura;
            LabelLocalidad.Text = cliente.Localidad;
        }

        private void BotonBuscarLocalidad_Click(object sender, EventArgs e)
        {
            // Obtener localidad ingresada
            string localidadIngresada = TextLocalidad.Text.Trim();

            // 1. Validar que no esté vacío (Excepciones 5.1 y 5.2)
            if (string.IsNullOrEmpty(localidadIngresada))
            {
                MessageBox.Show(
                    "El campo Localidad debe ser completado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Buscar localidad en el modelo (Excepción 6.1) -> Solo la encuentra si coincide exactamente
            ImposicionCallCenterModelo.Localidad localidad = modelo.BuscarLocalidad(localidadIngresada);

            // Validar existencia
            if (localidad == null)
            {
                MessageBox.Show(
                    "Localidad inexistente.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                TextLocalidad.Clear();
                return;
            }

            // Limpiar destinos actuales -> Buena practica
            ComboDestino.Items.Clear();

            // Cargar destinos disponibles para la localidad
            ComboDestino.Items.Add("Domicilio Destinatario");

            List<ImposicionCallCenterModelo.Agencia> agencias = modelo.ObtenerAgencias(localidadIngresada);

            List<ImposicionCallCenterModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidadIngresada);

            // Agregar agencias
            foreach (ImposicionCallCenterModelo.Agencia agencia in agencias)
            {
                ComboDestino.Items.Add(agencia.Nombre);
            }

            // Agregar CDs
            foreach (ImposicionCallCenterModelo.CentroDistribucion cd in cds)
            {
                ComboDestino.Items.Add(cd.Nombre);
            }

            MessageBox.Show(
                "Localidad encontrada correctamente.",
                "Búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            // Validar cliente seleccionado (No vacío)
            if (string.IsNullOrEmpty(LabelNombre.Text))
            {
                MessageBox.Show(
                    "Debe buscar y seleccionar un cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar localidad destino (No vacío)
            if (string.IsNullOrEmpty(TextLocalidad.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una localidad destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar destino seleccionado (No vacío)
            if (ComboDestino.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar calle seleccionada (No vacío)
            if (string.IsNullOrEmpty(TextCalle.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una calle destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //Validar Altura (No vacío)
            if (string.IsNullOrEmpty(TextAltura.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una altura destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
                return;
            }

            // Validar nombre destinatario (No vacío)
            if (string.IsNullOrEmpty(TextNombre.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar nombre destinatario (Que sea texto)
            if (TextNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El campo Nombre no puede contener caracteres numéricos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            // Validar apellido destinatario (No vacío)
            if (string.IsNullOrEmpty(TextApellido.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un apellido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar apellido destinatario (Que sea texto)
            if (TextApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El campo Apellido no puede contener caracteres numéricos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //Validar DNI (No vacío)
            string dniTexto = TextDni.Text.Trim();
            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show(
                    "Debe ingresar un DNI.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //Validar DNI (Que sean 8 numeros)
            if (dniTexto.Length != 8 || !dniTexto.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El campo DNI no puede contener caracteres alfabéticos o especiales y debe contener 8 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //Validar Teléfono (No vacío)
            string telefonoTexto = TextTEL.Text.Trim();
            if (string.IsNullOrEmpty(telefonoTexto))
            {
                MessageBox.Show(
                   "Debe ingresar un Telefono.",
                   "Validación",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            // Validar telefono (Numérico y que sean 10 digitos)
            if (telefonoTexto.Length != 10 || !telefonoTexto.All(char.IsDigit))
            {
                MessageBox.Show(
                   "El campo Teléfono no puede contener caracteres alfabéticos o especiales y debe contener 10 dígitos.",
                   "Validación",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            // Validar dimensión seleccionada (No vacío)
            if (ComboDimension.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una dimensión.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Buscar cliente seleccionado
            ImposicionCallCenterModelo.Cliente cliente = modelo.BuscarCliente(TxtCuit.Text.Trim());

            // Crear encomienda
            ImposicionCallCenterModelo.Encomienda encomienda = new ImposicionCallCenterModelo.Encomienda
            {
                Cliente = cliente,

                LocalidadDestino = TextLocalidad.Text,

                Destino = ComboDestino.SelectedItem.ToString(),

                CalleDestino = TextCalle.Text,

                AlturaDestino = TextAltura.Text,

                NombreDestinatario = TextNombre.Text,

                ApellidoDestinatario = TextApellido.Text,

                DniDestinatario = TextDni.Text,

                TelefonoDestinatario = TextTEL.Text,

                Dimension = ComboDimension.SelectedItem.ToString()
            };

            // Guardar encomienda en el modelo (se le asigna Tracking y Estado automáticamente)
            modelo.GuardarEncomienda(encomienda);

            // Mostrar mensaje de confirmación con el número de Tracking (Cumpliendo el Paso 12)
            MessageBox.Show(
                "Operación exitosa",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpiar formulario
            TxtCuit.Clear();
            TextLocalidad.Clear();
            TextCalle.Clear();
            TextAltura.Clear();
            TextNombre.Clear();
            TextApellido.Clear();
            TextDni.Clear();
            TextTEL.Clear();

            ComboDestino.SelectedIndex = -1;
            ComboDimension.SelectedIndex = -1;

            LabelNombre.Text = "";
            LabelApellido.Text = "";
            LabelTelefono.Text = "";
            LabelCalle.Text = "";
            LabelAltura.Text = "";
            LabelLocalidad.Text = "";

            // Rehabilitar edición
            TextCalle.Enabled = true;
            TextAltura.Enabled = true;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar formulario
            TxtCuit.Clear();
            TextLocalidad.Clear();
            TextCalle.Clear();
            TextAltura.Clear();
            TextNombre.Clear();
            TextApellido.Clear();
            TextDni.Clear();
            TextTEL.Clear();

            ComboDestino.SelectedIndex = -1;
            ComboDimension.SelectedIndex = -1;

            LabelNombre.Text = "";
            LabelApellido.Text = "";
            LabelTelefono.Text = "";
            LabelCalle.Text = "";
            LabelAltura.Text = "";
            LabelLocalidad.Text = "";

            // Rehabilitar edición
            TextCalle.Enabled = true;
            TextAltura.Enabled = true;

            // 2. Cerrar el formulario para volver al menú principal 
            // (Asumiendo que esta pantalla se abrió desde un menú principal)
            // ACA FALTA LA LINEA PARA CERRAR, PERO AUN NO HAY MENU -> this.Close();
        }
    }
}