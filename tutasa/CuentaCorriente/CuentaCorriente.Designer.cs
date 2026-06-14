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
            GrupoBusqueda.Location = new Point(15, 40);
            GrupoBusqueda.Margin = new Padding(3, 2, 3, 2);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Padding = new Padding(3, 2, 3, 2);
            GrupoBusqueda.Size = new Size(682, 187);
            GrupoBusqueda.TabIndex = 1;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Búsqueda";
            // 
            // BotonBuscarCuit
            // 
            BotonBuscarCuit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarCuit.Location = new Point(293, 26);
            BotonBuscarCuit.Margin = new Padding(3, 2, 3, 2);
            BotonBuscarCuit.Name = "BotonBuscarCuit";
            BotonBuscarCuit.Size = new Size(66, 22);
            BotonBuscarCuit.TabIndex = 30;
            BotonBuscarCuit.Text = "Buscar";
            BotonBuscarCuit.UseVisualStyleBackColor = true;
            BotonBuscarCuit.Click += BotonBuscarCuit_Click;
            // 
            // TextCuit
            // 
            TextCuit.Location = new Point(95, 25);
            TextCuit.Margin = new Padding(3, 2, 3, 2);
            TextCuit.Name = "TextCuit";
            TextCuit.Size = new Size(185, 23);
            TextCuit.TabIndex = 29;
            // 
            // BotonConfirmar
            // 
            BotonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonConfirmar.Location = new Point(587, 159);
            BotonConfirmar.Margin = new Padding(3, 2, 3, 2);
            BotonConfirmar.Name = "BotonConfirmar";
            BotonConfirmar.Size = new Size(81, 24);
            BotonConfirmar.TabIndex = 28;
            BotonConfirmar.Text = "Buscar";
            BotonConfirmar.UseVisualStyleBackColor = true;
            BotonConfirmar.Click += BotonConfirmar_Click;
            // 
            // FechaHasta
            // 
            FechaHasta.CustomFormat = "";
            FechaHasta.Font = new Font("Segoe UI", 9F);
            FechaHasta.Location = new Point(95, 116);
            FechaHasta.Margin = new Padding(3, 2, 3, 2);
            FechaHasta.Name = "FechaHasta";
            FechaHasta.Size = new Size(573, 23);
            FechaHasta.TabIndex = 9;
            FechaHasta.Value = new DateTime(2026, 5, 17, 17, 19, 19, 0);
            // 
            // FechaDesde
            // 
            FechaDesde.CustomFormat = "";
            FechaDesde.Font = new Font("Segoe UI", 9F);
            FechaDesde.Location = new Point(95, 85);
            FechaDesde.Margin = new Padding(3, 2, 3, 2);
            FechaDesde.Name = "FechaDesde";
            FechaDesde.Size = new Size(573, 23);
            FechaDesde.TabIndex = 8;
            FechaDesde.Value = new DateTime(2026, 5, 17, 17, 19, 28, 0);
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
            // LabelNombreCliente
            // 
            LabelNombreCliente.AutoSize = true;
            LabelNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNombreCliente.Location = new Point(70, 45);
            LabelNombreCliente.Name = "LabelNombreCliente";
            LabelNombreCliente.Size = new Size(0, 15);
            LabelNombreCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 30);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
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
            groupBox2.Controls.Add(LvEstadoCuenta);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 231);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(682, 298);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado Cuenta";
            // 
            // LvEstadoCuenta
            // 
            LvEstadoCuenta.Columns.AddRange(new ColumnHeader[] { ColumnaFecha, ColumnaNComprobante, ColumnaConcepto, ColumnaMonto, ColumnaPago, ColumnaSaldo });
            LvEstadoCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LvEstadoCuenta.Location = new Point(5, 19);
            LvEstadoCuenta.Margin = new Padding(3, 2, 3, 2);
            LvEstadoCuenta.Name = "LvEstadoCuenta";
            LvEstadoCuenta.Size = new Size(663, 199);
            LvEstadoCuenta.TabIndex = 12;
            LvEstadoCuenta.UseCompatibleStateImageBehavior = false;
            LvEstadoCuenta.View = View.Details;
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
            button1.Location = new Point(622, 533);
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
            // 
            // CuentaCorriente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 565);
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