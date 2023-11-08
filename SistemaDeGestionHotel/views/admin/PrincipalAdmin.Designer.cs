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
            btnHome = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            btnReporte = new FontAwesome.Sharp.IconButton();
            btnConsultas = new FontAwesome.Sharp.IconButton();
            btnAdmHabitaciones = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel1 = new Panel();
            btnMaximized = new FontAwesome.Sharp.IconButton();
            panelCont = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarServicios
            // 
            btnRegistrarServicios.Cursor = Cursors.Hand;
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
            btnRegistrarServicios.Location = new Point(0, 254);
            btnRegistrarServicios.Name = "btnRegistrarServicios";
            btnRegistrarServicios.Padding = new Padding(20, 0, 10, 0);
            btnRegistrarServicios.Size = new Size(220, 60);
            btnRegistrarServicios.TabIndex = 3;
            btnRegistrarServicios.Text = "Registrar Ss. Adicionales";
            btnRegistrarServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarServicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarServicios.UseVisualStyleBackColor = true;
            btnRegistrarServicios.Click += btnRegistrarServicios_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(39, 79, 193);
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.BottomRight;
            iconButton1.Location = new Point(472, 6);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 18);
            iconButton1.TabIndex = 6;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(220, 42);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(579, 502);
            panelContenedor.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(39, 79, 193);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(540, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 23);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPagos
            // 
            btnPagos.Cursor = Cursors.Hand;
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
            btnPagos.Location = new Point(0, 314);
            btnPagos.Name = "btnPagos";
            btnPagos.Padding = new Padding(20, 0, 10, 0);
            btnPagos.Size = new Size(220, 60);
            btnPagos.TabIndex = 4;
            btnPagos.Text = "Gestión de Pagos";
            btnPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.FromArgb(39, 79, 193);
            pictureLogo.Image = Properties.Resources.logoHotel;
            pictureLogo.Location = new Point(-11, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(240, 185);
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
            btnCerrarSesion.Location = new Point(39, 639);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(134, 39);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
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
            btnHome.Location = new Point(0, 194);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 10, 0);
            btnHome.Size = new Size(220, 60);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 79, 193);
            panelMenu.Controls.Add(btnReporte);
            panelMenu.Controls.Add(btnConsultas);
            panelMenu.Controls.Add(btnAdmHabitaciones);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnPagos);
            panelMenu.Controls.Add(btnRegistrarServicios);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ActiveCaptionText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 701);
            panelMenu.TabIndex = 4;
            // 
            // btnReporte
            // 
            btnReporte.Cursor = Cursors.Hand;
            btnReporte.Dock = DockStyle.Top;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnReporte.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnReporte.IconColor = Color.FromArgb(20, 20, 20);
            btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporte.IconSize = 38;
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(0, 554);
            btnReporte.Name = "btnReporte";
            btnReporte.Padding = new Padding(20, 0, 10, 0);
            btnReporte.Size = new Size(220, 60);
            btnReporte.TabIndex = 9;
            btnReporte.Text = "Reportes";
            btnReporte.TextAlign = ContentAlignment.MiddleLeft;
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.Dock = DockStyle.Top;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnConsultas.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultas.ForeColor = Color.White;
            btnConsultas.IconChar = FontAwesome.Sharp.IconChar.Question;
            btnConsultas.IconColor = Color.FromArgb(20, 20, 20);
            btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultas.IconSize = 38;
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(0, 494);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(20, 0, 10, 0);
            btnConsultas.Size = new Size(220, 60);
            btnConsultas.TabIndex = 8;
            btnConsultas.Text = "Consultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnAdmHabitaciones
            // 
            btnAdmHabitaciones.Cursor = Cursors.Hand;
            btnAdmHabitaciones.Dock = DockStyle.Top;
            btnAdmHabitaciones.FlatAppearance.BorderSize = 0;
            btnAdmHabitaciones.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnAdmHabitaciones.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAdmHabitaciones.FlatStyle = FlatStyle.Flat;
            btnAdmHabitaciones.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmHabitaciones.ForeColor = Color.White;
            btnAdmHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Bed;
            btnAdmHabitaciones.IconColor = Color.FromArgb(20, 20, 20);
            btnAdmHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmHabitaciones.IconSize = 38;
            btnAdmHabitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmHabitaciones.Location = new Point(0, 434);
            btnAdmHabitaciones.Name = "btnAdmHabitaciones";
            btnAdmHabitaciones.Padding = new Padding(20, 0, 10, 0);
            btnAdmHabitaciones.Size = new Size(220, 60);
            btnAdmHabitaciones.TabIndex = 7;
            btnAdmHabitaciones.Text = "Administrar Habitaciones";
            btnAdmHabitaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmHabitaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmHabitaciones.UseVisualStyleBackColor = true;
            btnAdmHabitaciones.Click += btnAdmHabitaciones_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
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
            btnUsuarios.Location = new Point(0, 374);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 10, 0);
            btnUsuarios.Size = new Size(220, 60);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Gestión de Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureLogo);
            panelLogo.Controls.Add(panelContenedor);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(20, 0, 10, 0);
            panelLogo.Size = new Size(220, 194);
            panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(btnMaximized);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 30);
            panel1.TabIndex = 9;
            // 
            // btnMaximized
            // 
            btnMaximized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximized.BackColor = Color.FromArgb(39, 79, 193);
            btnMaximized.FlatAppearance.BorderSize = 0;
            btnMaximized.FlatStyle = FlatStyle.Flat;
            btnMaximized.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnMaximized.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnMaximized.IconColor = Color.Black;
            btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMaximized.IconSize = 20;
            btnMaximized.Location = new Point(507, 4);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(33, 23);
            btnMaximized.TabIndex = 7;
            btnMaximized.UseVisualStyleBackColor = false;
            btnMaximized.Click += btnMaximized_Click_1;
            // 
            // panelCont
            // 
            panelCont.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCont.Location = new Point(220, 30);
            panelCont.Name = "panelCont";
            panelCont.Size = new Size(579, 671);
            panelCont.TabIndex = 10;
            // 
            // PrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 701);
            Controls.Add(panelCont);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalAdmin";
            Text = "Form1";
            Load += PrincipalAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnAdmHabitaciones;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMaximized;
        public Panel panelCont;
        private FontAwesome.Sharp.IconButton btnConsultas;
        private FontAwesome.Sharp.IconButton btnReporte;
    }
}