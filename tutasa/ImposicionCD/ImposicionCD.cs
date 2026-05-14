using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tutasa.Imposicion_CD
{
    public partial class Impiscion_CD : Form
    {
        // Instancia del modelo de imposición
        private tutasa.ImposicionCD.ImposicionCDModelo modelo =
            new tutasa.ImposicionCD.ImposicionCDModelo();

        public Impiscion_CD()
        {
            InitializeComponent();
        }

        private void Impiscion_CD_Load(object sender, EventArgs e)
        {

        }

        private void ComboDestino_SelectedIndexChanged1(object sender, EventArgs e)
        {
            // Validar selección
            if (ComboDestino.SelectedItem == null)
            {
                return;
            }

            // Obtener localidad
            tutasa.ImposicionCD.ImposicionCDModelo.Localidad localidad =
                modelo.BuscarLocalidad(TextLocalidad.Text.Trim());

            // Buscar destino seleccionado
            foreach (tutasa.ImposicionCD.ImposicionCDModelo.Destino destino
                in localidad.Destinos)
            {
                // Si coincide nombre
                if (destino.Nombre ==
                    ComboDestino.SelectedItem.ToString())
                {
                    // Si es domicilio destinatario
                    if (destino.Nombre ==
                        "Domicilio Destinatario")
                    {
                        // Habilitar edición manual
                        TextCalle.Enabled = true;
                        TextAltura.Enabled = true;

                        // Limpiar datos
                        TextCalle.Clear();
                        TextAltura.Clear();
                    }
                    else
                    {
                        // Completar automáticamente
                        TextCalle.Text = destino.Calle;
                        TextAltura.Text = destino.Altura;

                        // Bloquear edición
                        TextCalle.Enabled = false;
                        TextAltura.Enabled = false;
                    }

                    break;
                }
            }
        }

        private void BotonBuscarC_Click(object sender, EventArgs e)
        {
            // Obtener CUIT ingresado
            string cuit = TxtCuit.Text.Trim();

            // Validar que se haya ingresado CUIT
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

            // Validar que el CUIT sea numérico
            long numero;

            if (!long.TryParse(cuit, out numero))
            {
                MessageBox.Show(
                    "El CUIT debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Buscar cliente en el modelo
            tutasa.ImposicionCD.ImposicionCDModelo.Cliente cliente =
                modelo.BuscarCliente(cuit);

            // Validar existencia de cliente
            if (cliente == null)
            {
                MessageBox.Show(
                    "No se encontró un cliente con el CUIT ingresado.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Completar datos del cliente
            LabelNombre.Text = cliente.Nombre;
            LabelApellido.Text = cliente.Apellido;
            LabelTelefono.Text = cliente.Telefono;
        }

        private void BotonBuscarLocalidad_Click(object sender, EventArgs e)
        {
            // Obtener localidad ingresada
            string localidadIngresada =
                TextLocalidad.Text.Trim();

            // Validar ingreso
            if (string.IsNullOrEmpty(localidadIngresada))
            {
                MessageBox.Show(
                    "Debe ingresar una localidad.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Buscar localidad
            tutasa.ImposicionCD.ImposicionCDModelo.Localidad localidad =
                modelo.BuscarLocalidad(localidadIngresada);

            // Validar existencia
            if (localidad == null)
            {
                MessageBox.Show(
                    "No se encontró la localidad ingresada.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Limpiar destinos actuales
            ComboDestino.Items.Clear();

            // Cargar destinos disponibles para la localidad
            foreach (tutasa.ImposicionCD.ImposicionCDModelo.Destino destino
                in localidad.Destinos)
            {
                ComboDestino.Items.Add(destino.Nombre);
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

            // Validar localidad destino
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

            // Acá podríamos usar esta validación de "Solo validar calle y altura si es domicilio" pero
            // para simplificar validamos calle y altura siempre ya que en agencias y cd se completa automáticamente y no se puede editar,
            //Cualquier cosa me avisas y lo ajusto para que solo valide calle y altura si es domicilio
            /* if (ComboDestino.SelectedItem.ToString() == "Domicilio Destinatario")
             {
                 // Validar calle destino
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

                 // Validar altura numérica
                 long altura;

                 if (!long.TryParse(TextAltura.Text, out altura))
                 {
                     MessageBox.Show(
                         "Debe ingresar una altura numérica.",
                         "Validación",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning
                     );

                     return;
                 }
             }*/

            // Validar calle destino
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

            // Validar altura numérica
            long altura;

            if (!long.TryParse(TextAltura.Text, out altura))
            {
                MessageBox.Show(
                    "Debe ingresar una altura numérica.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar nombre destinatario
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

            // Validar apellido destinatario
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

            // Validar DNI numérico
            long dni;

            if (!long.TryParse(TextDNI.Text, out dni))
            {
                MessageBox.Show(
                    "Debe ingresar un DNI numérico.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar peso numérico
            decimal peso;

            if (!decimal.TryParse(TextPeso.Text, out peso))
            {
                MessageBox.Show(
                    "Debe ingresar un peso numérico.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                "Imposición confirmada.",
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
            TextDNI.Clear();
            TextTEL.Clear();
            TextPeso.Clear();

            ComboDestino.SelectedIndex = -1;

            LabelNombre.Text = "";
            LabelApellido.Text = "";
            LabelTelefono.Text = "";

            // Rehabilitar edición
            //TextCalle.Enabled = true;
            //TextAltura.Enabled = true;
        }

        
    }
}