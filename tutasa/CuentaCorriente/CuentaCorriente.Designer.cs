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
            BotonBuscarCuit = new Button();
            TextCuit = new TextBox();
            BotonConfirmar = new Button();
            FechaHasta = new DateTimePicker();
            FechaDesde = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            LabelNombreCliente = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            LvEstadoCuenta = new ListView();
            ColumnaFecha = new ColumnHeader();
            ColumnaNComprobante = new ColumnHeader();
            ColumnaConcepto = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            ColumnaPago = new ColumnHeader();
            ColumnaSaldo = new ColumnHeader();
            button1 = new Button();
            label8 = new Label();
            GrupoBusqueda.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(BotonBuscarCuit);
            GrupoBusqueda.Controls.Add(TextCuit);
            GrupoBusqueda.Controls.Add(BotonConfirmar);
            GrupoBusqueda.Controls.Add(FechaHasta);
            GrupoBusqueda.Controls.Add(FechaDesde);
            GrupoBusqueda.Controls.Add(label6);
            GrupoBusqueda.Controls.Add(label7);
            GrupoBusqueda.Controls.Add(LabelNombreCliente);
            GrupoBusqueda.Controls.Add(label2);
            GrupoBusqueda.Controls.Add(label1);
            GrupoBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrupoBusqueda.Location = new Point(17, 53);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(780, 249);
            GrupoBusqueda.TabIndex = 1;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Búsqueda";
            // 
            // BotonBuscarCuit
            // 
            BotonBuscarCuit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarCuit.Location = new Point(335, 35);
            BotonBuscarCuit.Margin = new Padding(3, 2, 3, 2);
            BotonBuscarCuit.Name = "BotonBuscarCuit";
            BotonBuscarCuit.Size = new Size(75, 25);
            BotonBuscarCuit.TabIndex = 30;
            BotonBuscarCuit.Text = "Buscar";
            BotonBuscarCuit.UseVisualStyleBackColor = true;
            BotonBuscarCuit.Click += BotonBuscarCuit_Click;
            // 
            // TextCuit
            // 
            TextCuit.Location = new Point(109, 33);
            TextCuit.Name = "TextCuit";
            TextCuit.Size = new Size(211, 27);
            TextCuit.TabIndex = 29;
            TextCuit.TextChanged += TextCuit_TextChanged;
            // 
            // BotonConfirmar
            // 
            BotonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonConfirmar.Location = new Point(697, 205);
            BotonConfirmar.Margin = new Padding(3, 2, 3, 2);
            BotonConfirmar.Name = "BotonConfirmar";
            BotonConfirmar.Size = new Size(66, 26);
            BotonConfirmar.TabIndex = 28;
            BotonConfirmar.Text = "Buscar";
            BotonConfirmar.UseVisualStyleBackColor = true;
            BotonConfirmar.Click += BotonConfirmar_Click;
            // 
            // FechaHasta
            // 
            FechaHasta.CustomFormat = "";
            FechaHasta.Font = new Font("Segoe UI", 9F);
            FechaHasta.Location = new Point(109, 155);
            FechaHasta.Margin = new Padding(3, 2, 3, 2);
            FechaHasta.Name = "FechaHasta";
            FechaHasta.Size = new Size(654, 27);
            FechaHasta.TabIndex = 9;
            FechaHasta.Value = new DateTime(2026, 5, 17, 17, 19, 19, 0);
            FechaHasta.ValueChanged += FechaHasta_ValueChanged;
            // 
            // FechaDesde
            // 
            FechaDesde.CustomFormat = "";
            FechaDesde.Font = new Font("Segoe UI", 9F);
            FechaDesde.Location = new Point(109, 113);
            FechaDesde.Margin = new Padding(3, 2, 3, 2);
            FechaDesde.Name = "FechaDesde";
            FechaDesde.Size = new Size(654, 27);
            FechaDesde.TabIndex = 8;
            FechaDesde.Value = new DateTime(2026, 5, 17, 17, 19, 28, 0);
            FechaDesde.ValueChanged += FechaDesde_ValueChanged;
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
            // LabelNombreCliente
            // 
            LabelNombreCliente.AutoSize = true;
            LabelNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombreCliente.Location = new Point(80, 60);
            LabelNombreCliente.Name = "LabelNombreCliente";
            LabelNombreCliente.Size = new Size(0, 20);
            LabelNombreCliente.TabIndex = 3;
            LabelNombreCliente.Click += LabelNombreCliente_Click;
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
            groupBox2.Controls.Add(LvEstadoCuenta);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(17, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 397);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado Cuenta";
            // 
            // LvEstadoCuenta
            // 
            LvEstadoCuenta.Columns.AddRange(new ColumnHeader[] { ColumnaFecha, ColumnaNComprobante, ColumnaConcepto, ColumnaMonto, ColumnaPago, ColumnaSaldo });
            LvEstadoCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LvEstadoCuenta.Location = new Point(6, 25);
            LvEstadoCuenta.Margin = new Padding(3, 2, 3, 2);
            LvEstadoCuenta.Name = "LvEstadoCuenta";
            LvEstadoCuenta.Size = new Size(757, 264);
            LvEstadoCuenta.TabIndex = 12;
            LvEstadoCuenta.UseCompatibleStateImageBehavior = false;
            LvEstadoCuenta.View = View.Details;
            LvEstadoCuenta.SelectedIndexChanged += LvEstadoCuenta_SelectedIndexChanged;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.Text = "Fecha";
            ColumnaFecha.Width = 120;
            // 
            // ColumnaNComprobante
            // 
            ColumnaNComprobante.Text = "N° Comprobante";
            ColumnaNComprobante.Width = 150;
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
            button1.Location = new Point(711, 711);
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
            // 
            // CuentaCorriente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 753);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrupoBusqueda;
        private Button ButtonConfirmar;
        private DateTimePicker FechaDesde;
        private DateTimePicker FechaHasta;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView LvEstadoCuenta;
        private ColumnHeader ColumnaFecha;
        private ColumnHeader ColumnaNComprobante;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private ColumnHeader ColumnaPago;
        private ColumnHeader ColumnaSaldo;
        private Button button1;
        private Label label8;
        private Button BotonBuscarCuit;
        private TextBox TextCuit;
        private Label LabelNombreCliente;
        private Button BotonConfirmar;

    }
}