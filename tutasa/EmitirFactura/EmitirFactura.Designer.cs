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
            btnBuscarCuit = new Button();
            txtCuit = new TextBox();
            LabelNombreCliente = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ListViewFacturacion = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            LabelTotal = new Label();
            label8 = new Label();
            btnEmitirFactura = new Button();
            button3 = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarCuit);
            groupBox1.Controls.Add(txtCuit);
            groupBox1.Controls.Add(LabelNombreCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 93);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // btnBuscarCuit
            // 
            btnBuscarCuit.Location = new Point(347, 31);
            btnBuscarCuit.Name = "btnBuscarCuit";
            btnBuscarCuit.Size = new Size(75, 23);
            btnBuscarCuit.TabIndex = 5;
            btnBuscarCuit.Text = "Buscar";
            btnBuscarCuit.UseVisualStyleBackColor = true;
            btnBuscarCuit.Click += BotonBuscarCliente_Click;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(89, 31);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(247, 23);
            txtCuit.TabIndex = 4;
            // 
            // LabelNombreCliente
            // 
            LabelNombreCliente.AutoSize = true;
            LabelNombreCliente.Font = new Font("Segoe UI", 9F);
            LabelNombreCliente.Location = new Point(89, 66);
            LabelNombreCliente.Name = "LabelNombreCliente";
            LabelNombreCliente.Size = new Size(91, 15);
            LabelNombreCliente.TabIndex = 3;
            LabelNombreCliente.Text = "Nombre Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(9, 31);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(9, 66);
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
            groupBox2.Location = new Point(15, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 215);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guias a Facturar";
            // 
            // ListViewFacturacion
            // 
            ListViewFacturacion.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaMonto });
            ListViewFacturacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListViewFacturacion.Location = new Point(5, 20);
            ListViewFacturacion.Margin = new Padding(3, 2, 3, 2);
            ListViewFacturacion.Name = "ListViewFacturacion";
            ListViewFacturacion.Size = new Size(408, 143);
            ListViewFacturacion.TabIndex = 17;
            ListViewFacturacion.UseCompatibleStateImageBehavior = false;
            ListViewFacturacion.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 130;
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
            LabelTotal.Location = new Point(89, 182);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(43, 15);
            LabelTotal.TabIndex = 7;
            LabelTotal.Text = "$10000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(0, 182);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 6;
            label8.Text = "Total a Facturar:";
            // 
            // btnEmitirFactura
            // 
            btnEmitirFactura.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEmitirFactura.Location = new Point(357, 374);
            btnEmitirFactura.Name = "btnEmitirFactura";
            btnEmitirFactura.Size = new Size(80, 25);
            btnEmitirFactura.TabIndex = 35;
            btnEmitirFactura.Text = "Emitir Factura";
            btnEmitirFactura.UseVisualStyleBackColor = true;
            btnEmitirFactura.Click += btnEmitirFactura_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 374);
            button3.Name = "button3";
            button3.Size = new Size(80, 25);
            button3.TabIndex = 34;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_cancelar_Click;
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
            ClientSize = new Size(450, 411);
            Controls.Add(label7);
            Controls.Add(btnEmitirFactura);
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
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private ListView ListViewFacturacion;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private Label LabelTotal;
        private Label label8;
        private Button btnEmitirFactura;
        private Button button3;
        private Label label7;
        private Label LabelNombreCliente;
        private Label label1;
        private Button btnBuscarCuit;
        private TextBox txtCuit;
    }
}