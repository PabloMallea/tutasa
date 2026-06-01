namespace tutasa.RuteoTransporte
{
    partial class FormRuteoTransporte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelCDDestino = new Label();
            ComboEmpresa = new ComboBox();
            LvGuiasDisponibles = new ListView();
            ColumnaNGuiaA = new ColumnHeader();
            ColumnaLocalidadA = new ColumnHeader();
            ColumnaDireccionA = new ColumnHeader();
            ColumnaDimensionA = new ColumnHeader();
            ColumnaPesoA = new ColumnHeader();
            ColumnaClienteA = new ColumnHeader();
            ColumnaCDDestinoA = new ColumnHeader();
            GrupoGuias = new GroupBox();
            LvSeleccion = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            BtnAgregarTodos = new Button();
            BtnQuitar = new Button();
            BtnAgregarSeleccion = new Button();
            GrupoConfigTransporte = new GroupBox();
            ComboServicio = new ComboBox();
            LabelServicio = new Label();
            ComboCDDestino = new ComboBox();
            LabelEmpresa = new Label();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            groupBox4 = new GroupBox();
            label3 = new Label();
            ComboLocalidad = new ComboBox();
            BtnBuscar = new Button();
            label6 = new Label();
            ComboDimension = new ComboBox();
            TxtCuit = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ComboCDDestinoBusqueda = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            GrupoGuias.SuspendLayout();
            GrupoConfigTransporte.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // LabelCDDestino
            // 
            LabelCDDestino.AutoSize = true;
            LabelCDDestino.Location = new Point(10, 40);
            LabelCDDestino.Name = "LabelCDDestino";
            LabelCDDestino.Size = new Size(230, 20);
            LabelCDDestino.TabIndex = 2;
            LabelCDDestino.Text = "Centro de distribución de destino";
            // 
            // ComboEmpresa
            // 
            ComboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEmpresa.FormattingEnabled = true;
            ComboEmpresa.Location = new Point(10, 133);
            ComboEmpresa.Margin = new Padding(3, 4, 3, 4);
            ComboEmpresa.Name = "ComboEmpresa";
            ComboEmpresa.Size = new Size(889, 28);
            ComboEmpresa.TabIndex = 3;
            ComboEmpresa.SelectedIndexChanged += ComboEmpresa_SelectedIndexChanged;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { ColumnaNGuiaA, ColumnaLocalidadA, ColumnaDireccionA, ColumnaDimensionA, ColumnaPesoA, ColumnaClienteA, ColumnaCDDestinoA });
            LvGuiasDisponibles.FullRowSelect = true;
            LvGuiasDisponibles.Location = new Point(10, 29);
            LvGuiasDisponibles.Margin = new Padding(3, 4, 3, 4);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(889, 199);
            LvGuiasDisponibles.TabIndex = 4;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            LvGuiasDisponibles.SelectedIndexChanged += LvGuiasDisponibles_SelectedIndexChanged;
            // 
            // ColumnaNGuiaA
            // 
            ColumnaNGuiaA.Text = "N° Guía";
            ColumnaNGuiaA.Width = 110;
            // 
            // ColumnaLocalidadA
            // 
            ColumnaLocalidadA.Text = "Localidad";
            ColumnaLocalidadA.Width = 110;
            // 
            // ColumnaDireccionA
            // 
            ColumnaDireccionA.Text = "Dirección";
            ColumnaDireccionA.Width = 110;
            // 
            // ColumnaDimensionA
            // 
            ColumnaDimensionA.Text = "Dimensión";
            ColumnaDimensionA.Width = 110;
            // 
            // ColumnaPesoA
            // 
            ColumnaPesoA.Text = "Peso";
            ColumnaPesoA.Width = 110;
            // 
            // ColumnaClienteA
            // 
            ColumnaClienteA.Text = "Cliente";
            ColumnaClienteA.Width = 110;
            // 
            // ColumnaCDDestinoA
            // 
            ColumnaCDDestinoA.Text = "CD Destino";
            ColumnaCDDestinoA.Width = 110;
            // 
            // GrupoGuias
            // 
            GrupoGuias.Controls.Add(LvSeleccion);
            GrupoGuias.Controls.Add(BtnAgregarTodos);
            GrupoGuias.Controls.Add(BtnQuitar);
            GrupoGuias.Controls.Add(BtnAgregarSeleccion);
            GrupoGuias.Controls.Add(LvGuiasDisponibles);
            GrupoGuias.Location = new Point(14, 195);
            GrupoGuias.Margin = new Padding(3, 4, 3, 4);
            GrupoGuias.Name = "GrupoGuias";
            GrupoGuias.Padding = new Padding(3, 4, 3, 4);
            GrupoGuias.Size = new Size(910, 549);
            GrupoGuias.TabIndex = 7;
            GrupoGuias.TabStop = false;
            GrupoGuias.Text = "Guías";
            // 
            // LvSeleccion
            // 
            LvSeleccion.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            LvSeleccion.FullRowSelect = true;
            LvSeleccion.Location = new Point(10, 297);
            LvSeleccion.Margin = new Padding(3, 4, 3, 4);
            LvSeleccion.Name = "LvSeleccion";
            LvSeleccion.Size = new Size(889, 199);
            LvSeleccion.TabIndex = 10;
            LvSeleccion.UseCompatibleStateImageBehavior = false;
            LvSeleccion.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Guía";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Localidad";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dimensión";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Peso";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cliente";
            columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "CD Destino";
            columnHeader7.Width = 110;
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(579, 237);
            BtnAgregarTodos.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(320, 33);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            BtnAgregarTodos.Click += BtnAgregarTodos_Click;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(10, 505);
            BtnQuitar.Margin = new Padding(3, 4, 3, 4);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(889, 31);
            BtnQuitar.TabIndex = 8;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            BtnQuitar.Click += BtnQuitar_Click;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(10, 237);
            BtnAgregarSeleccion.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(320, 33);
            BtnAgregarSeleccion.TabIndex = 6;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            BtnAgregarSeleccion.Click += BtnAgregarSeleccion_Click;
            // 
            // GrupoConfigTransporte
            // 
            GrupoConfigTransporte.Controls.Add(ComboServicio);
            GrupoConfigTransporte.Controls.Add(LabelServicio);
            GrupoConfigTransporte.Controls.Add(LabelCDDestino);
            GrupoConfigTransporte.Controls.Add(ComboCDDestino);
            GrupoConfigTransporte.Controls.Add(ComboEmpresa);
            GrupoConfigTransporte.Controls.Add(LabelEmpresa);
            GrupoConfigTransporte.Location = new Point(14, 752);
            GrupoConfigTransporte.Margin = new Padding(3, 4, 3, 4);
            GrupoConfigTransporte.Name = "GrupoConfigTransporte";
            GrupoConfigTransporte.Padding = new Padding(3, 4, 3, 4);
            GrupoConfigTransporte.Size = new Size(910, 251);
            GrupoConfigTransporte.TabIndex = 8;
            GrupoConfigTransporte.TabStop = false;
            GrupoConfigTransporte.Text = "Configuración del Transporte";
            // 
            // ComboServicio
            // 
            ComboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboServicio.FormattingEnabled = true;
            ComboServicio.Location = new Point(10, 200);
            ComboServicio.Margin = new Padding(3, 4, 3, 4);
            ComboServicio.Name = "ComboServicio";
            ComboServicio.Size = new Size(889, 28);
            ComboServicio.TabIndex = 5;
            // 
            // LabelServicio
            // 
            LabelServicio.AutoSize = true;
            LabelServicio.Location = new Point(10, 173);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(61, 20);
            LabelServicio.TabIndex = 4;
            LabelServicio.Text = "Servicio";
            // 
            // ComboCDDestino
            // 
            ComboCDDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboCDDestino.FormattingEnabled = true;
            ComboCDDestino.Location = new Point(10, 67);
            ComboCDDestino.Margin = new Padding(3, 4, 3, 4);
            ComboCDDestino.Name = "ComboCDDestino";
            ComboCDDestino.Size = new Size(889, 28);
            ComboCDDestino.TabIndex = 1;
            // 
            // LabelEmpresa
            // 
            LabelEmpresa.AutoSize = true;
            LabelEmpresa.Location = new Point(10, 107);
            LabelEmpresa.Name = "LabelEmpresa";
            LabelEmpresa.Size = new Size(66, 20);
            LabelEmpresa.TabIndex = 0;
            LabelEmpresa.Text = "Empresa";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(745, 1011);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 33);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(838, 1011);
            BtnConfirmar.Margin = new Padding(3, 4, 3, 4);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(86, 33);
            BtnConfirmar.TabIndex = 10;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(ComboLocalidad);
            groupBox4.Controls.Add(BtnBuscar);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(ComboDimension);
            groupBox4.Controls.Add(TxtCuit);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(ComboCDDestinoBusqueda);
            groupBox4.Location = new Point(14, 93);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(910, 93);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Criterios de búsqueda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 40);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Localidad";
            // 
            // ComboLocalidad
            // 
            ComboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboLocalidad.FormattingEnabled = true;
            ComboLocalidad.Location = new Point(466, 36);
            ComboLocalidad.Margin = new Padding(3, 4, 3, 4);
            ComboLocalidad.Name = "ComboLocalidad";
            ComboLocalidad.Size = new Size(119, 28);
            ComboLocalidad.TabIndex = 7;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(803, 33);
            BtnBuscar.Margin = new Padding(3, 4, 3, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(86, 33);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(593, 40);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 5;
            label6.Text = "Dimensión";
            // 
            // ComboDimension
            // 
            ComboDimension.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDimension.FormattingEnabled = true;
            ComboDimension.Location = new Point(674, 36);
            ComboDimension.Margin = new Padding(3, 4, 3, 4);
            ComboDimension.Name = "ComboDimension";
            ComboDimension.Size = new Size(119, 28);
            ComboDimension.TabIndex = 4;
            // 
            // TxtCuit
            // 
            TxtCuit.Location = new Point(266, 36);
            TxtCuit.Margin = new Padding(3, 4, 3, 4);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(119, 27);
            TxtCuit.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 40);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 2;
            label5.Text = "CUIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 40);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 1;
            label4.Text = "CD Destino";
            // 
            // ComboCDDestinoBusqueda
            // 
            ComboCDDestinoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboCDDestinoBusqueda.FormattingEnabled = true;
            ComboCDDestinoBusqueda.Location = new Point(96, 36);
            ComboCDDestinoBusqueda.Margin = new Padding(3, 4, 3, 4);
            ComboCDDestinoBusqueda.Name = "ComboCDDestinoBusqueda";
            ComboCDDestinoBusqueda.Size = new Size(119, 28);
            ComboCDDestinoBusqueda.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 13);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(205, 28);
            label7.TabIndex = 13;
            label7.Text = "Ruteo de Transporte";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 53);
            label9.Name = "label9";
            label9.Size = new Size(159, 20);
            label9.TabIndex = 14;
            label9.Text = "Centro de distribución:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(171, 53);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 15;
            label8.Text = "CD Buenos Aires";
            // 
            // FormRuteoTransporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 1055);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(GrupoConfigTransporte);
            Controls.Add(GrupoGuias);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRuteoTransporte";
            Text = "Ruteo de transporte";
            Load += FormRuteoTransporte_Load;
            GrupoGuias.ResumeLayout(false);
            GrupoConfigTransporte.ResumeLayout(false);
            GrupoConfigTransporte.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelCDDestino;
        private ComboBox ComboEmpresa;
        private ListView LvSeleccion;
        private GroupBox GrupoGuias;
        private GroupBox GrupoConfigTransporte;
        private Label LabelEmpresa;
        private ComboBox ComboCDDestino;
        private ColumnHeader ColumnaNGuiaA;
        private ColumnHeader ColumnaDireccionA;
        private ColumnHeader ColumnaDimensionA;
        private ColumnHeader ColumnaPesoA;
        private Button BtnAgregarSeleccion;
        private Button BtnQuitar;
        private Button BtnCancelar;
        private Button BtnConfirmar;
        private ComboBox ComboServicio;
        private Label LabelServicio;
        private Button BtnAgregarTodos;
        private GroupBox groupBox4;
        private Button BtnBuscar;
        private Label label6;
        private ComboBox ComboDimension;
        private TextBox TxtCuit;
        private Label label5;
        private Label label4;
        private ComboBox ComboCDDestinoBusqueda;
        private ColumnHeader ColumnaClienteA;
        private ColumnHeader ColumnaCDDestinoA;
        private ColumnHeader ColumnaLocalidadA;
        private Label label3;
        private ComboBox ComboLocalidad;
        private Label label7;
        private Label label9;
        private Label label8;
        private ListView LvGuiasDisponibles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
