namespace SistemaDeGestionHotel.views.recep
{
    partial class registrarServicio
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
            lTitulo2 = new Label();
            LDni = new Label();
            TDni = new TextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lTitulo2.Location = new Point(95, 59);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(392, 45);
            lTitulo2.TabIndex = 19;
            lTitulo2.Text = "Registrar Servicio";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.Location = new Point(41, 167);
            LDni.Name = "LDni";
            LDni.Size = new Size(183, 20);
            LDni.TabIndex = 18;
            LDni.Text = "Ingrese dni del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(230, 168);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 15;
            TDni.KeyDown += ValidarDni;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 21;
            label1.Text = "Servicio a registrar :";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(75, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 48);
            panel1.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Wifi", "Gimnasio", "Limpieza", "Estacionamiento" });
            comboBox1.Location = new Point(157, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(230, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 274);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 29;
            label2.Text = "Descripción :";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(277, 459);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 83);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Image = Properties.Resources.btn_guardar_;
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(159, 459);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 83);
            btnRegistrar.TabIndex = 30;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // registrarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(580, 564);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(lTitulo2);
            Controls.Add(LDni);
            Controls.Add(TDni);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarServicio";
            Text = "registrarServicio";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTitulo2;
        private Label LDni;
        private TextBox TDni;
        private Label label1;
        private ErrorProvider errorProvider;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Button btnCancelar;
        private Button btnRegistrar;
    }
}