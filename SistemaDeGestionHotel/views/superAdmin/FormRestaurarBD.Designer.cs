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
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txtFolderCopia = new Button();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.restauracionRED;
            pictureBox2.Location = new Point(516, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 198);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(234, 191);
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
            txtFolderCopia.Location = new Point(225, 216);
            txtFolderCopia.Name = "txtFolderCopia";
            txtFolderCopia.Size = new Size(232, 47);
            txtFolderCopia.TabIndex = 35;
            txtFolderCopia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(301, 363);
            button1.Name = "button1";
            button1.Size = new Size(355, 38);
            button1.TabIndex = 38;
            button1.Text = "Iniciar Proceso de Restauración";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 44);
            label2.Name = "label2";
            label2.Size = new Size(460, 51);
            label2.TabIndex = 39;
            label2.Text = "Restauración de Datos";
            label2.Click += label2_Click;
            // 
            // FormRestaurarBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(976, 462);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtFolderCopia);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRestaurarBD";
            Text = "FormRestaurarBD";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label3;
        private Button txtFolderCopia;
        private Button button1;
        private Label label2;
    }
}