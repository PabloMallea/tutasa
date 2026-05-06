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
            RBtnRetiro = new RadioButton();
            RBtnEntrega = new RadioButton();
            LvGuiasDisponibles = new ListView();
            ColumnaNGuia = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            ColumnaDireccion = new ColumnHeader();
            ColumnaTipo = new ColumnHeader();
            ColumnaDimension = new ColumnHeader();
            listView1 = new ListView();
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
            ComboAsignarFletero = new ComboBox();
            BtnCancelar = new Button();
            BtnConfirmar = new Button();
            GrupoBusqueda = new GroupBox();
            BtnBuscar = new Button();
            textBox1 = new TextBox();
            LabelCUIT = new Label();
            comboBox2 = new ComboBox();
            LbLocalidad = new Label();
            label3 = new Label();
            GrupoTipoRuteo.SuspendLayout();
            GrupoGuias.SuspendLayout();
            GrupoAsignarFletero.SuspendLayout();
            GrupoBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // GrupoTipoRuteo
            // 
            GrupoTipoRuteo.Controls.Add(RBtnRetiro);
            GrupoTipoRuteo.Controls.Add(RBtnEntrega);
            GrupoTipoRuteo.Location = new Point(12, 40);
            GrupoTipoRuteo.Name = "GrupoTipoRuteo";
            GrupoTipoRuteo.Size = new Size(734, 70);
            GrupoTipoRuteo.TabIndex = 0;
            GrupoTipoRuteo.TabStop = false;
            GrupoTipoRuteo.Text = "Tipo de Ruteo";
            // 
            // RBtnRetiro
            // 
            RBtnRetiro.AutoSize = true;
            RBtnRetiro.Location = new Point(200, 30);
            RBtnRetiro.Name = "RBtnRetiro";
            RBtnRetiro.RightToLeft = RightToLeft.Yes;
            RBtnRetiro.Size = new Size(146, 19);
            RBtnRetiro.TabIndex = 3;
            RBtnRetiro.TabStop = true;
            RBtnRetiro.Text = "Retiro de encomiendas";
            RBtnRetiro.UseVisualStyleBackColor = true;
            RBtnRetiro.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // RBtnEntrega
            // 
            RBtnEntrega.AutoSize = true;
            RBtnEntrega.Location = new Point(9, 30);
            RBtnEntrega.Name = "RBtnEntrega";
            RBtnEntrega.RightToLeft = RightToLeft.Yes;
            RBtnEntrega.Size = new Size(155, 19);
            RBtnEntrega.TabIndex = 2;
            RBtnEntrega.TabStop = true;
            RBtnEntrega.Text = "Entrega de encomiendas";
            RBtnEntrega.UseVisualStyleBackColor = true;
            RBtnEntrega.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { ColumnaNGuia, ColumnaCliente, ColumnaDireccion, ColumnaTipo, ColumnaDimension });
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader13, columnHeader7, columnHeader8, columnHeader9 });
            listView1.Location = new Point(9, 224);
            listView1.Name = "listView1";
            listView1.Size = new Size(708, 150);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            GrupoGuias.Controls.Add(listView1);
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
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(9, 380);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(708, 23);
            BtnQuitar.TabIndex = 10;
            BtnQuitar.Text = "Quitar";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(9, 178);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(289, 25);
            BtnAgregarSeleccion.TabIndex = 7;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // GrupoAsignarFletero
            // 
            GrupoAsignarFletero.Controls.Add(ComboAsignarFletero);
            GrupoAsignarFletero.Location = new Point(12, 611);
            GrupoAsignarFletero.Name = "GrupoAsignarFletero";
            GrupoAsignarFletero.Size = new Size(734, 75);
            GrupoAsignarFletero.TabIndex = 8;
            GrupoAsignarFletero.TabStop = false;
            GrupoAsignarFletero.Text = "Asignación de Fletero";
            // 
            // ComboAsignarFletero
            // 
            ComboAsignarFletero.FormattingEnabled = true;
            ComboAsignarFletero.Location = new Point(9, 30);
            ComboAsignarFletero.Name = "ComboAsignarFletero";
            ComboAsignarFletero.Size = new Size(700, 23);
            ComboAsignarFletero.TabIndex = 0;
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
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(BtnBuscar);
            GrupoBusqueda.Controls.Add(textBox1);
            GrupoBusqueda.Controls.Add(LabelCUIT);
            GrupoBusqueda.Controls.Add(comboBox2);
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 3;
            // 
            // LabelCUIT
            // 
            LabelCUIT.AutoSize = true;
            LabelCUIT.Location = new Point(323, 30);
            LabelCUIT.Name = "LabelCUIT";
            LabelCUIT.Size = new Size(72, 15);
            LabelCUIT.TabIndex = 2;
            LabelCUIT.Text = "CUIT Cliente";
            LabelCUIT.Click += label1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(73, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(230, 23);
            comboBox2.TabIndex = 1;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(177, 21);
            label3.TabIndex = 13;
            label3.Text = "Ruteo de Última Milla";
            // 
            // RuteoUltimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 730);
            Controls.Add(label3);
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
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrupoTipoRuteo;
        private RadioButton RBtnEntrega;
        private RadioButton RBtnRetiro;
        private ListView LvGuiasDisponibles;
        private ColumnHeader ColumnaNGuia;
        private ColumnHeader ColumnaDireccion;
        private ColumnHeader ColumnaTipo;
        private ColumnHeader ColumnaDimension;
        private ListView listView1;
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
        private ComboBox comboBox2;
        private ColumnHeader columnHeader13;
        private Button BtnBuscar;
        private TextBox textBox1;
        private Button BtnAgregarTodos;
        private Label label3;
    }
}