namespace tutasa.EmisionHojasRutaTransporte
{
    partial class EmisionHojasRutaTransporte
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
            BtnImprimirResumen = new Button();
            BtnEmitirHojasRuta = new Button();
            groupBox3 = new GroupBox();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            groupBox2 = new GroupBox();
            BtnDeseleccionar = new Button();
            button1 = new Button();
            LvRutasPendientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            BtnBuscar = new Button();
            LbFechaHasta = new Label();
            LbFechaDesde = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            LbServicio = new Label();
            LbEmpresa = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnImprimirResumen
            // 
            BtnImprimirResumen.Location = new Point(600, 598);
            BtnImprimirResumen.Name = "BtnImprimirResumen";
            BtnImprimirResumen.Size = new Size(150, 23);
            BtnImprimirResumen.TabIndex = 9;
            BtnImprimirResumen.Text = "Imprimir resumen";
            BtnImprimirResumen.UseVisualStyleBackColor = true;
            // 
            // BtnEmitirHojasRuta
            // 
            BtnEmitirHojasRuta.Location = new Point(433, 598);
            BtnEmitirHojasRuta.Name = "BtnEmitirHojasRuta";
            BtnEmitirHojasRuta.Size = new Size(150, 23);
            BtnEmitirHojasRuta.TabIndex = 8;
            BtnEmitirHojasRuta.Text = "Emitir hojas de ruta";
            BtnEmitirHojasRuta.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView1);
            groupBox3.Location = new Point(50, 374);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(700, 193);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de guías";
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.Location = new Point(18, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(664, 132);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nro Guía";
            columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "CD Destino";
            columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cliente";
            columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tipo";
            columnHeader8.Width = 132;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Peso";
            columnHeader9.Width = 132;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDeseleccionar);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(LvRutasPendientes);
            groupBox2.Location = new Point(50, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(700, 220);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hojas de ruta pendientes";
            // 
            // BtnDeseleccionar
            // 
            BtnDeseleccionar.Location = new Point(368, 165);
            BtnDeseleccionar.Name = "BtnDeseleccionar";
            BtnDeseleccionar.Size = new Size(314, 23);
            BtnDeseleccionar.TabIndex = 11;
            BtnDeseleccionar.Text = "Deseleccionar todas";
            BtnDeseleccionar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 165);
            button1.Name = "button1";
            button1.Size = new Size(314, 23);
            button1.TabIndex = 10;
            button1.Text = "Seleccionar todas";
            button1.UseVisualStyleBackColor = true;
            // 
            // LvRutasPendientes
            // 
            LvRutasPendientes.CheckBoxes = true;
            LvRutasPendientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            LvRutasPendientes.Location = new Point(18, 35);
            LvRutasPendientes.Name = "LvRutasPendientes";
            LvRutasPendientes.Size = new Size(664, 132);
            LvRutasPendientes.TabIndex = 0;
            LvRutasPendientes.UseCompatibleStateImageBehavior = false;
            LvRutasPendientes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CD Destino";
            columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Empresa";
            columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Servicio";
            columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cant. Guías";
            columnHeader4.Width = 165;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(LbFechaHasta);
            groupBox1.Controls.Add(LbFechaDesde);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(LbServicio);
            groupBox1.Controls.Add(LbEmpresa);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Location = new Point(50, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 123);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(0, 93);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(700, 23);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LbFechaHasta
            // 
            LbFechaHasta.AutoSize = true;
            LbFechaHasta.Location = new Point(348, 60);
            LbFechaHasta.Name = "LbFechaHasta";
            LbFechaHasta.Size = new Size(69, 15);
            LbFechaHasta.TabIndex = 8;
            LbFechaHasta.Text = "Fecha hasta";
            // 
            // LbFechaDesde
            // 
            LbFechaDesde.AutoSize = true;
            LbFechaDesde.Location = new Point(8, 60);
            LbFechaDesde.Name = "LbFechaDesde";
            LbFechaDesde.Size = new Size(72, 15);
            LbFechaDesde.TabIndex = 7;
            LbFechaDesde.Text = "Fecha desde";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(426, 54);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(256, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(86, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // LbServicio
            // 
            LbServicio.AutoSize = true;
            LbServicio.Location = new Point(348, 25);
            LbServicio.Name = "LbServicio";
            LbServicio.Size = new Size(48, 15);
            LbServicio.TabIndex = 5;
            LbServicio.Text = "Servicio";
            // 
            // LbEmpresa
            // 
            LbEmpresa.AutoSize = true;
            LbEmpresa.Location = new Point(8, 25);
            LbEmpresa.Name = "LbEmpresa";
            LbEmpresa.Size = new Size(52, 15);
            LbEmpresa.TabIndex = 4;
            LbEmpresa.Text = "Empresa";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(426, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(256, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(86, 22);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(256, 23);
            comboBox3.TabIndex = 3;
            // 
            // EmisionHojasRutaTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 651);
            Controls.Add(BtnImprimirResumen);
            Controls.Add(BtnEmitirHojasRuta);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmisionHojasRutaTransporte";
            Text = "Emisión de hojas de ruta de transporte";
            Load += EmisionHojasRutaTransporte_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnImprimirResumen;
        private Button BtnEmitirHojasRuta;
        private GroupBox groupBox3;
        private ListView listView1;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private GroupBox groupBox2;
        private Button BtnDeseleccionar;
        private Button button1;
        private ListView LvRutasPendientes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private Button BtnBuscar;
        private Label LbFechaHasta;
        private Label LbFechaDesde;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label LbServicio;
        private Label LbEmpresa;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}