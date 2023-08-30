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
            LUsuario = new Label();
            LPass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Magneto", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LUsuario.ForeColor = SystemColors.HotTrack;
            LUsuario.Location = new Point(177, 183);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(75, 20);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            LUsuario.Click += LUsuario_Click;
            // 
            // LPass
            // 
            LPass.AutoSize = true;
            LPass.Font = new Font("Magneto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LPass.ForeColor = SystemColors.HotTrack;
            LPass.Location = new Point(168, 247);
            LPass.Name = "LPass";
            LPass.Size = new Size(91, 20);
            LPass.TabIndex = 1;
            LPass.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 130);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(105, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(139, 172);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 36);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(139, 239);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(36, 33);
            iconButton2.TabIndex = 6;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(127, 317);
            button1.Name = "button1";
            button1.Size = new Size(155, 34);
            button1.TabIndex = 7;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 209, 100);
            ClientSize = new Size(408, 394);
            Controls.Add(button1);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LPass);
            Controls.Add(LUsuario);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LUsuario;
        private Label LPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button button1;
    }
}