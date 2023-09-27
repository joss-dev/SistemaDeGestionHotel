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
            btnMP = new Button();
            label1 = new Label();
            btnImp = new Button();
            label2 = new Label();
            btnOR = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 116);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(276, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnMP
            // 
            btnMP.Anchor = AnchorStyles.None;
            btnMP.BackColor = Color.ForestGreen;
            btnMP.FlatAppearance.BorderColor = Color.Black;
            btnMP.FlatStyle = FlatStyle.Popup;
            btnMP.Image = Properties.Resources.medios_de_pago;
            btnMP.Location = new Point(157, 286);
            btnMP.Name = "btnMP";
            btnMP.Size = new Size(111, 77);
            btnMP.TabIndex = 23;
            btnMP.UseVisualStyleBackColor = false;
            btnMP.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 371);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 24;
            label1.Text = "Medios de Pago";
            // 
            // btnImp
            // 
            btnImp.Anchor = AnchorStyles.None;
            btnImp.BackColor = Color.LightCoral;
            btnImp.FlatStyle = FlatStyle.Popup;
            btnImp.Image = Properties.Resources.Impuestos1;
            btnImp.Location = new Point(357, 286);
            btnImp.Name = "btnImp";
            btnImp.Size = new Size(111, 77);
            btnImp.TabIndex = 25;
            btnImp.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(370, 371);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 26;
            label2.Text = "Impuestos";
            // 
            // btnOR
            // 
            btnOR.Anchor = AnchorStyles.None;
            btnOR.BackColor = Color.DarkTurquoise;
            btnOR.FlatStyle = FlatStyle.Popup;
            btnOR.Image = Properties.Resources.Recargos;
            btnOR.Location = new Point(548, 286);
            btnOR.Name = "btnOR";
            btnOR.Size = new Size(111, 77);
            btnOR.TabIndex = 27;
            btnOR.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(529, 371);
            label3.Name = "label3";
            label3.Size = new Size(155, 21);
            label3.TabIndex = 28;
            label3.Text = "Ofertas - Recargos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 159);
            label4.Name = "label4";
            label4.Size = new Size(572, 54);
            label4.TabIndex = 29;
            label4.Text = "Seleccione la opción deseada:";
            // 
            // gestionDePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(798, 488);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnOR);
            Controls.Add(label2);
            Controls.Add(btnImp);
            Controls.Add(label1);
            Controls.Add(btnMP);
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
        private Button btnMP;
        private Label label1;
        private Button btnImp;
        private Label label2;
        private Button btnOR;
        private Label label3;
        private Label label4;
    }
}