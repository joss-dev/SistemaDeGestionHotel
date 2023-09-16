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
            btnGuardarReserva = new FontAwesome.Sharp.IconButton();
            btnVolver = new FontAwesome.Sharp.IconButton();
            errorProvider = new ErrorProvider(components);
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lTitulo2.Location = new Point(175, 48);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(203, 32);
            lTitulo2.TabIndex = 19;
            lTitulo2.Text = "Registrar Servicio";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.Location = new Point(44, 99);
            LDni.Name = "LDni";
            LDni.Size = new Size(183, 20);
            LDni.TabIndex = 18;
            LDni.Text = "Ingrese dni del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(233, 100);
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
            // btnGuardarReserva
            // 
            btnGuardarReserva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarReserva.BackColor = Color.Transparent;
            btnGuardarReserva.Cursor = Cursors.Hand;
            btnGuardarReserva.FlatAppearance.BorderSize = 0;
            btnGuardarReserva.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnGuardarReserva.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnGuardarReserva.ForeColor = Color.Black;
            btnGuardarReserva.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardarReserva.IconColor = SystemColors.ActiveCaptionText;
            btnGuardarReserva.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardarReserva.IconSize = 40;
            btnGuardarReserva.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarReserva.Location = new Point(476, 491);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(74, 61);
            btnGuardarReserva.TabIndex = 26;
            btnGuardarReserva.Text = "Registrar";
            btnGuardarReserva.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarReserva.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.Transparent;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnVolver.IconSize = 40;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(26, 491);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(74, 61);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(78, 146);
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
            textBox1.Location = new Point(233, 207);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 86);
            textBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 206);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 29;
            label2.Text = "Descripción :";
            // 
            // registrarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(580, 564);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(btnGuardarReserva);
            Controls.Add(btnVolver);
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
        private FontAwesome.Sharp.IconButton btnGuardarReserva;
        private FontAwesome.Sharp.IconButton btnVolver;
        private ErrorProvider errorProvider;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
    }
}