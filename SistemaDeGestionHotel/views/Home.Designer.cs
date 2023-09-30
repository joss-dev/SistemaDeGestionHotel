namespace SistemaDeGestionHotel.views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            btnEstadoHab = new Button();
            btnContacto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.None;
            monthCalendar1.BackColor = Color.IndianRed;
            monthCalendar1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.ForeColor = SystemColors.MenuHighlight;
            monthCalendar1.Location = new Point(580, 183);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.TitleBackColor = SystemColors.Highlight;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(839, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnEstadoHab
            // 
            btnEstadoHab.Anchor = AnchorStyles.None;
            btnEstadoHab.BackColor = Color.LightCoral;
            btnEstadoHab.FlatStyle = FlatStyle.Popup;
            btnEstadoHab.Font = new Font("Broadway", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEstadoHab.Location = new Point(580, 369);
            btnEstadoHab.Name = "btnEstadoHab";
            btnEstadoHab.Size = new Size(248, 48);
            btnEstadoHab.TabIndex = 12;
            btnEstadoHab.Text = "Consultar estados de habitaciones";
            btnEstadoHab.UseVisualStyleBackColor = false;
            btnEstadoHab.Click += btnEstadoHab_Click;
            // 
            // btnContacto
            // 
            btnContacto.Anchor = AnchorStyles.None;
            btnContacto.BackColor = Color.SpringGreen;
            btnContacto.FlatStyle = FlatStyle.Popup;
            btnContacto.Font = new Font("Broadway", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            btnContacto.Location = new Point(580, 438);
            btnContacto.Name = "btnContacto";
            btnContacto.Size = new Size(248, 48);
            btnContacto.TabIndex = 13;
            btnContacto.Text = "Contacto a soporte";
            btnContacto.UseVisualStyleBackColor = false;
            btnContacto.Click += btnContacto_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(888, 564);
            Controls.Add(btnContacto);
            Controls.Add(btnEstadoHab);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
        private Button btnEstadoHab;
        private Button btnContacto;
    }
}