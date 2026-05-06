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
            LabelCDOrigen = new Label();
            LabelCDDestino = new Label();
            cmbCDDestino = new ComboBox();
            LvGuiasDisponibles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            BtnAgregarTodos = new Button();
            BtnQuitar = new Button();
            LvGuiasSeleccionadas = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            BtnAgregarSeleccion = new Button();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            LabelEmpresa = new Label();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            groupBox4 = new GroupBox();
            button1 = new Button();
            label6 = new Label();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label3 = new Label();
            comboBox5 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // LabelCDOrigen
            // 
            LabelCDOrigen.AutoSize = true;
            LabelCDOrigen.Location = new Point(14, 19);
            LabelCDOrigen.Name = "LabelCDOrigen";
            LabelCDOrigen.Size = new Size(181, 15);
            LabelCDOrigen.TabIndex = 0;
            LabelCDOrigen.Text = "Centro de distribución de origen:";
            // 
            // LabelCDDestino
            // 
            LabelCDDestino.AutoSize = true;
            LabelCDDestino.Location = new Point(20, 28);
            LabelCDDestino.Name = "LabelCDDestino";
            LabelCDDestino.Size = new Size(183, 15);
            LabelCDDestino.TabIndex = 2;
            LabelCDDestino.Text = "Centro de distribución de destino";
            // 
            // cmbCDDestino
            // 
            cmbCDDestino.FormattingEnabled = true;
            cmbCDDestino.Location = new Point(20, 101);
            cmbCDDestino.Name = "cmbCDDestino";
            cmbCDDestino.Size = new Size(694, 23);
            cmbCDDestino.TabIndex = 3;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader13, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader11 });
            LvGuiasDisponibles.Location = new Point(14, 22);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(700, 150);
            LvGuiasDisponibles.TabIndex = 4;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Guía";
            columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 3;
            columnHeader3.Text = "Dimensión";
            columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 4;
            columnHeader4.Text = "Peso";
            columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 1;
            columnHeader5.Text = "Cliente";
            columnHeader5.Width = 116;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "CD Destino";
            columnHeader11.Width = 117;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LabelCDOrigen);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 53);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 19);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "CD Buenos Aires";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnAgregarTodos);
            groupBox2.Controls.Add(BtnQuitar);
            groupBox2.Controls.Add(LvGuiasSeleccionadas);
            groupBox2.Controls.Add(BtnAgregarSeleccion);
            groupBox2.Controls.Add(LvGuiasDisponibles);
            groupBox2.Location = new Point(26, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(726, 439);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(434, 188);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(280, 23);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(14, 395);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(700, 23);
            BtnQuitar.TabIndex = 8;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // LvGuiasSeleccionadas
            // 
            LvGuiasSeleccionadas.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader12, columnHeader14 });
            LvGuiasSeleccionadas.Location = new Point(14, 227);
            LvGuiasSeleccionadas.Name = "LvGuiasSeleccionadas";
            LvGuiasSeleccionadas.Size = new Size(700, 150);
            LvGuiasSeleccionadas.TabIndex = 7;
            LvGuiasSeleccionadas.UseCompatibleStateImageBehavior = false;
            LvGuiasSeleccionadas.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nro Guía";
            columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cliente";
            columnHeader7.Width = 116;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Dirección";
            columnHeader8.Width = 116;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Dimensión";
            columnHeader9.Width = 116;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Peso";
            columnHeader10.Width = 116;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "CD Destino";
            columnHeader12.Width = 117;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(14, 188);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(280, 23);
            BtnAgregarSeleccion.TabIndex = 6;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(LabelCDDestino);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(cmbCDDestino);
            groupBox3.Controls.Add(LabelEmpresa);
            groupBox3.Location = new Point(26, 634);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(726, 205);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Configuración del transporte";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(694, 23);
            comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 140);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Servicio";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(694, 23);
            comboBox1.TabIndex = 1;
            // 
            // LabelEmpresa
            // 
            LabelEmpresa.AutoSize = true;
            LabelEmpresa.Location = new Point(20, 83);
            LabelEmpresa.Name = "LabelEmpresa";
            LabelEmpresa.Size = new Size(52, 15);
            LabelEmpresa.TabIndex = 0;
            LabelEmpresa.Text = "Empresa";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(596, 854);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(677, 854);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 23);
            BtnConfirmar.TabIndex = 10;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(comboBox5);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Location = new Point(26, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(726, 112);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Criterios de búsqueda";
            // 
            // button1
            // 
            button1.Location = new Point(14, 73);
            button1.Name = "button1";
            button1.Size = new Size(700, 23);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 38);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Dimensión:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(614, 35);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(100, 23);
            comboBox4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 37);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 2;
            label5.Text = "CUIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 38);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 1;
            label4.Text = "CD Destino:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(89, 34);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(106, 23);
            comboBox3.TabIndex = 0;
            // 
            // columnHeader13
            // 
            columnHeader13.DisplayIndex = 6;
            columnHeader13.Text = "Localidad";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Localidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 37);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Localidad";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(411, 34);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(124, 23);
            comboBox5.TabIndex = 7;
            // 
            // FormRuteoTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 890);
            Controls.Add(groupBox4);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormRuteoTransporte";
            Text = "Ruteo de transporte";
            Load += FormRuteoTransporte_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelCDOrigen;
        private Label LabelCDDestino;
        private ComboBox cmbCDDestino;
        private ListView LvGuiasDisponibles;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label LabelEmpresa;
        private ComboBox comboBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button BtnAgregarSeleccion;
        private ListView LvGuiasSeleccionadas;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button BtnQuitar;
        private Button BtnCancelar;
        private Button BtnConfirmar;
        private ComboBox comboBox2;
        private Label label1;
        private Button BtnAgregarTodos;
        private Label label2;
        private GroupBox groupBox4;
        private Button button1;
        private Label label6;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label label3;
        private ComboBox comboBox5;
    }
}
