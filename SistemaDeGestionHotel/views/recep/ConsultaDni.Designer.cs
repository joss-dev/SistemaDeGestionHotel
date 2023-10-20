namespace SistemaDeGestionHotel.views.recep
{
    partial class ConsultaDni
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
            TDni = new TextBox();
            label8 = new Label();
            btnBuscar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(162, 90);
            TDni.MaxLength = 8;
            TDni.Name = "TDni";
            TDni.PlaceholderText = "Solo números";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 33;
            TDni.KeyDown += ValidarDni;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(174, 56);
            label8.Name = "label8";
            label8.Size = new Size(194, 18);
            label8.TabIndex = 34;
            label8.Text = "Ingrese el DNI del Huesped :";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(209, 133);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 38);
            btnBuscar.TabIndex = 35;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ConsultaDni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(573, 226);
            Controls.Add(btnBuscar);
            Controls.Add(TDni);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConsultaDni";
            Text = "ConsultaDni";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TDni;
        private Label label8;
        private Button btnBuscar;
        private ErrorProvider errorProvider1;
    }
}