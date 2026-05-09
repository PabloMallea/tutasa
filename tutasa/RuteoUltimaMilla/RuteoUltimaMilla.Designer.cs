namespace tutasa.RuteoUltimaMilla
{
    partial class RuteoUltimaMilla
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
            GrupoTipoRuteo = new GroupBox();
            RBRetiro = new RadioButton();
            RBEntrega = new RadioButton();
            LvGuiasDisponibles = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            ColumnaDireccion = new ColumnHeader();
            ColumnaTipo = new ColumnHeader();
            ColumnaDimension = new ColumnHeader();
            LvSeleccion = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            GrupoGuias = new GroupBox();
            BtnAgregarTodos = new Button();
            BtnQuitar = new Button();
            BtnAgregarSeleccion = new Button();
            GrupoAsignarFletero = new GroupBox();
            LbFletero = new Label();
            ComboAsignarFletero = new ComboBox();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            GrupoBusqueda = new GroupBox();
            BtnBuscar = new Button();
            txtBoxCuit = new TextBox();
            LabelCUIT = new Label();
            CmbLocalidad = new ComboBox();
            LbLocalidad = new Label();
            LbRuteoUltimaMilla = new Label();
            GrupoTipoRuteo.SuspendLayout();
            GrupoGuias.SuspendLayout();
            GrupoAsignarFletero.SuspendLayout();
            GrupoBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // GrupoTipoRuteo
            // 
            GrupoTipoRuteo.Controls.Add(RBRetiro);
            GrupoTipoRuteo.Controls.Add(RBEntrega);
            GrupoTipoRuteo.Location = new Point(12, 40);
            GrupoTipoRuteo.Name = "GrupoTipoRuteo";
            GrupoTipoRuteo.Size = new Size(734, 70);
            GrupoTipoRuteo.TabIndex = 0;
            GrupoTipoRuteo.TabStop = false;
            GrupoTipoRuteo.Text = "Tipo de Ruteo";
            // 
            // RBRetiro
            // 
            RBRetiro.AutoSize = true;
            RBRetiro.Location = new Point(200, 30);
            RBRetiro.Name = "RBRetiro";
            RBRetiro.RightToLeft = RightToLeft.Yes;
            RBRetiro.Size = new Size(146, 19);
            RBRetiro.TabIndex = 3;
            RBRetiro.TabStop = true;
            RBRetiro.Text = "Retiro de encomiendas";
            RBRetiro.UseVisualStyleBackColor = true;
            // 
            // RBEntrega
            // 
            RBEntrega.AutoSize = true;
            RBEntrega.Location = new Point(9, 30);
            RBEntrega.Name = "RBEntrega";
            RBEntrega.RightToLeft = RightToLeft.Yes;
            RBEntrega.Size = new Size(155, 19);
            RBEntrega.TabIndex = 2;
            RBEntrega.TabStop = true;
            RBEntrega.Text = "Entrega de encomiendas";
            RBEntrega.UseVisualStyleBackColor = true;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaCliente, ColumnaDireccion, ColumnaTipo, ColumnaDimension });
            LvGuiasDisponibles.FullRowSelect = true;
            LvGuiasDisponibles.Location = new Point(9, 22);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(708, 150);
            LvGuiasDisponibles.TabIndex = 5;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "Nro Guía";
            ColumnaNGuia.Width = 140;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 140;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.Text = "Dirección";
            ColumnaDireccion.Width = 140;
            // 
            // ColumnaTipo
            // 
            ColumnaTipo.Text = "Tipo";
            ColumnaTipo.Width = 140;
            // 
            // ColumnaDimension
            // 
            ColumnaDimension.Text = "Dimensión";
            ColumnaDimension.Width = 140;
            // 
            // LvSeleccion
            // 
            LvSeleccion.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader13, columnHeader7, columnHeader8, columnHeader9 });
            LvSeleccion.FullRowSelect = true;
            LvSeleccion.Location = new Point(9, 224);
            LvSeleccion.Name = "LvSeleccion";
            LvSeleccion.Size = new Size(708, 150);
            LvSeleccion.TabIndex = 6;
            LvSeleccion.UseCompatibleStateImageBehavior = false;
            LvSeleccion.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nro Guía";
            columnHeader6.Width = 130;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Cliente";
            columnHeader13.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Dirección";
            columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tipo";
            columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Dimensión";
            columnHeader9.Width = 130;
            // 
            // GrupoGuias
            // 
            GrupoGuias.Controls.Add(BtnAgregarTodos);
            GrupoGuias.Controls.Add(BtnQuitar);
            GrupoGuias.Controls.Add(BtnAgregarSeleccion);
            GrupoGuias.Controls.Add(LvSeleccion);
            GrupoGuias.Controls.Add(LvGuiasDisponibles);
            GrupoGuias.Location = new Point(12, 193);
            GrupoGuias.Name = "GrupoGuias";
            GrupoGuias.Size = new Size(734, 412);
            GrupoGuias.TabIndex = 7;
            GrupoGuias.TabStop = false;
            GrupoGuias.Text = "Guías";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(428, 178);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(289, 25);
            BtnAgregarTodos.TabIndex = 12;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            BtnAgregarTodos.Click += BtnAgregarTodos_Click_1;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(9, 380);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(708, 23);
            BtnQuitar.TabIndex = 10;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            BtnQuitar.Click += BtnQuitar_Click;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(9, 178);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(289, 25);
            BtnAgregarSeleccion.TabIndex = 7;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            BtnAgregarSeleccion.Click += BtnAgregarSeleccion_Click;
            // 
            // GrupoAsignarFletero
            // 
            GrupoAsignarFletero.Controls.Add(LbFletero);
            GrupoAsignarFletero.Controls.Add(ComboAsignarFletero);
            GrupoAsignarFletero.Location = new Point(12, 611);
            GrupoAsignarFletero.Name = "GrupoAsignarFletero";
            GrupoAsignarFletero.Size = new Size(734, 75);
            GrupoAsignarFletero.TabIndex = 8;
            GrupoAsignarFletero.TabStop = false;
            GrupoAsignarFletero.Text = "Asignación de Fletero";
            // 
            // LbFletero
            // 
            LbFletero.AutoSize = true;
            LbFletero.Location = new Point(9, 33);
            LbFletero.Name = "LbFletero";
            LbFletero.Size = new Size(43, 15);
            LbFletero.TabIndex = 5;
            LbFletero.Text = "Fletero";
            // 
            // ComboAsignarFletero
            // 
            ComboAsignarFletero.FormattingEnabled = true;
            ComboAsignarFletero.Location = new Point(73, 30);
            ComboAsignarFletero.Name = "ComboAsignarFletero";
            ComboAsignarFletero.Size = new Size(636, 23);
            ComboAsignarFletero.TabIndex = 0;
            ComboAsignarFletero.SelectedIndexChanged += ComboAsignarFletero_SelectedIndexChanged;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(590, 692);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 25);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(671, 692);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 25);
            BtnConfirmar.TabIndex = 11;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(BtnBuscar);
            GrupoBusqueda.Controls.Add(txtBoxCuit);
            GrupoBusqueda.Controls.Add(LabelCUIT);
            GrupoBusqueda.Controls.Add(CmbLocalidad);
            GrupoBusqueda.Controls.Add(LbLocalidad);
            GrupoBusqueda.Location = new Point(12, 116);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(734, 71);
            GrupoBusqueda.TabIndex = 12;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de Búsqueda";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(637, 27);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(80, 25);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBoxCuit
            // 
            txtBoxCuit.Location = new Point(401, 27);
            txtBoxCuit.Name = "txtBoxCuit";
            txtBoxCuit.Size = new Size(230, 23);
            txtBoxCuit.TabIndex = 3;
            // 
            // LabelCUIT
            // 
            LabelCUIT.AutoSize = true;
            LabelCUIT.Location = new Point(323, 30);
            LabelCUIT.Name = "LabelCUIT";
            LabelCUIT.Size = new Size(72, 15);
            LabelCUIT.TabIndex = 2;
            LabelCUIT.Text = "CUIT Cliente";
            // 
            // CmbLocalidad
            // 
            CmbLocalidad.FormattingEnabled = true;
            CmbLocalidad.Location = new Point(73, 27);
            CmbLocalidad.Name = "CmbLocalidad";
            CmbLocalidad.Size = new Size(230, 23);
            CmbLocalidad.TabIndex = 1;
            // 
            // LbLocalidad
            // 
            LbLocalidad.AutoSize = true;
            LbLocalidad.Location = new Point(9, 30);
            LbLocalidad.Name = "LbLocalidad";
            LbLocalidad.Size = new Size(58, 15);
            LbLocalidad.TabIndex = 0;
            LbLocalidad.Text = "Localidad";
            // 
            // LbRuteoUltimaMilla
            // 
            LbRuteoUltimaMilla.AutoSize = true;
            LbRuteoUltimaMilla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbRuteoUltimaMilla.Location = new Point(15, 10);
            LbRuteoUltimaMilla.Name = "LbRuteoUltimaMilla";
            LbRuteoUltimaMilla.RightToLeft = RightToLeft.No;
            LbRuteoUltimaMilla.Size = new Size(177, 21);
            LbRuteoUltimaMilla.TabIndex = 13;
            LbRuteoUltimaMilla.Text = "Ruteo de Última Milla";
            // 
            // RuteoUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 730);
            Controls.Add(LbRuteoUltimaMilla);
            Controls.Add(GrupoBusqueda);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(GrupoAsignarFletero);
            Controls.Add(GrupoTipoRuteo);
            Controls.Add(GrupoGuias);
            Name = "RuteoUltimaMilla";
            Text = "Ruteo de última milla";
            Load += RuteoUltimaMilla_Load;
            GrupoTipoRuteo.ResumeLayout(false);
            GrupoTipoRuteo.PerformLayout();
            GrupoGuias.ResumeLayout(false);
            GrupoAsignarFletero.ResumeLayout(false);
            GrupoAsignarFletero.PerformLayout();
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrupoTipoRuteo;
        private RadioButton RBEntrega;
        private RadioButton RBRetiro;
        private ListView LvGuiasDisponibles;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaDireccion;
        private ColumnHeader ColumnaTipo;
        private ColumnHeader ColumnaDimension;
        private ListView LvSeleccion;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private GroupBox GrupoGuias;
        private Button BtnAgregarSeleccion;
        private Button BtnQuitar;
        private GroupBox GrupoAsignarFletero;
        private ComboBox ComboAsignarFletero;
        private Button BtnCancelar;
        private Button BtnConfirmar;
        private GroupBox GrupoBusqueda;
        private Label LbLocalidad;
        private ColumnHeader ColumnaCliente;
        private Label LabelCUIT;
        private ComboBox CmbLocalidad;
        private ColumnHeader columnHeader13;
        private Button BtnBuscar;
        private TextBox txtBoxCuit;
        private Button BtnAgregarTodos;
        private Label LbRuteoUltimaMilla;
        private Label LbFletero;
    }
}