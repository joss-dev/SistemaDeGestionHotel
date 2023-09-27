namespace SistemaDeGestionHotel.views.superAdmin
{
    partial class FormRestaurarBD
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
            btnMaximized = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            comboBoxBD = new ComboBox();
            label3 = new Label();
            txtFolderCopia = new Button();
            dateTimeFin = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(btnMaximized);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 103);
            panel1.TabIndex = 25;
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
            btnMaximized.Location = new Point(1460, 6);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(33, 23);
            btnMaximized.TabIndex = 22;
            btnMaximized.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(424, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
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
            iconButton1.Location = new Point(1425, 8);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 18);
            iconButton1.TabIndex = 21;
            iconButton1.UseVisualStyleBackColor = false;
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
            btnExit.Location = new Point(1493, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 23);
            btnExit.TabIndex = 20;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.restauracionRED;
            pictureBox2.Location = new Point(517, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 198);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(229, 149);
            label1.Name = "label1";
            label1.Size = new Size(219, 19);
            label1.TabIndex = 30;
            label1.Text = "Seleccione la Base de Datos:";
            // 
            // comboBoxBD
            // 
            comboBoxBD.Anchor = AnchorStyles.None;
            comboBoxBD.BackColor = Color.Silver;
            comboBoxBD.FlatStyle = FlatStyle.Popup;
            comboBoxBD.FormattingEnabled = true;
            comboBoxBD.Location = new Point(225, 173);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(232, 23);
            comboBoxBD.TabIndex = 33;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(232, 215);
            label3.Name = "label3";
            label3.Size = new Size(213, 19);
            label3.TabIndex = 34;
            label3.Text = "Cargar archivo de respaldo:";
            // 
            // txtFolderCopia
            // 
            txtFolderCopia.Anchor = AnchorStyles.None;
            txtFolderCopia.FlatAppearance.BorderColor = Color.Black;
            txtFolderCopia.FlatStyle = FlatStyle.Popup;
            txtFolderCopia.Image = Properties.Resources.foldered;
            txtFolderCopia.Location = new Point(225, 237);
            txtFolderCopia.Name = "txtFolderCopia";
            txtFolderCopia.Size = new Size(232, 47);
            txtFolderCopia.TabIndex = 35;
            txtFolderCopia.UseVisualStyleBackColor = true;
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.None;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(394, 311);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(206, 312);
            label4.Name = "label4";
            label4.Size = new Size(176, 19);
            label4.TabIndex = 36;
            label4.Text = "Fecha de restauración:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(299, 378);
            button1.Name = "button1";
            button1.Size = new Size(355, 38);
            button1.TabIndex = 38;
            button1.Text = "Iniciar Proceso de Restauración";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormRestaurarBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(976, 462);
            Controls.Add(button1);
            Controls.Add(dateTimeFin);
            Controls.Add(label4);
            Controls.Add(txtFolderCopia);
            Controls.Add(label3);
            Controls.Add(comboBoxBD);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRestaurarBD";
            Text = "FormRestaurarBD";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox comboBoxBD;
        private Label label3;
        private Button txtFolderCopia;
        private DateTimePicker dateTimeFin;
        private Label label4;
        private Button button1;
    }
}