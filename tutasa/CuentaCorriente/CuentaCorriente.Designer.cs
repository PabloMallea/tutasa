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
            textBox1 = new TextBox();
            button2 = new Button();
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
            GrupoBusqueda.Location = new Point(15, 40);
            GrupoBusqueda.Margin = new Padding(3, 2, 3, 2);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Padding = new Padding(3, 2, 3, 2);
            GrupoBusqueda.Size = new Size(745, 187);
            GrupoBusqueda.TabIndex = 1;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Búsqueda";
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Location = new Point(672, 148);
            ButtonConfirmar.Margin = new Padding(3, 2, 3, 2);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(66, 26);
            ButtonConfirmar.TabIndex = 28;
            ButtonConfirmar.Text = "Buscar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Font = new Font("Segoe UI", 9F);
            dateTimePicker2.Location = new Point(84, 119);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(654, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Location = new Point(84, 88);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(654, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 120);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 7;
            label6.Text = "Fecha Hasta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 90);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 60);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Juan Pérez";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 30);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 231);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(745, 298);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado Cuenta";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaFecha, ColumnaNComprobante, ColumnaConcepto, ColumnaMonto, ColumnaPago, ColumnaSaldo });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(6, 20);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(728, 264);
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
            button1.Location = new Point(685, 533);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 30;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 10);
            label8.Name = "label8";
            label8.Size = new Size(217, 21);
            label8.TabIndex = 31;
            label8.Text = "Estado de Cuenta Corriente";
            label8.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(297, 23);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 30;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // CuentaCorriente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 565);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(GrupoBusqueda);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CuentaCorriente";
            Text = "Estado Cuenta Corriente";
            Load += CuentaCorriente_Load;
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            groupBox2.ResumeLayout(false);
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
    }
}