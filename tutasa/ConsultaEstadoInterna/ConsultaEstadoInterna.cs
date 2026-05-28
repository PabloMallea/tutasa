using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tutasa.ConsultaEstadoInterna
{
    public partial class ConsultaEstadoInterna : Form
    {
        // Instancia del modelo
        private ConsultaEstadoInternaModelo modelo = new ConsultaEstadoInternaModelo();

        public ConsultaEstadoInterna()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener número de guía ingresado
            string numeroGuia = TextNGuia.Text.Trim();

            // Validar ingreso
            if (string.IsNullOrEmpty(numeroGuia))
            {
                MessageBox.Show(
                    "Debe ingresar un número de guía.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Buscar encomienda
            ConsultaEstadoInternaModelo.Encomienda encomienda = modelo.BuscarEncomienda(numeroGuia);

            // Validar existencia
            if (encomienda == null)
            {
                MessageBox.Show(
                    "No se encontró la encomienda.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Obtener el último movimiento registrado en el historial.
            // Last() retorna directamente el último elemento de la lista.
            ConsultaEstadoInternaModelo.MovimientoEstado ultimoMovimiento = encomienda.Historial.Last();

            // Completar labels con la información más reciente de la encomienda
            LabelEstadoActual.Text = ultimoMovimiento.Estado;

            LabelUbicacionActual.Text = ultimoMovimiento.Ubicacion;

            LabelFechaActualizacion.Text =
                ultimoMovimiento.FechaHora.ToString("dd/MM/yyyy HH:mm");

            // Limpiar historial previo para evitar duplicar resultados
            // si se realiza una nueva búsqueda
            ListViewHistorial.Items.Clear();

            // Recorrer todos los movimientos del historial de la encomienda
            // para generar una fila por cada estado registrado
            foreach (ConsultaEstadoInternaModelo.MovimientoEstado movimiento
                in encomienda.Historial)
            {
                // Crear fila utilizando la fecha como primera columna
                ListViewItem item =
                    new ListViewItem(
                        movimiento.FechaHora.ToString("dd/MM/yyyy HH:mm")
                    );

                // Agregar columnas restantes
                item.SubItems.Add(movimiento.Estado);
                item.SubItems.Add(movimiento.Ubicacion);

                // Agregar fila al ListView
                ListViewHistorial.Items.Add(item);
            }
        }
        }
    }
