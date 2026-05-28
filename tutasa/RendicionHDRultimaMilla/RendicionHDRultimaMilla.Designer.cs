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
            label_cd.Location = new Point(150, 40);
            label_cd.Name = "label_cd";
            label_cd.Size = new Size(94, 15);
            label_cd.TabIndex = 1;
            label_cd.Text = "CD Buenos Aires";
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
            GrupoHDRAsignadas.Controls.Add(btn_agregar_no_cumplida);
            GrupoHDRAsignadas.Controls.Add(btn_agregar_seleccion);
            GrupoHDRAsignadas.Controls.Add(listview_hdr_asignadas);
            GrupoHDRAsignadas.Location = new Point(12, 141);
            GrupoHDRAsignadas.Name = "GrupoHDRAsignadas";
            GrupoHDRAsignadas.Size = new Size(645, 275);
            GrupoHDRAsignadas.TabIndex = 10;
            GrupoHDRAsignadas.TabStop = false;
            GrupoHDRAsignadas.Text = "HDR Asignadas";
            // 
            // btn_agregar_no_cumplida
            // 
            btn_agregar_no_cumplida.Location = new Point(349, 236);
            btn_agregar_no_cumplida.Name = "btn_agregar_no_cumplida";
            btn_agregar_no_cumplida.Size = new Size(280, 23);
            btn_agregar_no_cumplida.TabIndex = 9;
            btn_agregar_no_cumplida.Text = "Agregar selección No Cumplidas";
            btn_agregar_no_cumplida.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_seleccion
            // 
            btn_agregar_seleccion.Location = new Point(9, 236);
            btn_agregar_seleccion.Name = "btn_agregar_seleccion";
            btn_agregar_seleccion.Size = new Size(280, 23);
            btn_agregar_seleccion.TabIndex = 6;
            btn_agregar_seleccion.Text = "Agregar selección Cumplidas";
            btn_agregar_seleccion.UseVisualStyleBackColor = true;
            // 
            // listview_hdr_asignadas
            // 
            listview_hdr_asignadas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRAsignadas, ColumnaFleteroAsignadas, ColumnaEstadoAsignadas, ColumnaFechaAsignadas, ColumnaTipoAsignadas });
            listview_hdr_asignadas.Location = new Point(9, 30);
            listview_hdr_asignadas.Name = "listview_hdr_asignadas";
            listview_hdr_asignadas.Size = new Size(620, 200);
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
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(299, 21);
            label3.TabIndex = 12;
            label3.Text = "Rendición HDR de Retiro/Distribución";
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(527, 703);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(130, 25);
            btn_confirmar.TabIndex = 14;
            btn_confirmar.Text = "Confirmar Rendición";
            btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(446, 703);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 25);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(cbox_tipo);
            GrupoBusqueda.Controls.Add(LabelServicio);
            GrupoBusqueda.Controls.Add(btn_buscar);
            GrupoBusqueda.Controls.Add(cbox_fletero);
            GrupoBusqueda.Controls.Add(LabelEmpresa);
            GrupoBusqueda.Location = new Point(12, 70);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(645, 65);
            GrupoBusqueda.TabIndex = 23;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de Búsqueda";
            // 
            // cbox_tipo
            // 
            cbox_tipo.FormattingEnabled = true;
            cbox_tipo.Location = new Point(339, 30);
            cbox_tipo.Name = "cbox_tipo";
            cbox_tipo.Size = new Size(210, 23);
            cbox_tipo.TabIndex = 9;
            // 
            // LabelServicio
            // 
            LabelServicio.AutoSize = true;
            LabelServicio.Location = new Point(303, 33);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(31, 15);
            LabelServicio.TabIndex = 8;
            LabelServicio.Text = "Tipo";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(555, 30);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 25);
            btn_buscar.TabIndex = 7;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // cbox_fletero
            // 
            cbox_fletero.FormattingEnabled = true;
            cbox_fletero.Location = new Point(66, 30);
            cbox_fletero.Name = "cbox_fletero";
            cbox_fletero.Size = new Size(210, 23);
            cbox_fletero.TabIndex = 6;
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
            GrupoHDRRendidas.Controls.Add(btn_quitar_todo);
            GrupoHDRRendidas.Controls.Add(btn_quitar_seleccion);
            GrupoHDRRendidas.Controls.Add(listview_hdr_rendidas);
            GrupoHDRRendidas.Location = new Point(12, 422);
            GrupoHDRRendidas.Name = "GrupoHDRRendidas";
            GrupoHDRRendidas.Size = new Size(645, 275);
            GrupoHDRRendidas.TabIndex = 26;
            GrupoHDRRendidas.TabStop = false;
            GrupoHDRRendidas.Text = "HDR Rendidas";
            // 
            // btn_quitar_todo
            // 
            btn_quitar_todo.Location = new Point(349, 236);
            btn_quitar_todo.Name = "btn_quitar_todo";
            btn_quitar_todo.Size = new Size(280, 25);
            btn_quitar_todo.TabIndex = 13;
            btn_quitar_todo.Text = "Quitar Todo";
            btn_quitar_todo.UseVisualStyleBackColor = true;
            // 
            // btn_quitar_seleccion
            // 
            btn_quitar_seleccion.Location = new Point(9, 236);
            btn_quitar_seleccion.Name = "btn_quitar_seleccion";
            btn_quitar_seleccion.Size = new Size(280, 25);
            btn_quitar_seleccion.TabIndex = 12;
            btn_quitar_seleccion.Text = "Quitar selección";
            btn_quitar_seleccion.UseVisualStyleBackColor = true;
            // 
            // listview_hdr_rendidas
            // 
            listview_hdr_rendidas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRRendidas, ColumnaFleteroRendidas, ColumnaEstadoRendidas, ColumnaFechaRendidas, ColumnaTipoRendidas, ColumnaCumplida });
            listview_hdr_rendidas.Location = new Point(9, 30);
            listview_hdr_rendidas.Name = "listview_hdr_rendidas";
            listview_hdr_rendidas.Size = new Size(620, 200);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 742);
            Controls.Add(GrupoHDRRendidas);
            Controls.Add(GrupoBusqueda);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_confirmar);
            Controls.Add(label_cd);
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
    }
}