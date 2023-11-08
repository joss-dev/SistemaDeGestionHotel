namespace SistemaDeGestionHotel.views.recep
{
    partial class RegistrarCliente
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
            groupBox2 = new GroupBox();
            textBoxTelefono = new TextBox();
            label7 = new Label();
            lApellido = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            label5 = new Label();
            TDni = new TextBox();
            label8 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxTelefono);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lApellido);
            groupBox2.Controls.Add(TApellido);
            groupBox2.Controls.Add(TNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TDni);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(85, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(579, 248);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Huesped";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxTelefono.Location = new Point(320, 131);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Solo números";
            textBoxTelefono.Size = new Size(206, 24);
            textBoxTelefono.TabIndex = 38;
            textBoxTelefono.KeyDown += ValidacionTelefono;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(318, 105);
            label7.Name = "label7";
            label7.Size = new Size(74, 18);
            label7.TabIndex = 39;
            label7.Text = "Telefono :";
            // 
            // lApellido
            // 
            lApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lApellido.Location = new Point(48, 37);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(67, 18);
            lApellido.TabIndex = 30;
            lApellido.Text = "Apellido :";
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TApellido.BorderStyle = BorderStyle.FixedSingle;
            TApellido.Location = new Point(48, 60);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(206, 24);
            TApellido.TabIndex = 26;
            TApellido.KeyDown += ValidacionApellido;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TNombre.Location = new Point(320, 61);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(206, 24);
            TNombre.TabIndex = 27;
            TNombre.KeyDown += ValidacionNombre;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(320, 38);
            label5.Name = "label5";
            label5.Size = new Size(70, 18);
            label5.TabIndex = 31;
            label5.Text = "Nombre :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TDni.Location = new Point(48, 131);
            TDni.MaxLength = 8;
            TDni.Name = "TDni";
            TDni.PlaceholderText = "Solo números";
            TDni.Size = new Size(206, 24);
            TDni.TabIndex = 28;
            TDni.KeyDown += ValidacionDni;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(48, 107);
            label8.Name = "label8";
            label8.Size = new Size(41, 18);
            label8.TabIndex = 32;
            label8.Text = "DNI :";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(112, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 79);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegistrar.BackColor = Color.PowderBlue;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Image = Properties.Resources.btn_guardar_;
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(543, 354);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 79);
            btnRegistrar.TabIndex = 34;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 444);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "RegistrarCliente";
            Text = "Registrar Cliente";
            Load += CargarDatos;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox textBoxTelefono;
        private Label label7;
        private Label lApellido;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label label5;
        private TextBox TDni;
        private Label label8;
        private Button btnCancelar;
        private Button btnRegistrar;
        private ErrorProvider errorProvider1;
    }
}