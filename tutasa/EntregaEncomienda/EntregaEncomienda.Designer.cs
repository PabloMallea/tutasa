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
            TextNGuia = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            GrupoDetalleGuia = new GroupBox();
            listView1 = new ListView();
            ColumnaCliente = new ColumnHeader();
            ColumnaDestinatario = new ColumnHeader();
            ColumnaDNIDestinatario = new ColumnHeader();
            GrupoDetalleGuia.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "N° Guía";
            // 
            // TextNGuia
            // 
            TextNGuia.Location = new Point(69, 37);
            TextNGuia.Margin = new Padding(3, 2, 3, 2);
            TextNGuia.Name = "TextNGuia";
            TextNGuia.Size = new Size(205, 23);
            TextNGuia.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(280, 35);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(375, 278);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(124, 25);
            button2.TabIndex = 5;
            button2.Text = "Confirmar Entrega";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(294, 278);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 6;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 10);
            label7.Name = "label7";
            label7.Size = new Size(191, 21);
            label7.TabIndex = 37;
            label7.Text = "Entrega de Encomienda";
            // 
            // GrupoDetalleGuia
            // 
            GrupoDetalleGuia.Controls.Add(listView1);
            GrupoDetalleGuia.Location = new Point(15, 65);
            GrupoDetalleGuia.Name = "GrupoDetalleGuia";
            GrupoDetalleGuia.Size = new Size(484, 208);
            GrupoDetalleGuia.TabIndex = 38;
            GrupoDetalleGuia.TabStop = false;
            GrupoDetalleGuia.Text = "Detalle de Guía";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaCliente, ColumnaDestinatario, ColumnaDNIDestinatario });
            listView1.Location = new Point(6, 21);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 171);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Cliente";
            ColumnaCliente.Width = 150;
            // 
            // ColumnaDestinatario
            // 
            ColumnaDestinatario.Text = "Destinatario";
            ColumnaDestinatario.Width = 150;
            // 
            // ColumnaDNIDestinatario
            // 
            ColumnaDNIDestinatario.Text = "DNI Destinatario";
            ColumnaDNIDestinatario.Width = 150;
            // 
            // EntregaEncomienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 312);
            Controls.Add(GrupoDetalleGuia);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TextNGuia);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EntregaEncomienda";
            Text = "EntregaEncomienda";
            GrupoDetalleGuia.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextNGuia;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private GroupBox GrupoDetalleGuia;
        private ListView listView1;
        private ColumnHeader ColumnaCliente;
        private ColumnHeader ColumnaDestinatario;
        private ColumnHeader ColumnaDNIDestinatario;
    }
}