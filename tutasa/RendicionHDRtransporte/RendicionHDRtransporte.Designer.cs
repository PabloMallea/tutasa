namespace tutasa.RendicionHDRtransporte
{
    partial class RendicionHDRtransporte
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
            BtnConfirmar = new Button();
            LabelCD = new Label();
            LabelCDOrigen = new Label();
            LabelRendicionHDRT = new Label();
            BtnCancelar = new Button();
            GrupoBusqueda = new GroupBox();
            ComboServicio = new ComboBox();
            LabelServicio = new Label();
            BtnBuscar = new Button();
            ComboEmpresa = new ComboBox();
            LabelEmpresa = new Label();
            ListViewHDRAsignadas = new ListView();
            ColumnaNHDRAsignadas = new ColumnHeader();
            ColumnaEmpresaAsignadas = new ColumnHeader();
            ColumnaEstadoAsignadas = new ColumnHeader();
            ColumnaServicioAsignadas = new ColumnHeader();
            BtnAgregarSeleccion = new Button();
            BtnAgregarTodos = new Button();
            GrupoHDRAsignadas = new GroupBox();
            GrupoHDRRendidas = new GroupBox();
            BtnQuitarTodo = new Button();
            BtnQuitar = new Button();
            ListViewHDRRendidas = new ListView();
            ColumnaNHDRRendidas = new ColumnHeader();
            ColumnaEmpresaRendidas = new ColumnHeader();
            ColumnaEstadoRendidas = new ColumnHeader();
            ColumnaServicioRendidas = new ColumnHeader();
            GrupoBusqueda.SuspendLayout();
            GrupoHDRAsignadas.SuspendLayout();
            GrupoHDRRendidas.SuspendLayout();
            SuspendLayout();
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(527, 703);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(130, 25);
            BtnConfirmar.TabIndex = 20;
            BtnConfirmar.Text = "Confirmar Rendición";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // LabelCD
            // 
            LabelCD.AutoSize = true;
            LabelCD.Location = new Point(150, 40);
            LabelCD.Name = "LabelCD";
            LabelCD.Size = new Size(94, 15);
            LabelCD.TabIndex = 16;
            LabelCD.Text = "CD Buenos Aires";
            // 
            // LabelCDOrigen
            // 
            LabelCDOrigen.AutoSize = true;
            LabelCDOrigen.Location = new Point(15, 40);
            LabelCDOrigen.Name = "LabelCDOrigen";
            LabelCDOrigen.Size = new Size(128, 15);
            LabelCDOrigen.TabIndex = 15;
            LabelCDOrigen.Text = "Centro de distribución:";
            // 
            // LabelRendicionHDRT
            // 
            LabelRendicionHDRT.AutoSize = true;
            LabelRendicionHDRT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRendicionHDRT.Location = new Point(15, 10);
            LabelRendicionHDRT.Name = "LabelRendicionHDRT";
            LabelRendicionHDRT.RightToLeft = RightToLeft.No;
            LabelRendicionHDRT.Size = new Size(210, 21);
            LabelRendicionHDRT.TabIndex = 18;
            LabelRendicionHDRT.Text = "Rendición HDR Transporte";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(446, 703);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.RightToLeft = RightToLeft.No;
            BtnCancelar.Size = new Size(75, 25);
            BtnCancelar.TabIndex = 21;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(ComboServicio);
            GrupoBusqueda.Controls.Add(LabelServicio);
            GrupoBusqueda.Controls.Add(BtnBuscar);
            GrupoBusqueda.Controls.Add(ComboEmpresa);
            GrupoBusqueda.Controls.Add(LabelEmpresa);
            GrupoBusqueda.Location = new Point(12, 70);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(645, 65);
            GrupoBusqueda.TabIndex = 22;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de Búsqueda";
            // 
            // ComboServicio
            // 
            ComboServicio.FormattingEnabled = true;
            ComboServicio.Location = new Point(339, 30);
            ComboServicio.Name = "ComboServicio";
            ComboServicio.Size = new Size(210, 23);
            ComboServicio.TabIndex = 9;
            // 
            // LabelServicio
            // 
            LabelServicio.AutoSize = true;
            LabelServicio.Location = new Point(285, 33);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(48, 15);
            LabelServicio.TabIndex = 8;
            LabelServicio.Text = "Servicio";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(555, 30);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 25);
            BtnBuscar.TabIndex = 7;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // ComboEmpresa
            // 
            ComboEmpresa.FormattingEnabled = true;
            ComboEmpresa.Location = new Point(66, 30);
            ComboEmpresa.Name = "ComboEmpresa";
            ComboEmpresa.Size = new Size(210, 23);
            ComboEmpresa.TabIndex = 6;
            // 
            // LabelEmpresa
            // 
            LabelEmpresa.AutoSize = true;
            LabelEmpresa.Location = new Point(9, 30);
            LabelEmpresa.Name = "LabelEmpresa";
            LabelEmpresa.Size = new Size(48, 15);
            LabelEmpresa.TabIndex = 5;
            LabelEmpresa.Text = "Empesa";
            // 
            // ListViewHDRAsignadas
            // 
            ListViewHDRAsignadas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRAsignadas, ColumnaEmpresaAsignadas, ColumnaEstadoAsignadas, ColumnaServicioAsignadas });
            ListViewHDRAsignadas.Location = new Point(9, 30);
            ListViewHDRAsignadas.Name = "ListViewHDRAsignadas";
            ListViewHDRAsignadas.Size = new Size(620, 200);
            ListViewHDRAsignadas.TabIndex = 4;
            ListViewHDRAsignadas.UseCompatibleStateImageBehavior = false;
            ListViewHDRAsignadas.View = View.Details;
            ListViewHDRAsignadas.SelectedIndexChanged += LvGuiasDisponibles_SelectedIndexChanged;
            // 
            // ColumnaNHDRAsignadas
            // 
            ColumnaNHDRAsignadas.Text = "N° HDR";
            ColumnaNHDRAsignadas.Width = 150;
            // 
            // ColumnaEmpresaAsignadas
            // 
            ColumnaEmpresaAsignadas.Text = "Empresa";
            ColumnaEmpresaAsignadas.Width = 150;
            // 
            // ColumnaEstadoAsignadas
            // 
            ColumnaEstadoAsignadas.Text = "Estado";
            ColumnaEstadoAsignadas.Width = 150;
            // 
            // ColumnaServicioAsignadas
            // 
            ColumnaServicioAsignadas.Text = "Servicio";
            ColumnaServicioAsignadas.Width = 150;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(9, 236);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(280, 25);
            BtnAgregarSeleccion.TabIndex = 6;
            BtnAgregarSeleccion.Text = "Agregar selección";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(349, 236);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(280, 25);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar Todo";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // GrupoHDRAsignadas
            // 
            GrupoHDRAsignadas.Controls.Add(BtnAgregarTodos);
            GrupoHDRAsignadas.Controls.Add(BtnAgregarSeleccion);
            GrupoHDRAsignadas.Controls.Add(ListViewHDRAsignadas);
            GrupoHDRAsignadas.Location = new Point(12, 141);
            GrupoHDRAsignadas.Name = "GrupoHDRAsignadas";
            GrupoHDRAsignadas.Size = new Size(645, 275);
            GrupoHDRAsignadas.TabIndex = 17;
            GrupoHDRAsignadas.TabStop = false;
            GrupoHDRAsignadas.Text = "HDR Asignadas";
            // 
            // GrupoHDRRendidas
            // 
            GrupoHDRRendidas.Controls.Add(BtnQuitarTodo);
            GrupoHDRRendidas.Controls.Add(BtnQuitar);
            GrupoHDRRendidas.Controls.Add(ListViewHDRRendidas);
            GrupoHDRRendidas.Location = new Point(12, 422);
            GrupoHDRRendidas.Name = "GrupoHDRRendidas";
            GrupoHDRRendidas.Size = new Size(645, 275);
            GrupoHDRRendidas.TabIndex = 25;
            GrupoHDRRendidas.TabStop = false;
            GrupoHDRRendidas.Text = "HDR Rendidas";
            // 
            // BtnQuitarTodo
            // 
            BtnQuitarTodo.Location = new Point(349, 236);
            BtnQuitarTodo.Name = "BtnQuitarTodo";
            BtnQuitarTodo.Size = new Size(280, 25);
            BtnQuitarTodo.TabIndex = 13;
            BtnQuitarTodo.Text = "Quitar Todo";
            BtnQuitarTodo.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Location = new Point(9, 236);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(280, 25);
            BtnQuitar.TabIndex = 12;
            BtnQuitar.Text = "Quitar selección";
            BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // ListViewHDRRendidas
            // 
            ListViewHDRRendidas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRRendidas, ColumnaEmpresaRendidas, ColumnaEstadoRendidas, ColumnaServicioRendidas });
            ListViewHDRRendidas.Location = new Point(9, 30);
            ListViewHDRRendidas.Name = "ListViewHDRRendidas";
            ListViewHDRRendidas.Size = new Size(620, 200);
            ListViewHDRRendidas.TabIndex = 8;
            ListViewHDRRendidas.UseCompatibleStateImageBehavior = false;
            ListViewHDRRendidas.View = View.Details;
            // 
            // ColumnaNHDRRendidas
            // 
            ColumnaNHDRRendidas.Text = "N° HDR";
            ColumnaNHDRRendidas.Width = 150;
            // 
            // ColumnaEmpresaRendidas
            // 
            ColumnaEmpresaRendidas.Text = "Empresa";
            ColumnaEmpresaRendidas.Width = 150;
            // 
            // ColumnaEstadoRendidas
            // 
            ColumnaEstadoRendidas.Text = "Estado";
            ColumnaEstadoRendidas.Width = 150;
            // 
            // ColumnaServicioRendidas
            // 
            ColumnaServicioRendidas.Text = "Servicio";
            ColumnaServicioRendidas.Width = 150;
            // 
            // RendicionHDRtransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 742);
            Controls.Add(GrupoHDRRendidas);
            Controls.Add(GrupoBusqueda);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnConfirmar);
            Controls.Add(LabelCD);
            Controls.Add(LabelCDOrigen);
            Controls.Add(LabelRendicionHDRT);
            Controls.Add(GrupoHDRAsignadas);
            Name = "RendicionHDRtransporte";
            Text = "RendicionHDRtransporte";
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            GrupoHDRAsignadas.ResumeLayout(false);
            GrupoHDRRendidas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConfirmar;
        private Label LabelCD;
        private Label LabelCDOrigen;
        private Label LabelRendicionHDRT;
        private Button BtnCancelar;
        private GroupBox GrupoBusqueda;
        private ComboBox ComboServicio;
        private Label LabelServicio;
        private Button BtnBuscar;
        private ComboBox ComboEmpresa;
        private Label LabelEmpresa;
        private ListView ListViewHDRAsignadas;
        private ColumnHeader ColumnaNHDRAsignadas;
        private ColumnHeader ColumnaEmpresaAsignadas;
        private ColumnHeader ColumnaEstadoAsignadas;
        private ColumnHeader ColumnaServicioAsignadas;
        private Button BtnAgregarSeleccion;
        private Button BtnAgregarTodos;
        private GroupBox GrupoHDRAsignadas;
        private GroupBox GrupoHDRRendidas;
        private Button BtnQuitarTodo;
        private Button BtnQuitar;
        private ListView ListViewHDRRendidas;
        private ColumnHeader ColumnaNHDRRendidas;
        private ColumnHeader ColumnaEmpresaRendidas;
        private ColumnHeader ColumnaEstadoRendidas;
        private ColumnHeader ColumnaServicioRendidas;
    }
}