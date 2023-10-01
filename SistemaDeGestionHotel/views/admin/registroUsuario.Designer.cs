namespace SistemaDeGestionHotel.views.admin
{
    partial class registroUsuario
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            btnIMG = new Button();
            btnIMGPerfil = new Label();
            btnEditar = new Button();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            label9 = new Label();
            btnAgregar = new Button();
            label10 = new Label();
            label1 = new Label();
            txtCorreoElec = new TextBox();
            label11 = new Label();
            txtDireccion = new TextBox();
            label13 = new Label();
            txtDNI = new TextBox();
            label12 = new Label();
            errorProvider1 = new ErrorProvider(components);
            comboBoxTipoPerfil = new ComboBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(37, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 25;
            txtNombre.KeyDown += ValidacionNombre;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(99, 186);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 26;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Location = new Point(37, 209);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 27;
            txtApellido.KeyDown += ValidacionApellido;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, 170);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 28;
            label3.Text = "Nombre de usuario:";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(313, 194);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(207, 23);
            txtUserName.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(364, 229);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 30;
            label4.Text = "Contraseña:";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Location = new Point(313, 252);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(207, 23);
            txtPass.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 562);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(664, 106);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += CargaTextboxsDelDataGrid;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(121, 531);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 34;
            label5.Text = "Registrar";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(246, 531);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 36;
            label6.Text = "Cancelar";
            // 
            // btnIMG
            // 
            btnIMG.Anchor = AnchorStyles.None;
            btnIMG.BackColor = Color.PaleGreen;
            btnIMG.FlatStyle = FlatStyle.Popup;
            btnIMG.Image = Properties.Resources.img;
            btnIMG.Location = new Point(370, 458);
            btnIMG.Name = "btnIMG";
            btnIMG.Size = new Size(71, 71);
            btnIMG.TabIndex = 37;
            btnIMG.UseVisualStyleBackColor = false;
            // 
            // btnIMGPerfil
            // 
            btnIMGPerfil.Anchor = AnchorStyles.None;
            btnIMGPerfil.AutoSize = true;
            btnIMGPerfil.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIMGPerfil.Location = new Point(353, 530);
            btnIMGPerfil.Name = "btnIMGPerfil";
            btnIMGPerfil.Size = new Size(109, 17);
            btnIMGPerfil.TabIndex = 38;
            btnIMGPerfil.Text = "Imagen de pefil";
            btnIMGPerfil.UseWaitCursor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.PaleGreen;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(499, 458);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 71);
            btnEditar.TabIndex = 39;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(511, 531);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 40;
            label7.Text = "Editar";
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(356, 289);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 41;
            label8.Text = "Tipo de Perfil:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Image = Properties.Resources.img1;
            pictureBox2.Location = new Point(583, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.PaleGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancel1_77976;
            btnCancelar.Location = new Point(245, 459);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 44;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.PaleGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.Location = new Point(620, 458);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(71, 71);
            btnEliminar.TabIndex = 45;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(626, 530);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 46;
            label9.Text = "Eliminar";
            label9.UseWaitCursor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.Location = new Point(120, 459);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(71, 71);
            btnAgregar.TabIndex = 47;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(100, 132);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 24;
            label10.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 303);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 48;
            label1.Text = "Correo electrónico:";
            // 
            // txtCorreoElec
            // 
            txtCorreoElec.Anchor = AnchorStyles.None;
            txtCorreoElec.Location = new Point(37, 327);
            txtCorreoElec.Name = "txtCorreoElec";
            txtCorreoElec.Size = new Size(207, 23);
            txtCorreoElec.TabIndex = 49;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(88, 363);
            label11.Name = "label11";
            label11.Size = new Size(89, 21);
            label11.TabIndex = 50;
            label11.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Location = new Point(37, 387);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(207, 23);
            txtDireccion.TabIndex = 51;
            txtDireccion.KeyDown += ValidarDireccion;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(74, 241);
            label13.Name = "label13";
            label13.Size = new Size(137, 21);
            label13.TabIndex = 53;
            label13.Text = "Documento Nro:";
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.Location = new Point(37, 265);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Solo Números";
            txtDNI.Size = new Size(207, 23);
            txtDNI.TabIndex = 54;
            txtDNI.KeyDown += ValidacionDNI;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = Color.PaleGreen;
            label12.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(206, 41);
            label12.Name = "label12";
            label12.Size = new Size(424, 51);
            label12.TabIndex = 55;
            label12.Text = "Registro de Usuarios";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // comboBoxTipoPerfil
            // 
            comboBoxTipoPerfil.Anchor = AnchorStyles.None;
            comboBoxTipoPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoPerfil.FormattingEnabled = true;
            comboBoxTipoPerfil.Location = new Point(313, 316);
            comboBoxTipoPerfil.Name = "comboBoxTipoPerfil";
            comboBoxTipoPerfil.Size = new Size(203, 23);
            comboBoxTipoPerfil.TabIndex = 56;
            comboBoxTipoPerfil.SelectedIndexChanged += comboBoxTipoPerfil_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.DodgerBlue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(343, 363);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(152, 23);
            btnLimpiar.TabIndex = 57;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // registroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(862, 700);
            Controls.Add(btnLimpiar);
            Controls.Add(comboBoxTipoPerfil);
            Controls.Add(label12);
            Controls.Add(txtDNI);
            Controls.Add(label13);
            Controls.Add(txtDireccion);
            Controls.Add(label11);
            Controls.Add(txtCorreoElec);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnEditar);
            Controls.Add(btnIMGPerfil);
            Controls.Add(btnIMG);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registroUsuario";
            Text = "Registro de Usuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPass;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Button btnIMG;
        private Label btnIMGPerfil;
        private Button btnEditar;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private Button btnCancelar;
        private Button btnEliminar;
        private Label label9;
        private Button btnAgregar;
        private Label label10;
        private Label label1;
        private TextBox txtCorreoElec;
        private Label label11;
        private TextBox txtDireccion;
        private Label label13;
        private TextBox txtDNI;
        private Label label12;
        private ErrorProvider errorProvider1;
        private ComboBox comboBoxTipoPerfil;
        private Button btnLimpiar;
    }
}