namespace SistemaDeGestionHotel.views.recep
{
    partial class FormEfectivo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            btnVolver = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label5 = new Label();
            textBoxEfectivo = new TextBox();
            label4 = new Label();
            textBoxTotalApagar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 86);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(310, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = Color.DarkTurquoise;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.ImageAlign = ContentAlignment.TopCenter;
            btnCobrar.Location = new Point(621, 423);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(98, 78);
            btnCobrar.TabIndex = 41;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightCoral;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(15, 423);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 78);
            btnVolver.TabIndex = 42;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxEfectivo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxTotalApagar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(130, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 297);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cobrar con Efectivo";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(161, 220);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(180, 33);
            textBox1.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 192);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 40;
            label5.Text = "Cambio :";
            // 
            // textBoxEfectivo
            // 
            textBoxEfectivo.Location = new Point(161, 140);
            textBoxEfectivo.Name = "textBoxEfectivo";
            textBoxEfectivo.Size = new Size(180, 33);
            textBoxEfectivo.TabIndex = 39;
            textBoxEfectivo.KeyDown += ValidarEfectivo;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 112);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 38;
            label4.Text = "Efectivo : ";
            // 
            // textBoxTotalApagar
            // 
            textBoxTotalApagar.Enabled = false;
            textBoxTotalApagar.Location = new Point(161, 67);
            textBoxTotalApagar.Name = "textBoxTotalApagar";
            textBoxTotalApagar.ReadOnly = true;
            textBoxTotalApagar.Size = new Size(180, 33);
            textBoxTotalApagar.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 39);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 36;
            label3.Text = "Total a pagar: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(712, 70);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 35;
            label2.Text = "Fecha de Salida :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(712, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 34;
            label1.Text = "Telefono :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormEfectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(731, 513);
            Controls.Add(groupBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnCobrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormEfectivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEfectivo";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private FontAwesome.Sharp.IconButton btnVolver;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxTotalApagar;
        private Label label3;
        private TextBox textBoxEfectivo;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}