namespace tutasa.ConsultaEstadoInterna
{
    partial class ConsultaEstadoInterna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TextNGuia = new TextBox();
            BtnBuscar = new Button();
            BtnCerrar = new Button();
            GrupoDatosEncomienda = new GroupBox();
            LabelFechaActualizacion = new Label();
            LabelUbicacionActual = new Label();
            LabelEstadoActual = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            GrupoHistorial = new GroupBox();
            ListViewHistorial = new ListView();
            ColumnaFechaYHora = new ColumnHeader();
            ColumnaEstado = new ColumnHeader();
            ColumnaUbicacion = new ColumnHeader();
            GrupoDatosEncomienda.SuspendLayout();
            GrupoHistorial.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 1;
            label1.Text = "Estado de Encomienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 40);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "N°Guía";
            // 
            // TextNGuia
            // 
            TextNGuia.Location = new Point(71, 37);
            TextNGuia.Name = "TextNGuia";
            TextNGuia.Size = new Size(205, 23);
            TextNGuia.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(284, 35);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 25);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(486, 434);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(75, 25);
            BtnCerrar.TabIndex = 12;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // GrupoDatosEncomienda
            // 
            GrupoDatosEncomienda.Controls.Add(LabelFechaActualizacion);
            GrupoDatosEncomienda.Controls.Add(LabelUbicacionActual);
            GrupoDatosEncomienda.Controls.Add(LabelEstadoActual);
            GrupoDatosEncomienda.Controls.Add(label14);
            GrupoDatosEncomienda.Controls.Add(label15);
            GrupoDatosEncomienda.Controls.Add(label16);
            GrupoDatosEncomienda.Location = new Point(15, 70);
            GrupoDatosEncomienda.Name = "GrupoDatosEncomienda";
            GrupoDatosEncomienda.Size = new Size(545, 121);
            GrupoDatosEncomienda.TabIndex = 17;
            GrupoDatosEncomienda.TabStop = false;
            GrupoDatosEncomienda.Text = "Datos de Encomienda";
            // 
            // LabelFechaActualizacion
            // 
            LabelFechaActualizacion.AutoSize = true;
            LabelFechaActualizacion.Location = new Point(180, 90);
            LabelFechaActualizacion.Name = "LabelFechaActualizacion";
            LabelFechaActualizacion.Size = new Size(0, 15);
            LabelFechaActualizacion.TabIndex = 22;
            // 
            // LabelUbicacionActual
            // 
            LabelUbicacionActual.AutoSize = true;
            LabelUbicacionActual.Location = new Point(180, 60);
            LabelUbicacionActual.Name = "LabelUbicacionActual";
            LabelUbicacionActual.Size = new Size(0, 15);
            LabelUbicacionActual.TabIndex = 21;
            // 
            // LabelEstadoActual
            // 
            LabelEstadoActual.AutoSize = true;
            LabelEstadoActual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEstadoActual.Location = new Point(180, 30);
            LabelEstadoActual.Name = "LabelEstadoActual";
            LabelEstadoActual.Size = new Size(0, 17);
            LabelEstadoActual.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 90);
            label14.Name = "label14";
            label14.Size = new Size(136, 15);
            label14.TabIndex = 19;
            label14.Text = "Ultima fecha actualizada";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 60);
            label15.Name = "label15";
            label15.Size = new Size(97, 15);
            label15.TabIndex = 18;
            label15.Text = "Ubicación Actual";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(9, 30);
            label16.Name = "label16";
            label16.Size = new Size(91, 17);
            label16.TabIndex = 17;
            label16.Text = "Estado Actual";
            // 
            // GrupoHistorial
            // 
            GrupoHistorial.Controls.Add(ListViewHistorial);
            GrupoHistorial.Location = new Point(15, 197);
            GrupoHistorial.Name = "GrupoHistorial";
            GrupoHistorial.Size = new Size(545, 231);
            GrupoHistorial.TabIndex = 18;
            GrupoHistorial.TabStop = false;
            GrupoHistorial.Text = "Historial";
            // 
            // ListViewHistorial
            // 
            ListViewHistorial.Columns.AddRange(new ColumnHeader[] { ColumnaFechaYHora, ColumnaEstado, ColumnaUbicacion });
            ListViewHistorial.Location = new Point(9, 28);
            ListViewHistorial.Name = "ListViewHistorial";
            ListViewHistorial.Size = new Size(523, 188);
            ListViewHistorial.TabIndex = 6;
            ListViewHistorial.UseCompatibleStateImageBehavior = false;
            ListViewHistorial.View = View.Details;
            // 
            // ColumnaFechaYHora
            // 
            ColumnaFechaYHora.Text = "Fecha y Hora";
            ColumnaFechaYHora.Width = 150;
            // 
            // ColumnaEstado
            // 
            ColumnaEstado.Text = "Estado";
            ColumnaEstado.Width = 150;
            // 
            // ColumnaUbicacion
            // 
            ColumnaUbicacion.Text = "Ubicación";
            ColumnaUbicacion.Width = 220;
            // 
            // ConsultaEstadoInterna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 469);
            Controls.Add(GrupoHistorial);
            Controls.Add(GrupoDatosEncomienda);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnBuscar);
            Controls.Add(TextNGuia);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaEstadoInterna";
            Text = "ConsultaEstadoInterna";
            GrupoDatosEncomienda.ResumeLayout(false);
            GrupoDatosEncomienda.PerformLayout();
            GrupoHistorial.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextNGuia;
        private Button BtnBuscar;
        private Button BtnCerrar;
        private GroupBox GrupoDatosEncomienda;
        private Label LabelFechaActualizacion;
        private Label LabelUbicacionActual;
        private Label LabelEstadoActual;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox GrupoHistorial;
        private ListView ListViewHistorial;
        private ColumnHeader ColumnaFechaYHora;
        private ColumnHeader ColumnaEstado;
        private ColumnHeader ColumnaUbicacion;
    }
}