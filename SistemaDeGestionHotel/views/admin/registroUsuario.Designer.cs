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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            dataGridView1 = new DataGridView();
            btnRegistrar = new Button();
            label5 = new Label();
            btnCancelar = new Button();
            label6 = new Label();
            button3 = new Button();
            btnIMGPerfil = new Label();
            btnEditar = new Button();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 116);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(192, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 132);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 24;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(95, 184);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 26;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(36, 207);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 241);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 28;
            label3.Text = "Nombre de usuario:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(36, 262);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(207, 23);
            txtUserName.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 295);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 30;
            label4.Text = "Contraseña:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(36, 317);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(207, 23);
            txtPass.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 548);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(539, 164);
            dataGridView1.TabIndex = 32;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DeepSkyBlue;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Image = Properties.Resources.registrar;
            btnRegistrar.Location = new Point(43, 438);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(71, 71);
            btnRegistrar.TabIndex = 33;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 512);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 34;
            label5.Text = "Registrar";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(165, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 35;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(168, 512);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 36;
            label6.Text = "Cancelar";
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = Properties.Resources.img;
            button3.Location = new Point(292, 439);
            button3.Name = "button3";
            button3.Size = new Size(71, 71);
            button3.TabIndex = 37;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnIMGPerfil
            // 
            btnIMGPerfil.AutoSize = true;
            btnIMGPerfil.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIMGPerfil.Location = new Point(275, 511);
            btnIMGPerfil.Name = "btnIMGPerfil";
            btnIMGPerfil.Size = new Size(109, 17);
            btnIMGPerfil.TabIndex = 38;
            btnIMGPerfil.Text = "Imagen de pefil";
            btnIMGPerfil.UseWaitCursor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.PowderBlue;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(421, 439);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 72);
            btnEditar.TabIndex = 39;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(433, 512);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 40;
            label7.Text = "Editar";
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(77, 353);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 41;
            label8.Text = "Tipo de Perfil:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkTurquoise;
            pictureBox2.Image = Properties.Resources.img1;
            pictureBox2.Location = new Point(303, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // registroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(540, 700);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnEditar);
            Controls.Add(btnIMGPerfil);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridView1);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "registroUsuario";
            Text = "Registro de Usuario";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPass;
        private DataGridView dataGridView1;
        private Button btnRegistrar;
        private Label label5;
        private Button btnCancelar;
        private Label label6;
        private Button button3;
        private Label btnIMGPerfil;
        private Button btnEditar;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}