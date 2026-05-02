namespace tutasa.ConsultaEstadoInterna
{
    partial class ConsultaEstadoInterna
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            fechaActualización = new ColumnHeader();
            estado = new ColumnHeader();
            ubicación = new ColumnHeader();
            personaResponsable = new ColumnHeader();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 1;
            label1.Text = "Estado de Encomienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 51);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "N°Guía";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(367, 48);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { fechaActualización, estado, ubicación, personaResponsable });
            listView1.Location = new Point(104, 250);
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 264);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // fechaActualización
            // 
            fechaActualización.Text = "Fecha y Hora";
            fechaActualización.Width = 150;
            // 
            // estado
            // 
            estado.Text = "Estado";
            estado.TextAlign = HorizontalAlignment.Center;
            estado.Width = 150;
            // 
            // ubicación
            // 
            ubicación.Text = "Ubicación";
            ubicación.TextAlign = HorizontalAlignment.Center;
            ubicación.Width = 150;
            // 
            // personaResponsable
            // 
            personaResponsable.Text = "Responsable";
            personaResponsable.TextAlign = HorizontalAlignment.Center;
            personaResponsable.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 90);
            label3.Name = "label3";
            label3.Size = new Size(140, 17);
            label3.TabIndex = 6;
            label3.Text = "Datos de Encomienda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 121);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado Actual";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 150);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 9;
            label6.Text = "Ubicación Actual";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 179);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 10;
            label7.Text = "Ultima fecha actualizada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(104, 221);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 11;
            label8.Text = "Historial";
            // 
            // button2
            // 
            button2.Location = new Point(629, 529);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(274, 121);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 14;
            label10.Text = "Admitida";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(274, 150);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 15;
            label11.Text = "CD Buenos Aires";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(274, 179);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 16;
            label12.Text = "01/05/2026 10:00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(450, 121);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 17;
            label13.Text = "Responsable:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(586, 121);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 18;
            label14.Text = "Tito";
            // 
            // ConsultaEstadoInterna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaEstadoInterna";
            Text = "ConsultaEstadoInterna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader estado;
        private ColumnHeader ubicación;
        private ColumnHeader fechaActualización;
        private ColumnHeader personaResponsable;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}