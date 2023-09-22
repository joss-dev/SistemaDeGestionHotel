namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionDePagos
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 116);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(276, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.medios_de_pago;
            button1.Location = new Point(104, 264);
            button1.Name = "button1";
            button1.Size = new Size(114, 82);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 349);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 24;
            label1.Text = "Medios de Pago";
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.Impuestos1;
            button2.Location = new Point(304, 264);
            button2.Name = "button2";
            button2.Size = new Size(114, 82);
            button2.TabIndex = 25;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(317, 349);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 26;
            label2.Text = "Impuestos";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkTurquoise;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = Properties.Resources.Recargos;
            button3.Location = new Point(495, 264);
            button3.Name = "button3";
            button3.Size = new Size(114, 82);
            button3.TabIndex = 27;
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(476, 349);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 28;
            label3.Text = "Ofertas - Recargos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 160);
            label4.Name = "label4";
            label4.Size = new Size(569, 48);
            label4.TabIndex = 29;
            label4.Text = "Seleccione la opción deseada:";
            // 
            // gestionDePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(696, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionDePagos";
            Text = "gestionPagos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Label label4;
    }
}