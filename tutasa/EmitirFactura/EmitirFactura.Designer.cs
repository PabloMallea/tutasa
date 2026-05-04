namespace tutasa.EmitirFactura
{
    partial class EmitirFactura
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
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaConcepto = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            label6 = new Label();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(503, 155);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 40);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 28);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(123, 121);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 5;
            label4.Text = "Empresa SA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(21, 121);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(123, 81);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "30-23456789-0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(21, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 176);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(503, 191);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conceptos a Facturar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaConcepto, ColumnaMonto });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(6, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(466, 113);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 100;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(107, 148);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 7;
            label6.Text = "$10.500";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(6, 148);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 6;
            label8.Text = "Total a facturar";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 8.25F);
            button4.Location = new Point(400, 384);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(115, 31);
            button4.TabIndex = 35;
            button4.Text = "Emitir Factura";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(278, 384);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(115, 31);
            button3.TabIndex = 34;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // EmitirFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 434);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmitirFactura";
            Text = "Emitir Factura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private Label label6;
        private Label label8;
        private Button button4;
        private Button button3;
    }
}