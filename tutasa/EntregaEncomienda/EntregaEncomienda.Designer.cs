namespace tutasa.EntregaEncomienda
{
    partial class EntregaEncomienda
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
            label1 = new Label();
            txtNumeroGuia = new TextBox();
            btnBuscar = new Button();
            btnConfirmarEntrega = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            GrupoDetalleGuia = new GroupBox();
            lvDetalle = new ListView();
            ColumnaCliente = new ColumnHeader();
            ColumnaDestinatario = new ColumnHeader();
            ColumnaDNIDestinatario = new ColumnHeader();
            ColumnaEstadoActual = new ColumnHeader();
            GrupoDetalleGuia.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "N° Guía";
            // 
            // txtNumeroGuia
            // 
            txtNumeroGuia.Location = new Point(79, 49);
            txtNumeroGuia.Name = "txtNumeroGuia";
            txtNumeroGuia.Size = new Size(234, 27);
            txtNumeroGuia.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(320, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConfirmarEntrega
            // 
            btnConfirmarEntrega.Location = new Point(429, 371);
            btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            btnConfirmarEntrega.Size = new Size(142, 33);
            btnConfirmarEntrega.TabIndex = 5;
            btnConfirmarEntrega.Text = "Confirmar Entrega";
            btnConfirmarEntrega.UseVisualStyleBackColor = true;
            btnConfirmarEntrega.Click += btnConfirmarEntrega_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(336, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 13);
            label7.Name = "label7";
            label7.Size = new Size(235, 28);
            label7.TabIndex = 37;
            label7.Text = "Entrega de Encomienda";
            // 
            // GrupoDetalleGuia
            // 
            GrupoDetalleGuia.Controls.Add(lvDetalle);
            GrupoDetalleGuia.Location = new Point(17, 87);
            GrupoDetalleGuia.Margin = new Padding(3, 4, 3, 4);
            GrupoDetalleGuia.Name = "GrupoDetalleGuia";
            GrupoDetalleGuia.Padding = new Padding(3, 4, 3, 4);
            GrupoDetalleGuia.Size = new Size(643, 277);
            GrupoDetalleGuia.TabIndex = 38;
            GrupoDetalleGuia.TabStop = false;
            GrupoDetalleGuia.Text = "Detalle de Guía";
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { ColumnaCliente, ColumnaDestinatario, ColumnaDNIDestinatario, ColumnaEstadoActual });
            lvDetalle.Location = new Point(6, 27);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(612, 228);
            lvDetalle.TabIndex = 4;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            lvDetalle.SelectedIndexChanged += lvDetalle_SelectedIndexChanged;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 150;
            // 
            // ColumnaDestinatario
            // 
            ColumnaDestinatario.Text = "Destinatario";
            ColumnaDestinatario.Width = 150;
            // 
            // ColumnaDNIDestinatario
            // 
            ColumnaDNIDestinatario.Text = "DNI Destinatario";
            ColumnaDNIDestinatario.Width = 150;
            // 
            // ColumnaEstadoActual
            // 
            ColumnaEstadoActual.Text = "Estado Actual";
            ColumnaEstadoActual.Width = 158;
            // 
            // EntregaEncomienda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 416);
            Controls.Add(GrupoDetalleGuia);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarEntrega);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeroGuia);
            Controls.Add(label1);
            Name = "EntregaEncomienda";
            Text = "EntregaEncomienda";
            GrupoDetalleGuia.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeroGuia;
        private Button btnBuscar;
        private Button btnConfirmarEntrega;
        private Button btnCancelar;
        private Label label7;
        private GroupBox GrupoDetalleGuia;
        private ListView lvDetalle;
        private ColumnHeader ColumnaCliente;
        private ColumnHeader ColumnaDestinatario;
        private ColumnHeader ColumnaDNIDestinatario;
        private ColumnHeader ColumnaEstadoActual;
    }
}