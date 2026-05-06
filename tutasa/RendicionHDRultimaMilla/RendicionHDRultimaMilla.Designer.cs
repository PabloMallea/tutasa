namespace tutasa.RendicionHDRultimaMilla
{
    partial class RendicionHDRultimaMilla
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
            label2 = new Label();
            LabelCDOrigen = new Label();
            GrupoHDRAsignadas = new GroupBox();
            BtnAgregarTodos = new Button();
            BtnAgregarSeleccion = new Button();
            LvGuiasDisponibles = new ListView();
            ColumnaNHDRAsignadas = new ColumnHeader();
            ColumnaFleteroAsignadas = new ColumnHeader();
            ColumnaEstadoAsignadas = new ColumnHeader();
            ColumnaFechaAsignadas = new ColumnHeader();
            ColumnaTipoAsignadas = new ColumnHeader();
            label3 = new Label();
            button2 = new Button();
            button4 = new Button();
            GrupoBusqueda = new GroupBox();
            ComboServicio = new ComboBox();
            LabelServicio = new Label();
            BtnBuscar = new Button();
            ComboEmpresa = new ComboBox();
            LabelEmpresa = new Label();
            GrupoHDRRendidas = new GroupBox();
            BtnQuitarTodo = new Button();
            button1 = new Button();
            ListViewHDRRendidas = new ListView();
            ColumnaNHDRRendidas = new ColumnHeader();
            ColumnaFleteroRendidas = new ColumnHeader();
            ColumnaEstadoRendidas = new ColumnHeader();
            ColumnaFechaRendidas = new ColumnHeader();
            ColumnaTipoRendidas = new ColumnHeader();
            ColumnaCumplida = new ColumnHeader();
            GrupoHDRAsignadas.SuspendLayout();
            GrupoBusqueda.SuspendLayout();
            GrupoHDRRendidas.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 40);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "CD Buenos Aires";
            // 
            // LabelCDOrigen
            // 
            LabelCDOrigen.AutoSize = true;
            LabelCDOrigen.Location = new Point(15, 40);
            LabelCDOrigen.Name = "LabelCDOrigen";
            LabelCDOrigen.Size = new Size(128, 15);
            LabelCDOrigen.TabIndex = 0;
            LabelCDOrigen.Text = "Centro de distribución:";
            // 
            // GrupoHDRAsignadas
            // 
            GrupoHDRAsignadas.Controls.Add(BtnAgregarTodos);
            GrupoHDRAsignadas.Controls.Add(BtnAgregarSeleccion);
            GrupoHDRAsignadas.Controls.Add(LvGuiasDisponibles);
            GrupoHDRAsignadas.Location = new Point(12, 141);
            GrupoHDRAsignadas.Name = "GrupoHDRAsignadas";
            GrupoHDRAsignadas.Size = new Size(645, 275);
            GrupoHDRAsignadas.TabIndex = 10;
            GrupoHDRAsignadas.TabStop = false;
            GrupoHDRAsignadas.Text = "HDR Asignadas";
            // 
            // BtnAgregarTodos
            // 
            BtnAgregarTodos.Location = new Point(349, 236);
            BtnAgregarTodos.Name = "BtnAgregarTodos";
            BtnAgregarTodos.Size = new Size(280, 23);
            BtnAgregarTodos.TabIndex = 9;
            BtnAgregarTodos.Text = "Agregar selección No Cumplidas";
            BtnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarSeleccion
            // 
            BtnAgregarSeleccion.Location = new Point(9, 236);
            BtnAgregarSeleccion.Name = "BtnAgregarSeleccion";
            BtnAgregarSeleccion.Size = new Size(280, 23);
            BtnAgregarSeleccion.TabIndex = 6;
            BtnAgregarSeleccion.Text = "Agregar selección Cumplidas";
            BtnAgregarSeleccion.UseVisualStyleBackColor = true;
            // 
            // LvGuiasDisponibles
            // 
            LvGuiasDisponibles.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRAsignadas, ColumnaFleteroAsignadas, ColumnaEstadoAsignadas, ColumnaFechaAsignadas, ColumnaTipoAsignadas });
            LvGuiasDisponibles.Location = new Point(9, 30);
            LvGuiasDisponibles.Name = "LvGuiasDisponibles";
            LvGuiasDisponibles.Size = new Size(620, 200);
            LvGuiasDisponibles.TabIndex = 4;
            LvGuiasDisponibles.UseCompatibleStateImageBehavior = false;
            LvGuiasDisponibles.View = View.Details;
            // 
            // ColumnaNHDRAsignadas
            // 
            ColumnaNHDRAsignadas.Text = "N°HDR";
            ColumnaNHDRAsignadas.Width = 100;
            // 
            // ColumnaFleteroAsignadas
            // 
            ColumnaFleteroAsignadas.Text = "Fletero";
            ColumnaFleteroAsignadas.Width = 100;
            // 
            // ColumnaEstadoAsignadas
            // 
            ColumnaEstadoAsignadas.Text = "Estado";
            ColumnaEstadoAsignadas.Width = 100;
            // 
            // ColumnaFechaAsignadas
            // 
            ColumnaFechaAsignadas.Text = "Fecha";
            ColumnaFechaAsignadas.Width = 100;
            // 
            // ColumnaTipoAsignadas
            // 
            ColumnaTipoAsignadas.Text = "Tipo ";
            ColumnaTipoAsignadas.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(299, 21);
            label3.TabIndex = 12;
            label3.Text = "Rendición HDR de Retiro/Distribución";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(527, 703);
            button2.Name = "button2";
            button2.Size = new Size(130, 25);
            button2.TabIndex = 14;
            button2.Text = "Confirmar Rendición";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(446, 703);
            button4.Name = "button4";
            button4.Size = new Size(75, 25);
            button4.TabIndex = 15;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
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
            GrupoBusqueda.TabIndex = 23;
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
            LabelServicio.Location = new Point(303, 33);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(30, 15);
            LabelServicio.TabIndex = 8;
            LabelServicio.Text = "Tipo";
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
            LabelEmpresa.Size = new Size(43, 15);
            LabelEmpresa.TabIndex = 5;
            LabelEmpresa.Text = "Fletero";
            // 
            // GrupoHDRRendidas
            // 
            GrupoHDRRendidas.Controls.Add(BtnQuitarTodo);
            GrupoHDRRendidas.Controls.Add(button1);
            GrupoHDRRendidas.Controls.Add(ListViewHDRRendidas);
            GrupoHDRRendidas.Location = new Point(12, 422);
            GrupoHDRRendidas.Name = "GrupoHDRRendidas";
            GrupoHDRRendidas.Size = new Size(645, 275);
            GrupoHDRRendidas.TabIndex = 26;
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
            // button1
            // 
            button1.Location = new Point(9, 236);
            button1.Name = "button1";
            button1.Size = new Size(280, 25);
            button1.TabIndex = 12;
            button1.Text = "Quitar selección";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListViewHDRRendidas
            // 
            ListViewHDRRendidas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRRendidas, ColumnaFleteroRendidas, ColumnaEstadoRendidas, ColumnaFechaRendidas, ColumnaTipoRendidas, ColumnaCumplida });
            ListViewHDRRendidas.Location = new Point(9, 30);
            ListViewHDRRendidas.Name = "ListViewHDRRendidas";
            ListViewHDRRendidas.Size = new Size(620, 200);
            ListViewHDRRendidas.TabIndex = 8;
            ListViewHDRRendidas.UseCompatibleStateImageBehavior = false;
            ListViewHDRRendidas.View = View.Details;
            // 
            // ColumnaNHDRRendidas
            // 
            ColumnaNHDRRendidas.Text = "N°HDR";
            ColumnaNHDRRendidas.Width = 100;
            // 
            // ColumnaFleteroRendidas
            // 
            ColumnaFleteroRendidas.Text = "Fletero";
            ColumnaFleteroRendidas.Width = 100;
            // 
            // ColumnaEstadoRendidas
            // 
            ColumnaEstadoRendidas.Text = "Estado";
            ColumnaEstadoRendidas.Width = 100;
            // 
            // ColumnaFechaRendidas
            // 
            ColumnaFechaRendidas.Text = "Fecha";
            ColumnaFechaRendidas.Width = 100;
            // 
            // ColumnaTipoRendidas
            // 
            ColumnaTipoRendidas.Text = "Tipo";
            ColumnaTipoRendidas.Width = 100;
            // 
            // ColumnaCumplida
            // 
            ColumnaCumplida.Text = "Cumplida";
            ColumnaCumplida.Width = 100;
            // 
            // RendicionHDRultimaMilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 742);
            Controls.Add(GrupoHDRRendidas);
            Controls.Add(GrupoBusqueda);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(LabelCDOrigen);
            Controls.Add(label3);
            Controls.Add(GrupoHDRAsignadas);
            Name = "RendicionHDRultimaMilla";
            Text = "RendicionHDRultimaMilla";
            Load += RendicionHDRultimaMilla_Load;
            GrupoHDRAsignadas.ResumeLayout(false);
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            GrupoHDRRendidas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label LabelCDOrigen;
        private GroupBox GrupoHDRAsignadas;
        private Button BtnAgregarTodos;
        private Button BtnAgregarSeleccion;
        private ListView LvGuiasDisponibles;
        private ColumnHeader ColumnaFleteroAsignadas;
        private ColumnHeader ColumnaEstadoAsignadas;
        private Label label3;
        private ColumnHeader ColumnaFechaAsignadas;
        private Button button2;
        private ColumnHeader ColumnaNHDRAsignadas;
        private ColumnHeader ColumnaTipoAsignadas;
        private Button button4;
        private GroupBox GrupoBusqueda;
        private ComboBox ComboServicio;
        private Label LabelServicio;
        private Button BtnBuscar;
        private ComboBox ComboEmpresa;
        private Label LabelEmpresa;
        private GroupBox GrupoHDRRendidas;
        private Button BtnQuitarTodo;
        private Button button1;
        private ListView ListViewHDRRendidas;
        private ColumnHeader ColumnaNHDRRendidas;
        private ColumnHeader ColumnaFleteroRendidas;
        private ColumnHeader ColumnaEstadoRendidas;
        private ColumnHeader ColumnaFechaRendidas;
        private ColumnHeader ColumnaTipoRendidas;
        private ColumnHeader ColumnaCumplida;
    }
}