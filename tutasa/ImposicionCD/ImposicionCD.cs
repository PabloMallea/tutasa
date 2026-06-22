using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tutasa.Imposicion_CD
{
    public partial class Impiscion_CD : Form
    {
        private ImposicionCDModelo modelo = new ImposicionCDModelo();

        public Impiscion_CD()
        {
            InitializeComponent();
        }

        private void Impiscion_CD_Load(object sender, EventArgs e)
        {
            // --- Cargar Provincias al iniciar la pantalla ---
            List<ImposicionCDModelo.Provincias> provincias = modelo.ObtenerProvincias();
            ComboProvincias.DataSource = provincias;
            ComboProvincias.DisplayMember = "nombreProvincia";
            ComboProvincias.ValueMember = "idProvincia";
            ComboProvincias.SelectedIndex = -1;
        }

        private void BotonBuscarC_Click(object sender, EventArgs e)
        {
            string cuit = TxtCuit.Text.Trim();

            if (string.IsNullOrWhiteSpace(cuit))
            {
                MessageBox.Show("Debe ingresar un CUIT.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cuit.Length != 11 || !cuit.All(char.IsDigit))
            {
                MessageBox.Show("El campo CUIT debe contener únicamente 11 valores numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImposicionCDModelo.Cliente cliente = modelo.BuscarCliente(cuit);

            if (cliente == null)
            {
                MessageBox.Show("El CUIT ingresado no corresponde a un cliente registrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCuit.Clear();
                LabelNombre.Text = "";
                LabelApellido.Text = "";
                LabelTelefono.Text = "";
                return;
            }

            LabelNombre.Text = cliente.Nombre;
            LabelApellido.Text = cliente.Apellido;
            LabelTelefono.Text = cliente.Telefono;

            TxtCuit.Tag = cuit;
        }

        private void ComboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboProvincias.SelectedIndex == -1 || ComboProvincias.SelectedValue == null)
            {
                ComboLocalidad.DataSource = null;
                return;
            }

            if (ComboProvincias.SelectedValue is int idProvincia)
            {
                List<ImposicionCDModelo.Localidad> localidades = modelo.ObtenerLocalidadesPorProvincia(idProvincia);
                ComboLocalidad.DataSource = localidades;
                ComboLocalidad.DisplayMember = "Nombre";
                ComboLocalidad.ValueMember = "Nombre";
                ComboLocalidad.SelectedIndex = -1;
            }

            ComboDestino.Items.Clear();
            TextCalle.Clear();
            TextAltura.Clear();
        }

        private void ComboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDestino.Items.Clear();
            TextCalle.Clear();
            TextAltura.Clear();
            TextCalle.Enabled = true;
            TextAltura.Enabled = true;

            if (ComboLocalidad.SelectedIndex == -1 || ComboLocalidad.SelectedValue == null) return;

            string localidadSeleccionada = ComboLocalidad.SelectedValue.ToString();
            ComboDestino.Items.Add("Domicilio Destinatario");

            List<ImposicionCDModelo.Agencia> agencias = modelo.ObtenerAgencias(localidadSeleccionada);
            List<ImposicionCDModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidadSeleccionada);

            foreach (ImposicionCDModelo.Agencia agencia in agencias)
            {
                ComboDestino.Items.Add(agencia.Nombre);
            }

            foreach (ImposicionCDModelo.CentroDistribucion cd in cds)
            {
                ComboDestino.Items.Add(cd.Nombre);
            }
        }

        private void ComboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDestino.SelectedItem == null) return;

            string destino = ComboDestino.SelectedItem.ToString();

            if (destino == "Domicilio Destinatario")
            {
                TextCalle.Enabled = true;
                TextAltura.Enabled = true;
                TextCalle.Clear();
                TextAltura.Clear();
                return;
            }

            // AHORA LEE DEL COMBO
            string localidad = ComboLocalidad.Text.Trim();

            List<ImposicionCDModelo.Agencia> agencias = modelo.ObtenerAgencias(localidad);
            List<ImposicionCDModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidad);

            foreach (ImposicionCDModelo.Agencia agencia in agencias)
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

            foreach (ImposicionCDModelo.CentroDistribucion cd in cds)
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

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            // --- 1. VALIDACIÓN SECUENCIAL EN CASCADA ---

            if (string.IsNullOrWhiteSpace(LabelNombre.Text))
            {
                MessageBox.Show("Debe buscar y seleccionar un cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDAMOS EL COMBO EN LUGAR DEL TEXTBOX VIEJO
            if (string.IsNullOrWhiteSpace(ComboLocalidad.Text))
            {
                MessageBox.Show("Debe ingresar una localidad destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ComboDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextCalle.Text))
            {
                MessageBox.Show("Debe ingresar una calle destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextAltura.Text))
            {
                MessageBox.Show("Debe ingresar una altura destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo Nombre no puede contener caracteres numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El campo Apellido no puede contener caracteres numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dniTexto = TextDNI.Text.Trim();

            if (string.IsNullOrWhiteSpace(dniTexto))
            {
                MessageBox.Show("Debe ingresar un DNI.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dniTexto.Length != 8 || !dniTexto.All(char.IsDigit))
            {
                MessageBox.Show("El campo DNI no puede contener caracteres alfabéticos o especiales y debe contener 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string telefonoTexto = TextTEL.Text.Trim();

            if (string.IsNullOrWhiteSpace(telefonoTexto))
            {
                MessageBox.Show("Debe ingresar un teléfono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (telefonoTexto.Length != 10 || !telefonoTexto.All(char.IsDigit))
            {
                MessageBox.Show("El campo Teléfono no puede contener caracteres alfabéticos o especiales y debe contener 10 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 1. VALIDACIÓN DEL PESO ---

            string textoPeso = TextPeso.Text.Trim().Replace(",", ".");

            if (string.IsNullOrWhiteSpace(textoPeso))
            {
                MessageBox.Show("Debe ingresar un peso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textoPeso, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("Debe ingresar un peso numérico válido y mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dimensionFinal = modelo.CalcularDimension(peso);

            // --- PARCHE DE SEGURIDAD DEFINITIVO: Validación por llave primaria ---
            if (TxtCuit.Tag == null || TxtCuit.Text.Trim() != TxtCuit.Tag.ToString())
            {
                MessageBox.Show("El CUIT fue alterado o no ha sido validado. Por favor, presione el botón Buscar Cliente.", "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cliente = modelo.BuscarCliente(TxtCuit.Text.Trim());

            // ¡BORRAMOS EL VIEJO PARCHE 2 QUE VALIDABA LA LOCALIDAD A MANO!

            // --- CREACIÓN DE LA Guia ---
            ImposicionCDModelo.Guia Guia = new ImposicionCDModelo.Guia
            {
                Cliente = cliente,
                LocalidadDestino = ComboLocalidad.Text.Trim(), // AHORA TOMA DEL COMBO
                Destino = ComboDestino.SelectedItem.ToString(),
                CalleDestino = TextCalle.Text.Trim(),
                AlturaDestino = TextAltura.Text.Trim(),
                NombreDestinatario = TextNombre.Text.Trim(),
                ApellidoDestinatario = TextApellido.Text.Trim(),
                DniDestinatario = dniTexto,
                TelefonoDestinatario = telefonoTexto,
                Peso = peso.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture),
                Dimension = dimensionFinal
            };

            // --- GUARDADO CON MANEJO DE EXCEPCIONES --- 
            try
            {
                int numeroGuiaGenerado = modelo.GuardarGuia(Guia);

                MessageBox.Show(
                     $"Operación exitosa.\n\nEl paquete ha sido impuesto y admitido en el sistema.\nNúmero de Guía / Tracking: {numeroGuiaGenerado}",
                     "Confirmación",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                 );

                // --- 3. LIMPIEZA DE PANTALLA ---
                TxtCuit.Clear();
                TxtCuit.Tag = null;
                ComboProvincias.SelectedIndex = -1; // NUEVA LIMPIEZA
                ComboLocalidad.DataSource = null;   // NUEVA LIMPIEZA
                TextCalle.Clear();
                TextAltura.Clear();
                TextNombre.Clear();
                TextApellido.Clear();
                TextDNI.Clear();
                TextTEL.Clear();
                TextPeso.Clear();

                ComboDestino.SelectedIndex = -1;

                LabelNombre.Text = "";
                LabelApellido.Text = "";
                LabelTelefono.Text = "";
                LabelTamaño.Text = "S | M | L | XL";

                TextCalle.Enabled = true;
                TextAltura.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de Regla de Negocio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void TextPeso_TextChanged(object sender, EventArgs e)
        {
            string textoPeso = TextPeso.Text.Trim().Replace(",", ".");

            if (decimal.TryParse(textoPeso, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal peso) && peso > 0)
            {
                string dimensionCalculada = modelo.CalcularDimension(peso);
                LabelTamaño.Text = dimensionCalculada;
            }
            else
            {
                LabelTamaño.Text = "S | M | L | XL";
            }
        }

        private void ButtonCancelar_Click_1(object sender, EventArgs e)
        {
            TxtCuit.Clear();
            TxtCuit.Tag = null;
            ComboProvincias.SelectedIndex = -1; // NUEVA LIMPIEZA
            ComboLocalidad.DataSource = null;   // NUEVA LIMPIEZA
            TextCalle.Clear();
            TextAltura.Clear();
            TextNombre.Clear();
            TextApellido.Clear();
            TextDNI.Clear();
            TextTEL.Clear();
            TextPeso.Clear();

            ComboDestino.SelectedIndex = -1;

            LabelNombre.Text = "";
            LabelApellido.Text = "";
            LabelTelefono.Text = "";
            LabelTamaño.Text = "S | M | L | XL";

            TextCalle.Enabled = true;
            TextAltura.Enabled = true;

            //this.Close();
        }
    }
}