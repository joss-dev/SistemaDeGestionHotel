namespace SistemaDeGestionHotel.views.admin
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMail = new TextBox();
            txtMotivoConsulta = new TextBox();
            txtMsjeRecibido = new TextBox();
            btnCheck = new Button();
            label5 = new Label();
            label6 = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 33.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(285, 36);
            label1.Name = "label1";
            label1.Size = new Size(239, 52);
            label1.TabIndex = 0;
            label1.Text = "Consultas";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 121);
            label2.Name = "label2";
            label2.Size = new Size(168, 18);
            label2.TabIndex = 1;
            label2.Text = "Correo electrónico: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 184);
            label3.Name = "label3";
            label3.Size = new Size(180, 18);
            label3.TabIndex = 2;
            label3.Text = "Motivo de la consulta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 249);
            label4.Name = "label4";
            label4.Size = new Size(148, 18);
            label4.TabIndex = 3;
            label4.Text = "Mensaje recibido:";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Location = new Point(128, 146);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(342, 23);
            txtMail.TabIndex = 4;
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Anchor = AnchorStyles.None;
            txtMotivoConsulta.Location = new Point(128, 211);
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new Size(342, 23);
            txtMotivoConsulta.TabIndex = 5;
            // 
            // txtMsjeRecibido
            // 
            txtMsjeRecibido.Anchor = AnchorStyles.None;
            txtMsjeRecibido.Location = new Point(128, 277);
            txtMsjeRecibido.Multiline = true;
            txtMsjeRecibido.Name = "txtMsjeRecibido";
            txtMsjeRecibido.Size = new Size(582, 113);
            txtMsjeRecibido.TabIndex = 6;
            txtMsjeRecibido.Text = " ";
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.None;
            btnCheck.BackColor = Color.SteelBlue;
            btnCheck.FlatStyle = FlatStyle.Popup;
            btnCheck.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.Image = (Image)resources.GetObject("btnCheck.Image");
            btnCheck.Location = new Point(285, 412);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(71, 71);
            btnCheck.TabIndex = 7;
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(282, 488);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 8;
            label5.Text = "Resuelto";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(443, 488);
            label6.Name = "label6";
            label6.Size = new Size(59, 18);
            label6.TabIndex = 68;
            label6.Text = "Volver";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(437, 413);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(71, 71);
            btnVolver.TabIndex = 67;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 522);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(btnCheck);
            Controls.Add(txtMsjeRecibido);
            Controls.Add(txtMotivoConsulta);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas";
            MouseDown += Consulta_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMail;
        private TextBox txtMotivoConsulta;
        private TextBox txtMsjeRecibido;
        private Button btnCheck;
        private Label label5;
        private Label label6;
        private Button btnVolver;
    }
}