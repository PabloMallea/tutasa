namespace tutasa.Imposicion_CD
{
    partial class Impiscion_CD
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
            LabelImposicion = new Label();
            GrupoDestinatario = new GroupBox();
            BotonBuscarD = new Button();
            TextLocalidad = new TextBox();
            LabelLocalidadD = new Label();
            LabelDestinoD = new Label();
            LabelTELD = new Label();
            ComboDestino = new ComboBox();
            TextTEL = new TextBox();
            TextNombre = new TextBox();
            TextAltura = new TextBox();
            LabelAlturaD = new Label();
            TextCalle = new TextBox();
            LabelCalleD = new Label();
            TextDNI = new TextBox();
            LabelApellidoD = new Label();
            TextApellido = new TextBox();
            LabelNombreD = new Label();
            LabelDNI = new Label();
            GrupoCliente = new GroupBox();
            LabelTelefono = new Label();
            LabelApellido = new Label();
            LabelNombre = new Label();
            BotonBuscarC = new Button();
            LabelTELC = new Label();
            TxtCuit = new TextBox();
            LabelApellidoC = new Label();
            LabelNombreC = new Label();
            LabelCUIT = new Label();
            ButtonConfirmar = new Button();
            ButtonCancelar = new Button();
            LabelDimension = new Label();
            label6 = new Label();
            TextPeso = new TextBox();
            LabelTamaño = new Label();
            GrupoEncomienda = new GroupBox();
            GrupoDestinatario.SuspendLayout();
            GrupoCliente.SuspendLayout();
            GrupoEncomienda.SuspendLayout();
            SuspendLayout();
            // 
            // LabelImposicion
            // 
            LabelImposicion.AutoSize = true;
            LabelImposicion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelImposicion.Location = new Point(15, 10);
            LabelImposicion.Name = "LabelImposicion";
            LabelImposicion.Size = new Size(260, 21);
            LabelImposicion.TabIndex = 46;
            LabelImposicion.Text = "Imposición Centro de Distribución";
            // 
            // GrupoDestinatario
            // 
            GrupoDestinatario.Controls.Add(BotonBuscarD);
            GrupoDestinatario.Controls.Add(TextLocalidad);
            GrupoDestinatario.Controls.Add(LabelLocalidadD);
            GrupoDestinatario.Controls.Add(LabelDestinoD);
            GrupoDestinatario.Controls.Add(LabelTELD);
            GrupoDestinatario.Controls.Add(ComboDestino);
            GrupoDestinatario.Controls.Add(TextTEL);
            GrupoDestinatario.Controls.Add(TextNombre);
            GrupoDestinatario.Controls.Add(TextAltura);
            GrupoDestinatario.Controls.Add(LabelAlturaD);
            GrupoDestinatario.Controls.Add(TextCalle);
            GrupoDestinatario.Controls.Add(LabelCalleD);
            GrupoDestinatario.Controls.Add(TextDNI);
            GrupoDestinatario.Controls.Add(LabelApellidoD);
            GrupoDestinatario.Controls.Add(TextApellido);
            GrupoDestinatario.Controls.Add(LabelNombreD);
            GrupoDestinatario.Controls.Add(LabelDNI);
            GrupoDestinatario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoDestinatario.Location = new Point(406, 40);
            GrupoDestinatario.Name = "GrupoDestinatario";
            GrupoDestinatario.Size = new Size(382, 280);
            GrupoDestinatario.TabIndex = 44;
            GrupoDestinatario.TabStop = false;
            GrupoDestinatario.Text = "Destinatario";
            // 
            // BotonBuscarD
            // 
            BotonBuscarD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarD.Location = new Point(298, 30);
            BotonBuscarD.Name = "BotonBuscarD";
            BotonBuscarD.Size = new Size(75, 25);
            BotonBuscarD.TabIndex = 41;
            BotonBuscarD.Text = "Buscar";
            BotonBuscarD.UseVisualStyleBackColor = true;
            BotonBuscarD.Click += BotonBuscarLocalidad_Click;
            // 
            // TextLocalidad
            // 
            TextLocalidad.Location = new Point(76, 30);
            TextLocalidad.Name = "TextLocalidad";
            TextLocalidad.Size = new Size(216, 25);
            TextLocalidad.TabIndex = 39;
            // 
            // LabelLocalidadD
            // 
            LabelLocalidadD.AutoSize = true;
            LabelLocalidadD.Font = new Font("Segoe UI", 9F);
            LabelLocalidadD.Location = new Point(9, 30);
            LabelLocalidadD.Name = "LabelLocalidadD";
            LabelLocalidadD.Size = new Size(58, 15);
            LabelLocalidadD.TabIndex = 38;
            LabelLocalidadD.Text = "Localidad";
            // 
            // LabelDestinoD
            // 
            LabelDestinoD.AutoSize = true;
            LabelDestinoD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDestinoD.Location = new Point(9, 60);
            LabelDestinoD.Name = "LabelDestinoD";
            LabelDestinoD.Size = new Size(52, 17);
            LabelDestinoD.TabIndex = 42;
            LabelDestinoD.Text = "Destino";
            // 
            // LabelTELD
            // 
            LabelTELD.AutoSize = true;
            LabelTELD.Font = new Font("Segoe UI", 9F);
            LabelTELD.Location = new Point(9, 240);
            LabelTELD.Name = "LabelTELD";
            LabelTELD.Size = new Size(52, 15);
            LabelTELD.TabIndex = 37;
            LabelTELD.Text = "Teléfono";
            // 
            // ComboDestino
            // 
            ComboDestino.FormattingEnabled = true;
            ComboDestino.Location = new Point(76, 60);
            ComboDestino.Name = "ComboDestino";
            ComboDestino.Size = new Size(297, 25);
            ComboDestino.TabIndex = 40;
            ComboDestino.SelectedIndexChanged += ComboDestino_SelectedIndexChanged1;
            // 
            // TextTEL
            // 
            TextTEL.Location = new Point(76, 240);
            TextTEL.Name = "TextTEL";
            TextTEL.Size = new Size(297, 25);
            TextTEL.TabIndex = 36;
            // 
            // TextNombre
            // 
            TextNombre.Location = new Point(76, 150);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(297, 25);
            TextNombre.TabIndex = 35;
            // 
            // TextAltura
            // 
            TextAltura.Location = new Point(76, 120);
            TextAltura.Name = "TextAltura";
            TextAltura.Size = new Size(297, 25);
            TextAltura.TabIndex = 34;
            // 
            // LabelAlturaD
            // 
            LabelAlturaD.AutoSize = true;
            LabelAlturaD.Font = new Font("Segoe UI", 9F);
            LabelAlturaD.Location = new Point(9, 120);
            LabelAlturaD.Name = "LabelAlturaD";
            LabelAlturaD.Size = new Size(39, 15);
            LabelAlturaD.TabIndex = 33;
            LabelAlturaD.Text = "Altura";
            // 
            // TextCalle
            // 
            TextCalle.Location = new Point(76, 90);
            TextCalle.Name = "TextCalle";
            TextCalle.Size = new Size(297, 25);
            TextCalle.TabIndex = 32;
            // 
            // LabelCalleD
            // 
            LabelCalleD.AutoSize = true;
            LabelCalleD.Font = new Font("Segoe UI", 9F);
            LabelCalleD.Location = new Point(9, 90);
            LabelCalleD.Name = "LabelCalleD";
            LabelCalleD.Size = new Size(33, 15);
            LabelCalleD.TabIndex = 31;
            LabelCalleD.Text = "Calle";
            // 
            // TextDNI
            // 
            TextDNI.Location = new Point(76, 210);
            TextDNI.Name = "TextDNI";
            TextDNI.Size = new Size(297, 25);
            TextDNI.TabIndex = 30;
            // 
            // LabelApellidoD
            // 
            LabelApellidoD.AutoSize = true;
            LabelApellidoD.Font = new Font("Segoe UI", 9F);
            LabelApellidoD.Location = new Point(10, 180);
            LabelApellidoD.Name = "LabelApellidoD";
            LabelApellidoD.Size = new Size(51, 15);
            LabelApellidoD.TabIndex = 29;
            LabelApellidoD.Text = "Apellido";
            // 
            // TextApellido
            // 
            TextApellido.Location = new Point(76, 180);
            TextApellido.Name = "TextApellido";
            TextApellido.Size = new Size(297, 25);
            TextApellido.TabIndex = 28;
            // 
            // LabelNombreD
            // 
            LabelNombreD.AutoSize = true;
            LabelNombreD.Font = new Font("Segoe UI", 9F);
            LabelNombreD.Location = new Point(10, 150);
            LabelNombreD.Name = "LabelNombreD";
            LabelNombreD.Size = new Size(51, 15);
            LabelNombreD.TabIndex = 27;
            LabelNombreD.Text = "Nombre";
            // 
            // LabelDNI
            // 
            LabelDNI.AutoSize = true;
            LabelDNI.Font = new Font("Segoe UI", 9F);
            LabelDNI.Location = new Point(10, 210);
            LabelDNI.Name = "LabelDNI";
            LabelDNI.Size = new Size(27, 15);
            LabelDNI.TabIndex = 26;
            LabelDNI.Text = "DNI";
            // 
            // GrupoCliente
            // 
            GrupoCliente.Controls.Add(LabelTelefono);
            GrupoCliente.Controls.Add(LabelApellido);
            GrupoCliente.Controls.Add(LabelNombre);
            GrupoCliente.Controls.Add(BotonBuscarC);
            GrupoCliente.Controls.Add(LabelTELC);
            GrupoCliente.Controls.Add(TxtCuit);
            GrupoCliente.Controls.Add(LabelApellidoC);
            GrupoCliente.Controls.Add(LabelNombreC);
            GrupoCliente.Controls.Add(LabelCUIT);
            GrupoCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoCliente.Location = new Point(12, 40);
            GrupoCliente.Name = "GrupoCliente";
            GrupoCliente.Size = new Size(382, 280);
            GrupoCliente.TabIndex = 43;
            GrupoCliente.TabStop = false;
            GrupoCliente.Text = "Cliente";
            // 
            // LabelTelefono
            // 
            LabelTelefono.AutoSize = true;
            LabelTelefono.Location = new Point(73, 118);
            LabelTelefono.Name = "LabelTelefono";
            LabelTelefono.Size = new Size(0, 17);
            LabelTelefono.TabIndex = 36;
            // 
            // LabelApellido
            // 
            LabelApellido.AutoSize = true;
            LabelApellido.Location = new Point(75, 90);
            LabelApellido.Name = "LabelApellido";
            LabelApellido.Size = new Size(0, 17);
            LabelApellido.TabIndex = 35;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Location = new Point(75, 63);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 17);
            LabelNombre.TabIndex = 34;
            // 
            // BotonBuscarC
            // 
            BotonBuscarC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarC.Location = new Point(298, 30);
            BotonBuscarC.Name = "BotonBuscarC";
            BotonBuscarC.Size = new Size(75, 25);
            BotonBuscarC.TabIndex = 33;
            BotonBuscarC.Text = "Buscar";
            BotonBuscarC.UseVisualStyleBackColor = true;
            BotonBuscarC.Click += BotonBuscarC_Click;
            // 
            // LabelTELC
            // 
            LabelTELC.AutoSize = true;
            LabelTELC.Font = new Font("Segoe UI", 9F);
            LabelTELC.Location = new Point(9, 120);
            LabelTELC.Name = "LabelTELC";
            LabelTELC.Size = new Size(52, 15);
            LabelTELC.TabIndex = 30;
            LabelTELC.Text = "Teléfono";
            // 
            // TxtCuit
            // 
            TxtCuit.Location = new Point(75, 30);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(216, 25);
            TxtCuit.TabIndex = 28;
            // 
            // LabelApellidoC
            // 
            LabelApellidoC.AutoSize = true;
            LabelApellidoC.Font = new Font("Segoe UI", 9F);
            LabelApellidoC.Location = new Point(9, 90);
            LabelApellidoC.Name = "LabelApellidoC";
            LabelApellidoC.Size = new Size(51, 15);
            LabelApellidoC.TabIndex = 27;
            LabelApellidoC.Text = "Apellido";
            // 
            // LabelNombreC
            // 
            LabelNombreC.AutoSize = true;
            LabelNombreC.Font = new Font("Segoe UI", 9F);
            LabelNombreC.Location = new Point(9, 60);
            LabelNombreC.Name = "LabelNombreC";
            LabelNombreC.Size = new Size(51, 15);
            LabelNombreC.TabIndex = 26;
            LabelNombreC.Text = "Nombre";
            // 
            // LabelCUIT
            // 
            LabelCUIT.AutoSize = true;
            LabelCUIT.Font = new Font("Segoe UI", 9F);
            LabelCUIT.Location = new Point(9, 30);
            LabelCUIT.Name = "LabelCUIT";
            LabelCUIT.Size = new Size(32, 15);
            LabelCUIT.TabIndex = 25;
            LabelCUIT.Text = "CUIT";
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Location = new Point(713, 422);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(75, 25);
            ButtonConfirmar.TabIndex = 42;
            ButtonConfirmar.Text = "Confirmar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            ButtonConfirmar.Click += ButtonConfirmar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(632, 422);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 25);
            ButtonCancelar.TabIndex = 41;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // LabelDimension
            // 
            LabelDimension.AutoSize = true;
            LabelDimension.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDimension.Location = new Point(9, 60);
            LabelDimension.Name = "LabelDimension";
            LabelDimension.Size = new Size(64, 15);
            LabelDimension.TabIndex = 17;
            LabelDimension.Text = "Dimensión";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 38;
            label6.Text = "Peso (Kg):";
            // 
            // TextPeso
            // 
            TextPeso.Location = new Point(80, 30);
            TextPeso.Margin = new Padding(4, 3, 4, 3);
            TextPeso.Name = "TextPeso";
            TextPeso.Size = new Size(308, 25);
            TextPeso.TabIndex = 37;
            // 
            // LabelTamaño
            // 
            LabelTamaño.AutoSize = true;
            LabelTamaño.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTamaño.Location = new Point(80, 60);
            LabelTamaño.Name = "LabelTamaño";
            LabelTamaño.Size = new Size(73, 15);
            LabelTamaño.TabIndex = 45;
            LabelTamaño.Text = "S | M | L | XL ";
            // 
            // GrupoEncomienda
            // 
            GrupoEncomienda.Controls.Add(LabelTamaño);
            GrupoEncomienda.Controls.Add(TextPeso);
            GrupoEncomienda.Controls.Add(label6);
            GrupoEncomienda.Controls.Add(LabelDimension);
            GrupoEncomienda.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoEncomienda.Location = new Point(12, 326);
            GrupoEncomienda.Name = "GrupoEncomienda";
            GrupoEncomienda.Size = new Size(776, 90);
            GrupoEncomienda.TabIndex = 45;
            GrupoEncomienda.TabStop = false;
            GrupoEncomienda.Text = "Datos de Encomienta";
            // 
            // Impiscion_CD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 461);
            Controls.Add(LabelImposicion);
            Controls.Add(GrupoEncomienda);
            Controls.Add(GrupoDestinatario);
            Controls.Add(GrupoCliente);
            Controls.Add(ButtonConfirmar);
            Controls.Add(ButtonCancelar);
            Name = "Impiscion_CD";
            Text = "Imposción CD";
            GrupoDestinatario.ResumeLayout(false);
            GrupoDestinatario.PerformLayout();
            GrupoCliente.ResumeLayout(false);
            GrupoCliente.PerformLayout();
            GrupoEncomienda.ResumeLayout(false);
            GrupoEncomienda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelImposicion;
        private GroupBox GrupoDestinatario;
        private Button BotonBuscarD;
        private TextBox TextLocalidad;
        private Label LabelLocalidadD;
        private Label LabelDestinoD;
        private Label LabelTELD;
        private ComboBox ComboDestino;
        private TextBox TextTEL;
        private TextBox TextNombre;
        private TextBox TextAltura;
        private Label LabelAlturaD;
        private TextBox TextCalle;
        private Label LabelCalleD;
        private TextBox TextDNI;
        private Label LabelApellidoD;
        private TextBox TextApellido;
        private Label LabelNombreD;
        private Label LabelDNI;
        private GroupBox GrupoCliente;
        private Button BotonBuscarC;
        private Label LabelTELC;
        private TextBox TxtCuit;
        private Label LabelApellidoC;
        private Label LabelNombreC;
        private Label LabelCUIT;
        private Button ButtonConfirmar;
        private Button ButtonCancelar;
        private Label LabelDimension;
        private Label label6;
        private TextBox TextPeso;
        private Label LabelTamaño;
        private GroupBox GrupoEncomienda;
        private Label LabelTelefono;
        private Label LabelApellido;
        private Label LabelNombre;
    }
}