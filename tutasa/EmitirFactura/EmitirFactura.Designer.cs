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
            ComboCliente = new ComboBox();
            LabelNombre = new Label();
            label5 = new Label();
            LabelCuit = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ListViewFacturacion = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaConcepto = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            LabelTotal = new Label();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboCliente);
            groupBox1.Controls.Add(LabelNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(LabelCuit);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 116);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // ComboCliente
            // 
            ComboCliente.Font = new Font("Segoe UI", 9F);
            ComboCliente.FormattingEnabled = true;
            ComboCliente.Location = new Point(89, 30);
            ComboCliente.Name = "ComboCliente";
            ComboCliente.Size = new Size(324, 23);
            ComboCliente.TabIndex = 7;
            ComboCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 9F);
            LabelNombre.Location = new Point(89, 90);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 15);
            LabelNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(9, 90);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // LabelCuit
            // 
            LabelCuit.AutoSize = true;
            LabelCuit.Font = new Font("Segoe UI", 9F);
            LabelCuit.Location = new Point(89, 60);
            LabelCuit.Name = "LabelCuit";
            LabelCuit.Size = new Size(0, 15);
            LabelCuit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(9, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListViewFacturacion);
            groupBox2.Controls.Add(LabelTotal);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 137);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conceptos a Facturar";
            // 
            // ListViewFacturacion
            // 
            ListViewFacturacion.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaConcepto, ColumnaMonto });
            ListViewFacturacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListViewFacturacion.Location = new Point(5, 20);
            ListViewFacturacion.Margin = new Padding(3, 2, 3, 2);
            ListViewFacturacion.Name = "ListViewFacturacion";
            ListViewFacturacion.Size = new Size(408, 86);
            ListViewFacturacion.TabIndex = 17;
            ListViewFacturacion.UseCompatibleStateImageBehavior = false;
            ListViewFacturacion.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 130;
            // 
            // ColumnaConcepto
            // 
            ColumnaConcepto.Text = "Concepto";
            ColumnaConcepto.Width = 130;
            // 
            // ColumnaMonto
            // 
            ColumnaMonto.Text = "Monto";
            ColumnaMonto.Width = 130;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Segoe UI", 9F);
            LabelTotal.Location = new Point(94, 111);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(0, 15);
            LabelTotal.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(5, 111);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 6;
            label8.Text = "Total a facturar";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 8.25F);
            button4.Location = new Point(357, 305);
            button4.Name = "button4";
            button4.Size = new Size(80, 25);
            button4.TabIndex = 35;
            button4.Text = "Emitir Factura";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BotonConfirmar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 305);
            button3.Name = "button3";
            button3.Size = new Size(80, 25);
            button3.TabIndex = 34;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 10);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 36;
            label7.Text = "Emisión de Factura";
            // 
            // EmitirFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 339);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmitirFactura";
            Text = "Emitir Factura";
            Load += EmitirFactura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox ComboCliente;
        private Label label4;
        private Label label5;
        private Label LabelCuit;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView ListViewFacturacion;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private Label LabelTotal;
        private Label label8;
        private Button button4;
        private Button button3;
        private Label label7;
        private Label LabelNombre;
    }
}