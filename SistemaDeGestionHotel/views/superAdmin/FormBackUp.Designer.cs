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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 67);
            label2.Name = "label2";
            label2.Size = new Size(481, 51);
            label2.TabIndex = 26;
            label2.Text = "Back-Up Base de Datos";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.backup;
            pictureBox2.Location = new Point(517, 149);
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
            button1.Location = new Point(144, 203);
            button1.Name = "button1";
            button1.Size = new Size(309, 95);
            button1.TabIndex = 36;
            button1.Text = "Iniciar Proceso de Back-Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(961, 498);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBackUp";
            Text = "Back-Up Base de Datos";
            Load += FormBackUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox2;
        private Button button1;
    }
}