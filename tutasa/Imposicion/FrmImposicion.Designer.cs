namespace tutasa.Imposicion
{
    partial class FrmImposicion
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
            LabelTipoImposcion = new Label();
            ButtonCancelar = new Button();
            ButtonConfirmar = new Button();
            LabelTipoImposicion = new Label();
            GrupoCliente = new GroupBox();
            comboBox1 = new ComboBox();
            LabelDomicilio = new Label();
            LabelLocalidad = new Label();
            LabelAltura = new Label();
            LabelCalle = new Label();
            LabelTEL = new Label();
            LabelApellido = new Label();
            LabelNombre = new Label();
            BotonBuscarC = new Button();
            LabelLocalidadC = new Label();
            LabelAlturaC = new Label();
            LabelTELC = new Label();
            LabelCalleC = new Label();
            textBox1 = new TextBox();
            LabelApellidoC = new Label();
            LabelNombreC = new Label();
            LabelCUIT = new Label();
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
            GrupoEncomienda = new GroupBox();
            LabelTamaño = new Label();
            ComboDimension = new ComboBox();
            LabelDimension = new Label();
            LabelImposicion = new Label();
            GrupoCliente.SuspendLayout();
            GrupoDestinatario.SuspendLayout();
            GrupoEncomienda.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTipoImposcion
            // 
            LabelTipoImposcion.AutoSize = true;
            LabelTipoImposcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTipoImposcion.Location = new Point(12, 39);
            LabelTipoImposcion.Name = "LabelTipoImposcion";
            LabelTipoImposcion.Size = new Size(101, 17);
            LabelTipoImposcion.TabIndex = 18;
            LabelTipoImposcion.Text = "Tipo Imposición";
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(628, 459);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 23);
            ButtonCancelar.TabIndex = 26;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Location = new Point(709, 459);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(75, 23);
            ButtonConfirmar.TabIndex = 27;
            ButtonConfirmar.Text = "Confirmar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            ButtonConfirmar.Click += ButtonConfirmar_Click;
            // 
            // LabelTipoImposicion
            // 
            LabelTipoImposicion.AccessibleRole = AccessibleRole.OutlineButton;
            LabelTipoImposicion.AutoSize = true;
            LabelTipoImposicion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTipoImposicion.Location = new Point(119, 39);
            LabelTipoImposicion.Name = "LabelTipoImposicion";
            LabelTipoImposicion.Size = new Size(270, 17);
            LabelTipoImposicion.TabIndex = 28;
            LabelTipoImposicion.Text = "Agencia | Centro de Distribución | Call Center";
            // 
            // GrupoCliente
            // 
            GrupoCliente.Controls.Add(comboBox1);
            GrupoCliente.Controls.Add(LabelDomicilio);
            GrupoCliente.Controls.Add(LabelLocalidad);
            GrupoCliente.Controls.Add(LabelAltura);
            GrupoCliente.Controls.Add(LabelCalle);
            GrupoCliente.Controls.Add(LabelTEL);
            GrupoCliente.Controls.Add(LabelApellido);
            GrupoCliente.Controls.Add(LabelNombre);
            GrupoCliente.Controls.Add(BotonBuscarC);
            GrupoCliente.Controls.Add(LabelLocalidadC);
            GrupoCliente.Controls.Add(LabelAlturaC);
            GrupoCliente.Controls.Add(LabelTELC);
            GrupoCliente.Controls.Add(LabelCalleC);
            GrupoCliente.Controls.Add(textBox1);
            GrupoCliente.Controls.Add(LabelApellidoC);
            GrupoCliente.Controls.Add(LabelNombreC);
            GrupoCliente.Controls.Add(LabelCUIT);
            GrupoCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoCliente.Location = new Point(12, 70);
            GrupoCliente.Name = "GrupoCliente";
            GrupoCliente.Size = new Size(383, 286);
            GrupoCliente.TabIndex = 29;
            GrupoCliente.TabStop = false;
            GrupoCliente.Text = "Cliente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 25);
            comboBox1.TabIndex = 41;
            // 
            // LabelDomicilio
            // 
            LabelDomicilio.AutoSize = true;
            LabelDomicilio.Font = new Font("Segoe UI", 9F);
            LabelDomicilio.Location = new Point(9, 150);
            LabelDomicilio.Name = "LabelDomicilio";
            LabelDomicilio.Size = new Size(68, 15);
            LabelDomicilio.TabIndex = 40;
            LabelDomicilio.Text = "Domicilio/s";
            // 
            // LabelLocalidad
            // 
            LabelLocalidad.AutoSize = true;
            LabelLocalidad.Font = new Font("Segoe UI", 9F);
            LabelLocalidad.Location = new Point(78, 240);
            LabelLocalidad.Name = "LabelLocalidad";
            LabelLocalidad.Size = new Size(64, 15);
            LabelLocalidad.TabIndex = 38;
            LabelLocalidad.Text = "Springfield";
            // 
            // LabelAltura
            // 
            LabelAltura.AutoSize = true;
            LabelAltura.Font = new Font("Segoe UI", 9F);
            LabelAltura.Location = new Point(76, 210);
            LabelAltura.Name = "LabelAltura";
            LabelAltura.Size = new Size(25, 15);
            LabelAltura.TabIndex = 37;
            LabelAltura.Text = "123";
            // 
            // LabelCalle
            // 
            LabelCalle.AutoSize = true;
            LabelCalle.Font = new Font("Segoe UI", 9F);
            LabelCalle.Location = new Point(76, 180);
            LabelCalle.Name = "LabelCalle";
            LabelCalle.Size = new Size(62, 15);
            LabelCalle.TabIndex = 36;
            LabelCalle.Text = "Calle Falsa";
            LabelCalle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTEL
            // 
            LabelTEL.AutoSize = true;
            LabelTEL.Font = new Font("Segoe UI", 9F);
            LabelTEL.Location = new Point(76, 120);
            LabelTEL.Name = "LabelTEL";
            LabelTEL.Size = new Size(67, 15);
            LabelTEL.TabIndex = 35;
            LabelTEL.Text = "1122334455";
            // 
            // LabelApellido
            // 
            LabelApellido.AutoSize = true;
            LabelApellido.Font = new Font("Segoe UI", 9F);
            LabelApellido.Location = new Point(78, 90);
            LabelApellido.Name = "LabelApellido";
            LabelApellido.Size = new Size(35, 15);
            LabelApellido.TabIndex = 34;
            LabelApellido.Text = "Perez";
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Segoe UI", 9F);
            LabelNombre.Location = new Point(78, 60);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(31, 15);
            LabelNombre.TabIndex = 39;
            LabelNombre.Text = "Juan";
            // 
            // BotonBuscarC
            // 
            BotonBuscarC.Location = new Point(299, 30);
            BotonBuscarC.Name = "BotonBuscarC";
            BotonBuscarC.Size = new Size(75, 23);
            BotonBuscarC.TabIndex = 33;
            BotonBuscarC.Text = "Buscar";
            BotonBuscarC.UseVisualStyleBackColor = true;
            // 
            // LabelLocalidadC
            // 
            LabelLocalidadC.AutoSize = true;
            LabelLocalidadC.Font = new Font("Segoe UI", 9F);
            LabelLocalidadC.Location = new Point(9, 240);
            LabelLocalidadC.Name = "LabelLocalidadC";
            LabelLocalidadC.Size = new Size(58, 15);
            LabelLocalidadC.TabIndex = 32;
            LabelLocalidadC.Text = "Localidad";
            // 
            // LabelAlturaC
            // 
            LabelAlturaC.AutoSize = true;
            LabelAlturaC.Font = new Font("Segoe UI", 9F);
            LabelAlturaC.Location = new Point(9, 210);
            LabelAlturaC.Name = "LabelAlturaC";
            LabelAlturaC.Size = new Size(39, 15);
            LabelAlturaC.TabIndex = 31;
            LabelAlturaC.Text = "Altura";
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
            // LabelCalleC
            // 
            LabelCalleC.AutoSize = true;
            LabelCalleC.Font = new Font("Segoe UI", 9F);
            LabelCalleC.Location = new Point(9, 180);
            LabelCalleC.Name = "LabelCalleC";
            LabelCalleC.Size = new Size(33, 15);
            LabelCalleC.TabIndex = 29;
            LabelCalleC.Text = "Calle";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 25);
            textBox1.TabIndex = 28;
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
            GrupoDestinatario.Location = new Point(401, 70);
            GrupoDestinatario.Name = "GrupoDestinatario";
            GrupoDestinatario.Size = new Size(383, 286);
            GrupoDestinatario.TabIndex = 30;
            GrupoDestinatario.TabStop = false;
            GrupoDestinatario.Text = "Destinatario";
            // 
            // BotonBuscarD
            // 
            BotonBuscarD.Location = new Point(298, 30);
            BotonBuscarD.Name = "BotonBuscarD";
            BotonBuscarD.Size = new Size(75, 23);
            BotonBuscarD.TabIndex = 41;
            BotonBuscarD.Text = "Buscar";
            BotonBuscarD.UseVisualStyleBackColor = true;
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
            TextAltura.Size = new Size(295, 25);
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
            TextCalle.Size = new Size(296, 25);
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
            // GrupoEncomienda
            // 
            GrupoEncomienda.Controls.Add(LabelTamaño);
            GrupoEncomienda.Controls.Add(ComboDimension);
            GrupoEncomienda.Controls.Add(LabelDimension);
            GrupoEncomienda.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrupoEncomienda.Location = new Point(12, 362);
            GrupoEncomienda.Name = "GrupoEncomienda";
            GrupoEncomienda.Size = new Size(772, 91);
            GrupoEncomienda.TabIndex = 31;
            GrupoEncomienda.TabStop = false;
            GrupoEncomienda.Text = "Datos de Encomienta";
            // 
            // LabelTamaño
            // 
            LabelTamaño.AutoSize = true;
            LabelTamaño.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTamaño.Location = new Point(78, 54);
            LabelTamaño.Name = "LabelTamaño";
            LabelTamaño.Size = new Size(308, 15);
            LabelTamaño.TabIndex = 19;
            LabelTamaño.Text = "S: hasta 2.5 kg | M: hasta 5 kg | L: hasta10 kg | XL: hasta 20";
            // 
            // ComboDimension
            // 
            ComboDimension.FormattingEnabled = true;
            ComboDimension.Location = new Point(80, 25);
            ComboDimension.Name = "ComboDimension";
            ComboDimension.Size = new Size(682, 25);
            ComboDimension.TabIndex = 18;
            // 
            // LabelDimension
            // 
            LabelDimension.AutoSize = true;
            LabelDimension.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDimension.Location = new Point(11, 25);
            LabelDimension.Name = "LabelDimension";
            LabelDimension.Size = new Size(64, 15);
            LabelDimension.TabIndex = 17;
            LabelDimension.Text = "Dimensión";
            // 
            // LabelImposicion
            // 
            LabelImposicion.AutoSize = true;
            LabelImposicion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelImposicion.Location = new Point(12, 9);
            LabelImposicion.Name = "LabelImposicion";
            LabelImposicion.Size = new Size(91, 21);
            LabelImposicion.TabIndex = 32;
            LabelImposicion.Text = "Imposición";
            // 
            // FrmImposicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 496);
            Controls.Add(LabelImposicion);
            Controls.Add(GrupoEncomienda);
            Controls.Add(GrupoDestinatario);
            Controls.Add(GrupoCliente);
            Controls.Add(LabelTipoImposicion);
            Controls.Add(ButtonConfirmar);
            Controls.Add(ButtonCancelar);
            Controls.Add(LabelTipoImposcion);
            Name = "FrmImposicion";
            Text = "Imposición";
            Load += Imposicion_Load;
            GrupoCliente.ResumeLayout(false);
            GrupoCliente.PerformLayout();
            GrupoDestinatario.ResumeLayout(false);
            GrupoDestinatario.PerformLayout();
            GrupoEncomienda.ResumeLayout(false);
            GrupoEncomienda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelTipoImposcion;
        private Button ButtonCancelar;
        private Button ButtonConfirmar;
        private Label LabelTipoImposicion;
        private GroupBox GrupoCliente;
        private ComboBox comboBox1;
        private Label LabelDomicilio;
        private Label LabelLocalidad;
        private Label LabelAltura;
        private Label LabelCalle;
        private Label LabelTEL;
        private Label LabelApellido;
        private Label LabelNombre;
        private Button BotonBuscarC;
        private Label LabelLocalidadC;
        private Label LabelAlturaC;
        private Label LabelTELC;
        private Label LabelCalleC;
        private TextBox textBox1;
        private Label LabelApellidoC;
        private Label LabelNombreC;
        private Label LabelCUIT;
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
        private GroupBox GrupoEncomienda;
        private Label LabelTamaño;
        private ComboBox ComboDimension;
        private Label LabelDimension;
        private Label LabelImposicion;
    }
}