namespace SistemaDeGestionHotel.views.recep
{
    partial class FormTarjeta
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
            btnVolver = new FontAwesome.Sharp.IconButton();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 86);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(273, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightCoral;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(12, 446);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 78);
            btnVolver.TabIndex = 44;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = Color.DarkTurquoise;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.ImageAlign = ContentAlignment.TopCenter;
            btnCobrar.Location = new Point(580, 446);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(98, 78);
            btnCobrar.TabIndex = 43;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // FormTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(690, 536);
            Controls.Add(btnVolver);
            Controls.Add(btnCobrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTarjeta";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnCobrar;
    }
}