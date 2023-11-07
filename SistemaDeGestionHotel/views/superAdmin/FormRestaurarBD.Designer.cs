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
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(109, 162);
            button1.Name = "button1";
            button1.Size = new Size(355, 125);
            button1.TabIndex = 38;
            button1.Text = "Iniciar Proceso de Restauración";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
        private Button button1;
        private Label label2;
    }
}