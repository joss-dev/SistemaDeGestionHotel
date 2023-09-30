namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionOfertas
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
            label1 = new Label();
            txtNombre = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimeInicio = new DateTimePicker();
            dateTimeFin = new DateTimePicker();
            label5 = new Label();
            txtDescuento = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtRecargo = new TextBox();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            label12 = new Label();
            comboBoxEstado = new ComboBox();
            btnEditar = new Button();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnBuscar = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnVolver = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 155);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 23;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(194, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 23);
            txtNombre.TabIndex = 24;
            txtNombre.KeyDown += ValidacionNombre;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(492, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 232);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 25;
            label3.Text = "Fecha hasta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(115, 230);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 26;
            label4.Text = "Fecha desde:";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Anchor = AnchorStyles.None;
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            dateTimeInicio.Location = new Point(237, 230);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(95, 23);
            dateTimeInicio.TabIndex = 27;
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.None;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(462, 232);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 311);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 29;
            label5.Text = "% Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.None;
            txtDescuento.Location = new Point(237, 309);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(173, 23);
            txtDescuento.TabIndex = 30;
            txtDescuento.KeyDown += ValidacionDescuento;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(115, 272);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 31;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(125, 353);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 33;
            label7.Text = "% Recargo:";
            // 
            // txtRecargo
            // 
            txtRecargo.Anchor = AnchorStyles.None;
            txtRecargo.Location = new Point(237, 352);
            txtRecargo.Name = "txtRecargo";
            txtRecargo.Size = new Size(173, 23);
            txtRecargo.TabIndex = 34;
            txtRecargo.KeyDown += ValidacionRecargo;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(113, 194);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 35;
            label8.Text = "Vigencia:";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.BackgroundColor = Color.Gainsboro;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(59, 411);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(759, 152);
            dataGridView2.TabIndex = 42;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = Color.Aquamarine;
            label12.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(231, 48);
            label12.Name = "label12";
            label12.Size = new Size(419, 50);
            label12.TabIndex = 43;
            label12.Text = "Ofertas - Recargos";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.None;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(237, 272);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 44;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.LightSalmon;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.edit11;
            btnEditar.Location = new Point(619, 325);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(54, 50);
            btnEditar.TabIndex = 47;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 36;
            btnEliminar.Location = new Point(687, 325);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(54, 50);
            btnEliminar.TabIndex = 46;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.SpringGreen;
            btnRegistrar.FlatAppearance.BorderColor = Color.White;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Registered;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnRegistrar.Location = new Point(548, 325);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(55, 50);
            btnRegistrar.TabIndex = 45;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(684, 378);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 52;
            label9.Text = "Eliminar";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(625, 378);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 51;
            label10.Text = "Editar";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(543, 378);
            label11.Name = "label11";
            label11.Size = new Size(67, 17);
            label11.TabIndex = 50;
            label11.Text = "Registrar";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.DeepSkyBlue;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(652, 180);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 23);
            btnBuscar.TabIndex = 60;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.Teal;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(756, 325);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(55, 50);
            btnVolver.TabIndex = 64;
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(761, 378);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 63;
            label2.Text = "Volver";
            // 
            // gestionOfertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(873, 613);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(comboBoxEstado);
            Controls.Add(label12);
            Controls.Add(dataGridView2);
            Controls.Add(label8);
            Controls.Add(txtRecargo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDescuento);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(dateTimeFin);
            Controls.Add(dateTimeInicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionOfertas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gestionOfertas";
            Load += gestionOfertas_Load;
            MouseDown += GestioMediosPago_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNombre;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeFin;
        private Label label5;
        private TextBox txtDescuento;
        private Label label6;
        private Label label7;
        private TextBox txtRecargo;
        private Label label8;
        private DataGridView dataGridView2;
        private Label label12;
        private ComboBox comboBoxEstado;
        private Button btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnBuscar;
        private ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Label label2;
    }
}