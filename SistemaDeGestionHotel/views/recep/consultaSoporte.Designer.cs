namespace SistemaDeGestionHotel.views.recep
{
    partial class consultaSoporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaSoporte));
            label1 = new Label();
            label2 = new Label();
            txtMotivo = new TextBox();
            label3 = new Label();
            txtMsje = new TextBox();
            label4 = new Label();
            txtMail = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            label16 = new Label();
            btnCancelar = new Button();
            btnVolver = new Button();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 25);
            label1.Name = "label1";
            label1.Size = new Size(590, 50);
            label1.TabIndex = 0;
            label1.Text = "Consultas Soporte Técnico";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(75, 182);
            label2.Name = "label2";
            label2.Size = new Size(180, 18);
            label2.TabIndex = 1;
            label2.Text = "Motivo de la consulta:";
            // 
            // txtMotivo
            // 
            txtMotivo.Anchor = AnchorStyles.None;
            txtMotivo.Location = new Point(100, 211);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(321, 23);
            txtMotivo.TabIndex = 2;
            txtMotivo.KeyDown += ValidarMotivo;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(75, 250);
            label3.Name = "label3";
            label3.Size = new Size(208, 18);
            label3.TabIndex = 3;
            label3.Text = "Escriba aquí su consulta:";
            // 
            // txtMsje
            // 
            txtMsje.Anchor = AnchorStyles.None;
            txtMsje.Location = new Point(100, 284);
            txtMsje.Multiline = true;
            txtMsje.Name = "txtMsje";
            txtMsje.Size = new Size(597, 105);
            txtMsje.TabIndex = 4;
            txtMsje.KeyDown += ValidarMensaje;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(75, 108);
            label4.Name = "label4";
            label4.Size = new Size(281, 18);
            label4.TabIndex = 5;
            label4.Text = "Correo electronónico corporativo:";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Location = new Point(100, 138);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(321, 23);
            txtMail.TabIndex = 6;
            txtMail.KeyDown += ValidarMail;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(483, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(247, 418);
            button1.Name = "button1";
            button1.Size = new Size(71, 71);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(254, 494);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 9;
            label5.Text = "Enviar";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(373, 495);
            label16.Name = "label16";
            label16.Size = new Size(81, 18);
            label16.TabIndex = 64;
            label16.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.PaleGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(378, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 63;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(514, 419);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(71, 71);
            btnVolver.TabIndex = 65;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(520, 494);
            label6.Name = "label6";
            label6.Size = new Size(59, 18);
            label6.TabIndex = 66;
            label6.Text = "Volver";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // consultaSoporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 549);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(label16);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(txtMsje);
            Controls.Add(label3);
            Controls.Add(txtMotivo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "consultaSoporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "consultaSoporte";
            MouseDown += ConsultaSoporte_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMotivo;
        private Label label3;
        private TextBox txtMsje;
        private Label label4;
        private TextBox txtMail;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label5;
        private Label label16;
        private Button btnCancelar;
        private Button btnVolver;
        private Label label6;
        private ErrorProvider errorProvider1;
    }
}