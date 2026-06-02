using System;
using System.Globalization;
using System.Windows.Forms;

namespace tutasa.Admision
{
    public partial class Admision : Form
    {

        public Admision()
        {
            InitializeComponent();
        }

        private AdmisionModelo modelo = new();

        private void Admision_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            btnConfirmar.Enabled = false; // Deshabilitar hasta que se busque una guía
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un número de guía
            if (string.IsNullOrWhiteSpace(intNroGuia.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de guía.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //TODO:Validar formato de guia
           

            // Validar que sea un número válido
            if (!int.TryParse(intNroGuia.Text, out int numeroGuia))
            {
                MessageBox.Show("Por favor, ingrese un número de guía válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar la guía usando el modelo (datos mock por ahora)
            Guia guiaEncontrada = modelo.BuscarGuiaPorIdentificador(numeroGuia);

            // Verificar si se encontró la guía
            if (guiaEncontrada == null)
            {
                MessageBox.Show("No se encontró ninguna guía con ese número.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                return;
            }

            // Buscar el cliente usando el CUIT de la guía
            Cliente clienteEncontrado = modelo.BuscarClientePorCuit(guiaEncontrada.CuitCliente);

            if (clienteEncontrado == null)
            {
                MessageBox.Show("No se encontró el cliente asociado a la guía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarFormulario();
                return;
            }

            // Cargar los datos del cliente (remitente) en la pantalla
            txtNombreRemitente.Text = $"{clienteEncontrado.Nombre} {clienteEncontrado.Apellido}";
            txtCUITCliente.Text = clienteEncontrado.CUIT;
            txtDireccionOrigen.Text = clienteEncontrado.Direccion;

            // Cargar los datos del destinatario en la pantalla
            txtNombreDestinatario.Text = $"{guiaEncontrada.NombreDestinatario} {guiaEncontrada.ApellidoDestinatario}";
            txtDNIDestinatario.Text = guiaEncontrada.DniDestinatario;
            txtDireccionDestino.Text = guiaEncontrada.DireccionDestino;

            // Cargar peso y dimensión precargados
            intPeso.Text = guiaEncontrada.Peso.ToString("0.00");
            txtDimension.Text = guiaEncontrada.Dimension;

            // Habilitar el botón Confirmar
            btnConfirmar.Enabled = true;

            //MessageBox.Show("Guía encontrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarFormulario()
        {
            txtNombreRemitente.Text = "";
            txtCUITCliente.Text = "";
            txtDireccionOrigen.Text = "";
            txtNombreDestinatario.Text = "";
            txtDNIDestinatario.Text = "";
            txtDireccionDestino.Text = "";
            txtDimension.Text = "";
            intPeso.Text = "";
            btnConfirmar.Enabled = false;
        }

        private void intPeso_TextChanged(object sender, EventArgs e)
        {
            // Recalcular la dimensión automáticamente cuando cambia el peso
            ActualizarDimension();
        }

        private void ActualizarDimension()
        {
            // Si el campo está vacío, limpiar la dimensión
            if (string.IsNullOrWhiteSpace(intPeso.Text))
            {
                txtDimension.Text = "";
                return;
            }

            // Normalizar el texto: reemplazar punto por coma para que funcione con la cultura argentina
            string pesoTexto = intPeso.Text.Replace('.', ',');

            // Usar la cultura actual del sistema (en Argentina usa coma como separador decimal)
            if (decimal.TryParse(pesoTexto, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal peso))
            {
                // Validar que el peso sea positivo
                if (peso > 0)
                {
                    string dimensionCalculada = modelo.CalcularDimension(peso);
                    txtDimension.Text = dimensionCalculada;
                }
                else
                {
                    // Peso cero o negativo
                    txtDimension.Text = "";
                    MessageBox.Show(
                        "El peso debe ser mayor a cero.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                // Dato no numérico o caracteres no válidos
                txtDimension.Text = "";
                MessageBox.Show(
                    "Por favor, ingrese un peso válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un número de guía
            if (string.IsNullOrWhiteSpace(intNroGuia.Text) || string.IsNullOrWhiteSpace(txtNGuia.Text))
            {
                MessageBox.Show("Primero debe buscar una guía antes de confirmar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sea un número válido
            if (!int.TryParse(intNroGuia.Text, out int numeroGuia))
            {
                MessageBox.Show("Número de guía inválido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar la guía nuevamente para confirmar
            Guia guiaEncontrada = modelo.BuscarGuiaPorIdentificador(numeroGuia);

            if (guiaEncontrada == null)
            {
                MessageBox.Show("No se pudo encontrar la guía. Por favor, búsquela nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado un peso
            if (string.IsNullOrWhiteSpace(intPeso.Text))
            {
                MessageBox.Show("Por favor, ingrese el peso del paquete.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                intPeso.Focus();
                return;
            }

            // Validar que el peso sea un número válido
            // Normalizar: reemplazar punto por coma para consistencia con cultura argentina
            string pesoTexto = intPeso.Text.Replace('.', ',');
            if (!decimal.TryParse(pesoTexto, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal peso))
            {
                MessageBox.Show("Por favor, ingrese un peso válido (puede usar punto o coma para decimales, ej: 5.5 o 5,5).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                intPeso.Focus();
                return;
            }

            // Validar que el peso sea positivo
            if (peso <= 0)
            {
                MessageBox.Show("El peso debe ser mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                intPeso.Focus();
                return;
            }

            // Calcular la dimensión según el peso ingresado
            string dimensionCalculada = modelo.CalcularDimension(peso);

            // Mostrar la dimensión calculada
            txtDimension.Text = dimensionCalculada;

            // Confirmar con el usuario antes de registrar
            DialogResult resultado = MessageBox.Show(
                $"¿Confirma la admisión de la guía N° {guiaEncontrada.NumeroGuia}?\n\n" +
                $"Peso: {peso:0.00} Kg\n" +
                $"Dimensión: {dimensionCalculada}",
                "Confirmar Admisión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
            {
                return;
            }

            // Registrar la admisión en el modelo
            bool exitoso = modelo.RegistrarAdmision(guiaEncontrada, peso, dimensionCalculada);

            if (exitoso)
            {
                MessageBox.Show(
                    $"La guía N° {guiaEncontrada.NumeroGuia} ha sido admitida correctamente.\n\n" +
                    $"Estado: Admitida\n" +
                    $"Peso: {peso:0.00} Kg\n" +
                    $"Dimensión: {dimensionCalculada}",
                    "Admisión Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpiar el formulario para una nueva admisión
                intNroGuia.Text = "";
                LimpiarFormulario();
                intNroGuia.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Ocurrió un error al registrar la admisión. Por favor, intente nuevamente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Confirmar si realmente quiere cancelar
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar la operación?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Limpiar el formulario
                intNroGuia.Text = "";
                LimpiarFormulario();
                intNroGuia.Focus();
            }
        }
    }
}


