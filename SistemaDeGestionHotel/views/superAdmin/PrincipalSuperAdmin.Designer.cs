namespace SistemaDeGestionHotel.views
{
    partial class PrincipalSuperAdmin
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
            button1 = new Button();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnRestaurarBD = new FontAwesome.Sharp.IconButton();
            btnBackUpBD = new FontAwesome.Sharp.IconButton();
            btnCerrarSesion = new Button();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureLogo = new PictureBox();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnPantallaCompleta = new FontAwesome.Sharp.IconButton();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 79, 193);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnRestaurarBD);
            panelMenu.Controls.Add(btnBackUpBD);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ActiveCaptionText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 570);
            panelMenu.TabIndex = 1;
            panelMenu.MouseDown += MouseDownSuperAdmin;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.GrayText;
            button1.Location = new Point(45, 435);
            button1.Name = "button1";
            button1.Size = new Size(134, 39);
            button1.TabIndex = 9;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = false;
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
            btnUsuarios.Location = new Point(0, 320);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 10, 0);
            btnUsuarios.Size = new Size(220, 60);
            btnUsuarios.TabIndex = 8;
            btnUsuarios.Text = "Gestión de Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnRestaurarBD
            // 
            btnRestaurarBD.Cursor = Cursors.Hand;
            btnRestaurarBD.Dock = DockStyle.Top;
            btnRestaurarBD.FlatAppearance.BorderSize = 0;
            btnRestaurarBD.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnRestaurarBD.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRestaurarBD.FlatStyle = FlatStyle.Flat;
            btnRestaurarBD.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaurarBD.ForeColor = Color.White;
            btnRestaurarBD.IconChar = FontAwesome.Sharp.IconChar.CircleNodes;
            btnRestaurarBD.IconColor = Color.FromArgb(15, 15, 15);
            btnRestaurarBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestaurarBD.IconSize = 38;
            btnRestaurarBD.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestaurarBD.Location = new Point(0, 260);
            btnRestaurarBD.Name = "btnRestaurarBD";
            btnRestaurarBD.Padding = new Padding(20, 0, 10, 0);
            btnRestaurarBD.Size = new Size(220, 60);
            btnRestaurarBD.TabIndex = 7;
            btnRestaurarBD.Text = "Restauración Base de Datos";
            btnRestaurarBD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestaurarBD.UseVisualStyleBackColor = true;
            btnRestaurarBD.Click += btnRestaurarBD_Click;
            // 
            // btnBackUpBD
            // 
            btnBackUpBD.Cursor = Cursors.Hand;
            btnBackUpBD.Dock = DockStyle.Top;
            btnBackUpBD.FlatAppearance.BorderSize = 0;
            btnBackUpBD.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnBackUpBD.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBackUpBD.FlatStyle = FlatStyle.Flat;
            btnBackUpBD.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackUpBD.ForeColor = Color.White;
            btnBackUpBD.IconChar = FontAwesome.Sharp.IconChar.Shield;
            btnBackUpBD.IconColor = Color.FromArgb(15, 15, 15);
            btnBackUpBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBackUpBD.IconSize = 38;
            btnBackUpBD.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackUpBD.Location = new Point(0, 200);
            btnBackUpBD.Name = "btnBackUpBD";
            btnBackUpBD.Padding = new Padding(20, 0, 10, 0);
            btnBackUpBD.Size = new Size(220, 60);
            btnBackUpBD.TabIndex = 6;
            btnBackUpBD.Text = "BackUp Base de Datos";
            btnBackUpBD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackUpBD.UseVisualStyleBackColor = true;
            btnBackUpBD.Click += btnBackUp_Click;
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
            btnCerrarSesion.Location = new Point(39, 973);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(134, 39);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
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
            pictureLogo.MouseDown += MouseDownPicture;
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
            btnMinimizar.Location = new Point(790, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 26);
            btnMinimizar.TabIndex = 6;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
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
            btnExit.Location = new Point(861, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            btnPantallaCompleta.Location = new Point(825, 0);
            btnPantallaCompleta.Name = "btnPantallaCompleta";
            btnPantallaCompleta.Size = new Size(33, 26);
            btnPantallaCompleta.TabIndex = 7;
            btnPantallaCompleta.UseVisualStyleBackColor = true;
            btnPantallaCompleta.Click += btnPantallaCompleta_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Location = new Point(219, 29);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(675, 541);
            panelContenedor.TabIndex = 8;
            // 
            // PrincipalSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(893, 570);
            Controls.Add(panelContenedor);
            Controls.Add(btnMinimizar);
            Controls.Add(btnExit);
            Controls.Add(btnPantallaCompleta);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalSuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += PAdmin_Load;
            MouseDown += PAdmin_MouseDown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panelLogo;
        private PictureBox pictureLogo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnPantallaCompleta;
        private Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnBackUpBD;
        private FontAwesome.Sharp.IconButton btnRestaurarBD;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private Button button1;
    }
}