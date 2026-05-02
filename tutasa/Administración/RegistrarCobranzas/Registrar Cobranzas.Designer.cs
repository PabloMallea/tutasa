namespace Pantallas_administración
{
    partial class RegistrarCobranzas
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
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            ColumnaNFactura = new ColumnHeader();
            ColumnaConcepto = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            groupBox3 = new GroupBox();
            label12 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 119);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(108, 90);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "Empresa SA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(18, 90);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Razón Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(108, 60);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "30-23456789-0";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 141);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Facturas a Cobrar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(94, 110);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 18;
            label6.Text = "$10.500";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(5, 110);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 17;
            label8.Text = "Total a cobrar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaNFactura, ColumnaConcepto, ColumnaMonto });
            listView1.Location = new Point(5, 20);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(409, 86);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaNFactura
            // 
            ColumnaNFactura.Text = "N° Factura";
            ColumnaNFactura.Width = 100;
            // 
            // ColumnaConcepto
            // 
            ColumnaConcepto.Text = "Concepto";
            ColumnaConcepto.Width = 100;
            // 
            // ColumnaMonto
            // 
            ColumnaMonto.Text = "Monto";
            ColumnaMonto.Width = 100;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(9, 287);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 70);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Medios de Pago";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(18, 30);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 0;
            label12.Text = "Medio de Pago";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 23);
            comboBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(229, 364);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 30;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(336, 364);
            button4.Name = "button4";
            button4.Size = new Size(101, 23);
            button4.TabIndex = 31;
            button4.Text = "Registrar Cobro";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(306, 23);
            comboBox2.TabIndex = 7;
            // 
            // RegistrarCobranzas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 398);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistrarCobranzas";
            Text = "Registrar Cobranzas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private ListView listView1;
        private ColumnHeader ColumnaNFactura;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private Label label6;
        private Label label8;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private ComboBox comboBox2;
    }
}