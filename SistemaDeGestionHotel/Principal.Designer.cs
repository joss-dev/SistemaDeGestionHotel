namespace SistemaDeGestionHotel
{
    partial class Principal
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
            panelMenu = new Panel();
            btnGestionPagos = new FontAwesome.Sharp.IconButton();
            btnRegistrarServicios = new FontAwesome.Sharp.IconButton();
            btnGestionHabitaciones = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            pictureLogo = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 79, 193);
            panelMenu.Controls.Add(btnGestionPagos);
            panelMenu.Controls.Add(btnRegistrarServicios);
            panelMenu.Controls.Add(btnGestionHabitaciones);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ActiveCaptionText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnGestionPagos
            // 
            btnGestionPagos.Dock = DockStyle.Top;
            btnGestionPagos.FlatAppearance.BorderSize = 0;
            btnGestionPagos.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnGestionPagos.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnGestionPagos.FlatStyle = FlatStyle.Flat;
            btnGestionPagos.ForeColor = Color.White;
            btnGestionPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnGestionPagos.IconColor = Color.White;
            btnGestionPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionPagos.IconSize = 38;
            btnGestionPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionPagos.Location = new Point(0, 320);
            btnGestionPagos.Name = "btnGestionPagos";
            btnGestionPagos.Padding = new Padding(20, 0, 10, 0);
            btnGestionPagos.Size = new Size(220, 60);
            btnGestionPagos.TabIndex = 4;
            btnGestionPagos.Text = "Gestionar Pagos";
            btnGestionPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionPagos.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarServicios
            // 
            btnRegistrarServicios.Dock = DockStyle.Top;
            btnRegistrarServicios.FlatAppearance.BorderSize = 0;
            btnRegistrarServicios.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnRegistrarServicios.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegistrarServicios.FlatStyle = FlatStyle.Flat;
            btnRegistrarServicios.ForeColor = Color.White;
            btnRegistrarServicios.IconChar = FontAwesome.Sharp.IconChar.Spa;
            btnRegistrarServicios.IconColor = Color.White;
            btnRegistrarServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarServicios.IconSize = 38;
            btnRegistrarServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarServicios.Location = new Point(0, 260);
            btnRegistrarServicios.Name = "btnRegistrarServicios";
            btnRegistrarServicios.Padding = new Padding(20, 0, 10, 0);
            btnRegistrarServicios.Size = new Size(220, 60);
            btnRegistrarServicios.TabIndex = 3;
            btnRegistrarServicios.Text = "Registrar Servicios ";
            btnRegistrarServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarServicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarServicios.UseVisualStyleBackColor = true;
            // 
            // btnGestionHabitaciones
            // 
            btnGestionHabitaciones.Dock = DockStyle.Top;
            btnGestionHabitaciones.FlatAppearance.BorderSize = 0;
            btnGestionHabitaciones.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnGestionHabitaciones.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnGestionHabitaciones.FlatStyle = FlatStyle.Flat;
            btnGestionHabitaciones.ForeColor = Color.White;
            btnGestionHabitaciones.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnGestionHabitaciones.IconColor = Color.White;
            btnGestionHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionHabitaciones.IconSize = 38;
            btnGestionHabitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionHabitaciones.Location = new Point(0, 200);
            btnGestionHabitaciones.Name = "btnGestionHabitaciones";
            btnGestionHabitaciones.Padding = new Padding(20, 0, 10, 0);
            btnGestionHabitaciones.Size = new Size(220, 60);
            btnGestionHabitaciones.TabIndex = 2;
            btnGestionHabitaciones.Text = "Gestionar Habitaciones";
            btnGestionHabitaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionHabitaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionHabitaciones.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 38;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 140);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 10, 0);
            btnHome.Size = new Size(220, 60);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(20, 0, 10, 0);
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 30;
            btnExit.Location = new Point(763, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 36);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.FromArgb(39, 79, 193);
            pictureLogo.Image = Properties.Resources.logoHotel;
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(220, 140);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Home";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnGestionPagos;
        private FontAwesome.Sharp.IconButton btnRegistrarServicios;
        private FontAwesome.Sharp.IconButton btnGestionHabitaciones;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureLogo;
    }
}