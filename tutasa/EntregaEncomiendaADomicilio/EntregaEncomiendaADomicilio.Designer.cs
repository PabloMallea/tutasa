namespace tutasa.EntregaEncomiendaADomicilio
{
    partial class EntregaEncomiendaADomicilio
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
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ColumnaGuía = new ColumnHeader();
            ColumnaFletero = new ColumnHeader();
            ColumnaCalle = new ColumnHeader();
            ColumnaAltura = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            ColumnaEntregasFallidas = new ColumnHeader();
            ColumnaMotivo = new ColumnHeader();
            textBox2 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(598, 422);
            button3.Name = "button3";
            button3.Size = new Size(121, 30);
            button3.TabIndex = 13;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(495, 286);
            button2.Name = "button2";
            button2.Size = new Size(194, 30);
            button2.TabIndex = 12;
            button2.Text = "Entrega Realizada";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 11;
            label2.Text = "Detalle de Guía";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaGuía, ColumnaFletero, ColumnaCalle, ColumnaAltura, ColumnaCliente, ColumnaEntregasFallidas, ColumnaMotivo });
            listView1.Location = new Point(63, 142);
            listView1.Name = "listView1";
            listView1.Size = new Size(626, 103);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(568, 39);
            button1.Name = "button1";
            button1.Size = new Size(121, 30);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 27);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 7;
            label1.Text = "Número de Guía";
            // 
            // ColumnaGuía
            // 
            ColumnaGuía.Text = "Guia";
            ColumnaGuía.Width = 80;
            // 
            // ColumnaFletero
            // 
            ColumnaFletero.Text = "Fletero";
            ColumnaFletero.Width = 80;
            // 
            // ColumnaCalle
            // 
            ColumnaCalle.Text = "Calle";
            ColumnaCalle.Width = 80;
            // 
            // ColumnaAltura
            // 
            ColumnaAltura.Text = "Altura";
            ColumnaAltura.Width = 80;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 80;
            // 
            // ColumnaEntregasFallidas
            // 
            ColumnaEntregasFallidas.Text = "Entregas Fallidas";
            ColumnaEntregasFallidas.Width = 140;
            // 
            // ColumnaMotivo
            // 
            ColumnaMotivo.Text = "Motivo";
            ColumnaMotivo.Width = 80;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 354);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 357);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 14;
            label3.Text = "Motivo";
            label3.Click += this.label3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(63, 286);
            button4.Name = "button4";
            button4.Size = new Size(269, 30);
            button4.TabIndex = 16;
            button4.Text = "No fue posible realizar la entrega";
            button4.UseVisualStyleBackColor = true;
            // 
            // EntregaEncomiendaADomicilio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 473);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EntregaEncomiendaADomicilio";
            Text = "EntregaEncomiendaADomicilio";
            Load += EntregaEncomiendaADomicilio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Label label2;
        private ListView listView1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ColumnHeader ColumnaGuía;
        private ColumnHeader ColumnaFletero;
        private ColumnHeader ColumnaCalle;
        private ColumnHeader ColumnaAltura;
        private ColumnHeader ColumnaCliente;
        private ColumnHeader ColumnaEntregasFallidas;
        private ColumnHeader ColumnaMotivo;
        private TextBox textBox2;
        private Label label3;
        private Button button4;
    }
}