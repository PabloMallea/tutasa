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
            btn_confirmar = new Button();
            label_cd = new Label();
            LabelCDOrigen = new Label();
            LabelRendicionHDRT = new Label();
            btn_cancelar = new Button();
            GrupoBusqueda = new GroupBox();
            btn_limpiar_campos = new Button();
            cbox_servicio = new ComboBox();
            LabelServicio = new Label();
            btn_buscar = new Button();
            cbox_empresa = new ComboBox();
            LabelEmpresa = new Label();
            listview_hdr_emitidas = new ListView();
            ColumnaNHDRAsignadas = new ColumnHeader();
            ColumnaEmpresaAsignadas = new ColumnHeader();
            ColumnaEstadoAsignadas = new ColumnHeader();
            ColumnaServicioAsignadas = new ColumnHeader();
            btn_agregar_seleccion = new Button();
            btn_agregar_todo = new Button();
            GrupoHDREmitidas = new GroupBox();
            GrupoHDRRendidas = new GroupBox();
            btn_quitar_todo = new Button();
            btn_quitar_seleccion = new Button();
            listview_hdr_rendidas = new ListView();
            ColumnaNHDRRendidas = new ColumnHeader();
            ColumnaEmpresaRendidas = new ColumnHeader();
            ColumnaEstadoRendidas = new ColumnHeader();
            ColumnaServicioRendidas = new ColumnHeader();
            GrupoBusqueda.SuspendLayout();
            GrupoHDREmitidas.SuspendLayout();
            GrupoHDRRendidas.SuspendLayout();
            SuspendLayout();
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(586, 705);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(130, 25);
            btn_confirmar.TabIndex = 20;
            btn_confirmar.Text = "Confirmar Rendición";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // label_cd
            // 
            label_cd.AutoSize = true;
            label_cd.Location = new Point(150, 40);
            label_cd.Name = "label_cd";
            label_cd.Size = new Size(94, 15);
            label_cd.TabIndex = 16;
            label_cd.Text = "CD Buenos Aires";
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
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(505, 705);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.RightToLeft = RightToLeft.No;
            btn_cancelar.Size = new Size(75, 25);
            btn_cancelar.TabIndex = 21;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // GrupoBusqueda
            // 
            GrupoBusqueda.Controls.Add(btn_limpiar_campos);
            GrupoBusqueda.Controls.Add(cbox_servicio);
            GrupoBusqueda.Controls.Add(LabelServicio);
            GrupoBusqueda.Controls.Add(btn_buscar);
            GrupoBusqueda.Controls.Add(cbox_empresa);
            GrupoBusqueda.Controls.Add(LabelEmpresa);
            GrupoBusqueda.Location = new Point(12, 70);
            GrupoBusqueda.Name = "GrupoBusqueda";
            GrupoBusqueda.Size = new Size(710, 65);
            GrupoBusqueda.TabIndex = 22;
            GrupoBusqueda.TabStop = false;
            GrupoBusqueda.Text = "Criterios de Búsqueda";
            // 
            // btn_limpiar_campos
            // 
            btn_limpiar_campos.Location = new Point(586, 28);
            btn_limpiar_campos.Name = "btn_limpiar_campos";
            btn_limpiar_campos.Size = new Size(118, 25);
            btn_limpiar_campos.TabIndex = 10;
            btn_limpiar_campos.Text = "Limpiar Campos";
            btn_limpiar_campos.UseVisualStyleBackColor = true;
            btn_limpiar_campos.Click += btn_limpiar_campos_Click;
            // 
            // cbox_servicio
            // 
            cbox_servicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_servicio.FormattingEnabled = true;
            cbox_servicio.Location = new Point(276, 30);
            cbox_servicio.Name = "cbox_servicio";
            cbox_servicio.Size = new Size(200, 23);
            cbox_servicio.TabIndex = 9;
            // 
            // LabelServicio
            // 
            LabelServicio.AutoSize = true;
            LabelServicio.Location = new Point(222, 33);
            LabelServicio.Name = "LabelServicio";
            LabelServicio.Size = new Size(48, 15);
            LabelServicio.TabIndex = 8;
            LabelServicio.Text = "Servicio";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(505, 28);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 25);
            btn_buscar.TabIndex = 7;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // cbox_empresa
            // 
            cbox_empresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_empresa.FormattingEnabled = true;
            cbox_empresa.Location = new Point(66, 30);
            cbox_empresa.Name = "cbox_empresa";
            cbox_empresa.Size = new Size(150, 23);
            cbox_empresa.TabIndex = 6;
            cbox_empresa.SelectedIndexChanged += cbox_empresa_SelectedIndexChanged;
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
            // listview_hdr_emitidas
            // 
            listview_hdr_emitidas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRAsignadas, ColumnaEmpresaAsignadas, ColumnaEstadoAsignadas, ColumnaServicioAsignadas });
            listview_hdr_emitidas.Location = new Point(9, 30);
            listview_hdr_emitidas.Name = "listview_hdr_emitidas";
            listview_hdr_emitidas.Size = new Size(695, 200);
            listview_hdr_emitidas.TabIndex = 4;
            listview_hdr_emitidas.UseCompatibleStateImageBehavior = false;
            listview_hdr_emitidas.View = View.Details;
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
            ColumnaServicioAsignadas.Width = 200;
            // 
            // btn_agregar_seleccion
            // 
            btn_agregar_seleccion.Location = new Point(9, 236);
            btn_agregar_seleccion.Name = "btn_agregar_seleccion";
            btn_agregar_seleccion.Size = new Size(280, 25);
            btn_agregar_seleccion.TabIndex = 6;
            btn_agregar_seleccion.Text = "Agregar Selección";
            btn_agregar_seleccion.UseVisualStyleBackColor = true;
            btn_agregar_seleccion.Click += btn_agregar_seleccion_Click;
            // 
            // btn_agregar_todo
            // 
            btn_agregar_todo.Location = new Point(424, 236);
            btn_agregar_todo.Name = "btn_agregar_todo";
            btn_agregar_todo.Size = new Size(280, 25);
            btn_agregar_todo.TabIndex = 9;
            btn_agregar_todo.Text = "Agregar Todo";
            btn_agregar_todo.UseVisualStyleBackColor = true;
            btn_agregar_todo.Click += btn_agregar_todo_Click;
            // 
            // GrupoHDREmitidas
            // 
            GrupoHDREmitidas.Controls.Add(btn_agregar_todo);
            GrupoHDREmitidas.Controls.Add(btn_agregar_seleccion);
            GrupoHDREmitidas.Controls.Add(listview_hdr_emitidas);
            GrupoHDREmitidas.Location = new Point(12, 141);
            GrupoHDREmitidas.Name = "GrupoHDREmitidas";
            GrupoHDREmitidas.Size = new Size(710, 275);
            GrupoHDREmitidas.TabIndex = 17;
            GrupoHDREmitidas.TabStop = false;
            GrupoHDREmitidas.Text = "HDR Emitidas";
            // 
            // GrupoHDRRendidas
            // 
            GrupoHDRRendidas.Controls.Add(btn_quitar_todo);
            GrupoHDRRendidas.Controls.Add(btn_quitar_seleccion);
            GrupoHDRRendidas.Controls.Add(listview_hdr_rendidas);
            GrupoHDRRendidas.Location = new Point(12, 422);
            GrupoHDRRendidas.Name = "GrupoHDRRendidas";
            GrupoHDRRendidas.Size = new Size(710, 275);
            GrupoHDRRendidas.TabIndex = 25;
            GrupoHDRRendidas.TabStop = false;
            GrupoHDRRendidas.Text = "HDR Rendidas";
            // 
            // btn_quitar_todo
            // 
            btn_quitar_todo.Location = new Point(424, 236);
            btn_quitar_todo.Name = "btn_quitar_todo";
            btn_quitar_todo.Size = new Size(280, 25);
            btn_quitar_todo.TabIndex = 13;
            btn_quitar_todo.Text = "Quitar Todo";
            btn_quitar_todo.UseVisualStyleBackColor = true;
            btn_quitar_todo.Click += btn_quitar_todo_Click;
            // 
            // btn_quitar_seleccion
            // 
            btn_quitar_seleccion.Location = new Point(9, 236);
            btn_quitar_seleccion.Name = "btn_quitar_seleccion";
            btn_quitar_seleccion.Size = new Size(280, 25);
            btn_quitar_seleccion.TabIndex = 12;
            btn_quitar_seleccion.Text = "Quitar Selección";
            btn_quitar_seleccion.UseVisualStyleBackColor = true;
            btn_quitar_seleccion.Click += btn_quitar_seleccion_Click;
            // 
            // listview_hdr_rendidas
            // 
            listview_hdr_rendidas.Columns.AddRange(new ColumnHeader[] { ColumnaNHDRRendidas, ColumnaEmpresaRendidas, ColumnaEstadoRendidas, ColumnaServicioRendidas });
            listview_hdr_rendidas.Location = new Point(9, 30);
            listview_hdr_rendidas.Name = "listview_hdr_rendidas";
            listview_hdr_rendidas.Size = new Size(695, 200);
            listview_hdr_rendidas.TabIndex = 8;
            listview_hdr_rendidas.UseCompatibleStateImageBehavior = false;
            listview_hdr_rendidas.View = View.Details;
            // 
            // ColumnaNHDRRendidas
            // 
            ColumnaNHDRRendidas.Text = "N° HDR";
            ColumnaNHDRRendidas.Width = 200;
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
            ClientSize = new Size(734, 742);
            Controls.Add(GrupoHDRRendidas);
            Controls.Add(GrupoBusqueda);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_confirmar);
            Controls.Add(label_cd);
            Controls.Add(LabelCDOrigen);
            Controls.Add(LabelRendicionHDRT);
            Controls.Add(GrupoHDREmitidas);
            Name = "RendicionHDRtransporte";
            Text = "RendicionHDRtransporte";
            Load += RendicionHDRtransporte_Load;
            GrupoBusqueda.ResumeLayout(false);
            GrupoBusqueda.PerformLayout();
            GrupoHDREmitidas.ResumeLayout(false);
            GrupoHDRRendidas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirmar;
        private Label label_cd;
        private Label LabelCDOrigen;
        private Label LabelRendicionHDRT;
        private Button btn_cancelar;
        private GroupBox GrupoBusqueda;
        private ComboBox cbox_servicio;
        private Label LabelServicio;
        private Button btn_buscar;
        private ComboBox cbox_empresa;
        private Label LabelEmpresa;
        private ListView listview_hdr_emitidas;
        private ColumnHeader ColumnaNHDRAsignadas;
        private ColumnHeader ColumnaEmpresaAsignadas;
        private ColumnHeader ColumnaEstadoAsignadas;
        private ColumnHeader ColumnaServicioAsignadas;
        private Button btn_agregar_seleccion;
        private Button btn_agregar_todo;
        private GroupBox GrupoHDREmitidas;
        private GroupBox GrupoHDRRendidas;
        private Button btn_quitar_todo;
        private Button btn_quitar_seleccion;
        private ListView listview_hdr_rendidas;
        private ColumnHeader ColumnaNHDRRendidas;
        private ColumnHeader ColumnaEmpresaRendidas;
        private ColumnHeader ColumnaEstadoRendidas;
        private ColumnHeader ColumnaServicioRendidas;
        private Button btn_limpiar_campos;
    }
}