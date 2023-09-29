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
            label1 = new Label();
            comboBoxBD = new ComboBox();
            label3 = new Label();
            txtFolderCopia = new Button();
            dateTimeFin = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.restauracionRED;
            pictureBox2.Location = new Point(528, 98);
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
            label1.Location = new Point(240, 108);
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
            comboBoxBD.Location = new Point(236, 132);
            comboBoxBD.Name = "comboBoxBD";
            comboBoxBD.Size = new Size(232, 23);
            comboBoxBD.TabIndex = 33;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(243, 174);
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
            txtFolderCopia.Location = new Point(236, 196);
            txtFolderCopia.Name = "txtFolderCopia";
            txtFolderCopia.Size = new Size(232, 47);
            txtFolderCopia.TabIndex = 35;
            txtFolderCopia.UseVisualStyleBackColor = true;
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.None;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(405, 270);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(217, 271);
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
            button1.Location = new Point(310, 337);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRestaurarBD";
            Text = "FormRestaurarBD";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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