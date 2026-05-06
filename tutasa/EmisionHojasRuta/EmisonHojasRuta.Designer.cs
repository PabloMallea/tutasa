namespace tutasa.EmisionHojasRuta
{
    partial class EmisonHojasRuta
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            LbTipo = new Label();
            BtnBuscar = new Button();
            LbFeltero = new Label();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            BtnDeseleccionar = new Button();
            button1 = new Button();
            LvRutasPendientes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            groupBox3 = new GroupBox();
            BtnEmitirHojasRuta = new Button();
            BtnImprimirResumen = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(LbTipo);
            groupBox1.Controls.Add(BtnBuscar);
            groupBox1.Controls.Add(LbFeltero);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(21, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 79);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criterios de búsqueda";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(326, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 11;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.Location = new Point(289, 32);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(31, 15);
            LbTipo.TabIndex = 10;
            LbTipo.Text = "Tipo";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(618, 28);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 23);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // LbFeltero
            // 
            LbFeltero.AutoSize = true;
            LbFeltero.Location = new Point(18, 31);
            LbFeltero.Name = "LbFeltero";
            LbFeltero.Size = new Size(43, 15);
            LbFeltero.TabIndex = 5;
            LbFeltero.Text = "Fletero";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(67, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDeseleccionar);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(LvRutasPendientes);
            groupBox2.Location = new Point(21, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(735, 241);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hojas de ruta pendientes";
            // 
            // BtnDeseleccionar
            // 
            BtnDeseleccionar.Location = new Point(404, 200);
            BtnDeseleccionar.Name = "BtnDeseleccionar";
            BtnDeseleccionar.Size = new Size(314, 23);
            BtnDeseleccionar.TabIndex = 11;
            BtnDeseleccionar.Text = "Deseleccionar todas";
            BtnDeseleccionar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 200);
            button1.Name = "button1";
            button1.Size = new Size(314, 23);
            button1.TabIndex = 10;
            button1.Text = "Seleccionar todas";
            button1.UseVisualStyleBackColor = true;
            // 
            // LvRutasPendientes
            // 
            LvRutasPendientes.CheckBoxes = true;
            LvRutasPendientes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader10 });
            LvRutasPendientes.Location = new Point(18, 35);
            LvRutasPendientes.Name = "LvRutasPendientes";
            LvRutasPendientes.Size = new Size(700, 150);
            LvRutasPendientes.TabIndex = 0;
            LvRutasPendientes.UseCompatibleStateImageBehavior = false;
            LvRutasPendientes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 1;
            columnHeader1.Text = "Tipo";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Fletero";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 3;
            columnHeader3.Text = "Dirección";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 4;
            columnHeader4.Text = "Cant. Guías";
            columnHeader4.Width = 140;
            // 
            // columnHeader10
            // 
            columnHeader10.DisplayIndex = 0;
            columnHeader10.Text = "N°HDR";
            columnHeader10.Width = 140;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.Location = new Point(18, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 150);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nro Guía";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 2;
            columnHeader6.Text = "Dirección";
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.DisplayIndex = 1;
            columnHeader7.Text = "Cliente";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tipo";
            columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Dimensión";
            columnHeader9.Width = 140;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView1);
            groupBox3.Location = new Point(21, 397);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(735, 190);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de guías";
            // 
            // BtnEmitirHojasRuta
            // 
            BtnEmitirHojasRuta.Location = new Point(439, 608);
            BtnEmitirHojasRuta.Name = "BtnEmitirHojasRuta";
            BtnEmitirHojasRuta.Size = new Size(150, 23);
            BtnEmitirHojasRuta.TabIndex = 3;
            BtnEmitirHojasRuta.Text = "Emitir hojas de ruta";
            BtnEmitirHojasRuta.UseVisualStyleBackColor = true;
            // 
            // BtnImprimirResumen
            // 
            BtnImprimirResumen.Location = new Point(606, 608);
            BtnImprimirResumen.Name = "BtnImprimirResumen";
            BtnImprimirResumen.Size = new Size(150, 23);
            BtnImprimirResumen.TabIndex = 4;
            BtnImprimirResumen.Text = "Imprimir resumen";
            BtnImprimirResumen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(206, 21);
            label1.TabIndex = 5;
            label1.Text = "Emisión HDR ultima milla";
            // 
            // EmisonHojasRuta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 657);
            Controls.Add(label1);
            Controls.Add(BtnImprimirResumen);
            Controls.Add(BtnEmitirHojasRuta);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmisonHojasRuta";
            Text = "Emisión de hojas de ruta de última milla";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label LbFeltero;
        private ComboBox comboBox2;
        private Button BtnBuscar;
        private GroupBox groupBox2;
        private ListView LvRutasPendientes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView1;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button BtnDeseleccionar;
        private Button button1;
        private GroupBox groupBox3;
        private Button BtnEmitirHojasRuta;
        private Button BtnImprimirResumen;
        private ComboBox comboBox1;
        private Label LbTipo;
        private Label label1;
        private ColumnHeader columnHeader10;
    }
}