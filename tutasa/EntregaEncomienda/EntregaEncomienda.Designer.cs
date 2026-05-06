namespace tutasa.EntregaEncomienda
{
    partial class EntregaEncomienda
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            ColumnaDestinatario = new ColumnHeader();
            ColumnaDNIDestinatario = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Número de Guía";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 33);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(446, 35);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(106, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaDestinatario, ColumnaDNIDestinatario, ColumnaCliente });
            listView1.Location = new Point(52, 108);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 78);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaDestinatario
            // 
            ColumnaDestinatario.DisplayIndex = 1;
            ColumnaDestinatario.Text = "Destinatario";
            ColumnaDestinatario.Width = 150;
            // 
            // ColumnaDNIDestinatario
            // 
            ColumnaDNIDestinatario.DisplayIndex = 2;
            ColumnaDNIDestinatario.Text = "DNI Destinatario";
            ColumnaDNIDestinatario.Width = 150;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.DisplayIndex = 0;
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Detalle de Guía";
            // 
            // button2
            // 
            button2.Location = new Point(197, 203);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 22);
            button2.TabIndex = 5;
            button2.Text = "Confirmar Entrega";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(446, 203);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(106, 22);
            button3.TabIndex = 6;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // EntregaEncomienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 263);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EntregaEncomienda";
            Text = "EntregaEncomienda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader ColumnaDestinatario;
        private ColumnHeader ColumnaDNIDestinatario;
        private Label label2;
        private Button button2;
        private Button button3;
        private ColumnHeader ColumnaCliente;
    }
}