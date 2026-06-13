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
                // Limpiar los datos del cliente anterior si la búsqueda falla
                LabelNombre.Text = "";
                LabelApellido.Text = "";
                LabelTelefono.Text = "";
                return;
            }

            // A diferencia del Call Center, acá solo mostramos 3 datos
            LabelNombre.Text = cliente.Nombre;
            LabelApellido.Text = cliente.Apellido;
            LabelTelefono.Text = cliente.Telefono;
        }

        private void BotonBuscarLocalidad_Click(object sender, EventArgs e)
        {
            // PARCHE VISUAL: Reiniciar siempre la dirección cuando se hace una nueva búsqueda
            TextCalle.Clear();
            TextAltura.Clear();
            TextCalle.Enabled = true;
            TextAltura.Enabled = true;

            string localidadIngresada = TextLocalidad.Text.Trim();

            if (string.IsNullOrWhiteSpace(localidadIngresada))
            {
                // Mensaje original de tu código CD
                MessageBox.Show("Debe ingresar una localidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImposicionCDModelo.Localidad localidad = modelo.BuscarLocalidad(localidadIngresada);

            if (localidad == null)
            {
                // Mensaje original de tu código CD
                MessageBox.Show("No se encontró la localidad ingresada.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextLocalidad.Clear();
                // Limpiar el combo para que no queden sucursales viejas
                ComboDestino.Items.Clear();
                return;
            }

            ComboDestino.Items.Clear();
            ComboDestino.Items.Add("Domicilio Destinatario");

            List<ImposicionCDModelo.Agencia> agencias = modelo.ObtenerAgencias(localidadIngresada);
            List<ImposicionCDModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidadIngresada);

            foreach (ImposicionCDModelo.Agencia agencia in agencias)
            {
                ComboDestino.Items.Add(agencia.Nombre);
            }

            foreach (ImposicionCDModelo.CentroDistribucion cd in cds)
            {
                ComboDestino.Items.Add(cd.Nombre);
            }

            MessageBox.Show("Localidad encontrada correctamente.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string localidad = TextLocalidad.Text.Trim();
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

            if (string.IsNullOrWhiteSpace(TextLocalidad.Text))
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
                // Adaptado de tu mensaje original (le saqué la palabra "numérica")
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

            // 1. Limpiamos y forzamos a que siempre use punto
            string textoPeso = TextPeso.Text.Trim().Replace(",", ".");

            if (string.IsNullOrWhiteSpace(textoPeso))
            {
                MessageBox.Show("Debe ingresar un peso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que sea un número decimal (usando InvariantCulture para que no falle en otras PCs) y positivo
            if (!decimal.TryParse(textoPeso, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("Debe ingresar un peso numérico válido y mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Calculamos la dimensión final para guardarla en el objeto
            string dimensionFinal = modelo.CalcularDimension(peso);


            // --- 2. CREACIÓN Y GUARDADO ---

            ImposicionCDModelo.Cliente cliente = modelo.BuscarCliente(TxtCuit.Text.Trim());

            // PARCHE DE SEGURIDAD: Evita que confirmen si alteraron el CUIT después de buscarlo
            if (cliente == null || cliente.Nombre != LabelNombre.Text)
            {
                MessageBox.Show("El CUIT actual no coincide con el cliente buscado. Vuelva a buscar el cliente.", "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PARCHE DE SEGURIDAD 2: Verifica que la Localidad exista y que el destino coincida con ella
            string destinoSeleccionado = ComboDestino.SelectedItem.ToString();
            bool destinoValido = false;

            if (destinoSeleccionado == "Domicilio Destinatario")
            {
                destinoValido = true;
            }
            else
            {
                // Revisa si el destino seleccionado está en la lista de agencias o CDs de la localidad escrita actualmente
                if (modelo.ObtenerAgencias(TextLocalidad.Text.Trim()).Any(a => a.Nombre == destinoSeleccionado) ||
                    modelo.ObtenerCD(TextLocalidad.Text.Trim()).Any(c => c.Nombre == destinoSeleccionado))
                {
                    destinoValido = true;
                }
            }

            if (modelo.BuscarLocalidad(TextLocalidad.Text.Trim()) == null || !destinoValido)
            {
                MessageBox.Show("La localidad fue alterada después de la búsqueda o el destino no corresponde. Vuelva a buscar la localidad.", "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- CREACIÓN DE LA Guia ---
            ImposicionCDModelo.Guia Guia = new ImposicionCDModelo.Guia
            {
                Cliente = cliente,
                LocalidadDestino = TextLocalidad.Text.Trim(),
                Destino = ComboDestino.SelectedItem.ToString(),
                CalleDestino = TextCalle.Text.Trim(),
                AlturaDestino = TextAltura.Text.Trim(),
                NombreDestinatario = TextNombre.Text.Trim(),
                ApellidoDestinatario = TextApellido.Text.Trim(),
                DniDestinatario = dniTexto,
                TelefonoDestinatario = telefonoTexto,
                Peso = peso.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture), //Guardar como string siempre con punto, ignorando la compu local
                Dimension = dimensionFinal
            };

            modelo.GuardarGuia(Guia);

            MessageBox.Show("Operación exitosa", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- 3. LIMPIEZA DE PANTALLA ---

            TxtCuit.Clear();
            TextLocalidad.Clear();
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

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            TxtCuit.Clear();
            TextLocalidad.Clear();
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

            this.Close();
        }

        private void LabelTamaño_Click(object sender, EventArgs e)
        {

        }

        private void LabelDimension_Click(object sender, EventArgs e)
        {

        }

        private void TextPeso_TextChanged(object sender, EventArgs e)
        {
            // 1. Limpiamos y forzamos a que siempre use punto
            string textoPeso = TextPeso.Text.Trim().Replace(",", ".");

            // 2. Validamos usando InvariantCulture (exactamente igual que en el botón)
            if (decimal.TryParse(textoPeso, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal peso) && peso > 0)
            {
                // Si es válido, calculamos la dimensión y actualizamos solo el recuadro de la derecha
                string dimensionCalculada = modelo.CalcularDimension(peso);
                LabelTamaño.Text = dimensionCalculada;
            }
            else
            {
                // Si el campo está vacío o se ingresa un valor no válido, volvemos al estado original
                LabelTamaño.Text = "S | M | L | XL";
            }
        }

        private void GrupoCliente_Enter(object sender, EventArgs e)
        {

        }

        private void Impiscion_CD_Load_1(object sender, EventArgs e)
        {

        }
    }
}