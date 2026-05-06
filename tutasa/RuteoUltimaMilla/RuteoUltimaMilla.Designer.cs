namespace tutasa.RuteoUltimaMilla
{
    partial class RuteoUltimaMilla
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
            groupBox1 = new GroupBox();
            RBtnRetiro = new RadioButton();
            RBtnEntrega = new RadioButton();
            LvGuiasDisponibles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            groupBox2 = new GroupBox();
            BtnAgregarTodos = new Button();
            BtnQuitar = new Button();
            BtnAgregarSeleccion = new Button();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            groupBox4 = new GroupBox();
            BtnBuscar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            LbLocalidad = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBtnRetiro);
            groupBox1.Controls.Add(RBtnEntrega);
            groupBox1.Location = new Point(39, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de ruteo";
            // 
            // RBtnRetiro
            // 
            RBtnRetiro.AutoSize = true;
            RBtnRetiro.Location = new Point(198, 32);
            RBtnRetiro.Name = "RBtnRetiro";
            RBtnRetiro.RightToLeft = RightToLeft.Yes;
            RBtnRetiro.Size = new Size(146, 19);
            RBtnRetiro.TabIndex = 3;
            RBtnRetiro.TabStop = true;
            RBtnRetiro.Text = "Retiro de encomiendas";
            RBtnRetiro.UseVisualStyleBackColor = true;
            RBtnRetiro.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // RBtnEntrega
            // 
            RBtnEntrega.AutoSize = true;
            RBtnEntrega.Location = new Point(17, 32);
            RBtnEntrega.Name = "RBtnEntrega";
            RBtnEntrega.RightToLeft = RightToLeft.Yes;
            RBtnEntrega.Size = new Size(155, 19);
            RBtnEntrega.TabIndex = 2;
            RBtnEntrega.TabStop = true;
            RBtnEntrega.Text = "Entrega de encomiendas";
            RBtnEntrega.UseVisualStyleBackColor = true;
            RBtnEntrega.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader12, columnHeader2, columnHeader3, columnHeader4 });
            LvGuiasDisponibles.Location = new Point(17, 28);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(700, 150);
            LvGuiasDisponibles.TabIndex = 5;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Guía";
            columnHeader1.Width = 140;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Cliente";
            columnHeader12.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dimensión";
            columnHeader4.Width = 140;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader13, columnHeader7, columnHeader8, columnHeader9 });
            listView1.Location = new Point(17, 224);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 150);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nro Guía";
            columnHeader6.Width = 130;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Cliente";
            columnHeader13.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Dirección";
            columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tipo";
            columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Dimensión";
            columnHeader9.Width = 130;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnAgregarTodos);
            groupBox2.Controls.Add(BtnQuitar);
            groupBox2.Controls.Add(BtnAgregarSeleccion);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(LvGuiasDisponibles);
            groupBox2.Location = new Point(39, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 412);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(428, 184);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(289, 23);
            BtnAgregarTodos.TabIndex = 12;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(16, 380);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(701, 23);
            BtnQuitar.TabIndex = 10;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(16, 184);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(289, 23);
            BtnAgregarSeleccion.TabIndex = 7;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(39, 592);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(734, 75);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Asignación de fletero";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(700, 23);
            comboBox1.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(619, 673);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(700, 673);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 23);
            BtnConfirmar.TabIndex = 11;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnBuscar);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(LbLocalidad);
            groupBox4.Location = new Point(39, 97);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(734, 71);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Criterios de búsqueda";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(517, 25);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(80, 23);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "CUIT Cliente";
            label1.Click += label1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(82, 25);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 23);
            comboBox2.TabIndex = 1;
            // 
            // LbLocalidad
            // 
            LbLocalidad.AutoSize = true;
            LbLocalidad.Location = new Point(18, 29);
            LbLocalidad.Name = "LbLocalidad";
            LbLocalidad.Size = new Size(58, 15);
            LbLocalidad.TabIndex = 0;
            LbLocalidad.Text = "Localidad";
            // 
            // RuteoUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 708);
            Controls.Add(groupBox4);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "RuteoUltimaMilla";
            Text = "Ruteo de última milla";
            Load += RuteoUltimaMilla_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RBtnEntrega;
        private RadioButton RBtnRetiro;
        private ListView LvGuiasDisponibles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private GroupBox groupBox2;
        private Button BtnAgregarSeleccion;
        private Button BtnQuitar;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button BtnCancelar;
        private Button BtnConfirmar;
        private GroupBox groupBox4;
        private Label LbLocalidad;
        private ColumnHeader columnHeader12;
        private Label label1;
        private ComboBox comboBox2;
        private ColumnHeader columnHeader13;
        private Button BtnBuscar;
        private TextBox textBox1;
        private Button BtnAgregarTodos;
    }
}