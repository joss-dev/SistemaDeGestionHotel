namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionDePagos
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
            btnMP = new Button();
            label1 = new Label();
            btnOR = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnMP
            // 
            btnMP.Anchor = AnchorStyles.None;
            btnMP.BackColor = Color.LimeGreen;
            btnMP.FlatAppearance.BorderColor = Color.Black;
            btnMP.FlatStyle = FlatStyle.Popup;
            btnMP.Image = Properties.Resources.medios_de_pago;
            btnMP.Location = new Point(227, 244);
            btnMP.Name = "btnMP";
            btnMP.Size = new Size(120, 86);
            btnMP.TabIndex = 23;
            btnMP.UseVisualStyleBackColor = false;
            btnMP.Click += btnMP_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 345);
            label1.Name = "label1";
            label1.Size = new Size(169, 24);
            label1.TabIndex = 24;
            label1.Text = "Medios de Pago";
            // 
            // btnOR
            // 
            btnOR.Anchor = AnchorStyles.None;
            btnOR.BackColor = Color.DarkTurquoise;
            btnOR.FlatStyle = FlatStyle.Popup;
            btnOR.Image = Properties.Resources.Recargos;
            btnOR.Location = new Point(469, 244);
            btnOR.Name = "btnOR";
            btnOR.Size = new Size(120, 86);
            btnOR.TabIndex = 27;
            btnOR.UseVisualStyleBackColor = false;
            btnOR.Click += btnOR_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(430, 345);
            label3.Name = "label3";
            label3.Size = new Size(199, 24);
            label3.TabIndex = 28;
            label3.Text = "Ofertas - Recargos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.PaleGreen;
            label4.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(134, 102);
            label4.Name = "label4";
            label4.Size = new Size(572, 54);
            label4.TabIndex = 29;
            label4.Text = "Seleccione la opción deseada:";
            // 
            // gestionDePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(798, 488);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnOR);
            Controls.Add(label1);
            Controls.Add(btnMP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionDePagos";
            Text = "gestionPagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMP;
        private Label label1;
        private Button btnOR;
        private Label label3;
        private Label label4;
    }
}