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
            components = new System.ComponentModel.Container();
            btnVolver = new FontAwesome.Sharp.IconButton();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label8 = new Label();
            textBoxCvv = new TextBox();
            label7 = new Label();
            textBoxTitular = new TextBox();
            label6 = new Label();
            textBoxFechaCad = new TextBox();
            label5 = new Label();
            textBoxNroTarjeta = new TextBox();
            label4 = new Label();
            comboBoxTarjeta = new ComboBox();
            textBoxTotalApagar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProviderNumero = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightCoral;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(12, 515);
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
            btnCobrar.BackColor = Color.SeaGreen;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.ImageAlign = ContentAlignment.TopCenter;
            btnCobrar.Location = new Point(227, 514);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(255, 78);
            btnCobrar.TabIndex = 43;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
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
            groupBox1.Controls.Add(comboBoxTarjeta);
            groupBox1.Controls.Add(textBoxTotalApagar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(115, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 405);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cobrar con tarjeta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 340);
            label8.Name = "label8";
            label8.Size = new Size(40, 16);
            label8.TabIndex = 50;
            label8.Text = "CVV :";
            // 
            // textBoxCvv
            // 
            textBoxCvv.Location = new Point(31, 360);
            textBoxCvv.MaxLength = 3;
            textBoxCvv.Name = "textBoxCvv";
            textBoxCvv.PlaceholderText = "XXX";
            textBoxCvv.Size = new Size(75, 22);
            textBoxCvv.TabIndex = 49;
            textBoxCvv.KeyDown += ValidarCvv;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 278);
            label7.Name = "label7";
            label7.Size = new Size(123, 16);
            label7.TabIndex = 48;
            label7.Text = "Titular de la tarjeta :";
            // 
            // textBoxTitular
            // 
            textBoxTitular.Location = new Point(31, 298);
            textBoxTitular.Name = "textBoxTitular";
            textBoxTitular.Size = new Size(315, 22);
            textBoxTitular.TabIndex = 47;
            textBoxTitular.KeyDown += ValidarTitular;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 221);
            label6.Name = "label6";
            label6.Size = new Size(137, 16);
            label6.TabIndex = 46;
            label6.Text = "Fecha de caducidad :";
            // 
            // textBoxFechaCad
            // 
            textBoxFechaCad.Location = new Point(31, 241);
            textBoxFechaCad.Name = "textBoxFechaCad";
            textBoxFechaCad.PlaceholderText = "MM/AA";
            textBoxFechaCad.Size = new Size(61, 22);
            textBoxFechaCad.TabIndex = 45;
            textBoxFechaCad.KeyDown += ValidarFecha;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 161);
            label5.Name = "label5";
            label5.Size = new Size(100, 16);
            label5.TabIndex = 44;
            label5.Text = "Nro  de tarjeta : ";
            // 
            // textBoxNroTarjeta
            // 
            textBoxNroTarjeta.Location = new Point(30, 181);
            textBoxNroTarjeta.Name = "textBoxNroTarjeta";
            textBoxNroTarjeta.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            textBoxNroTarjeta.Size = new Size(316, 22);
            textBoxNroTarjeta.TabIndex = 43;
            textBoxNroTarjeta.KeyDown += ValidarNroTarjeta;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 103);
            label4.Name = "label4";
            label4.Size = new Size(84, 16);
            label4.TabIndex = 42;
            label4.Text = "Tipo tarjeta : ";
            // 
            // comboBoxTarjeta
            // 
            comboBoxTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBoxTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTarjeta.FormattingEnabled = true;
            comboBoxTarjeta.Items.AddRange(new object[] { "Débito", "Crédito" });
            comboBoxTarjeta.Location = new Point(30, 123);
            comboBoxTarjeta.Name = "comboBoxTarjeta";
            comboBoxTarjeta.Size = new Size(121, 24);
            comboBoxTarjeta.TabIndex = 41;
            // 
            // textBoxTotalApagar
            // 
            textBoxTotalApagar.Enabled = false;
            textBoxTotalApagar.Location = new Point(30, 55);
            textBoxTotalApagar.Name = "textBoxTotalApagar";
            textBoxTotalApagar.ReadOnly = true;
            textBoxTotalApagar.Size = new Size(180, 22);
            textBoxTotalApagar.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 35);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
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
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago con Tarjeta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private ComboBox comboBoxTarjeta;
        private Label label8;
        private TextBox textBoxCvv;
        private Label label7;
        private TextBox textBoxTitular;
        private ErrorProvider errorProviderNumero;
    }
}