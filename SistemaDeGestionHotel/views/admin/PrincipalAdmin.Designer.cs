namespace SistemaDeGestionHotel
{
    partial class PrincipalAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistrarServicios = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelContenedor = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnPagos = new FontAwesome.Sharp.IconButton();
            pictureLogo = new PictureBox();
            btnCerrarSesion = new Button();
            btnGestionHabitaciones = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            panelLogo = new Panel();
            btnMaximized = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarServicios
            // 
            btnRegistrarServicios.Dock = DockStyle.Top;
            btnRegistrarServicios.FlatAppearance.BorderSize = 0;
            btnRegistrarServicios.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnRegistrarServicios.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegistrarServicios.FlatStyle = FlatStyle.Flat;
            btnRegistrarServicios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarServicios.ForeColor = Color.White;
            btnRegistrarServicios.IconChar = FontAwesome.Sharp.IconChar.Spa;
            btnRegistrarServicios.IconColor = Color.FromArgb(15, 15, 15);
            btnRegistrarServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarServicios.IconSize = 38;
            btnRegistrarServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarServicios.Location = new Point(0, 260);
            btnRegistrarServicios.Name = "btnRegistrarServicios";
            btnRegistrarServicios.Padding = new Padding(20, 0, 10, 0);
            btnRegistrarServicios.Size = new Size(220, 60);
            btnRegistrarServicios.TabIndex = 3;
            btnRegistrarServicios.Text = "Registrar Adicionales";
            btnRegistrarServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarServicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarServicios.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.BottomRight;
            iconButton1.Location = new Point(706, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 18);
            iconButton1.TabIndex = 6;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(221, 33);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(581, 502);
            panelContenedor.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(769, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPagos
            // 
            btnPagos.Dock = DockStyle.Top;
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnPagos.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.ForeColor = Color.White;
            btnPagos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnPagos.IconColor = Color.FromArgb(15, 15, 15);
            btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPagos.IconSize = 38;
            btnPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagos.Location = new Point(0, 320);
            btnPagos.Name = "btnPagos";
            btnPagos.Padding = new Padding(20, 0, 10, 0);
            btnPagos.Size = new Size(220, 60);
            btnPagos.TabIndex = 4;
            btnPagos.Text = "Pagos";
            btnPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnRegistrarUsuario_Click;
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
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.BackColor = Color.FromArgb(40, 40, 40);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.GrayText;
            btnCerrarSesion.Location = new Point(39, 481);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(134, 39);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnGestionHabitaciones
            // 
            btnGestionHabitaciones.Cursor = Cursors.Hand;
            btnGestionHabitaciones.Dock = DockStyle.Top;
            btnGestionHabitaciones.FlatAppearance.BorderSize = 0;
            btnGestionHabitaciones.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnGestionHabitaciones.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnGestionHabitaciones.FlatStyle = FlatStyle.Flat;
            btnGestionHabitaciones.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionHabitaciones.ForeColor = Color.White;
            btnGestionHabitaciones.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnGestionHabitaciones.IconColor = Color.FromArgb(15, 15, 15);
            btnGestionHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionHabitaciones.IconSize = 38;
            btnGestionHabitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionHabitaciones.Location = new Point(0, 200);
            btnGestionHabitaciones.Name = "btnGestionHabitaciones";
            btnGestionHabitaciones.Padding = new Padding(20, 0, 10, 0);
            btnGestionHabitaciones.Size = new Size(220, 60);
            btnGestionHabitaciones.TabIndex = 2;
            btnGestionHabitaciones.Text = "Gestion de Habitaciones";
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
            btnHome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.FromArgb(15, 15, 15);
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 79, 193);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnPagos);
            panelMenu.Controls.Add(btnRegistrarServicios);
            panelMenu.Controls.Add(btnGestionHabitaciones);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ActiveCaptionText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 535);
            panelMenu.TabIndex = 4;
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
            // btnMaximized
            // 
            btnMaximized.BackColor = SystemColors.ActiveCaptionText;
            btnMaximized.ForeColor = SystemColors.ActiveCaptionText;
            btnMaximized.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnMaximized.IconColor = Color.Black;
            btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximized.IconSize = 15;
            btnMaximized.Location = new Point(743, 6);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(26, 25);
            btnMaximized.TabIndex = 8;
            btnMaximized.Text = "Maximizar";
            btnMaximized.UseVisualStyleBackColor = false;
            btnMaximized.Click += btnMaximized_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUsuarios.IconColor = Color.FromArgb(15, 15, 15);
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 38;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 380);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 10, 0);
            btnUsuarios.Size = new Size(220, 60);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Gestión de Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // PrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(btnMaximized);
            Controls.Add(iconButton1);
            Controls.Add(panelContenedor);
            Controls.Add(btnExit);
            Controls.Add(panelMenu);
            Name = "PrincipalAdmin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegistrarServicios;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnPagos;
        private PictureBox pictureLogo;
        private Button btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnGestionHabitaciones;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private FontAwesome.Sharp.IconButton btnUsuarios;
    }
}