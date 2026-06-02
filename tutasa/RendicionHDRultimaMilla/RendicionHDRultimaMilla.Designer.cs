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
            label_cd = new Label();
            LabelCDOrigen = new Label();
            GrupoHDRAsignadas = new GroupBox();
            btn_agregar_no_cumplida = new Button();
            btn_agregar_seleccion = new Button();
            listview_hdr_asignadas = new ListView();
            ColumnaNHDRAsignadas = new ColumnHeader();
            ColumnaFleteroAsignadas = new ColumnHeader();
            ColumnaEstadoAsignadas = new ColumnHeader();
            ColumnaFechaAsignadas = new ColumnHeader();
            ColumnaTipoAsignadas = new ColumnHeader();
            label3 = new Label();
            btn_confirmar = new Button();
            btn_cancelar = new Button();
            GrupoBusqueda = new GroupBox();
            btn_limpiar_campos = new Button();
            cbox_tipo = new ComboBox();
            LabelServicio = new Label();
            btn_buscar = new Button();
            cbox_fletero = new ComboBox();
            LabelEmpresa = new Label();
            GrupoHDRRendidas = new GroupBox();
            btn_quitar_todo = new Button();
            btn_quitar_seleccion = new Button();
            listview_hdr_rendidas = new ListView();
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
            // label_cd
            // 
            label_cd.AutoSize = true;
            label_cd.Location = new Point(171, 53);
            label_cd.Name = "label_cd";
            label_cd.Size = new Size(118, 20);
            label_cd.TabIndex = 1;
            label_cd.Text = "CD Buenos Aires";
            // 
            // LabelCDOrigen
            // 
            LabelCDOrigen.AutoSize = true;
            LabelCDOrigen.Location = new Point(17, 53);
            LabelCDOrigen.Name = "LabelCDOrigen";
            LabelCDOrigen.Size = new Size(159, 20);
            LabelCDOrigen.TabIndex = 0;
            LabelCDOrigen.Text = "Centro de distribución:";
            // 
            // GrupoHDRAsignadas
            // 
            GrupoHDRAsignadas.Controls.Add(btn_agregar_no_cumplida);
            GrupoHDRAsignadas.Controls.Add(btn_agregar_seleccion);
            GrupoHDRAsignadas.Controls.Add(listview_hdr_asignadas);
            GrupoHDRAsignadas.Location = new Point(14, 188);
            GrupoHDRAsignadas.Margin = new Padding(3, 4, 3, 4);
            GrupoHDRAsignadas.Name = "GrupoHDRAsignadas";
            GrupoHDRAsignadas.Padding = new Padding(3, 4, 3, 4);
            GrupoHDRAsignadas.Size = new Size(777, 367);
            GrupoHDRAsignadas.TabIndex = 10;
            GrupoHDRAsignadas.TabStop = false;
            GrupoHDRAsignadas.Text = "HDR Asignadas";
            // 
            // btn_agregar_no_cumplida
            // 
            btn_agregar_no_cumplida.Location = new Point(450, 315);
            btn_agregar_no_cumplida.Margin = new Padding(3, 4, 3, 4);
            btn_agregar_no_cumplida.Name = "btn_agregar_no_cumplida";
            btn_agregar_no_cumplida.Size = new Size(320, 31);
            btn_agregar_no_cumplida.TabIndex = 9;
            btn_agregar_no_cumplida.Text = "Agregar selección No Cumplidas";
            btn_agregar_no_cumplida.UseVisualStyleBackColor = true;
            btn_agregar_no_cumplida.Click += btn_agregar_no_cumplida_Click;
            // 
            // btn_agregar_seleccion
            // 
            btn_agregar_seleccion.Location = new Point(10, 315);
            btn_agregar_seleccion.Margin = new Padding(3, 4, 3, 4);
            btn_agregar_seleccion.Name = "btn_agregar_seleccion";
            btn_agregar_seleccion.Size = new Size(320, 31);
            btn_agregar_seleccion.TabIndex = 6;
            btn_agregar_seleccion.Text = "Agregar selección Cumplidas";
            btn_agregar_seleccion.UseVisualStyleBackColor = true;
            btn_agregar_seleccion.Click += btn_agregar_seleccion_Click;
            // 
            // listview_hdr_asignadas
            // 
            listview_hdr_asignadas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRAsignadas, ColumnaFleteroAsignadas, ColumnaEstadoAsignadas, ColumnaFechaAsignadas, ColumnaTipoAsignadas });
            listview_hdr_asignadas.Location = new Point(10, 40);
            listview_hdr_asignadas.Margin = new Padding(3, 4, 3, 4);
            listview_hdr_asignadas.Name = "listview_hdr_asignadas";
            listview_hdr_asignadas.Size = new Size(759, 265);
            listview_hdr_asignadas.TabIndex = 4;
            listview_hdr_asignadas.UseCompatibleStateImageBehavior = false;
            listview_hdr_asignadas.View = View.Details;
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
            label3.Location = new Point(17, 13);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(373, 28);
            label3.TabIndex = 12;
            label3.Text = "Rendición HDR de Retiro/Distribución";
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(635, 937);
            btn_confirmar.Margin = new Padding(3, 4, 3, 4);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(149, 33);
            btn_confirmar.TabIndex = 14;
            btn_confirmar.Text = "Confirmar Rendición";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(543, 940);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(86, 33);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(btn_limpiar_campos);
            GrupoBusqueda.Controls.Add(cbox_tipo);
            GrupoBusqueda.Controls.Add(LabelServicio);
            GrupoBusqueda.Controls.Add(btn_buscar);
            GrupoBusqueda.Controls.Add(cbox_fletero);
            GrupoBusqueda.Controls.Add(LabelEmpresa);
            GrupoBusqueda.Location = new Point(14, 93);
            GrupoBusqueda.Margin = new Padding(3, 4, 3, 4);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Padding = new Padding(3, 4, 3, 4);
            GrupoBusqueda.Size = new Size(777, 87);
            GrupoBusqueda.TabIndex = 23;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de Búsqueda";
            // 
            // btn_limpiar_campos
            // 
            btn_limpiar_campos.Location = new Point(648, 37);
            btn_limpiar_campos.Margin = new Padding(3, 4, 3, 4);
            btn_limpiar_campos.Name = "btn_limpiar_campos";
            btn_limpiar_campos.Size = new Size(122, 33);
            btn_limpiar_campos.TabIndex = 27;
            btn_limpiar_campos.Text = "Limpiar Campos";
            btn_limpiar_campos.UseVisualStyleBackColor = true;
            btn_limpiar_campos.Click += btn_limpiar_campos_Click;
            // 
            // cbox_tipo
            // 
            cbox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_tipo.FormattingEnabled = true;
            cbox_tipo.Location = new Point(363, 40);
            cbox_tipo.Margin = new Padding(3, 4, 3, 4);
            cbox_tipo.Name = "cbox_tipo";
            cbox_tipo.Size = new Size(161, 28);
            cbox_tipo.TabIndex = 9;
            // 
            // LabelServicio
            // 
            LabelServicio.AutoSize = true;
            LabelServicio.Location = new Point(322, 44);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(39, 20);
            LabelServicio.TabIndex = 8;
            LabelServicio.Text = "Tipo";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(555, 37);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(86, 33);
            btn_buscar.TabIndex = 7;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // cbox_fletero
            // 
            cbox_fletero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_fletero.FormattingEnabled = true;
            cbox_fletero.Location = new Point(75, 40);
            cbox_fletero.Margin = new Padding(3, 4, 3, 4);
            cbox_fletero.Name = "cbox_fletero";
            cbox_fletero.Size = new Size(239, 28);
            cbox_fletero.TabIndex = 6;
            // 
            // LabelEmpresa
            // 
            LabelEmpresa.AutoSize = true;
            LabelEmpresa.Location = new Point(10, 40);
            LabelEmpresa.Name = "LabelEmpresa";
            LabelEmpresa.Size = new Size(55, 20);
            LabelEmpresa.TabIndex = 5;
            LabelEmpresa.Text = "Fletero";
            // 
            // GrupoHDRRendidas
            // 
            GrupoHDRRendidas.Controls.Add(btn_quitar_todo);
            GrupoHDRRendidas.Controls.Add(btn_quitar_seleccion);
            GrupoHDRRendidas.Controls.Add(listview_hdr_rendidas);
            GrupoHDRRendidas.Location = new Point(14, 563);
            GrupoHDRRendidas.Margin = new Padding(3, 4, 3, 4);
            GrupoHDRRendidas.Name = "GrupoHDRRendidas";
            GrupoHDRRendidas.Padding = new Padding(3, 4, 3, 4);
            GrupoHDRRendidas.Size = new Size(777, 367);
            GrupoHDRRendidas.TabIndex = 26;
            GrupoHDRRendidas.TabStop = false;
            GrupoHDRRendidas.Text = "HDR Rendidas";
            // 
            // btn_quitar_todo
            // 
            btn_quitar_todo.Location = new Point(450, 315);
            btn_quitar_todo.Margin = new Padding(3, 4, 3, 4);
            btn_quitar_todo.Name = "btn_quitar_todo";
            btn_quitar_todo.Size = new Size(320, 33);
            btn_quitar_todo.TabIndex = 13;
            btn_quitar_todo.Text = "Quitar Todo";
            btn_quitar_todo.UseVisualStyleBackColor = true;
            btn_quitar_todo.Click += btn_quitar_todo_Click;
            // 
            // btn_quitar_seleccion
            // 
            btn_quitar_seleccion.Location = new Point(10, 315);
            btn_quitar_seleccion.Margin = new Padding(3, 4, 3, 4);
            btn_quitar_seleccion.Name = "btn_quitar_seleccion";
            btn_quitar_seleccion.Size = new Size(320, 33);
            btn_quitar_seleccion.TabIndex = 12;
            btn_quitar_seleccion.Text = "Quitar selección";
            btn_quitar_seleccion.UseVisualStyleBackColor = true;
            btn_quitar_seleccion.Click += btn_quitar_seleccion_Click;
            // 
            // listview_hdr_rendidas
            // 
            listview_hdr_rendidas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRRendidas, ColumnaFleteroRendidas, ColumnaEstadoRendidas, ColumnaFechaRendidas, ColumnaTipoRendidas, ColumnaCumplida });
            listview_hdr_rendidas.Location = new Point(10, 40);
            listview_hdr_rendidas.Margin = new Padding(3, 4, 3, 4);
            listview_hdr_rendidas.Name = "listview_hdr_rendidas";
            listview_hdr_rendidas.Size = new Size(759, 265);
            listview_hdr_rendidas.TabIndex = 8;
            listview_hdr_rendidas.UseCompatibleStateImageBehavior = false;
            listview_hdr_rendidas.View = View.Details;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 989);
            Controls.Add(GrupoHDRRendidas);
            Controls.Add(GrupoBusqueda);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_confirmar);
            Controls.Add(label_cd);
            Controls.Add(LabelCDOrigen);
            Controls.Add(label3);
            Controls.Add(GrupoHDRAsignadas);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label_cd;
        private Label LabelCDOrigen;
        private GroupBox GrupoHDRAsignadas;
        private Button btn_agregar_no_cumplida;
        private Button btn_agregar_seleccion;
        private ListView listview_hdr_asignadas;
        private ColumnHeader ColumnaFleteroAsignadas;
        private ColumnHeader ColumnaEstadoAsignadas;
        private Label label3;
        private ColumnHeader ColumnaFechaAsignadas;
        private Button btn_confirmar;
        private ColumnHeader ColumnaNHDRAsignadas;
        private ColumnHeader ColumnaTipoAsignadas;
        private Button btn_cancelar;
        private GroupBox GrupoBusqueda;
        private ComboBox cbox_tipo;
        private Label LabelServicio;
        private Button btn_buscar;
        private ComboBox cbox_fletero;
        private Label LabelEmpresa;
        private GroupBox GrupoHDRRendidas;
        private Button btn_quitar_todo;
        private Button btn_quitar_seleccion;
        private ListView listview_hdr_rendidas;
        private ColumnHeader ColumnaNHDRRendidas;
        private ColumnHeader ColumnaFleteroRendidas;
        private ColumnHeader ColumnaEstadoRendidas;
        private ColumnHeader ColumnaFechaRendidas;
        private ColumnHeader ColumnaTipoRendidas;
        private ColumnHeader ColumnaCumplida;
        private Button btn_limpiar_campos;
    }
}