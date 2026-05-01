namespace Pantallas_Administración
{
    partial class ConsultaCuentaCorrienteForm
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
            Cliente = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lvMovimientos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(12, 45);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(55, 20);
            Cliente.TabIndex = 0;
            Cliente.Text = "Cliente";
            Cliente.Click += Cliente_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 42);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "cmbCliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 94);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "CUIT";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 91);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "txtCUIT";
            // 
            // lvMovimientos
            // 
            lvMovimientos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvMovimientos.FullRowSelect = true;
            lvMovimientos.GridLines = true;
            lvMovimientos.Location = new Point(12, 32);
            lvMovimientos.Margin = new Padding(3, 4, 3, 4);
            lvMovimientos.Name = "lvMovimientos";
            lvMovimientos.Size = new Size(481, 96);
            lvMovimientos.TabIndex = 4;
            lvMovimientos.UseCompatibleStateImageBehavior = false;
            lvMovimientos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Número";
            columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Importe";
            columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estado";
            columnHeader5.Width = 97;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 34);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Total Deuda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 34);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "lblTotalDeuda";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 65);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 8;
            label4.Text = "lblTotalPagado";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 65);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Pagado";
            // 
            // button1
            // 
            button1.Location = new Point(188, 433);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 9;
            button1.Text = "Ver detalle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(358, 433);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 106);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Totales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(Cliente);
            groupBox2.Location = new Point(9, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 130);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Cliente";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(4, 129);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(509, 354);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lvMovimientos);
            groupBox4.Location = new Point(9, 152);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(509, 150);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Movimientos";
            // 
            // ConsultaCuentaCorrienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 680);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultaCuentaCorrienteForm";
            Text = "ConsultaCuentaCorrienteForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lvMovimientos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}