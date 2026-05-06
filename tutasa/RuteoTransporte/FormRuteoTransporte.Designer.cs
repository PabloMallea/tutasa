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
            listView1 = new ListView();
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
            comboBox5 = new ComboBox();
            BtnBuscar = new Button();
            label6 = new Label();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
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
            LabelCDDestino.Location = new Point(9, 30);
            LabelCDDestino.Name = "LabelCDDestino";
            LabelCDDestino.Size = new Size(183, 15);
            LabelCDDestino.TabIndex = 2;
            LabelCDDestino.Text = "Centro de distribución de destino";
            // 
            // ComboEmpresa
            // 
            ComboEmpresa.FormattingEnabled = true;
            ComboEmpresa.Location = new Point(9, 100);
            ComboEmpresa.Name = "ComboEmpresa";
            ComboEmpresa.Size = new Size(778, 23);
            ComboEmpresa.TabIndex = 3;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { ColumnaNGuiaA, ColumnaLocalidadA, ColumnaDireccionA, ColumnaDimensionA, ColumnaPesoA, ColumnaClienteA, ColumnaCDDestinoA });
            LvGuiasDisponibles.Location = new Point(9, 22);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(778, 150);
            LvGuiasDisponibles.TabIndex = 4;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
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
            GrupoGuias.Controls.Add(listView1);
            GrupoGuias.Controls.Add(BtnAgregarTodos);
            GrupoGuias.Controls.Add(BtnQuitar);
            GrupoGuias.Controls.Add(BtnAgregarSeleccion);
            GrupoGuias.Controls.Add(LvGuiasDisponibles);
            GrupoGuias.Location = new Point(12, 146);
            GrupoGuias.Name = "GrupoGuias";
            GrupoGuias.Size = new Size(796, 412);
            GrupoGuias.TabIndex = 7;
            GrupoGuias.TabStop = false;
            GrupoGuias.Text = "Guías";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(9, 223);
            listView1.Name = "listView1";
            listView1.Size = new Size(778, 150);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            BtnAgregarTodos.Location = new Point(507, 178);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(280, 25);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            BtnAgregarTodos.Click += BtnAgregarTodos_Click;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(9, 379);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(778, 23);
            BtnQuitar.TabIndex = 8;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(9, 178);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(280, 25);
            BtnAgregarSeleccion.TabIndex = 6;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // GrupoConfigTransporte
            // 
            GrupoConfigTransporte.Controls.Add(ComboServicio);
            GrupoConfigTransporte.Controls.Add(LabelServicio);
            GrupoConfigTransporte.Controls.Add(LabelCDDestino);
            GrupoConfigTransporte.Controls.Add(ComboCDDestino);
            GrupoConfigTransporte.Controls.Add(ComboEmpresa);
            GrupoConfigTransporte.Controls.Add(LabelEmpresa);
            GrupoConfigTransporte.Location = new Point(12, 564);
            GrupoConfigTransporte.Name = "GrupoConfigTransporte";
            GrupoConfigTransporte.Size = new Size(796, 188);
            GrupoConfigTransporte.TabIndex = 8;
            GrupoConfigTransporte.TabStop = false;
            GrupoConfigTransporte.Text = "Configuración del Transporte";
            GrupoConfigTransporte.Enter += groupBox3_Enter;
            // 
            // ComboServicio
            // 
            ComboServicio.FormattingEnabled = true;
            ComboServicio.Location = new Point(9, 150);
            ComboServicio.Name = "ComboServicio";
            ComboServicio.Size = new Size(778, 23);
            ComboServicio.TabIndex = 5;
            // 
            // LabelServicio
            // 
            LabelServicio.AutoSize = true;
            LabelServicio.Location = new Point(9, 130);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(48, 15);
            LabelServicio.TabIndex = 4;
            LabelServicio.Text = "Servicio";
            // 
            // ComboCDDestino
            // 
            ComboCDDestino.FormattingEnabled = true;
            ComboCDDestino.Location = new Point(9, 50);
            ComboCDDestino.Name = "ComboCDDestino";
            ComboCDDestino.Size = new Size(778, 23);
            ComboCDDestino.TabIndex = 1;
            // 
            // LabelEmpresa
            // 
            LabelEmpresa.AutoSize = true;
            LabelEmpresa.Location = new Point(9, 80);
            LabelEmpresa.Name = "LabelEmpresa";
            LabelEmpresa.Size = new Size(52, 15);
            LabelEmpresa.TabIndex = 0;
            LabelEmpresa.Text = "Empresa";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(652, 758);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 25);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(733, 758);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 25);
            BtnConfirmar.TabIndex = 10;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(comboBox5);
            groupBox4.Controls.Add(BtnBuscar);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Location = new Point(12, 70);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(796, 70);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Criterios de búsqueda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 30);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Localidad";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(408, 27);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(105, 23);
            comboBox5.TabIndex = 7;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(703, 25);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 25);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(519, 30);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Dimensión";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(590, 27);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(105, 23);
            comboBox4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 23);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 30);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 2;
            label5.Text = "CUIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 1;
            label4.Text = "CD Destino";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(84, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(105, 23);
            comboBox3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 10);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(163, 21);
            label7.TabIndex = 13;
            label7.Text = "Ruteo de Transporte";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 40);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 14;
            label9.Text = "Centro de distribución:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(150, 40);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 15;
            label8.Text = "CD Buenos Aires";
            // 
            // FormRuteoTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 797);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(GrupoConfigTransporte);
            Controls.Add(GrupoGuias);
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
        private ListView LvGuiasDisponibles;
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
        private ComboBox comboBox4;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox3;
        private ColumnHeader ColumnaClienteA;
        private ColumnHeader ColumnaCDDestinoA;
        private ColumnHeader ColumnaLocalidadA;
        private Label label3;
        private ComboBox comboBox5;
        private Label label7;
        private Label label9;
        private Label label8;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
