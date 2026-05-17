namespace tutasa.CuentaCorriente
{
    partial class CuentaCorriente
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
            GrupoBusqueda = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            ButtonConfirmar = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            ColumnaFecha = new ColumnHeader();
            ColumnaNComprobante = new ColumnHeader();
            ColumnaConcepto = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            ColumnaPago = new ColumnHeader();
            ColumnaSaldo = new ColumnHeader();
            button1 = new Button();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            GrupoBusqueda.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(button2);
            GrupoBusqueda.Controls.Add(textBox1);
            GrupoBusqueda.Controls.Add(ButtonConfirmar);
            GrupoBusqueda.Controls.Add(dateTimePicker2);
            GrupoBusqueda.Controls.Add(dateTimePicker1);
            GrupoBusqueda.Controls.Add(label6);
            GrupoBusqueda.Controls.Add(label7);
            GrupoBusqueda.Controls.Add(label3);
            GrupoBusqueda.Controls.Add(label2);
            GrupoBusqueda.Controls.Add(label1);
            GrupoBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrupoBusqueda.Location = new Point(17, 53);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(851, 249);
            GrupoBusqueda.TabIndex = 1;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Búsqueda";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(339, 31);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 30;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 33);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 29;
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Location = new Point(768, 197);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(75, 35);
            ButtonConfirmar.TabIndex = 28;
            ButtonConfirmar.Text = "Buscar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Font = new Font("Segoe UI", 9F);
            dateTimePicker2.Location = new Point(96, 159);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(747, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Location = new Point(96, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(747, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 160);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 7;
            label6.Text = "Fecha Hasta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 120);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 6;
            label7.Text = "Fecha Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 80);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Juan Pérez";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 80);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(17, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(851, 397);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado Cuenta";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaFecha, ColumnaNComprobante, ColumnaConcepto, ColumnaMonto, ColumnaPago, ColumnaSaldo });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(7, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(831, 291);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.Text = "Fecha";
            ColumnaFecha.Width = 120;
            // 
            // ColumnaNComprobante
            // 
            ColumnaNComprobante.Text = "N° Comprobante";
            ColumnaNComprobante.Width = 120;
            // 
            // ColumnaConcepto
            // 
            ColumnaConcepto.Text = "Concepto";
            ColumnaConcepto.Width = 120;
            // 
            // ColumnaMonto
            // 
            ColumnaMonto.Text = "Monto";
            ColumnaMonto.Width = 120;
            // 
            // ColumnaPago
            // 
            ColumnaPago.Text = "Pago";
            ColumnaPago.Width = 120;
            // 
            // ColumnaSaldo
            // 
            ColumnaSaldo.Text = "Saldo";
            ColumnaSaldo.Width = 120;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(783, 711);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 30;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 13);
            label8.Name = "label8";
            label8.Size = new Size(270, 28);
            label8.TabIndex = 31;
            label8.Text = "Estado de Cuenta Corriente";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 342);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 13;
            label4.Text = "Total Saldo";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 342);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 14;
            label5.Text = "$10.500";
            // 
            // CuentaCorriente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 753);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBusqueda);
            Name = "CuentaCorriente";
            Text = "Estado Cuenta Corriente";
            Load += CuentaCorriente_Load;
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrupoBusqueda;
        private Button ButtonConfirmar;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader ColumnaFecha;
        private ColumnHeader ColumnaNComprobante;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private ColumnHeader ColumnaPago;
        private ColumnHeader ColumnaSaldo;
        private Button button1;
        private Label label8;
        private Button button2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
    }
}