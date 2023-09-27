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
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            btnCancelar = new Button();
            btnEliminar = new Button();
            label9 = new Label();
            label10 = new Label();
            btnAgregar = new Button();
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
            panel1.Size = new Size(664, 116);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(255, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 184);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 26;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(88, 207);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(207, 23);
            txtApellido.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(108, 241);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 28;
            label3.Text = "Nombre de usuario:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(88, 263);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(207, 23);
            txtUserName.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(137, 296);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 30;
            label4.Text = "Contraseña:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(88, 317);
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
            dataGridView1.Size = new Size(664, 164);
            dataGridView1.TabIndex = 32;
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
            // btnIMG
            // 
            btnIMG.BackColor = Color.PaleGreen;
            btnIMG.FlatStyle = FlatStyle.Popup;
            btnIMG.Image = Properties.Resources.img;
            btnIMG.Location = new Point(292, 439);
            btnIMG.Name = "btnIMG";
            btnIMG.Size = new Size(71, 71);
            btnIMG.TabIndex = 37;
            btnIMG.UseVisualStyleBackColor = false;
            btnIMG.Click += button3_Click;
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
            btnEditar.BackColor = Color.PaleGreen;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(421, 439);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 71);
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
            label8.Location = new Point(130, 353);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 41;
            label8.Text = "Tipo de Perfil:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox2.Image = Properties.Resources.img1;
            pictureBox2.Location = new Point(364, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.PaleGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancel1_77976;
            btnCancelar.Location = new Point(167, 440);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 44;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.PaleGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.Location = new Point(542, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(71, 71);
            btnEliminar.TabIndex = 45;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(548, 511);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 46;
            label9.Text = "Eliminar";
            label9.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(151, 132);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 24;
            label10.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.Location = new Point(42, 440);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(71, 71);
            btnAgregar.TabIndex = 47;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // registroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(660, 700);
            Controls.Add(btnAgregar);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button btnCancelar;
        private Button btnEliminar;
        private Label label9;
        private Label label10;
        private Button btnAgregar;
    }
}