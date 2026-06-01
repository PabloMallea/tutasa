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
            columnHeader1 = new ColumnHeader();
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
            GrupoTipoRuteo.Location = new Point(14, 53);
            GrupoTipoRuteo.Margin = new Padding(3, 4, 3, 4);
            GrupoTipoRuteo.Name = "GrupoTipoRuteo";
            GrupoTipoRuteo.Padding = new Padding(3, 4, 3, 4);
            GrupoTipoRuteo.Size = new Size(839, 93);
            GrupoTipoRuteo.TabIndex = 0;
            GrupoTipoRuteo.TabStop = false;
            GrupoTipoRuteo.Text = "Tipo de Ruteo";
            // 
            // RBRetiro
            // 
            RBRetiro.AutoSize = true;
            RBRetiro.Location = new Point(229, 40);
            RBRetiro.Margin = new Padding(3, 4, 3, 4);
            RBRetiro.Name = "RBRetiro";
            RBRetiro.RightToLeft = RightToLeft.Yes;
            RBRetiro.Size = new Size(183, 24);
            RBRetiro.TabIndex = 3;
            RBRetiro.TabStop = true;
            RBRetiro.Text = "Retiro de encomiendas";
            RBRetiro.UseVisualStyleBackColor = true;
            // 
            // RBEntrega
            // 
            RBEntrega.AutoSize = true;
            RBEntrega.Location = new Point(10, 40);
            RBEntrega.Margin = new Padding(3, 4, 3, 4);
            RBEntrega.Name = "RBEntrega";
            RBEntrega.RightToLeft = RightToLeft.Yes;
            RBEntrega.Size = new Size(194, 24);
            RBEntrega.TabIndex = 2;
            RBEntrega.TabStop = true;
            RBEntrega.Text = "Entrega de encomiendas";
            RBEntrega.UseVisualStyleBackColor = true;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaCliente, ColumnaDireccion, ColumnaTipo, ColumnaDimension, columnHeader1 });
            LvGuiasDisponibles.FullRowSelect = true;
            LvGuiasDisponibles.Location = new Point(10, 29);
            LvGuiasDisponibles.Margin = new Padding(3, 4, 3, 4);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(809, 199);
            LvGuiasDisponibles.TabIndex = 5;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // ColumnaNGuia
            // 
            ColumnaNGuia.Text = "Nro Guía";
            ColumnaNGuia.Width = 120;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 120;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.Text = "CUIT";
            ColumnaDireccion.Width = 120;
            // 
            // ColumnaTipo
            // 
            ColumnaTipo.Text = "Localidad";
            ColumnaTipo.Width = 120;
            // 
            // ColumnaDimension
            // 
            ColumnaDimension.Text = "Dirección";
            ColumnaDimension.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dimensión";
            columnHeader1.Width = 120;
            // 
            // LvSeleccion
            // 
            LvSeleccion.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader13, columnHeader7, columnHeader8, columnHeader9 });
            LvSeleccion.FullRowSelect = true;
            LvSeleccion.Location = new Point(10, 299);
            LvSeleccion.Margin = new Padding(3, 4, 3, 4);
            LvSeleccion.Name = "LvSeleccion";
            LvSeleccion.Size = new Size(809, 199);
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
            GrupoGuias.Location = new Point(14, 257);
            GrupoGuias.Margin = new Padding(3, 4, 3, 4);
            GrupoGuias.Name = "GrupoGuias";
            GrupoGuias.Padding = new Padding(3, 4, 3, 4);
            GrupoGuias.Size = new Size(839, 549);
            GrupoGuias.TabIndex = 7;
            GrupoGuias.TabStop = false;
            GrupoGuias.Text = "Guías";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(489, 237);
            BtnAgregarTodos.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(330, 33);
            BtnAgregarTodos.TabIndex = 12;
            BtnAgregarTodos.Text = "Agregar todos";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            BtnAgregarTodos.Click += BtnAgregarTodos_Click_1;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(10, 507);
            BtnQuitar.Margin = new Padding(3, 4, 3, 4);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(809, 31);
            BtnQuitar.TabIndex = 10;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            BtnQuitar.Click += BtnQuitar_Click;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(10, 237);
            BtnAgregarSeleccion.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(330, 33);
            BtnAgregarSeleccion.TabIndex = 7;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            BtnAgregarSeleccion.Click += BtnAgregarSeleccion_Click;
            // 
            // GrupoAsignarFletero
            // 
            GrupoAsignarFletero.Controls.Add(LbFletero);
            GrupoAsignarFletero.Controls.Add(ComboAsignarFletero);
            GrupoAsignarFletero.Location = new Point(14, 815);
            GrupoAsignarFletero.Margin = new Padding(3, 4, 3, 4);
            GrupoAsignarFletero.Name = "GrupoAsignarFletero";
            GrupoAsignarFletero.Padding = new Padding(3, 4, 3, 4);
            GrupoAsignarFletero.Size = new Size(839, 100);
            GrupoAsignarFletero.TabIndex = 8;
            GrupoAsignarFletero.TabStop = false;
            GrupoAsignarFletero.Text = "Asignación de Fletero";
            // 
            // LbFletero
            // 
            LbFletero.AutoSize = true;
            LbFletero.Location = new Point(10, 44);
            LbFletero.Name = "LbFletero";
            LbFletero.Size = new Size(55, 20);
            LbFletero.TabIndex = 5;
            LbFletero.Text = "Fletero";
            // 
            // ComboAsignarFletero
            // 
            ComboAsignarFletero.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboAsignarFletero.FormattingEnabled = true;
            ComboAsignarFletero.Location = new Point(83, 40);
            ComboAsignarFletero.Margin = new Padding(3, 4, 3, 4);
            ComboAsignarFletero.Name = "ComboAsignarFletero";
            ComboAsignarFletero.Size = new Size(726, 28);
            ComboAsignarFletero.TabIndex = 0;
            ComboAsignarFletero.SelectedIndexChanged += ComboAsignarFletero_SelectedIndexChanged;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(674, 923);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 33);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(767, 923);
            BtnConfirmar.Margin = new Padding(3, 4, 3, 4);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(86, 33);
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
            GrupoBusqueda.Location = new Point(14, 155);
            GrupoBusqueda.Margin = new Padding(3, 4, 3, 4);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Padding = new Padding(3, 4, 3, 4);
            GrupoBusqueda.Size = new Size(839, 95);
            GrupoBusqueda.TabIndex = 12;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de Búsqueda";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(728, 36);
            BtnBuscar.Margin = new Padding(3, 4, 3, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(91, 33);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBoxCuit
            // 
            txtBoxCuit.Location = new Point(458, 36);
            txtBoxCuit.Margin = new Padding(3, 4, 3, 4);
            txtBoxCuit.Name = "txtBoxCuit";
            txtBoxCuit.Size = new Size(262, 27);
            txtBoxCuit.TabIndex = 3;
            // 
            // LabelCUIT
            // 
            LabelCUIT.AutoSize = true;
            LabelCUIT.Location = new Point(369, 40);
            LabelCUIT.Name = "LabelCUIT";
            LabelCUIT.Size = new Size(90, 20);
            LabelCUIT.TabIndex = 2;
            LabelCUIT.Text = "CUIT Cliente";
            // 
            // CmbLocalidad
            // 
            CmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbLocalidad.FormattingEnabled = true;
            CmbLocalidad.Location = new Point(83, 36);
            CmbLocalidad.Margin = new Padding(3, 4, 3, 4);
            CmbLocalidad.Name = "CmbLocalidad";
            CmbLocalidad.Size = new Size(262, 28);
            CmbLocalidad.TabIndex = 1;
            // 
            // LbLocalidad
            // 
            LbLocalidad.AutoSize = true;
            LbLocalidad.Location = new Point(10, 40);
            LbLocalidad.Name = "LbLocalidad";
            LbLocalidad.Size = new Size(74, 20);
            LbLocalidad.TabIndex = 0;
            LbLocalidad.Text = "Localidad";
            // 
            // LbRuteoUltimaMilla
            // 
            LbRuteoUltimaMilla.AutoSize = true;
            LbRuteoUltimaMilla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbRuteoUltimaMilla.Location = new Point(17, 13);
            LbRuteoUltimaMilla.Name = "LbRuteoUltimaMilla";
            LbRuteoUltimaMilla.RightToLeft = RightToLeft.No;
            LbRuteoUltimaMilla.Size = new Size(220, 28);
            LbRuteoUltimaMilla.TabIndex = 13;
            LbRuteoUltimaMilla.Text = "Ruteo de Última Milla";
            // 
            // RuteoUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 973);
            Controls.Add(LbRuteoUltimaMilla);
            Controls.Add(GrupoBusqueda);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnCancelar);
            Controls.Add(GrupoAsignarFletero);
            Controls.Add(GrupoTipoRuteo);
            Controls.Add(GrupoGuias);
            Margin = new Padding(3, 4, 3, 4);
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
        private ColumnHeader columnHeader1;
    }
}