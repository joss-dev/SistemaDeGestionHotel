﻿namespace SistemaDeGestionHotel.views.superAdmin
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
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(406, -11);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 103);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 205);
            label1.Name = "label1";
            label1.Size = new Size(219, 19);
            label1.TabIndex = 25;
            label1.Text = "Seleccione la Base de Datos:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(221, 129);
            label2.Name = "label2";
            label2.Size = new Size(481, 51);
            label2.TabIndex = 26;
            label2.Text = "Back-Up Base de Datos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(186, 269);
            label3.Name = "label3";
            label3.Size = new Size(250, 19);
            label3.TabIndex = 28;
            label3.Text = "Seleccione la carpeta de destino:";
            // 
            // txtFolderDestino
            // 
            txtFolderDestino.Anchor = AnchorStyles.None;
            txtFolderDestino.FlatAppearance.BorderColor = Color.Black;
            txtFolderDestino.FlatStyle = FlatStyle.Popup;
            txtFolderDestino.Image = Properties.Resources.foldered;
            txtFolderDestino.Location = new Point(194, 293);
            txtFolderDestino.Name = "txtFolderDestino";
            txtFolderDestino.Size = new Size(232, 47);
            txtFolderDestino.TabIndex = 31;
            txtFolderDestino.UseVisualStyleBackColor = true;
            // 
            // comboBoxBD
            // 
            comboBoxBD.Anchor = AnchorStyles.None;
            comboBoxBD.BackColor = Color.Silver;
            comboBoxBD.FlatStyle = FlatStyle.Popup;
            comboBoxBD.FormattingEnabled = true;
            comboBoxBD.Location = new Point(194, 230);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(232, 23);
            comboBoxBD.TabIndex = 32;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(173, 358);
            label4.Name = "label4";
            label4.Size = new Size(164, 19);
            label4.TabIndex = 33;
            label4.Text = "Fecha de realización:";
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.None;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(341, 358);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.backup;
            pictureBox2.Location = new Point(518, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 208);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(308, 431);
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
            ClientSize = new Size(961, 498);
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