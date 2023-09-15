namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionHabitaciones
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnGuardarReserva = new FontAwesome.Sharp.IconButton();
            btnVolver = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(76, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 125);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 71;
            iconPictureBox1.Location = new Point(15, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(71, 76);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // btnGuardarReserva
            // 
            btnGuardarReserva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarReserva.BackColor = Color.Transparent;
            btnGuardarReserva.Cursor = Cursors.Hand;
            btnGuardarReserva.FlatAppearance.BorderSize = 0;
            btnGuardarReserva.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnGuardarReserva.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnGuardarReserva.ForeColor = Color.Black;
            btnGuardarReserva.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardarReserva.IconColor = SystemColors.ActiveCaptionText;
            btnGuardarReserva.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardarReserva.IconSize = 40;
            btnGuardarReserva.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarReserva.Location = new Point(465, 482);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(74, 61);
            btnGuardarReserva.TabIndex = 17;
            btnGuardarReserva.Text = "Registrar";
            btnGuardarReserva.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarReserva.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.Transparent;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnVolver.IconSize = 40;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(15, 482);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(74, 61);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // gestionHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(580, 564);
            Controls.Add(btnGuardarReserva);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionHabitaciones";
            ShowIcon = false;
            Text = "gestionHabitaciones";
            Load += gestionHabitaciones_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnGuardarReserva;
        private FontAwesome.Sharp.IconButton btnVolver;
    }
}