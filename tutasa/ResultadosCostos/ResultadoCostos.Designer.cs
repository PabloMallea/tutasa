namespace tutasa.ResultadosCostos
{
    partial class ResultadoCostos
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
            ButtonConfirmar = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label11 = new Label();
            label7 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaTamaño = new ColumnHeader();
            ColumnaImporte = new ColumnHeader();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            label9 = new Label();
            label10 = new Label();
            label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label14 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonConfirmar);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criterios de Búsqueda";
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Location = new Point(347, 119);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(75, 25);
            ButtonConfirmar.TabIndex = 29;
            ButtonConfirmar.Text = "Buscar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(141, 87);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(280, 23);
            comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(280, 23);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 23);
            comboBox1.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(9, 90);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 12;
            label11.Text = "Seleccionar Año";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(9, 60);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 6;
            label7.Text = "Seleccionar Mes ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Empresa de Transporte";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(433, 169);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Envíos y Guías";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaTamaño, ColumnaImporte });
            listView1.Font = new Font("Segoe UI", 9F);
            listView1.Location = new Point(9, 21);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(413, 134);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 125;
            // 
            // ColumnaTamaño
            // 
            ColumnaTamaño.Text = "Tamaño ";
            ColumnaTamaño.Width = 125;
            // 
            // ColumnaImporte
            // 
            ColumnaImporte.Text = "Importe Guía";
            ColumnaImporte.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(15, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(434, 146);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen de Resultados Mensuales";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(110, 30);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 20;
            label12.Text = "$90.000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(9, 30);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 19;
            label13.Text = "Ventas del Mes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(110, 120);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 18;
            label9.Text = "Resultadotxt";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(9, 120);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 17;
            label10.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(110, 90);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 16;
            label2.Text = "%11,00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(9, 90);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 15;
            label6.Text = "Margen %";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 82);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(110, 60);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 13;
            label5.Text = "$10.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(9, 60);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 12;
            label4.Text = "Costo Mensual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 44);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(373, 529);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 31;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(15, 10);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(219, 21);
            label14.TabIndex = 32;
            label14.Text = "Resultado Costos vs. Ventas";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(292, 529);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 33;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ResultadoCostos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 566);
            Controls.Add(button2);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResultadoCostos";
            Text = "Resultado Costos vs Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button ButtonConfirmar;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label11;
        private Label label7;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaTamaño;
        private ColumnHeader ColumnaImporte;
        private GroupBox groupBox3;
        private Label label12;
        private Label label13;
        private Label label9;
        private Label label10;
        private Label label2;
        private Label label6;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label14;
        private Button button2;
    }
}