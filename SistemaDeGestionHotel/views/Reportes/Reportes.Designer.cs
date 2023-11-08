namespace SistemaDeGestionHotel.views.Reportes
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            BTNIngresos = new Button();
            label1 = new Label();
            BTNSituacionHabit = new Button();
            BTNSsAdicionales = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // BTNIngresos
            // 
            BTNIngresos.Anchor = AnchorStyles.None;
            BTNIngresos.BackColor = Color.Salmon;
            BTNIngresos.FlatStyle = FlatStyle.Popup;
            BTNIngresos.Image = (Image)resources.GetObject("BTNIngresos.Image");
            BTNIngresos.Location = new Point(51, 247);
            BTNIngresos.Name = "BTNIngresos";
            BTNIngresos.Size = new Size(88, 77);
            BTNIngresos.TabIndex = 0;
            BTNIngresos.UseVisualStyleBackColor = false;
            BTNIngresos.Click += BTNIngresos_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(280, 81);
            label1.Name = "label1";
            label1.Size = new Size(240, 55);
            label1.TabIndex = 1;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTNSituacionHabit
            // 
            BTNSituacionHabit.Anchor = AnchorStyles.None;
            BTNSituacionHabit.FlatStyle = FlatStyle.Popup;
            BTNSituacionHabit.Image = (Image)resources.GetObject("BTNSituacionHabit.Image");
            BTNSituacionHabit.Location = new Point(337, 248);
            BTNSituacionHabit.Name = "BTNSituacionHabit";
            BTNSituacionHabit.Size = new Size(89, 78);
            BTNSituacionHabit.TabIndex = 2;
            BTNSituacionHabit.UseVisualStyleBackColor = true;
            BTNSituacionHabit.Click += BTNSituacionHabit_Click;
            // 
            // BTNSsAdicionales
            // 
            BTNSsAdicionales.Anchor = AnchorStyles.None;
            BTNSsAdicionales.FlatStyle = FlatStyle.Popup;
            BTNSsAdicionales.Image = (Image)resources.GetObject("BTNSsAdicionales.Image");
            BTNSsAdicionales.Location = new Point(611, 248);
            BTNSsAdicionales.Name = "BTNSsAdicionales";
            BTNSsAdicionales.Size = new Size(89, 78);
            BTNSsAdicionales.TabIndex = 3;
            BTNSsAdicionales.UseVisualStyleBackColor = true;
            BTNSsAdicionales.Click += BTNSsAdicionales_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 190);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 4;
            label2.Text = "Ingresos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(272, 190);
            label3.Name = "label3";
            label3.Size = new Size(233, 24);
            label3.TabIndex = 5;
            label3.Text = "Estados de ocupación";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(546, 190);
            label4.Name = "label4";
            label4.Size = new Size(228, 24);
            label4.TabIndex = 6;
            label4.Text = "Servicios Adicionales";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(592, 212);
            label5.Name = "label5";
            label5.Size = new Size(132, 24);
            label5.TabIndex = 7;
            label5.Text = "contratados";
            label5.Click += label5_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(798, 488);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BTNSsAdicionales);
            Controls.Add(BTNSituacionHabit);
            Controls.Add(label1);
            Controls.Add(BTNIngresos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNIngresos;
        private Label label1;
        private Button BTNSituacionHabit;
        private Button BTNSsAdicionales;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}