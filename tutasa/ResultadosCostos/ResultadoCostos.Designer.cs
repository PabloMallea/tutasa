namespace tutasa.ResultadosCostos
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
            btnBuscar = new Button();
            cmbAnio = new ComboBox();
            cmbMes = new ComboBox();
            cmbEmpresa = new ComboBox();
            label11 = new Label();
            label7 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvGuias = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaTamaño = new ColumnHeader();
            ColumnaImporte = new ColumnHeader();
            groupBox3 = new GroupBox();
            txtVentasMes = new Label();
            label13 = new Label();
            txtResultado = new Label();
            label10 = new Label();
            txtMargen = new Label();
            label6 = new Label();
            label8 = new Label();
            txtCostoMensual = new Label();
            label4 = new Label();
            label3 = new Label();
            btnConfirmar = new Button();
            label14 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(cmbAnio);
            groupBox1.Controls.Add(cmbMes);
            groupBox1.Controls.Add(cmbEmpresa);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criterios de Búsqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(347, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbAnio
            // 
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.FormattingEnabled = true;
            cmbAnio.Location = new Point(141, 87);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(280, 23);
            cmbAnio.TabIndex = 14;
            // 
            // cmbMes
            // 
            cmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMes.FormattingEnabled = true;
            cmbMes.Location = new Point(141, 57);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(280, 23);
            cmbMes.TabIndex = 14;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(141, 27);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(280, 23);
            cmbEmpresa.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(9, 90);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 12;
            label11.Text = "Seleccionar Año";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(9, 60);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 6;
            label7.Text = "Seleccionar Mes ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Empresa de Transporte";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGuias);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(433, 169);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Envíos y Guías";
            // 
            // dgvGuias
            // 
            dgvGuias.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaTamaño, ColumnaImporte });
            dgvGuias.Font = new Font("Segoe UI", 9F);
            dgvGuias.Location = new Point(9, 21);
            dgvGuias.Margin = new Padding(3, 2, 3, 2);
            dgvGuias.Name = "dgvGuias";
            dgvGuias.Size = new Size(413, 134);
            dgvGuias.TabIndex = 0;
            dgvGuias.UseCompatibleStateImageBehavior = false;
            dgvGuias.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "N° Guía";
            ColumnaNGuia.Width = 125;
            // 
            // ColumnaTamaño
            // 
            ColumnaTamaño.Text = "Tamaño ";
            ColumnaTamaño.Width = 125;
            // 
            // ColumnaImporte
            // 
            ColumnaImporte.Text = "Importe Guía";
            ColumnaImporte.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtVentasMes);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtResultado);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtMargen);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtCostoMensual);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(15, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(434, 146);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen de Resultados Mensuales";
            // 
            // txtVentasMes
            // 
            txtVentasMes.AutoSize = true;
            txtVentasMes.Font = new Font("Segoe UI", 9F);
            txtVentasMes.Location = new Point(110, 30);
            txtVentasMes.Name = "txtVentasMes";
            txtVentasMes.Size = new Size(25, 20);
            txtVentasMes.TabIndex = 20;
            txtVentasMes.Text = "$0";
            txtVentasMes.Click += txtVentasMes_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(9, 30);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 19;
            label13.Text = "Ventas del Mes";
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Font = new Font("Segoe UI", 9F);
            txtResultado.Location = new Point(110, 120);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(25, 20);
            txtResultado.TabIndex = 18;
            txtResultado.Text = "$0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(9, 120);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 17;
            label10.Text = "Resultado";
            // 
            // txtMargen
            // 
            txtMargen.AutoSize = true;
            txtMargen.Font = new Font("Segoe UI", 9F);
            txtMargen.Location = new Point(110, 90);
            txtMargen.Name = "txtMargen";
            txtMargen.Size = new Size(0, 15);
            txtMargen.TabIndex = 16;
            txtMargen.Text = "%00,00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(9, 90);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 15;
            label6.Text = "Margen %";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 82);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 14;
            // 
            // txtCostoMensual
            // 
            txtCostoMensual.AutoSize = true;
            txtCostoMensual.Font = new Font("Segoe UI", 9F);
            txtCostoMensual.Location = new Point(110, 60);
            txtCostoMensual.Name = "txtCostoMensual";
            txtCostoMensual.Size = new Size(25, 20);
            txtCostoMensual.TabIndex = 13;
            txtCostoMensual.Text = "$0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(9, 60);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 12;
            label4.Text = "Costo Mensual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 44);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(373, 529);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 25);
            btnConfirmar.TabIndex = 31;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(15, 10);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(219, 21);
            label14.TabIndex = 32;
            label14.Text = "Resultado Costos vs. Ventas";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(292, 529);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 25);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ResultadoCostos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 566);
            Controls.Add(btnCancelar);
            Controls.Add(label14);
            Controls.Add(btnConfirmar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResultadoCostos";
            Text = "Resultado Costos vs Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBuscar;
        private ComboBox cmbAnio;
        private ComboBox cmbMes;
        private ComboBox cmbEmpresa;
        private Label label11;
        private Label label7;
        private Label label1;
        private GroupBox groupBox2;
        private ListView dgvGuias;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaTamaño;
        private ColumnHeader ColumnaImporte;
        private GroupBox groupBox3;
        private Label txtVentasMes;
        private Label label13;
        private Label txtResultado;
        private Label label10;
        private Label txtMargen;
        private Label label6;
        private Label label8;
        private Label txtCostoMensual;
        private Label label4;
        private Label label3;
        private Button btnConfirmar;
        private Label label14;
        private Button btnCancelar;
    }
}