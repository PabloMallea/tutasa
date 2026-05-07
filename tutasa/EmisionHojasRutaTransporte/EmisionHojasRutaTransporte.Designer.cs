namespace tutasa.EmisionHojasRutaTransporte
{
    partial class EmisionHojasRutaTransporte
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
            BtnImprimirResumen = new Button();
            BtnEmitirHojasRuta = new Button();
            GrupoDetalleGuias = new GroupBox();
            ListViewGuias = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            ColumnaDireccion = new ColumnHeader();
            ColumnaTipo = new ColumnHeader();
            ColumnaDimension = new ColumnHeader();
            GrupoHDRPendientes = new GroupBox();
            BtnDeseleccionar = new Button();
            button1 = new Button();
            ListViewRutasPendientes = new ListView();
            ColumnaNHDR = new ColumnHeader();
            ColumnaEmpresa = new ColumnHeader();
            ColumnaServicio = new ColumnHeader();
            ColumnaCantGuias = new ColumnHeader();
            GrupoBusqueda = new GroupBox();
            BtnBuscar = new Button();
            LbServicio = new Label();
            LbEmpresa = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            GrupoDetalleGuias.SuspendLayout();
            GrupoHDRPendientes.SuspendLayout();
            GrupoBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // BtnImprimirResumen
            // 
            BtnImprimirResumen.Location = new Point(559, 509);
            BtnImprimirResumen.Name = "BtnImprimirResumen";
            BtnImprimirResumen.Size = new Size(150, 25);
            BtnImprimirResumen.TabIndex = 9;
            BtnImprimirResumen.Text = "Imprimir resumen";
            BtnImprimirResumen.UseVisualStyleBackColor = true;
            BtnImprimirResumen.Click += BtnImprimirResumen_Click;
            // 
            // BtnEmitirHojasRuta
            // 
            BtnEmitirHojasRuta.Location = new Point(403, 509);
            BtnEmitirHojasRuta.Name = "BtnEmitirHojasRuta";
            BtnEmitirHojasRuta.Size = new Size(150, 25);
            BtnEmitirHojasRuta.TabIndex = 8;
            BtnEmitirHojasRuta.Text = "Emitir hojas de ruta";
            BtnEmitirHojasRuta.UseVisualStyleBackColor = true;
            // 
            // GrupoDetalleGuias
            // 
            GrupoDetalleGuias.Controls.Add(ListViewGuias);
            GrupoDetalleGuias.Location = new Point(9, 325);
            GrupoDetalleGuias.Name = "GrupoDetalleGuias";
            GrupoDetalleGuias.Size = new Size(700, 178);
            GrupoDetalleGuias.TabIndex = 7;
            GrupoDetalleGuias.TabStop = false;
            GrupoDetalleGuias.Text = "Detalle de Guías";
            // 
            // ListViewGuias
            // 
            ListViewGuias.CheckBoxes = true;
            ListViewGuias.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaCliente, ColumnaDireccion, ColumnaTipo, ColumnaDimension });
            ListViewGuias.Location = new Point(9, 30);
            ListViewGuias.Name = "ListViewGuias";
            ListViewGuias.Size = new Size(673, 132);
            ListViewGuias.TabIndex = 1;
            ListViewGuias.UseCompatibleStateImageBehavior = false;
            ListViewGuias.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 130;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 130;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.Text = "Dirección";
            ColumnaDireccion.Width = 130;
            // 
            // ColumnaTipo
            // 
            ColumnaTipo.Text = "Tipo";
            ColumnaTipo.Width = 130;
            // 
            // ColumnaDimension
            // 
            ColumnaDimension.Text = "Dimensión";
            ColumnaDimension.Width = 130;
            // 
            // GrupoHDRPendientes
            // 
            GrupoHDRPendientes.Controls.Add(BtnDeseleccionar);
            GrupoHDRPendientes.Controls.Add(button1);
            GrupoHDRPendientes.Controls.Add(ListViewRutasPendientes);
            GrupoHDRPendientes.Location = new Point(9, 110);
            GrupoHDRPendientes.Name = "GrupoHDRPendientes";
            GrupoHDRPendientes.Size = new Size(700, 209);
            GrupoHDRPendientes.TabIndex = 6;
            GrupoHDRPendientes.TabStop = false;
            GrupoHDRPendientes.Text = "HDR Pendientes";
            // 
            // BtnDeseleccionar
            // 
            BtnDeseleccionar.Location = new Point(368, 168);
            BtnDeseleccionar.Name = "BtnDeseleccionar";
            BtnDeseleccionar.Size = new Size(314, 23);
            BtnDeseleccionar.TabIndex = 11;
            BtnDeseleccionar.Text = "Deseleccionar todas";
            BtnDeseleccionar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(9, 168);
            button1.Name = "button1";
            button1.Size = new Size(314, 23);
            button1.TabIndex = 10;
            button1.Text = "Seleccionar todas";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListViewRutasPendientes
            // 
            ListViewRutasPendientes.CheckBoxes = true;
            ListViewRutasPendientes.Columns.AddRange(new ColumnHeader[] { ColumnaNHDR, ColumnaEmpresa, ColumnaServicio, ColumnaCantGuias });
            ListViewRutasPendientes.Location = new Point(9, 30);
            ListViewRutasPendientes.Name = "ListViewRutasPendientes";
            ListViewRutasPendientes.Size = new Size(673, 132);
            ListViewRutasPendientes.TabIndex = 0;
            ListViewRutasPendientes.UseCompatibleStateImageBehavior = false;
            ListViewRutasPendientes.View = View.Details;
            // 
            // ColumnaNHDR
            // 
            ColumnaNHDR.Text = "N° HDR";
            ColumnaNHDR.Width = 165;
            // 
            // ColumnaEmpresa
            // 
            ColumnaEmpresa.Text = "Empresa";
            ColumnaEmpresa.Width = 165;
            // 
            // ColumnaServicio
            // 
            ColumnaServicio.Text = "Servicio";
            ColumnaServicio.Width = 165;
            // 
            // ColumnaCantGuias
            // 
            ColumnaCantGuias.Text = "Cant. Guías";
            ColumnaCantGuias.Width = 165;
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(BtnBuscar);
            GrupoBusqueda.Controls.Add(LbServicio);
            GrupoBusqueda.Controls.Add(LbEmpresa);
            GrupoBusqueda.Controls.Add(comboBox2);
            GrupoBusqueda.Controls.Add(comboBox3);
            GrupoBusqueda.Location = new Point(9, 40);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(700, 64);
            GrupoBusqueda.TabIndex = 5;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de búsqueda";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(607, 25);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 25);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LbServicio
            // 
            LbServicio.AutoSize = true;
            LbServicio.Location = new Point(308, 30);
            LbServicio.Name = "LbServicio";
            LbServicio.Size = new Size(48, 15);
            LbServicio.TabIndex = 5;
            LbServicio.Text = "Servicio";
            LbServicio.Click += LbServicio_Click;
            // 
            // LbEmpresa
            // 
            LbEmpresa.AutoSize = true;
            LbEmpresa.Location = new Point(9, 30);
            LbEmpresa.Name = "LbEmpresa";
            LbEmpresa.Size = new Size(52, 15);
            LbEmpresa.TabIndex = 4;
            LbEmpresa.Text = "Empresa";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(362, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(235, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(67, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(235, 23);
            comboBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 10;
            label1.Text = "Emisión HDR Transporte";
            // 
            // EmisionHojasRutaTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 545);
            Controls.Add(label1);
            Controls.Add(BtnImprimirResumen);
            Controls.Add(BtnEmitirHojasRuta);
            Controls.Add(GrupoDetalleGuias);
            Controls.Add(GrupoHDRPendientes);
            Controls.Add(GrupoBusqueda);
            Name = "EmisionHojasRutaTransporte";
            Text = "Emisión de hojas de ruta de transporte";
            Load += EmisionHojasRutaTransporte_Load;
            GrupoDetalleGuias.ResumeLayout(false);
            GrupoHDRPendientes.ResumeLayout(false);
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnImprimirResumen;
        private Button BtnEmitirHojasRuta;
        private GroupBox GrupoDetalleGuias;
        private ListView ListViewGuias;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaCliente;
        private ColumnHeader ColumnaDireccion;
        private ColumnHeader ColumnaTipo;
        private GroupBox GrupoHDRPendientes;
        private Button BtnDeseleccionar;
        private Button button1;
        private ListView ListViewRutasPendientes;
        private ColumnHeader ColumnaNHDR;
        private ColumnHeader ColumnaEmpresa;
        private ColumnHeader ColumnaServicio;
        private ColumnHeader ColumnaCantGuias;
        private GroupBox GrupoBusqueda;
        private Button BtnBuscar;
        private Label LbServicio;
        private Label LbEmpresa;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private ColumnHeader ColumnaDimension;
    }
}