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
            label1 = new Label();
            ComboProvincias = new ComboBox();
            ComboLocalidad = new ComboBox();
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
            GrupoDestinatario.Controls.Add(label1);
            GrupoDestinatario.Controls.Add(ComboProvincias);
            GrupoDestinatario.Controls.Add(ComboLocalidad);
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
            GrupoDestinatario.Location = new Point(406, 10);
            GrupoDestinatario.Name = "GrupoDestinatario";
            GrupoDestinatario.Size = new Size(382, 310);
            GrupoDestinatario.TabIndex = 44;
            GrupoDestinatario.TabStop = false;
            GrupoDestinatario.Text = "Destinatario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 45;
            label1.Text = "Provincia";
            // 
            // ComboProvincias
            // 
            ComboProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboProvincias.FormattingEnabled = true;
            ComboProvincias.Location = new Point(76, 31);
            ComboProvincias.Name = "ComboProvincias";
            ComboProvincias.Size = new Size(297, 25);
            ComboProvincias.TabIndex = 44;
            ComboProvincias.SelectedIndexChanged += ComboProvincias_SelectedIndexChanged;
            // 
            // ComboLocalidad
            // 
            ComboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboLocalidad.FormattingEnabled = true;
            ComboLocalidad.Location = new Point(76, 62);
            ComboLocalidad.Name = "ComboLocalidad";
            ComboLocalidad.Size = new Size(297, 25);
            ComboLocalidad.TabIndex = 43;
            ComboLocalidad.SelectedIndexChanged += ComboLocalidad_SelectedIndexChanged;
            // 
            // LabelLocalidadD
            // 
            LabelLocalidadD.AutoSize = true;
            LabelLocalidadD.Font = new Font("Segoe UI", 9F);
            LabelLocalidadD.Location = new Point(9, 67);
            LabelLocalidadD.Name = "LabelLocalidadD";
            LabelLocalidadD.Size = new Size(58, 15);
            LabelLocalidadD.TabIndex = 38;
            LabelLocalidadD.Text = "Localidad";
            // 
            // LabelDestinoD
            // 
            LabelDestinoD.AutoSize = true;
            LabelDestinoD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDestinoD.Location = new Point(9, 96);
            LabelDestinoD.Name = "LabelDestinoD";
            LabelDestinoD.Size = new Size(52, 17);
            LabelDestinoD.TabIndex = 42;
            LabelDestinoD.Text = "Destino";
            // 
            // LabelTELD
            // 
            LabelTELD.AutoSize = true;
            LabelTELD.Font = new Font("Segoe UI", 9F);
            LabelTELD.Location = new Point(9, 284);
            LabelTELD.Name = "LabelTELD";
            LabelTELD.Size = new Size(52, 15);
            LabelTELD.TabIndex = 37;
            LabelTELD.Text = "Teléfono";
            // 
            // ComboDestino
            // 
            ComboDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDestino.FormattingEnabled = true;
            ComboDestino.Location = new Point(76, 93);
            ComboDestino.Name = "ComboDestino";
            ComboDestino.Size = new Size(297, 25);
            ComboDestino.TabIndex = 40;
            ComboDestino.SelectedIndexChanged += ComboDestino_SelectedIndexChanged;
            // 
            // TextTEL
            // 
            TextTEL.Location = new Point(76, 279);
            TextTEL.Name = "TextTEL";
            TextTEL.Size = new Size(297, 25);
            TextTEL.TabIndex = 36;
            // 
            // TextNombre
            // 
            TextNombre.Location = new Point(76, 186);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(297, 25);
            TextNombre.TabIndex = 35;
            // 
            // TextAltura
            // 
            TextAltura.Location = new Point(76, 155);
            TextAltura.Name = "TextAltura";
            TextAltura.Size = new Size(297, 25);
            TextAltura.TabIndex = 34;
            // 
            // LabelAlturaD
            // 
            LabelAlturaD.AutoSize = true;
            LabelAlturaD.Font = new Font("Segoe UI", 9F);
            LabelAlturaD.Location = new Point(10, 160);
            LabelAlturaD.Name = "LabelAlturaD";
            LabelAlturaD.Size = new Size(39, 15);
            LabelAlturaD.TabIndex = 33;
            LabelAlturaD.Text = "Altura";
            // 
            // TextCalle
            // 
            TextCalle.Location = new Point(76, 124);
            TextCalle.Name = "TextCalle";
            TextCalle.Size = new Size(297, 25);
            TextCalle.TabIndex = 32;
            // 
            // LabelCalleD
            // 
            LabelCalleD.AutoSize = true;
            LabelCalleD.Font = new Font("Segoe UI", 9F);
            LabelCalleD.Location = new Point(10, 129);
            LabelCalleD.Name = "LabelCalleD";
            LabelCalleD.Size = new Size(33, 15);
            LabelCalleD.TabIndex = 31;
            LabelCalleD.Text = "Calle";
            // 
            // TextDNI
            // 
            TextDNI.Location = new Point(76, 248);
            TextDNI.Name = "TextDNI";
            TextDNI.Size = new Size(297, 25);
            TextDNI.TabIndex = 30;
            // 
            // LabelApellidoD
            // 
            LabelApellidoD.AutoSize = true;
            LabelApellidoD.Font = new Font("Segoe UI", 9F);
            LabelApellidoD.Location = new Point(10, 222);
            LabelApellidoD.Name = "LabelApellidoD";
            LabelApellidoD.Size = new Size(51, 15);
            LabelApellidoD.TabIndex = 29;
            LabelApellidoD.Text = "Apellido";
            // 
            // TextApellido
            // 
            TextApellido.Location = new Point(76, 217);
            TextApellido.Name = "TextApellido";
            TextApellido.Size = new Size(297, 25);
            TextApellido.TabIndex = 28;
            // 
            // LabelNombreD
            // 
            LabelNombreD.AutoSize = true;
            LabelNombreD.Font = new Font("Segoe UI", 9F);
            LabelNombreD.Location = new Point(9, 191);
            LabelNombreD.Name = "LabelNombreD";
            LabelNombreD.Size = new Size(51, 15);
            LabelNombreD.TabIndex = 27;
            LabelNombreD.Text = "Nombre";
            // 
            // LabelDNI
            // 
            LabelDNI.AutoSize = true;
            LabelDNI.Font = new Font("Segoe UI", 9F);
            LabelDNI.Location = new Point(10, 253);
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
            ButtonCancelar.Click += ButtonCancelar_Click_1;
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
            TextPeso.TextChanged += TextPeso_TextChanged;
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
            Load += Impiscion_CD_Load;
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
        private Label label1;
        private ComboBox ComboProvincias;
        private ComboBox ComboLocalidad;
    }
}