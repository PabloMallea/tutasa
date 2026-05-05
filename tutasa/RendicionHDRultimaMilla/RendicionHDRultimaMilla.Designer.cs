namespace tutasa.RendicionHDRultimaMilla
{
    partial class RendicionHDRultimaMilla
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
            label2 = new Label();
            LabelCDOrigen = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            label1 = new Label();
            BtnAgregarTodos = new Button();
            BtnQuitar = new Button();
            LvGuiasSeleccionadas = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            BtnAgregarSeleccion = new Button();
            LvGuiasDisponibles = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            comboBox3 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            button4 = new Button();
            columnHeader5 = new ColumnHeader();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 58);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "CD Buenos Aires";
            // 
            // LabelCDOrigen
            // 
            LabelCDOrigen.AutoSize = true;
            LabelCDOrigen.Location = new Point(47, 58);
            LabelCDOrigen.Name = "LabelCDOrigen";
            LabelCDOrigen.Size = new Size(128, 15);
            LabelCDOrigen.TabIndex = 0;
            LabelCDOrigen.Text = "Centro de distribución:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(BtnAgregarTodos);
            groupBox2.Controls.Add(BtnQuitar);
            groupBox2.Controls.Add(LvGuiasSeleccionadas);
            groupBox2.Controls.Add(BtnAgregarSeleccion);
            groupBox2.Controls.Add(LvGuiasDisponibles);
            groupBox2.Location = new Point(47, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(709, 570);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "HDR Asignadas";
            // 
            // button3
            // 
            button3.Location = new Point(413, 531);
            button3.Name = "button3";
            button3.Size = new Size(280, 23);
            button3.TabIndex = 11;
            button3.Text = "Quitar Todo";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 286);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 10;
            label1.Text = "HDR Rendidas";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(413, 240);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(280, 23);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar selección No Cumplidas";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(14, 531);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(280, 23);
            BtnQuitar.TabIndex = 8;
            BtnQuitar.Text = "Quitar selección";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // LvGuiasSeleccionadas
            // 
            LvGuiasSeleccionadas.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader7, columnHeader5 });
            LvGuiasSeleccionadas.Location = new Point(14, 318);
            LvGuiasSeleccionadas.Name = "LvGuiasSeleccionadas";
            LvGuiasSeleccionadas.Size = new Size(679, 200);
            LvGuiasSeleccionadas.TabIndex = 7;
            LvGuiasSeleccionadas.UseCompatibleStateImageBehavior = false;
            LvGuiasSeleccionadas.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "N°HDR";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "N°Guia";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Fletero";
            columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Estado";
            columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Fecha";
            columnHeader16.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.DisplayIndex = 5;
            columnHeader7.Text = "Tipo Entrega";
            columnHeader7.Width = 100;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(14, 240);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(280, 23);
            BtnAgregarSeleccion.TabIndex = 6;
            BtnAgregarSeleccion.Text = "Agregar selección Cumplidas";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6 });
            LvGuiasDisponibles.Location = new Point(14, 34);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(679, 200);
            LvGuiasDisponibles.TabIndex = 4;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "N°HDR";
            columnHeader11.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Guía";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fletero";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha";
            columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tipo Entrega";
            columnHeader6.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 18);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(224, 21);
            label3.TabIndex = 12;
            label3.Text = "Rendición HDR Ultima Milla";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(47, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 58);
            panel1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(289, 17);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(66, 17);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 20);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "Fletero:";
            // 
            // button2
            // 
            button2.Location = new Point(312, 739);
            button2.Name = "button2";
            button2.Size = new Size(169, 23);
            button2.TabIndex = 14;
            button2.Text = "Confirmar Rendición";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(681, 739);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cumplida";
            columnHeader5.Width = 100;
            // 
            // RendicionHDRultimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 786);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(LabelCDOrigen);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Name = "RendicionHDRultimaMilla";
            Text = "RendicionHDRultimaMilla";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label LabelCDOrigen;
        private GroupBox groupBox2;
        private Button BtnAgregarTodos;
        private Button BtnQuitar;
        private ListView LvGuiasSeleccionadas;
        private Button BtnAgregarSeleccion;
        private ListView LvGuiasDisponibles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private ComboBox comboBox3;
        private Label label4;
        private Label label1;
        private ColumnHeader columnHeader4;
        private Button button2;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader6;
        private Button button3;
        private ColumnHeader columnHeader7;
        private Button button4;
        private ColumnHeader columnHeader5;
    }
}