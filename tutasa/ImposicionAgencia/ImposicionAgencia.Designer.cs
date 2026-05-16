namespace tutasa.Imposicion_Agencia
{
    partial class Imposicion_Agencia
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
            GrupoEncomienda = new GroupBox();
            LabelTamaño = new Label();
            ComboDimension = new ComboBox();
            LabelDimension = new Label();
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
            ButtonConfirmar = new Button();
            ButtonCancelar = new Button();
            LabelCUIT = new Label();
            LabelNombreC = new Label();
            LabelApellidoC = new Label();
            TxtCuit = new TextBox();
            LabelTELC = new Label();
            BotonBuscarC = new Button();
            LabelNombre = new Label();
            LabelApellido = new Label();
            LabelTEL = new Label();
            GrupoCliente = new GroupBox();
            GrupoEncomienda.SuspendLayout();
            GrupoDestinatario.SuspendLayout();
            GrupoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // LabelImposicion
            // 
            LabelImposicion.AutoSize = true;
            LabelImposicion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelImposicion.Location = new Point(15, 10);
            LabelImposicion.Name = "LabelImposicion";
            LabelImposicion.Size = new Size(154, 21);
            LabelImposicion.TabIndex = 40;
            LabelImposicion.Text = "Imposición Agencia";
            // 
            // GrupoEncomienda
            // 
            GrupoEncomienda.Controls.Add(LabelTamaño);
            GrupoEncomienda.Controls.Add(ComboDimension);
            GrupoEncomienda.Controls.Add(LabelDimension);
            GrupoEncomienda.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoEncomienda.Location = new Point(12, 326);
            GrupoEncomienda.Name = "GrupoEncomienda";
            GrupoEncomienda.Size = new Size(776, 90);
            GrupoEncomienda.TabIndex = 39;
            GrupoEncomienda.TabStop = false;
            GrupoEncomienda.Text = "Datos de Encomienta";
            // 
            // LabelTamaño
            // 
            LabelTamaño.AutoSize = true;
            LabelTamaño.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTamaño.Location = new Point(80, 58);
            LabelTamaño.Name = "LabelTamaño";
            LabelTamaño.Size = new Size(308, 15);
            LabelTamaño.TabIndex = 19;
            LabelTamaño.Text = "S: hasta 2.5 kg | M: hasta 5 kg | L: hasta10 kg | XL: hasta 20";
            LabelTamaño.Click += LabelTamaño_Click;
            // 
            // ComboDimension
            // 
            ComboDimension.FormattingEnabled = true;
            ComboDimension.Location = new Point(80, 30);
            ComboDimension.Name = "ComboDimension";
            ComboDimension.Size = new Size(308, 25);
            ComboDimension.TabIndex = 18;
            // 
            // LabelDimension
            // 
            LabelDimension.AutoSize = true;
            LabelDimension.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDimension.Location = new Point(9, 30);
            LabelDimension.Name = "LabelDimension";
            LabelDimension.Size = new Size(64, 15);
            LabelDimension.TabIndex = 17;
            LabelDimension.Text = "Dimensión";
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
            GrupoDestinatario.TabIndex = 38;
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
            BotonBuscarD.Click += BotonBuscarD_Click;
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
            // ButtonConfirmar
            // 
            ButtonConfirmar.Location = new Point(713, 422);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(75, 25);
            ButtonConfirmar.TabIndex = 35;
            ButtonConfirmar.Text = "Confirmar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            ButtonConfirmar.Click += ButtonConfirmar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(632, 422);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 25);
            ButtonCancelar.TabIndex = 34;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
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
            // TxtCuit
            // 
            TxtCuit.Location = new Point(75, 30);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(216, 25);
            TxtCuit.TabIndex = 28;
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
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 9F);
            LabelNombre.Location = new Point(75, 60);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 15);
            LabelNombre.TabIndex = 39;
            // 
            // LabelApellido
            // 
            LabelApellido.AutoSize = true;
            LabelApellido.Font = new Font("Segoe UI", 9F);
            LabelApellido.Location = new Point(75, 90);
            LabelApellido.Name = "LabelApellido";
            LabelApellido.Size = new Size(0, 15);
            LabelApellido.TabIndex = 34;
            // 
            // LabelTEL
            // 
            LabelTEL.AutoSize = true;
            LabelTEL.Font = new Font("Segoe UI", 9F);
            LabelTEL.Location = new Point(75, 120);
            LabelTEL.Name = "LabelTEL";
            LabelTEL.Size = new Size(0, 15);
            LabelTEL.TabIndex = 35;
            // 
            // GrupoCliente
            // 
            GrupoCliente.Controls.Add(LabelTEL);
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
            GrupoCliente.TabIndex = 37;
            GrupoCliente.TabStop = false;
            GrupoCliente.Text = "Cliente";
            // 
            // Imposicion_Agencia
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
            Name = "Imposicion_Agencia";
            Text = "Imposicion_Agencia";
            Load += Imposicion_Agencia_Load;
            GrupoEncomienda.ResumeLayout(false);
            GrupoEncomienda.PerformLayout();
            GrupoDestinatario.ResumeLayout(false);
            GrupoDestinatario.PerformLayout();
            GrupoCliente.ResumeLayout(false);
            GrupoCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelImposicion;
        private GroupBox GrupoEncomienda;
        private Label LabelTamaño;
        private ComboBox ComboDimension;
        private Label LabelDimension;
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
        private Button ButtonConfirmar;
        private Button ButtonCancelar;
        private Label LabelCUIT;
        private Label LabelNombreC;
        private Label LabelApellidoC;
        private TextBox TxtCuit;
        private Label LabelTELC;
        private Button BotonBuscarC;
        private Label LabelNombre;
        private Label LabelApellido;
        private Label LabelTEL;
        private GroupBox GrupoCliente;
    }
}