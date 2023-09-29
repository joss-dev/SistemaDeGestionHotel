namespace SistemaDeGestionHotel.views.recep
{
    partial class FormTarjeta
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
            pictureBox1 = new PictureBox();
            btnVolver = new FontAwesome.Sharp.IconButton();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            textBoxTotalApagar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxEstado = new ComboBox();
            label4 = new Label();
            textBoxNroTarjeta = new TextBox();
            label5 = new Label();
            textBoxFechaCad = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxTitular = new TextBox();
            label8 = new Label();
            textBoxCvv = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 86);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(273, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
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
            btnVolver.Location = new Point(12, 514);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 78);
            btnVolver.TabIndex = 44;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
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
            btnCobrar.Location = new Point(580, 514);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(98, 78);
            btnCobrar.TabIndex = 43;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxCvv);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxTitular);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxFechaCad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxNroTarjeta);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxEstado);
            groupBox1.Controls.Add(textBoxTotalApagar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(115, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 405);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cobrar con tarjeta";
            // 
            // textBoxTotalApagar
            // 
            textBoxTotalApagar.Enabled = false;
            textBoxTotalApagar.Location = new Point(30, 55);
            textBoxTotalApagar.Name = "textBoxTotalApagar";
            textBoxTotalApagar.ReadOnly = true;
            textBoxTotalApagar.Size = new Size(180, 25);
            textBoxTotalApagar.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 35);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 36;
            label3.Text = "Total a pagar : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(837, 70);
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
            label1.Location = new Point(837, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 34;
            label1.Text = "Telefono :";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Débito", "Crédito" });
            comboBoxEstado.Location = new Point(30, 123);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 25);
            comboBoxEstado.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 103);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 42;
            label4.Text = "Tipo tarjeta : ";
            // 
            // textBoxNroTarjeta
            // 
            textBoxNroTarjeta.Location = new Point(30, 181);
            textBoxNroTarjeta.Name = "textBoxNroTarjeta";
            textBoxNroTarjeta.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            textBoxNroTarjeta.Size = new Size(316, 25);
            textBoxNroTarjeta.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 161);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 44;
            label5.Text = "Nro  de tarjeta : ";
            // 
            // textBoxFechaCad
            // 
            textBoxFechaCad.Location = new Point(31, 241);
            textBoxFechaCad.Name = "textBoxFechaCad";
            textBoxFechaCad.PlaceholderText = "MM/AA";
            textBoxFechaCad.Size = new Size(61, 25);
            textBoxFechaCad.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 221);
            label6.Name = "label6";
            label6.Size = new Size(136, 17);
            label6.TabIndex = 46;
            label6.Text = "Fecha de caducidad :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 278);
            label7.Name = "label7";
            label7.Size = new Size(135, 17);
            label7.TabIndex = 48;
            label7.Text = "Titular de la tarjeta :";
            // 
            // textBoxTitular
            // 
            textBoxTitular.Location = new Point(31, 298);
            textBoxTitular.Name = "textBoxTitular";
            textBoxTitular.Size = new Size(315, 25);
            textBoxTitular.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 340);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 50;
            label8.Text = "CVV :";
            // 
            // textBoxCvv
            // 
            textBoxCvv.Location = new Point(31, 360);
            textBoxCvv.Name = "textBoxCvv";
            textBoxCvv.PlaceholderText = "XXX";
            textBoxCvv.Size = new Size(75, 25);
            textBoxCvv.TabIndex = 49;
            // 
            // FormTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(690, 604);
            Controls.Add(groupBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnCobrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTarjeta";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private GroupBox groupBox1;
        private TextBox textBoxTotalApagar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox textBoxFechaCad;
        private Label label5;
        private TextBox textBoxNroTarjeta;
        private Label label4;
        private ComboBox comboBoxEstado;
        private Label label8;
        private TextBox textBoxCvv;
        private Label label7;
        private TextBox textBoxTitular;
    }
}