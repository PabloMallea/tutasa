using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutasa.Imposicion_Agencia
{
    public partial class Imposicion_Agencia : Form
    {
        // Instancia del modelo de imposición de Agencia
        private ImposicionAgenciaModelo modelo = new ImposicionAgenciaModelo();

        public Imposicion_Agencia()
        {
            InitializeComponent();
        }

        private void Imposicion_Agencia_Load(object sender, EventArgs e)
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

        private void ComboDestino_SelectedIndexChanged1(object sender, EventArgs e)
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

            List<ImposicionAgenciaModelo.Agencia> agencias = modelo.ObtenerAgencias(localidad);
            List<ImposicionAgenciaModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidad);

            // Buscar en agencias
            foreach (ImposicionAgenciaModelo.Agencia agencia in agencias)
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

            // Buscar en centros de distribución
            foreach (ImposicionAgenciaModelo.CentroDistribucion cd in cds)
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
            string cuit = TxtCuit.Text.Trim();

            // 1. Validar que se haya ingresado CUIT
            if (string.IsNullOrWhiteSpace(cuit))
            {
                MessageBox.Show(
                    "Debe ingresar un CUIT.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Validar que sea numérico y tenga 11 dígitos
            if (cuit.Length != 11 || !cuit.All(char.IsDigit))
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
            ImposicionAgenciaModelo.Cliente cliente = modelo.BuscarCliente(cuit);

            // Validar existencia de cliente
            if (cliente == null)
            {
                MessageBox.Show("El CUIT ingresado no corresponde a un cliente registrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCuit.Clear();

                // SOLUCIÓN: Limpiar los datos del cliente anterior si la búsqueda falla
                LabelNombre.Text = "";
                LabelApellido.Text = "";
                LabelTEL.Text = "";
                return;
            }

            // Completar datos del cliente mapeados al formulario de Agencia
            LabelNombre.Text = cliente.Nombre;
            LabelApellido.Text = cliente.Apellido;
            LabelTEL.Text = cliente.Telefono;
            // Guardamos el CUIT validado en el bolsillo secreto del TextBox
            TxtCuit.Tag = cuit;

        }

        // Este es el botón "Buscar Localidad" mapeado al nombre de tu formulario de Agencia
        private void BotonBuscarD_Click(object sender, EventArgs e)
        {
            // PARCHE VISUAL: Reiniciar siempre la dirección cuando se hace una nueva búsqueda
            TextCalle.Clear();
            TextAltura.Clear();
            TextCalle.Enabled = true;
            TextAltura.Enabled = true;

            string localidadIngresada = TextLocalidad.Text.Trim();

            // 1. Validar que no esté vacío
            if (string.IsNullOrWhiteSpace(localidadIngresada))
            {
                MessageBox.Show(
                    "El campo Localidad debe ser completado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Buscar localidad en el modelo
            ImposicionAgenciaModelo.Localidad localidad = modelo.BuscarLocalidad(localidadIngresada);

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
                //Limpiar el combo para que no queden sucursales viejas
                ComboDestino.Items.Clear();
                return;
            }

            // Limpiar destinos actuales
            ComboDestino.Items.Clear();

            // Cargar destinos disponibles
            ComboDestino.Items.Add("Domicilio Destinatario");

            List<ImposicionAgenciaModelo.Agencia> agencias = modelo.ObtenerAgencias(localidadIngresada);
            List<ImposicionAgenciaModelo.CentroDistribucion> cds = modelo.ObtenerCD(localidadIngresada);

            // Agregar agencias al combo
            foreach (ImposicionAgenciaModelo.Agencia agencia in agencias)
            {
                ComboDestino.Items.Add(agencia.Nombre);
            }

            // Agregar CDs al combo
            foreach (ImposicionAgenciaModelo.CentroDistribucion cd in cds)
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
            // Validar cliente seleccionado
            if (string.IsNullOrWhiteSpace(LabelNombre.Text))
            {
                MessageBox.Show(
                    "Debe buscar y seleccionar un cliente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar localidad destino
            if (string.IsNullOrWhiteSpace(TextLocalidad.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una localidad destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar destino seleccionado
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

            // Validar calle seleccionada
            if (string.IsNullOrWhiteSpace(TextCalle.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una calle destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar Altura vacía
            if (string.IsNullOrWhiteSpace(TextAltura.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una altura destino.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                 );
                return;
            }

            // Validar nombre destinatario
            if (string.IsNullOrWhiteSpace(TextNombre.Text))
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

            // Validar apellido destinatario
            if (string.IsNullOrWhiteSpace(TextApellido.Text))
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

            // Validar DNI vacío
            string dniTexto = TextDNI.Text.Trim(); // Cambiado a TextDNI por tu UI
            if (string.IsNullOrWhiteSpace(dniTexto))
            {
                MessageBox.Show(
                    "Debe ingresar un DNI.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar DNI (8 dígitos numéricos)
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

            // Validar Teléfono vacío
            string telefonoTexto = TextTEL.Text.Trim();
            if (string.IsNullOrWhiteSpace(telefonoTexto))
            {
                MessageBox.Show(
                   "Debe ingresar un Telefono.",
                   "Validación",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            // Validar teléfono (10 dígitos numéricos)
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

            // Validar dimensión seleccionada
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

            // --- PARCHE DE SEGURIDAD DEFINITIVO: Validación por llave primaria ---
            // Verificamos si nunca se buscó (Tag nulo) o si el texto actual es distinto al que se validó
            if (TxtCuit.Tag == null || TxtCuit.Text.Trim() != TxtCuit.Tag.ToString())
            {
                MessageBox.Show("El CUIT fue alterado o no ha sido validado. Por favor, presione el botón Buscar Cliente.", "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si llegamos acá, es 100% seguro que el CUIT en pantalla es el que se buscó
            ImposicionAgenciaModelo.Cliente cliente = modelo.BuscarCliente(TxtCuit.Text.Trim());

            // --- PARCHE DE SEGURIDAD 2: Verifica que la Localidad y Destino coincidan ---
            string destinoSeleccionado = ComboDestino.SelectedItem.ToString();
            bool destinoValido = false;

            if (destinoSeleccionado == "Domicilio Destinatario")
            {
                destinoValido = true;
            }
            else
            {
                // Revisa si el destino seleccionado está en la lista de la localidad actual
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

            // --- CREACIÓN LIMPIA: Aplicando .Trim() a todo ---
            ImposicionAgenciaModelo.Guia Guia = new ImposicionAgenciaModelo.Guia
            {
                Cliente = cliente,
                LocalidadDestino = TextLocalidad.Text.Trim(),
                Destino = ComboDestino.SelectedItem.ToString(),
                CalleDestino = TextCalle.Text.Trim(),
                AlturaDestino = TextAltura.Text.Trim(),
                NombreDestinatario = TextNombre.Text.Trim(),
                ApellidoDestinatario = TextApellido.Text.Trim(),
                DniDestinatario = TextDNI.Text.Trim(),
                TelefonoDestinatario = TextTEL.Text.Trim(),
                Dimension = ComboDimension.SelectedItem.ToString()
            };

            // --- GUARDADO CON MANEJO DE EXCEPCIONES ---
            try
            {
                // Guardamos la guía en el modelo y atrapamos el número que nos devuelve
                int numeroGuiaGenerado = modelo.GuardarGuia(Guia);

                // Mostramos el mensaje de éxito incluyendo el número de Tracking
                MessageBox.Show(
                    $"Operación exitosa.\n\nEl paquete ha sido impuesto en la agencia.\nNúmero de Guía / Tracking: {numeroGuiaGenerado}",
                    "Confirmación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // --- LIMPIEZA DE PANTALLA ---
                TxtCuit.Clear();
                TxtCuit.Tag = null; // Vaciamos el bolsillo secreto
                TextLocalidad.Clear();
                TextCalle.Clear();
                TextAltura.Clear();
                TextNombre.Clear();
                TextApellido.Clear();
                TextDNI.Clear();
                TextTEL.Clear();

                ComboDestino.SelectedIndex = -1;
                ComboDimension.SelectedIndex = -1;

                LabelNombre.Text = "";
                LabelApellido.Text = "";
                LabelTEL.Text = "";

                // Rehabilitar edición de dirección manual por defecto
                TextCalle.Enabled = true;
                TextAltura.Enabled = true;
            }
            catch (Exception ex)
            {
                // Si el Modelo detecta que no hay CD en el destino, lo atajamos aquí
                MessageBox.Show(
                    ex.Message,
                    "Error de Regla de Negocio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Si tenés un botón Cancelar asociado en tu diseño, podés usar este código:
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            TxtCuit.Clear();
            TxtCuit.Tag = null; // Vaciamos el bolsillo secreto
            TextLocalidad.Clear();
            TextCalle.Clear();
            TextAltura.Clear();
            TextNombre.Clear();
            TextApellido.Clear();
            TextDNI.Clear();
            TextTEL.Clear();

            ComboDestino.SelectedIndex = -1;
            ComboDimension.SelectedIndex = -1;

            LabelNombre.Text = "";
            LabelApellido.Text = "";
            LabelTEL.Text = "";

            TextCalle.Enabled = true;
            TextAltura.Enabled = true;

            // 2. Cerrar el formulario para volver al menú principal 
            // (Asumiendo que esta pantalla se abrió desde un menú principal)
            // ACA FALTA LA LINEA PARA CERRAR, PERO AUN NO HAY MENU -> this.Close();
        }

        private void GrupoCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}