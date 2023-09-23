﻿namespace SistemaDeGestionHotel
{
    partial class PrincipalRecep
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
            btnAgregarReserva = new FontAwesome.Sharp.IconButton();
            btnCerrarSesion = new Button();
            btnGestionPagos = new FontAwesome.Sharp.IconButton();
            btnGestionHabitaciones = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureLogo = new PictureBox();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            panelContenedor = new Panel();
            btnPantallaCompleta = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 79, 193);
            panelMenu.Controls.Add(btnAgregarReserva);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnGestionPagos);
            panelMenu.Controls.Add(btnGestionHabitaciones);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ActiveCaptionText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 564);
            panelMenu.TabIndex = 0;
            panelMenu.MouseDown += Form1_MouseDown;
            panelMenu.MouseMove += Form1_MouseMove;
            panelMenu.MouseUp += Form1_MouseUp;
            // 
            // btnAgregarReserva
            // 
            btnAgregarReserva.Cursor = Cursors.Hand;
            btnAgregarReserva.Dock = DockStyle.Top;
            btnAgregarReserva.FlatAppearance.BorderSize = 0;
            btnAgregarReserva.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnAgregarReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAgregarReserva.FlatStyle = FlatStyle.Flat;
            btnAgregarReserva.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarReserva.ForeColor = Color.White;
            btnAgregarReserva.IconChar = FontAwesome.Sharp.IconChar.Archive;
            btnAgregarReserva.IconColor = Color.FromArgb(15, 15, 15);
            btnAgregarReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarReserva.IconSize = 38;
            btnAgregarReserva.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarReserva.Location = new Point(0, 320);
            btnAgregarReserva.Name = "btnAgregarReserva";
            btnAgregarReserva.Padding = new Padding(20, 0, 10, 0);
            btnAgregarReserva.Size = new Size(220, 60);
            btnAgregarReserva.TabIndex = 7;
            btnAgregarReserva.Text = "Agregar Reserva";
            btnAgregarReserva.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarReserva.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarReserva.UseVisualStyleBackColor = true;
            btnAgregarReserva.Click += btnAgregarReserva_Click_1;
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
            btnCerrarSesion.Location = new Point(39, 503);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(134, 39);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnGestionPagos
            // 
            btnGestionPagos.Cursor = Cursors.Hand;
            btnGestionPagos.Dock = DockStyle.Top;
            btnGestionPagos.FlatAppearance.BorderSize = 0;
            btnGestionPagos.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnGestionPagos.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnGestionPagos.FlatStyle = FlatStyle.Flat;
            btnGestionPagos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionPagos.ForeColor = Color.White;
            btnGestionPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnGestionPagos.IconColor = Color.FromArgb(15, 15, 15);
            btnGestionPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionPagos.IconSize = 38;
            btnGestionPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionPagos.Location = new Point(0, 260);
            btnGestionPagos.Name = "btnGestionPagos";
            btnGestionPagos.Padding = new Padding(20, 0, 10, 0);
            btnGestionPagos.Size = new Size(220, 60);
            btnGestionPagos.TabIndex = 4;
            btnGestionPagos.Text = "Gestionar Pagos";
            btnGestionPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionPagos.UseVisualStyleBackColor = true;
            btnGestionPagos.Click += btnGestionPagos_Click;
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
            btnGestionHabitaciones.Text = "Gestionar Habitaciones";
            btnGestionHabitaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionHabitaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionHabitaciones.UseVisualStyleBackColor = true;
            btnGestionHabitaciones.Click += btnGestionHabitaciones_Click;
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
            btnHome.Location = new Point(0, 140);
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
            pictureLogo.MouseDown += Form1_MouseDown;
            pictureLogo.MouseMove += Form1_MouseMove;
            pictureLogo.MouseUp += Form1_MouseUp;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(767, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.Black;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMinimizar.IconSize = 20;
            btnMinimizar.ImageAlign = ContentAlignment.BottomRight;
            btnMinimizar.Location = new Point(696, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 26);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenedor.Location = new Point(220, 33);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(580, 531);
            panelContenedor.TabIndex = 3;
            // 
            // btnPantallaCompleta
            // 
            btnPantallaCompleta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPantallaCompleta.FlatAppearance.BorderSize = 0;
            btnPantallaCompleta.FlatStyle = FlatStyle.Flat;
            btnPantallaCompleta.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnPantallaCompleta.IconColor = Color.Black;
            btnPantallaCompleta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnPantallaCompleta.IconSize = 20;
            btnPantallaCompleta.Location = new Point(731, 1);
            btnPantallaCompleta.Name = "btnPantallaCompleta";
            btnPantallaCompleta.Size = new Size(33, 26);
            btnPantallaCompleta.TabIndex = 4;
            btnPantallaCompleta.UseVisualStyleBackColor = true;
            btnPantallaCompleta.Click += btnPantallaCompleta_Click;
            // 
            // PrincipalRecep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 564);
            Controls.Add(btnMinimizar);
            Controls.Add(btnExit);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Controls.Add(btnPantallaCompleta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalRecep";
            Text = "Home";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
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
        private FontAwesome.Sharp.IconButton btnGestionHabitaciones;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureLogo;
        private Button btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnPantallaCompleta;
        private FontAwesome.Sharp.IconButton btnAgregarReserva;
    }
}