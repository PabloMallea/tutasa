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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BtnAgregarTodos = new Button();
            BtnQuitar = new Button();
            LvGuiasSeleccionadas = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            BtnAgregarSeleccion = new Button();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            LabelEmpresa = new Label();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            cmbCDDestino.Size = new Size(673, 23);
            cmbCDDestino.TabIndex = 3;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            LvGuiasDisponibles.Location = new Point(14, 34);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(679, 130);
            LvGuiasDisponibles.TabIndex = 4;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Guía";
            columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección destino";
            columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo";
            columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Peso";
            columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha admisión";
            columnHeader5.Width = 135;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LabelCDOrigen);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 53);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnAgregarTodos);
            groupBox2.Controls.Add(BtnQuitar);
            groupBox2.Controls.Add(LvGuiasSeleccionadas);
            groupBox2.Controls.Add(BtnAgregarSeleccion);
            groupBox2.Controls.Add(LvGuiasDisponibles);
            groupBox2.Location = new Point(26, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(709, 382);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(413, 163);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(280, 23);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(14, 335);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(679, 23);
            BtnQuitar.TabIndex = 8;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // LvGuiasSeleccionadas
            // 
            LvGuiasSeleccionadas.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            LvGuiasSeleccionadas.Location = new Point(14, 206);
            LvGuiasSeleccionadas.Name = "LvGuiasSeleccionadas";
            LvGuiasSeleccionadas.Size = new Size(679, 130);
            LvGuiasSeleccionadas.TabIndex = 7;
            LvGuiasSeleccionadas.UseCompatibleStateImageBehavior = false;
            LvGuiasSeleccionadas.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nro Guía";
            columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Dirección destino";
            columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tipo";
            columnHeader8.Width = 135;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Peso";
            columnHeader9.Width = 135;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fecha admisión";
            columnHeader10.Width = 135;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(14, 163);
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
            groupBox3.Location = new Point(26, 459);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(709, 205);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Configuración del transporte";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(673, 23);
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
            comboBox1.Size = new Size(673, 23);
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
            BtnCancelar.Location = new Point(579, 682);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(660, 682);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 23);
            BtnConfirmar.TabIndex = 10;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
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
            // FormRuteoTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 721);
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
        private ColumnHeader columnHeader5;
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
    }
}
