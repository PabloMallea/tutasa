
using System.Data;

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
            // Validar que se haya ingresado un número de guía
            if (string.IsNullOrWhiteSpace(TextNGuia.Text))
            {
                MessageBox.Show(
                    "Por favor, ingrese un valor.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validar que sea un número válido
            if (!int.TryParse(TextNGuia.Text, out int numeroGuia))
            {
                MessageBox.Show(
                    "Por favor, ingrese un identificador de guía válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Buscar la guía usando el modelo (desde el almacén)
            Guia guiaEncontrada = modelo.BuscarGuiaPorIdentificador(numeroGuia);

            // Validar existencia
            if (guiaEncontrada == null)
            {
                MessageBox.Show(
                    "No se encontró ninguna guía asociada al valor ingresado.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarResultados();
                return;
            }

            // Buscar el historial de movimientos
            List<MovimientoEstado> historial = guiaEncontrada.Historial;

            // Validar que exista historial
            if (historial == null || historial.Count == 0)
            {
                MessageBox.Show(
                    "No se encontró historial de movimientos para esta guía.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarResultados();
                return;
            }

            // Obtener el último movimiento registrado
            MovimientoEstado ultimoMovimiento = historial.OrderByDescending(m => m.FechaHora).FirstOrDefault();
        

            // Completar labels con la información más reciente
            LabelEstadoActual.Text = ultimoMovimiento.Estado.ToString();
            LabelUbicacionActual.Text = ultimoMovimiento.Ubicacion;
            LabelFechaActualizacion.Text = ultimoMovimiento.FechaHora.ToString("dd/MM/yyyy HH:mm");

            // Limpiar historial previo para evitar duplicar resultados
            ListViewHistorial.Items.Clear();

            // Recorrer todos los movimientos del historial
            foreach (MovimientoEstado movimiento in historial)
            {
                // Crear fila utilizando la fecha como primera columna
                ListViewItem item = new ListViewItem(movimiento.FechaHora.ToString("dd/MM/yyyy HH:mm"));

                // Agregar columnas restantes
                item.SubItems.Add(movimiento.Estado.ToString());
                item.SubItems.Add(movimiento.Ubicacion);

                // Agregar fila al ListView
                ListViewHistorial.Items.Add(item);
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
                // Limpiar el campo de búsqueda y resultados
                TextNGuia.Text = "";
                LimpiarResultados();
                TextNGuia.Focus();
            }
        }

        private void LimpiarResultados()
        {
            // Limpiar labels de estado actual
            LabelEstadoActual.Text = "";
            LabelUbicacionActual.Text = "";
            LabelFechaActualizacion.Text = "";

            // Limpiar el ListView del historial
            ListViewHistorial.Items.Clear();
        }
    }
}
