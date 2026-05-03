<<<<<<< HEAD:tutasa/ResultadosCostos/ResultadosCostos.Designer.cs
﻿namespace tutasa.Administración.ResultadoCostos
=======
﻿namespace tutasa.ResultadosCostos
>>>>>>> sacar de carpeta de admin:tutasa/ResultadosCostos/ResultadoCostos.Designer.cs
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
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(501, 208);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criterios de Búsqueda";
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Location = new Point(397, 159);
            ButtonConfirmar.Margin = new Padding(3, 4, 3, 4);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(86, 31);
            ButtonConfirmar.TabIndex = 29;
            ButtonConfirmar.Text = "Buscar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(188, 120);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(293, 28);
            comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(188, 80);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(293, 28);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 40);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 28);
            comboBox1.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(21, 121);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 12;
            label11.Text = "Seleccionar Año";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(21, 81);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 6;
            label7.Text = "Seleccionar Mes ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Empresa de Transporte";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(501, 171);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Envíos y Guías";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaTamaño, ColumnaImporte });
            listView1.Font = new Font("Segoe UI", 9F);
            listView1.Location = new Point(16, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 113);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 100;
            // 
            // ColumnaTamaño
            // 
            ColumnaTamaño.Text = "Tamaño ";
            ColumnaTamaño.Width = 100;
            // 
            // ColumnaImporte
            // 
            ColumnaImporte.Text = "Importe Guía";
            ColumnaImporte.Width = 100;
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
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 408);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(501, 205);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen de Resultados Mensuales";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(130, 41);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 20;
            label12.Text = "$90.000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(6, 41);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 19;
            label13.Text = "Ventas del Mes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(130, 161);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 18;
            label9.Text = "Resultadotxt";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(6, 161);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 17;
            label10.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(130, 121);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 16;
            label2.Text = "%11,00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(6, 121);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 15;
            label6.Text = "Margen %";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 110);
            label8.Name = "label8";
            label8.Size = new Size(0, 18);
            label8.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(130, 81);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 13;
            label5.Text = "$10.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 81);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 12;
            label4.Text = "Costo Mensual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 58);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(427, 621);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 31;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // ResultadoCostos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 665);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ResultadoCostos";
            Text = "Resultado Costos vs Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
    }
}