namespace SistemaDeGestionHotel
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            btnSalir = new Button();
            linkPass = new LinkLabel();
            TUsuario = new TextBox();
            TPass = new TextBox();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(-1, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.HotTrack;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 330);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += Login_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(420, 48);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 14;
            label1.Text = "INICIAR SESIÓN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.GrayText;
            btnLogin.Location = new Point(338, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(339, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(40, 40, 40);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.GrayText;
            btnSalir.Location = new Point(648, 279);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 30);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // linkPass
            // 
            linkPass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkPass.AutoSize = true;
            linkPass.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkPass.LinkColor = Color.Gray;
            linkPass.Location = new Point(433, 239);
            linkPass.Name = "linkPass";
            linkPass.Size = new Size(149, 13);
            linkPass.TabIndex = 0;
            linkPass.TabStop = true;
            linkPass.Text = "¿Has olvidado tu contraseña?";
            // 
            // TUsuario
            // 
            TUsuario.BackColor = Color.Black;
            TUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TUsuario.ForeColor = SystemColors.GrayText;
            TUsuario.Location = new Point(322, 102);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(376, 26);
            TUsuario.TabIndex = 1;
            TUsuario.Text = "Usuario";
            TUsuario.TextAlign = HorizontalAlignment.Center;
            TUsuario.Enter += TUsuario_Enter;
            TUsuario.Leave += TUsuario_Leave;
            // 
            // TPass
            // 
            TPass.BackColor = Color.Black;
            TPass.BorderStyle = BorderStyle.FixedSingle;
            TPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TPass.ForeColor = SystemColors.GrayText;
            TPass.Location = new Point(322, 155);
            TPass.Name = "TPass";
            TPass.Size = new Size(376, 26);
            TPass.TabIndex = 2;
            TPass.Text = "Contraseña";
            TPass.TextAlign = HorizontalAlignment.Center;
            TPass.Enter += TPass_Enter;
            TPass.Leave += TPass_Leave;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.Transparent;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.Gray;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 24;
            btnMinimizar.ImageAlign = ContentAlignment.BottomRight;
            btnMinimizar.Location = new Point(730, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(38, 33);
            btnMinimizar.TabIndex = 5;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconButton1.IconColor = Color.Gray;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(705, 153);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 30);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            CausesValidation = false;
            ClientSize = new Size(780, 330);
            Controls.Add(iconButton1);
            Controls.Add(btnMinimizar);
            Controls.Add(TPass);
            Controls.Add(TUsuario);
            Controls.Add(linkPass);
            Controls.Add(btnSalir);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox TUsuario;
        private Label label1;
        private Button btnLogin;
        private Button btnSalir;
        private LinkLabel linkPass;
        private TextBox TPas;
        private TextBox TPass;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}