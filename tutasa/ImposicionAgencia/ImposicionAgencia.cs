using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tutasa.Imposicion_Agencia
{
    public partial class Imposicion_Agencia : Form
    {
        // Instancia del modelo de imposición
        private ImposicionAgenciaModelo modelo =
            new ImposicionAgenciaModelo();

        public Imposicion_Agencia()
        {
            InitializeComponent();
        }

        private void Imposicion_Agencia_Load(object sender, EventArgs e)
        {
            // Obtener dimensiones desde el modelo
            List<string> dimensiones =
                modelo.ObtenerDimensiones();

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
            // Validar selección
            if (ComboDestino.SelectedItem == null)
            {
                return;
            }

            // Obtener localidad
            ImposicionAgenciaModelo.Localidad localidad =
                modelo.BuscarLocalidad(TextLocalidad.Text.Trim());

            // Validar localidad encontrada
            if (localidad == null)
            {
                return;
            }

            // Buscar destino seleccionado
            foreach (ImposicionAgenciaModelo.Destino destino
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
            ImposicionAgenciaModelo.Cliente cliente =
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
            LabelTEL.Text = cliente.Telefono;
        }

        private void BotonBuscarD_Click(object sender, EventArgs e)
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
            ImposicionAgenciaModelo.Localidad localidad =
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
            foreach (ImposicionAgenciaModelo.Destino destino
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

            // Validar teléfono numérico
            long telefono;

            if (!long.TryParse(TextTEL.Text, out telefono))
            {
                MessageBox.Show(
                    "Debe ingresar un teléfono numérico.",
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

            // Buscar cliente seleccionado
            ImposicionAgenciaModelo.Cliente cliente =
                modelo.BuscarCliente(
                    TxtCuit.Text.Trim()
                );

            // Crear encomienda
            ImposicionAgenciaModelo.Encomienda encomienda =
                new ImposicionAgenciaModelo.Encomienda
                {
                    Cliente = cliente,

                    LocalidadDestino =
                        TextLocalidad.Text,

                    Destino =
                        ComboDestino.SelectedItem.ToString(),

                    CalleDestino =
                        TextCalle.Text,

                    AlturaDestino =
                        TextAltura.Text,

                    NombreDestinatario =
                        TextNombre.Text,

                    ApellidoDestinatario =
                        TextApellido.Text,

                    DniDestinatario =
                        TextDNI.Text,

                    TelefonoDestinatario =
                        TextTEL.Text,

                    Dimension =
                        ComboDimension.SelectedItem.ToString()
                };

            // Guardar encomienda en el modelo
            modelo.GuardarEncomienda(encomienda);

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

            ComboDestino.SelectedIndex = -1;
            ComboDimension.SelectedIndex = -1;

            LabelNombre.Text = "";
            LabelApellido.Text = "";
            LabelTEL.Text = "";

            // Rehabilitar edición
            TextCalle.Enabled = true;
            TextAltura.Enabled = true;
        }


    }
}