namespace tutasa.EmisionHojasRuta
{
    partial class EmisonHojasRuta
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
            GrupoBusqueda = new GroupBox();
            ComboTipo = new ComboBox();
            LbTipo = new Label();
            BtnBuscar = new Button();
            LbFeltero = new Label();
            ComboFletero = new ComboBox();
            GrupoHDRPendientes = new GroupBox();
            BtnDeseleccionar = new Button();
            BtnSeleccionarTodas = new Button();
            ListViewRutasPendientes = new ListView();
            ColumnaNHDR = new ColumnHeader();
            ColumnaTipo = new ColumnHeader();
            ColumnaFletero = new ColumnHeader();
            ColumnaDireccion = new ColumnHeader();
            ColumnaCantGuias = new ColumnHeader();
            ListViewGuias = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaDireccionG = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            ColumnaTipoG = new ColumnHeader();
            ColumnaDimension = new ColumnHeader();
            GrupoGuias = new GroupBox();
            BtnEmitirHojasRuta = new Button();
            BtnImprimirResumen = new Button();
            label1 = new Label();
            GrupoBusqueda.SuspendLayout();
            GrupoHDRPendientes.SuspendLayout();
            GrupoGuias.SuspendLayout();
            SuspendLayout();
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(ComboTipo);
            GrupoBusqueda.Controls.Add(LbTipo);
            GrupoBusqueda.Controls.Add(BtnBuscar);
            GrupoBusqueda.Controls.Add(LbFeltero);
            GrupoBusqueda.Controls.Add(ComboFletero);
            GrupoBusqueda.Location = new Point(9, 40);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(700, 64);
            GrupoBusqueda.TabIndex = 0;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de búsqueda";
            // 
            // ComboTipo
            // 
            ComboTipo.FormattingEnabled = true;
            ComboTipo.Location = new Point(348, 27);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.Size = new Size(250, 23);
            ComboTipo.TabIndex = 11;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.Location = new Point(312, 30);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(30, 15);
            LbTipo.TabIndex = 10;
            LbTipo.Text = "Tipo";
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
            // LbFeltero
            // 
            LbFeltero.AutoSize = true;
            LbFeltero.Location = new Point(9, 30);
            LbFeltero.Name = "LbFeltero";
            LbFeltero.Size = new Size(43, 15);
            LbFeltero.TabIndex = 5;
            LbFeltero.Text = "Fletero";
            // 
            // ComboFletero
            // 
            ComboFletero.FormattingEnabled = true;
            ComboFletero.Location = new Point(58, 27);
            ComboFletero.Name = "ComboFletero";
            ComboFletero.Size = new Size(250, 23);
            ComboFletero.TabIndex = 2;
            // 
            // GrupoHDRPendientes
            // 
            GrupoHDRPendientes.Controls.Add(BtnDeseleccionar);
            GrupoHDRPendientes.Controls.Add(BtnSeleccionarTodas);
            GrupoHDRPendientes.Controls.Add(ListViewRutasPendientes);
            GrupoHDRPendientes.Location = new Point(9, 110);
            GrupoHDRPendientes.Name = "GrupoHDRPendientes";
            GrupoHDRPendientes.Size = new Size(700, 209);
            GrupoHDRPendientes.TabIndex = 1;
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
            // BtnSeleccionarTodas
            // 
            BtnSeleccionarTodas.Location = new Point(9, 168);
            BtnSeleccionarTodas.Name = "BtnSeleccionarTodas";
            BtnSeleccionarTodas.Size = new Size(314, 23);
            BtnSeleccionarTodas.TabIndex = 10;
            BtnSeleccionarTodas.Text = "Seleccionar todas";
            BtnSeleccionarTodas.UseVisualStyleBackColor = true;
            // 
            // ListViewRutasPendientes
            // 
            ListViewRutasPendientes.CheckBoxes = true;
            ListViewRutasPendientes.Columns.AddRange(new ColumnHeader[] { ColumnaNHDR, ColumnaTipo, ColumnaFletero, ColumnaDireccion, ColumnaCantGuias });
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
            ColumnaNHDR.Width = 130;
            // 
            // ColumnaTipo
            // 
            ColumnaTipo.Text = "Tipo";
            ColumnaTipo.Width = 130;
            // 
            // ColumnaFletero
            // 
            ColumnaFletero.Text = "Fletero";
            ColumnaFletero.Width = 130;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.Text = "Dirección";
            ColumnaDireccion.Width = 130;
            // 
            // ColumnaCantGuias
            // 
            ColumnaCantGuias.Text = "Cant. Guías";
            ColumnaCantGuias.Width = 130;
            // 
            // ListViewGuias
            // 
            ListViewGuias.CheckBoxes = true;
            ListViewGuias.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaDireccionG, ColumnaCliente, ColumnaTipoG, ColumnaDimension });
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
            // ColumnaDireccionG
            // 
            ColumnaDireccionG.DisplayIndex = 2;
            ColumnaDireccionG.Text = "Dirección";
            ColumnaDireccionG.Width = 130;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.DisplayIndex = 1;
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 130;
            // 
            // ColumnaTipoG
            // 
            ColumnaTipoG.Text = "Tipo";
            ColumnaTipoG.Width = 130;
            // 
            // ColumnaDimension
            // 
            ColumnaDimension.Text = "Dimensión";
            ColumnaDimension.Width = 130;
            // 
            // GrupoGuias
            // 
            GrupoGuias.Controls.Add(ListViewGuias);
            GrupoGuias.Location = new Point(9, 325);
            GrupoGuias.Name = "GrupoGuias";
            GrupoGuias.Size = new Size(700, 178);
            GrupoGuias.TabIndex = 2;
            GrupoGuias.TabStop = false;
            GrupoGuias.Text = "Detalle de guías";
            // 
            // BtnEmitirHojasRuta
            // 
            BtnEmitirHojasRuta.Location = new Point(403, 509);
            BtnEmitirHojasRuta.Name = "BtnEmitirHojasRuta";
            BtnEmitirHojasRuta.Size = new Size(150, 25);
            BtnEmitirHojasRuta.TabIndex = 3;
            BtnEmitirHojasRuta.Text = "Emitir hojas de ruta";
            BtnEmitirHojasRuta.UseVisualStyleBackColor = true;
            // 
            // BtnImprimirResumen
            // 
            BtnImprimirResumen.Location = new Point(559, 509);
            BtnImprimirResumen.Name = "BtnImprimirResumen";
            BtnImprimirResumen.Size = new Size(150, 25);
            BtnImprimirResumen.TabIndex = 4;
            BtnImprimirResumen.Text = "Imprimir resumen";
            BtnImprimirResumen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(206, 21);
            label1.TabIndex = 5;
            label1.Text = "Emisión HDR ultima milla";
            // 
            // EmisonHojasRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 545);
            Controls.Add(label1);
            Controls.Add(BtnImprimirResumen);
            Controls.Add(BtnEmitirHojasRuta);
            Controls.Add(GrupoGuias);
            Controls.Add(GrupoHDRPendientes);
            Controls.Add(GrupoBusqueda);
            Name = "EmisonHojasRuta";
            Text = "Emisión de hojas de ruta de última milla";
            Load += Form1_Load;
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            GrupoHDRPendientes.ResumeLayout(false);
            GrupoGuias.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrupoBusqueda;
        private Label LbFeltero;
        private ComboBox ComboFletero;
        private Button BtnBuscar;
        private GroupBox GrupoHDRPendientes;
        private ListView ListViewRutasPendientes;
        private ColumnHeader ColumnaTipo;
        private ColumnHeader ColumnaFletero;
        private ColumnHeader ColumnaDireccion;
        private ColumnHeader ColumnaCantGuias;
        private ListView ListViewGuias;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaDireccionG;
        private ColumnHeader ColumnaCliente;
        private ColumnHeader ColumnaTipoG;
        private ColumnHeader ColumnaDimension;
        private Button BtnDeseleccionar;
        private Button BtnSeleccionarTodas;
        private GroupBox GrupoGuias;
        private Button BtnEmitirHojasRuta;
        private Button BtnImprimirResumen;
        private ComboBox ComboTipo;
        private Label LbTipo;
        private Label label1;
        private ColumnHeader ColumnaNHDR;
    }
}