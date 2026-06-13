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
            LabelImposicion.Location = new Point(17, 13);
            LabelImposicion.Name = "LabelImposicion";
            LabelImposicion.Size = new Size(190, 28);
            LabelImposicion.TabIndex = 40;
            LabelImposicion.Text = "Imposición Agencia";
            // 
            // GrupoEncomienda
            // 
            GrupoEncomienda.Controls.Add(LabelTamaño);
            GrupoEncomienda.Controls.Add(ComboDimension);
            GrupoEncomienda.Controls.Add(LabelDimension);
            GrupoEncomienda.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoEncomienda.Location = new Point(14, 435);
            GrupoEncomienda.Margin = new Padding(3, 4, 3, 4);
            GrupoEncomienda.Name = "GrupoEncomienda";
            GrupoEncomienda.Padding = new Padding(3, 4, 3, 4);
            GrupoEncomienda.Size = new Size(887, 120);
            GrupoEncomienda.TabIndex = 39;
            GrupoEncomienda.TabStop = false;
            GrupoEncomienda.Text = "Datos de Encomienta";
            // 
            // LabelTamaño
            // 
            LabelTamaño.AutoSize = true;
            LabelTamaño.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTamaño.Location = new Point(91, 77);
            LabelTamaño.Name = "LabelTamaño";
            LabelTamaño.Size = new Size(388, 20);
            LabelTamaño.TabIndex = 19;
            LabelTamaño.Text = "S: hasta 2.5 kg | M: hasta 5 kg | L: hasta10 kg | XL: hasta 20";
            LabelTamaño.Click += LabelTamaño_Click;
            // 
            // ComboDimension
            // 
            ComboDimension.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDimension.FormattingEnabled = true;
            ComboDimension.Location = new Point(91, 40);
            ComboDimension.Margin = new Padding(3, 4, 3, 4);
            ComboDimension.Name = "ComboDimension";
            ComboDimension.Size = new Size(351, 29);
            ComboDimension.TabIndex = 18;
            // 
            // LabelDimension
            // 
            LabelDimension.AutoSize = true;
            LabelDimension.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDimension.Location = new Point(10, 40);
            LabelDimension.Name = "LabelDimension";
            LabelDimension.Size = new Size(80, 20);
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
            GrupoDestinatario.Location = new Point(464, 53);
            GrupoDestinatario.Margin = new Padding(3, 4, 3, 4);
            GrupoDestinatario.Name = "GrupoDestinatario";
            GrupoDestinatario.Padding = new Padding(3, 4, 3, 4);
            GrupoDestinatario.Size = new Size(437, 373);
            GrupoDestinatario.TabIndex = 38;
            GrupoDestinatario.TabStop = false;
            GrupoDestinatario.Text = "Destinatario";
            // 
            // BotonBuscarD
            // 
            BotonBuscarD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarD.Location = new Point(341, 40);
            BotonBuscarD.Margin = new Padding(3, 4, 3, 4);
            BotonBuscarD.Name = "BotonBuscarD";
            BotonBuscarD.Size = new Size(86, 33);
            BotonBuscarD.TabIndex = 41;
            BotonBuscarD.Text = "Buscar";
            BotonBuscarD.UseVisualStyleBackColor = true;
            BotonBuscarD.Click += BotonBuscarD_Click;
            // 
            // TextLocalidad
            // 
            TextLocalidad.Location = new Point(87, 40);
            TextLocalidad.Margin = new Padding(3, 4, 3, 4);
            TextLocalidad.Name = "TextLocalidad";
            TextLocalidad.Size = new Size(246, 29);
            TextLocalidad.TabIndex = 39;
            // 
            // LabelLocalidadD
            // 
            LabelLocalidadD.AutoSize = true;
            LabelLocalidadD.Font = new Font("Segoe UI", 9F);
            LabelLocalidadD.Location = new Point(10, 40);
            LabelLocalidadD.Name = "LabelLocalidadD";
            LabelLocalidadD.Size = new Size(74, 20);
            LabelLocalidadD.TabIndex = 38;
            LabelLocalidadD.Text = "Localidad";
            // 
            // LabelDestinoD
            // 
            LabelDestinoD.AutoSize = true;
            LabelDestinoD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDestinoD.Location = new Point(10, 80);
            LabelDestinoD.Name = "LabelDestinoD";
            LabelDestinoD.Size = new Size(68, 23);
            LabelDestinoD.TabIndex = 42;
            LabelDestinoD.Text = "Destino";
            // 
            // LabelTELD
            // 
            LabelTELD.AutoSize = true;
            LabelTELD.Font = new Font("Segoe UI", 9F);
            LabelTELD.Location = new Point(10, 320);
            LabelTELD.Name = "LabelTELD";
            LabelTELD.Size = new Size(67, 20);
            LabelTELD.TabIndex = 37;
            LabelTELD.Text = "Teléfono";
            // 
            // ComboDestino
            // 
            ComboDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDestino.FormattingEnabled = true;
            ComboDestino.Location = new Point(87, 80);
            ComboDestino.Margin = new Padding(3, 4, 3, 4);
            ComboDestino.Name = "ComboDestino";
            ComboDestino.Size = new Size(339, 29);
            ComboDestino.TabIndex = 40;
            ComboDestino.SelectedIndexChanged += ComboDestino_SelectedIndexChanged1;
            // 
            // TextTEL
            // 
            TextTEL.Location = new Point(87, 320);
            TextTEL.Margin = new Padding(3, 4, 3, 4);
            TextTEL.Name = "TextTEL";
            TextTEL.Size = new Size(339, 29);
            TextTEL.TabIndex = 36;
            // 
            // TextNombre
            // 
            TextNombre.Location = new Point(87, 200);
            TextNombre.Margin = new Padding(3, 4, 3, 4);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(339, 29);
            TextNombre.TabIndex = 35;
            // 
            // TextAltura
            // 
            TextAltura.Location = new Point(87, 160);
            TextAltura.Margin = new Padding(3, 4, 3, 4);
            TextAltura.Name = "TextAltura";
            TextAltura.Size = new Size(339, 29);
            TextAltura.TabIndex = 34;
            // 
            // LabelAlturaD
            // 
            LabelAlturaD.AutoSize = true;
            LabelAlturaD.Font = new Font("Segoe UI", 9F);
            LabelAlturaD.Location = new Point(10, 160);
            LabelAlturaD.Name = "LabelAlturaD";
            LabelAlturaD.Size = new Size(49, 20);
            LabelAlturaD.TabIndex = 33;
            LabelAlturaD.Text = "Altura";
            // 
            // TextCalle
            // 
            TextCalle.Location = new Point(87, 120);
            TextCalle.Margin = new Padding(3, 4, 3, 4);
            TextCalle.Name = "TextCalle";
            TextCalle.Size = new Size(339, 29);
            TextCalle.TabIndex = 32;
            // 
            // LabelCalleD
            // 
            LabelCalleD.AutoSize = true;
            LabelCalleD.Font = new Font("Segoe UI", 9F);
            LabelCalleD.Location = new Point(10, 120);
            LabelCalleD.Name = "LabelCalleD";
            LabelCalleD.Size = new Size(42, 20);
            LabelCalleD.TabIndex = 31;
            LabelCalleD.Text = "Calle";
            // 
            // TextDNI
            // 
            TextDNI.Location = new Point(87, 280);
            TextDNI.Margin = new Padding(3, 4, 3, 4);
            TextDNI.Name = "TextDNI";
            TextDNI.Size = new Size(339, 29);
            TextDNI.TabIndex = 30;
            // 
            // LabelApellidoD
            // 
            LabelApellidoD.AutoSize = true;
            LabelApellidoD.Font = new Font("Segoe UI", 9F);
            LabelApellidoD.Location = new Point(11, 240);
            LabelApellidoD.Name = "LabelApellidoD";
            LabelApellidoD.Size = new Size(66, 20);
            LabelApellidoD.TabIndex = 29;
            LabelApellidoD.Text = "Apellido";
            // 
            // TextApellido
            // 
            TextApellido.Location = new Point(87, 240);
            TextApellido.Margin = new Padding(3, 4, 3, 4);
            TextApellido.Name = "TextApellido";
            TextApellido.Size = new Size(339, 29);
            TextApellido.TabIndex = 28;
            // 
            // LabelNombreD
            // 
            LabelNombreD.AutoSize = true;
            LabelNombreD.Font = new Font("Segoe UI", 9F);
            LabelNombreD.Location = new Point(11, 200);
            LabelNombreD.Name = "LabelNombreD";
            LabelNombreD.Size = new Size(64, 20);
            LabelNombreD.TabIndex = 27;
            LabelNombreD.Text = "Nombre";
            // 
            // LabelDNI
            // 
            LabelDNI.AutoSize = true;
            LabelDNI.Font = new Font("Segoe UI", 9F);
            LabelDNI.Location = new Point(11, 280);
            LabelDNI.Name = "LabelDNI";
            LabelDNI.Size = new Size(35, 20);
            LabelDNI.TabIndex = 26;
            LabelDNI.Text = "DNI";
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Location = new Point(815, 563);
            ButtonConfirmar.Margin = new Padding(3, 4, 3, 4);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(86, 33);
            ButtonConfirmar.TabIndex = 35;
            ButtonConfirmar.Text = "Confirmar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            ButtonConfirmar.Click += ButtonConfirmar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(722, 563);
            ButtonCancelar.Margin = new Padding(3, 4, 3, 4);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(86, 33);
            ButtonCancelar.TabIndex = 34;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // LabelCUIT
            // 
            LabelCUIT.AutoSize = true;
            LabelCUIT.Font = new Font("Segoe UI", 9F);
            LabelCUIT.Location = new Point(10, 40);
            LabelCUIT.Name = "LabelCUIT";
            LabelCUIT.Size = new Size(40, 20);
            LabelCUIT.TabIndex = 25;
            LabelCUIT.Text = "CUIT";
            // 
            // LabelNombreC
            // 
            LabelNombreC.AutoSize = true;
            LabelNombreC.Font = new Font("Segoe UI", 9F);
            LabelNombreC.Location = new Point(10, 80);
            LabelNombreC.Name = "LabelNombreC";
            LabelNombreC.Size = new Size(64, 20);
            LabelNombreC.TabIndex = 26;
            LabelNombreC.Text = "Nombre";
            // 
            // LabelApellidoC
            // 
            LabelApellidoC.AutoSize = true;
            LabelApellidoC.Font = new Font("Segoe UI", 9F);
            LabelApellidoC.Location = new Point(10, 120);
            LabelApellidoC.Name = "LabelApellidoC";
            LabelApellidoC.Size = new Size(66, 20);
            LabelApellidoC.TabIndex = 27;
            LabelApellidoC.Text = "Apellido";
            // 
            // TxtCuit
            // 
            TxtCuit.Location = new Point(86, 40);
            TxtCuit.Margin = new Padding(3, 4, 3, 4);
            TxtCuit.Name = "TxtCuit";
            TxtCuit.Size = new Size(246, 29);
            TxtCuit.TabIndex = 28;
            // 
            // LabelTELC
            // 
            LabelTELC.AutoSize = true;
            LabelTELC.Font = new Font("Segoe UI", 9F);
            LabelTELC.Location = new Point(10, 160);
            LabelTELC.Name = "LabelTELC";
            LabelTELC.Size = new Size(67, 20);
            LabelTELC.TabIndex = 30;
            LabelTELC.Text = "Teléfono";
            // 
            // BotonBuscarC
            // 
            BotonBuscarC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarC.Location = new Point(341, 40);
            BotonBuscarC.Margin = new Padding(3, 4, 3, 4);
            BotonBuscarC.Name = "BotonBuscarC";
            BotonBuscarC.Size = new Size(86, 33);
            BotonBuscarC.TabIndex = 33;
            BotonBuscarC.Text = "Buscar";
            BotonBuscarC.UseVisualStyleBackColor = true;
            BotonBuscarC.Click += BotonBuscarC_Click;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 9F);
            LabelNombre.Location = new Point(86, 80);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(0, 20);
            LabelNombre.TabIndex = 39;
            // 
            // LabelApellido
            // 
            LabelApellido.AutoSize = true;
            LabelApellido.Font = new Font("Segoe UI", 9F);
            LabelApellido.Location = new Point(86, 120);
            LabelApellido.Name = "LabelApellido";
            LabelApellido.Size = new Size(0, 20);
            LabelApellido.TabIndex = 34;
            // 
            // LabelTEL
            // 
            LabelTEL.AutoSize = true;
            LabelTEL.Font = new Font("Segoe UI", 9F);
            LabelTEL.Location = new Point(86, 160);
            LabelTEL.Name = "LabelTEL";
            LabelTEL.Size = new Size(0, 20);
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
            GrupoCliente.Location = new Point(14, 53);
            GrupoCliente.Margin = new Padding(3, 4, 3, 4);
            GrupoCliente.Name = "GrupoCliente";
            GrupoCliente.Padding = new Padding(3, 4, 3, 4);
            GrupoCliente.Size = new Size(437, 373);
            GrupoCliente.TabIndex = 37;
            GrupoCliente.TabStop = false;
            GrupoCliente.Text = "Cliente";
            GrupoCliente.Enter += GrupoCliente_Enter;
            // 
            // Imposicion_Agencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 615);
            Controls.Add(LabelImposicion);
            Controls.Add(GrupoEncomienda);
            Controls.Add(GrupoDestinatario);
            Controls.Add(GrupoCliente);
            Controls.Add(ButtonConfirmar);
            Controls.Add(ButtonCancelar);
            Margin = new Padding(3, 4, 3, 4);
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