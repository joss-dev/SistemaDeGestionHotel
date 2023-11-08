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
            BtnResuelto = new Button();
            label5 = new Label();
            label6 = new Label();
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 33.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(377, 37);
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
            label2.Location = new Point(190, 122);
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
            label3.Location = new Point(190, 185);
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
            label4.Location = new Point(190, 250);
            label4.Name = "label4";
            label4.Size = new Size(148, 18);
            label4.TabIndex = 3;
            label4.Text = "Mensaje recibido:";
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Location = new Point(220, 147);
            txtMail.Name = "txtMail";
            txtMail.ReadOnly = true;
            txtMail.Size = new Size(342, 23);
            txtMail.TabIndex = 4;
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Anchor = AnchorStyles.None;
            txtMotivoConsulta.Location = new Point(220, 212);
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.ReadOnly = true;
            txtMotivoConsulta.Size = new Size(342, 23);
            txtMotivoConsulta.TabIndex = 5;
            // 
            // txtMsjeRecibido
            // 
            txtMsjeRecibido.Anchor = AnchorStyles.None;
            txtMsjeRecibido.Location = new Point(220, 278);
            txtMsjeRecibido.Multiline = true;
            txtMsjeRecibido.Name = "txtMsjeRecibido";
            txtMsjeRecibido.ReadOnly = true;
            txtMsjeRecibido.Size = new Size(582, 113);
            txtMsjeRecibido.TabIndex = 6;
            txtMsjeRecibido.Text = " ";
            // 
            // BtnResuelto
            // 
            BtnResuelto.Anchor = AnchorStyles.None;
            BtnResuelto.BackColor = Color.SteelBlue;
            BtnResuelto.FlatStyle = FlatStyle.Popup;
            BtnResuelto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnResuelto.Image = (Image)resources.GetObject("BtnResuelto.Image");
            BtnResuelto.Location = new Point(377, 667);
            BtnResuelto.Name = "BtnResuelto";
            BtnResuelto.Size = new Size(71, 71);
            BtnResuelto.TabIndex = 7;
            BtnResuelto.UseVisualStyleBackColor = false;
            BtnResuelto.Click += BtnResuelto_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(374, 743);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Resuelto";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(535, 743);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 68;
            label6.Text = "Volver";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(529, 668);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(71, 71);
            btnVolver.TabIndex = 67;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(904, 203);
            dataGridView1.TabIndex = 69;
            dataGridView1.CellClick += CargaDatosAlTextBox;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(984, 788);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(BtnResuelto);
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
            Load += CargarDatos;
            MouseDown += Consulta_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button BtnResuelto;
        private Label label5;
        private Label label6;
        private Button btnVolver;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}