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
            errorProvider = new ErrorProvider(components);
            btnCancelar = new Button();
            btnRegistrar = new Button();
            groupBox1 = new GroupBox();
            labelPrecio = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxServicios = new ComboBox();
            TDni = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lTitulo2.Location = new Point(282, 9);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(293, 39);
            lTitulo2.TabIndex = 19;
            lTitulo2.Text = "Registrar Servicio";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(117, 497);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 83);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom;
            btnRegistrar.BackColor = Color.PowderBlue;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Image = Properties.Resources.btn_guardar_;
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(606, 497);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 83);
            btnRegistrar.TabIndex = 30;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(labelPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxServicios);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(42, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 222);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servicios Adicionales";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(469, 109);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(0, 20);
            labelPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 109);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio : $";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 78);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo servicio: ";
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(136, 105);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(121, 28);
            comboBoxServicios.TabIndex = 0;
            comboBoxServicios.SelectedIndexChanged += CargaPrecio;
            // 
            // TDni
            // 
            TDni.Location = new Point(42, 95);
            TDni.MaxLength = 8;
            TDni.Name = "TDni";
            TDni.PlaceholderText = "Solo números";
            TDni.Size = new Size(214, 23);
            TDni.TabIndex = 37;
            TDni.KeyDown += ValidarDni;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(42, 65);
            label8.Name = "label8";
            label8.Size = new Size(194, 18);
            label8.TabIndex = 38;
            label8.Text = "Ingrese el DNI del Huesped :";
            // 
            // registrarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(857, 613);
            Controls.Add(TDni);
            Controls.Add(label8);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lTitulo2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarServicio";
            Text = "Registrar Servicio";
            Load += CargaDatos;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTitulo2;
        private ErrorProvider errorProvider;
        private Button btnCancelar;
        private Button btnRegistrar;
        private GroupBox groupBox1;
        private TextBox TDni;
        private Label label8;
        private Label label1;
        private ComboBox comboBoxServicios;
        private Label label2;
        private Label labelPrecio;
    }
}