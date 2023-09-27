namespace SistemaDeGestionHotel.views.superAdmin
{
    partial class FormBackUp
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
            btnMaximized = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label3 = new Label();
            txtFolderDestino = new Button();
            comboBoxBD = new ComboBox();
            label4 = new Label();
            dateTimeFin = new DateTimePicker();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(303, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(btnMaximized);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 103);
            panel1.TabIndex = 24;
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
            btnMaximized.Location = new Point(681, 6);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(33, 23);
            btnMaximized.TabIndex = 22;
            btnMaximized.UseVisualStyleBackColor = false;
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
            iconButton1.Location = new Point(646, 8);
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
            btnExit.Location = new Point(714, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 23);
            btnExit.TabIndex = 20;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(97, 201);
            label1.Name = "label1";
            label1.Size = new Size(219, 19);
            label1.TabIndex = 25;
            label1.Text = "Seleccione la Base de Datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 125);
            label2.Name = "label2";
            label2.Size = new Size(518, 50);
            label2.TabIndex = 26;
            label2.Text = "Back-Up Base de Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 265);
            label3.Name = "label3";
            label3.Size = new Size(250, 19);
            label3.TabIndex = 28;
            label3.Text = "Seleccione la carpeta de destino:";
            // 
            // txtFolderDestino
            // 
            txtFolderDestino.FlatAppearance.BorderColor = Color.Black;
            txtFolderDestino.FlatStyle = FlatStyle.Popup;
            txtFolderDestino.Image = Properties.Resources.foldered;
            txtFolderDestino.Location = new Point(91, 289);
            txtFolderDestino.Name = "txtFolderDestino";
            txtFolderDestino.Size = new Size(232, 47);
            txtFolderDestino.TabIndex = 31;
            txtFolderDestino.UseVisualStyleBackColor = true;
            // 
            // comboBoxBD
            // 
            comboBoxBD.BackColor = Color.Silver;
            comboBoxBD.FlatStyle = FlatStyle.Popup;
            comboBoxBD.FormattingEnabled = true;
            comboBoxBD.Location = new Point(91, 226);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(232, 23);
            comboBoxBD.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 354);
            label4.Name = "label4";
            label4.Size = new Size(164, 19);
            label4.TabIndex = 33;
            label4.Text = "Fecha de realización:";
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.None;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(238, 354);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.backup;
            pictureBox2.Location = new Point(415, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 208);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(205, 427);
            button1.Name = "button1";
            button1.Size = new Size(309, 38);
            button1.TabIndex = 36;
            button1.Text = "Iniciar Proceso de Back-Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(755, 490);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(dateTimeFin);
            Controls.Add(label4);
            Controls.Add(comboBoxBD);
            Controls.Add(txtFolderDestino);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBackUp";
            Text = "Back-Up Base de Datos";
            Load += FormBackUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnExit;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label3;
        private Button txtFolderDestino;
        private ComboBox comboBoxBD;
        private Label label4;
        private DateTimePicker dateTimeFin;
        private PictureBox pictureBox2;
        private Button button1;
    }
}