namespace tutasa.Admision
{
    partial class Admision
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
            intNroGuia = new TextBox();
            btnBuscar = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            GrupoDatosGuia = new GroupBox();
            txtDNIDestinatario = new Label();
            label16 = new Label();
            txtDimension = new Label();
            label7 = new Label();
            txtDireccionOrigen = new Label();
            label5 = new Label();
            txtFleteroAsignado = new Label();
            intPeso = new TextBox();
            label17 = new Label();
            label6 = new Label();
            label13 = new Label();
            txtDireccionDestino = new Label();
            txtCUITCliente = new Label();
            txtNombreDestinatario = new Label();
            txtNombreRemitente = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtNGuia = new Label();
            GrupoDatosGuia.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Admisión";
            // 
            // intNroGuia
            // 
            intNroGuia.Location = new Point(71, 37);
            intNroGuia.Margin = new Padding(4, 3, 4, 3);
            intNroGuia.Name = "intNroGuia";
            intNroGuia.Size = new Size(205, 23);
            intNroGuia.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(284, 35);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(557, 342);
            btnConfirmar.Margin = new Padding(4, 3, 4, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 25);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(640, 342);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 25);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // GrupoDatosGuia
            // 
            GrupoDatosGuia.Controls.Add(txtDNIDestinatario);
            GrupoDatosGuia.Controls.Add(label16);
            GrupoDatosGuia.Controls.Add(txtDimension);
            GrupoDatosGuia.Controls.Add(label7);
            GrupoDatosGuia.Controls.Add(txtDireccionOrigen);
            GrupoDatosGuia.Controls.Add(label5);
            GrupoDatosGuia.Controls.Add(txtFleteroAsignado);
            GrupoDatosGuia.Controls.Add(intPeso);
            GrupoDatosGuia.Controls.Add(label17);
            GrupoDatosGuia.Controls.Add(label6);
            GrupoDatosGuia.Controls.Add(label13);
            GrupoDatosGuia.Controls.Add(txtDireccionDestino);
            GrupoDatosGuia.Controls.Add(txtCUITCliente);
            GrupoDatosGuia.Controls.Add(txtNombreDestinatario);
            GrupoDatosGuia.Controls.Add(txtNombreRemitente);
            GrupoDatosGuia.Controls.Add(label14);
            GrupoDatosGuia.Controls.Add(label12);
            GrupoDatosGuia.Controls.Add(label10);
            GrupoDatosGuia.Controls.Add(label9);
            GrupoDatosGuia.Location = new Point(15, 70);
            GrupoDatosGuia.Name = "GrupoDatosGuia";
            GrupoDatosGuia.Size = new Size(700, 266);
            GrupoDatosGuia.TabIndex = 40;
            GrupoDatosGuia.TabStop = false;
            GrupoDatosGuia.Text = "Datos de Guía";
            GrupoDatosGuia.Enter += GrupoDatosGuia_Enter;
            // 
            // txtDNIDestinatario
            // 
            txtDNIDestinatario.AutoSize = true;
            txtDNIDestinatario.Location = new Point(550, 60);
            txtDNIDestinatario.Margin = new Padding(4, 0, 4, 0);
            txtDNIDestinatario.Name = "txtDNIDestinatario";
            txtDNIDestinatario.Size = new Size(61, 15);
            txtDNIDestinatario.TabIndex = 56;
            txtDNIDestinatario.Text = "12.345.678";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(500, 60);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(30, 15);
            label16.TabIndex = 55;
            label16.Text = "DNI:";
            // 
            // txtDimension
            // 
            txtDimension.AutoSize = true;
            txtDimension.Location = new Point(84, 190);
            txtDimension.Margin = new Padding(4, 0, 4, 0);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(70, 15);
            txtDimension.TabIndex = 54;
            txtDimension.Text = "S | M | L | XL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 190);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 53;
            label7.Text = "Dimensión:";
            // 
            // txtDireccionOrigen
            // 
            txtDireccionOrigen.AutoSize = true;
            txtDireccionOrigen.Location = new Point(360, 30);
            txtDireccionOrigen.Margin = new Padding(4, 0, 4, 0);
            txtDireccionOrigen.Name = "txtDireccionOrigen";
            txtDireccionOrigen.Size = new Size(89, 15);
            txtDireccionOrigen.TabIndex = 52;
            txtDireccionOrigen.Text = "Calle Falsa 1234";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 51;
            label5.Text = "Direccion Origen:";
            // 
            // txtFleteroAsignado
            // 
            txtFleteroAsignado.AutoSize = true;
            txtFleteroAsignado.Location = new Point(115, 90);
            txtFleteroAsignado.Margin = new Padding(4, 0, 4, 0);
            txtFleteroAsignado.Name = "txtFleteroAsignado";
            txtFleteroAsignado.Size = new Size(49, 15);
            txtFleteroAsignado.TabIndex = 48;
            txtFleteroAsignado.Text = "Feltero1";
            // 
            // intPeso
            // 
            intPeso.Location = new Point(84, 160);
            intPeso.Margin = new Padding(4, 3, 4, 3);
            intPeso.Name = "intPeso";
            intPeso.Size = new Size(177, 23);
            intPeso.TabIndex = 50;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 90);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(99, 15);
            label17.TabIndex = 47;
            label17.Text = "Fletero Asignado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 160);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 46;
            label6.Text = "Peso (Kg):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 130);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(232, 15);
            label13.TabIndex = 49;
            label13.Text = "Modifique el peso en caso de ser necesario";
            // 
            // txtDireccionDestino
            // 
            txtDireccionDestino.AutoSize = true;
            txtDireccionDestino.Location = new Point(360, 60);
            txtDireccionDestino.Margin = new Padding(4, 0, 4, 0);
            txtDireccionDestino.Name = "txtDireccionDestino";
            txtDireccionDestino.Size = new Size(89, 15);
            txtDireccionDestino.TabIndex = 45;
            txtDireccionDestino.Text = "Calle Falsa 1234";
            // 
            // txtCUITCliente
            // 
            txtCUITCliente.AutoSize = true;
            txtCUITCliente.Location = new Point(550, 30);
            txtCUITCliente.Margin = new Padding(4, 0, 4, 0);
            txtCUITCliente.Name = "txtCUITCliente";
            txtCUITCliente.Size = new Size(83, 15);
            txtCUITCliente.TabIndex = 44;
            txtCUITCliente.Text = "30-12345678-9";
            // 
            // txtNombreDestinatario
            // 
            txtNombreDestinatario.AutoSize = true;
            txtNombreDestinatario.Location = new Point(115, 60);
            txtNombreDestinatario.Margin = new Padding(4, 0, 4, 0);
            txtNombreDestinatario.Name = "txtNombreDestinatario";
            txtNombreDestinatario.Size = new Size(62, 15);
            txtNombreDestinatario.TabIndex = 43;
            txtNombreDestinatario.Text = "Juan Perez";
            // 
            // txtNombreRemitente
            // 
            txtNombreRemitente.AutoSize = true;
            txtNombreRemitente.Location = new Point(115, 30);
            txtNombreRemitente.Margin = new Padding(4, 0, 4, 0);
            txtNombreRemitente.Name = "txtNombreRemitente";
            txtNombreRemitente.Size = new Size(79, 15);
            txtNombreRemitente.TabIndex = 42;
            txtNombreRemitente.Text = "Pepe Sanchez";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(240, 60);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 41;
            label14.Text = "Direccion Destino:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(500, 30);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 40;
            label12.Text = "CUIT:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 60);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 39;
            label10.Text = "Destinatario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 30);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 38;
            label9.Text = "Remitente:";
            // 
            // txtNGuia
            // 
            txtNGuia.AutoSize = true;
            txtNGuia.Location = new Point(15, 40);
            txtNGuia.Name = "txtNGuia";
            txtNGuia.Size = new Size(48, 15);
            txtNGuia.TabIndex = 41;
            txtNGuia.Text = "N° Guía";
            // 
            // Admision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 377);
            Controls.Add(txtNGuia);
            Controls.Add(GrupoDatosGuia);
            Controls.Add(btnBuscar);
            Controls.Add(intNroGuia);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Admision";
            Text = "Admision";
            Load += Admision_Load;
            GrupoDatosGuia.ResumeLayout(false);
            GrupoDatosGuia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox intNroGuia;
        private Button btnBuscar;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Panel panel2;
        private Label label8;
        private GroupBox GrupoDatosGuia;
        private Label txtDNIDestinatario;
        private Label label16;
        private Label txtDimension;
        private Label label7;
        private Label txtDireccionOrigen;
        private Label label5;
        private Label txtFleteroAsignado;
        private TextBox intPeso;
        private Label label17;
        private Label label6;
        private Label label13;
        private Label txtDireccionDestino;
        private Label txtCUITCliente;
        private Label txtNombreDestinatario;
        private Label txtNombreRemitente;
        private Label label14;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label txtNGuia;
    }
}