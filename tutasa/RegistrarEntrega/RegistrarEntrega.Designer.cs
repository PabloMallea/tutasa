namespace tutasa.RegistrarEntrega
{
    partial class RegistrarEntrega
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
            textBox1 = new TextBox();
            ButtonConfirmar = new Button();
            label5 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            listView1 = new ListView();
            ColumnaFecha = new ColumnHeader();
            ColumnaNComprobante = new ColumnHeader();
            ColumnaConcepto = new ColumnHeader();
            ColumnaMonto = new ColumnHeader();
            ColumnaSaldo = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ButtonConfirmar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 29;
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Location = new Point(424, 23);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(75, 31);
            ButtonConfirmar.TabIndex = 28;
            ButtonConfirmar.Text = "Buscar";
            ButtonConfirmar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 60);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Destinatario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 178);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tabla de Resultados";
            // 
            // button3
            // 
            button3.Location = new Point(362, 130);
            button3.Name = "button3";
            button3.Size = new Size(180, 30);
            button3.TabIndex = 13;
            button3.Text = "Seleccionar Todas";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaFecha, ColumnaNComprobante, ColumnaConcepto, ColumnaMonto, ColumnaSaldo });
            listView1.Location = new Point(18, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(524, 92);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.Text = "Guía";
            ColumnaFecha.Width = 100;
            // 
            // ColumnaNComprobante
            // 
            ColumnaNComprobante.Text = "Destinatario";
            ColumnaNComprobante.Width = 120;
            // 
            // ColumnaConcepto
            // 
            ColumnaConcepto.Text = "Dirección";
            ColumnaConcepto.Width = 100;
            // 
            // ColumnaMonto
            // 
            ColumnaMonto.Text = "Estado";
            ColumnaMonto.Width = 100;
            // 
            // ColumnaSaldo
            // 
            ColumnaSaldo.Text = "Motivo";
            ColumnaSaldo.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(186, 289);
            button1.Name = "button1";
            button1.Size = new Size(180, 45);
            button1.TabIndex = 4;
            button1.Text = "Confirmar Entrega";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(445, 352);
            button2.Name = "button2";
            button2.Size = new Size(123, 36);
            button2.TabIndex = 5;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // RegistrarEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 409);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistrarEntrega";
            Text = "Registrar Entrega de Encomiendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button ButtonConfirmar;
        private Label label5;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private ListView listView1;
        private ColumnHeader ColumnaFecha;
        private ColumnHeader ColumnaNComprobante;
        private ColumnHeader ColumnaConcepto;
        private ColumnHeader ColumnaMonto;
        private ColumnHeader ColumnaSaldo;
        private Button button1;
        private Button button2;
    }
}