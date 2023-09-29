namespace SistemaDeGestionHotel.views.admin
{
    partial class administracionHabitaciones
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtNroHab = new TextBox();
            label2 = new Label();
            txtCantCamas = new TextBox();
            label3 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtPiso = new TextBox();
            btnAgregarHabitac = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnEliminar = new Button();
            btnHabilitarHabitacion = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            btnDeshabHabitacion = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label16 = new Label();
            btnCancelar = new Button();
            label6 = new Label();
            comboBoxTipoHab = new ComboBox();
            comboBoxEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.habitac1;
            pictureBox2.Location = new Point(499, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 190);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 162);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 25;
            label1.Text = "Número de habitación:";
            // 
            // txtNroHab
            // 
            txtNroHab.Anchor = AnchorStyles.None;
            txtNroHab.Location = new Point(290, 161);
            txtNroHab.Name = "txtNroHab";
            txtNroHab.PlaceholderText = "Números sin punto";
            txtNroHab.Size = new Size(137, 23);
            txtNroHab.TabIndex = 26;
            txtNroHab.KeyDown += ValidacionNroHabitacion;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(147, 240);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 27;
            label2.Text = "Cantidad de camas:";
            // 
            // txtCantCamas
            // 
            txtCantCamas.Anchor = AnchorStyles.None;
            txtCantCamas.Location = new Point(290, 238);
            txtCantCamas.Name = "txtCantCamas";
            txtCantCamas.PlaceholderText = "Solo números";
            txtCantCamas.Size = new Size(137, 23);
            txtCantCamas.TabIndex = 28;
            txtCantCamas.KeyDown += ValidacionCantidadCamas;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(232, 363);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 29;
            label3.Text = "Costo:";
            // 
            // txtCosto
            // 
            txtCosto.Anchor = AnchorStyles.None;
            txtCosto.Location = new Point(290, 363);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(137, 23);
            txtCosto.TabIndex = 30;
            txtCosto.KeyDown += ValidacionCosto;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(225, 322);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 31;
            label4.Text = "Estado:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(143, 199);
            label5.Name = "label5";
            label5.Size = new Size(142, 19);
            label5.TabIndex = 33;
            label5.Text = "Tipo de Habitación:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(243, 282);
            label7.Name = "label7";
            label7.Size = new Size(41, 19);
            label7.TabIndex = 37;
            label7.Text = "Piso:";
            // 
            // txtPiso
            // 
            txtPiso.Anchor = AnchorStyles.None;
            txtPiso.Location = new Point(290, 279);
            txtPiso.Name = "txtPiso";
            txtPiso.PlaceholderText = "Solo números";
            txtPiso.Size = new Size(137, 23);
            txtPiso.TabIndex = 38;
            txtPiso.KeyDown += ValidacionPiso;
            // 
            // btnAgregarHabitac
            // 
            btnAgregarHabitac.Anchor = AnchorStyles.None;
            btnAgregarHabitac.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnAgregarHabitac.FlatStyle = FlatStyle.Popup;
            btnAgregarHabitac.Image = Properties.Resources.agregar;
            btnAgregarHabitac.Location = new Point(92, 447);
            btnAgregarHabitac.Name = "btnAgregarHabitac";
            btnAgregarHabitac.Size = new Size(71, 71);
            btnAgregarHabitac.TabIndex = 39;
            btnAgregarHabitac.UseVisualStyleBackColor = true;
            btnAgregarHabitac.Click += btnAgregarHabitac_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(101, 519);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 40;
            label8.Text = "Agregar ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(195, 519);
            label9.Name = "label9";
            label9.Size = new Size(83, 17);
            label9.TabIndex = 42;
            label9.Text = "Deshabilitar";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(434, 520);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 50;
            label10.Text = "Editar";
            label10.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(536, 519);
            label11.Name = "label11";
            label11.Size = new Size(59, 17);
            label11.TabIndex = 52;
            label11.Text = "Eliminar";
            label11.UseWaitCursor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.LightGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.Location = new Point(530, 446);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(71, 71);
            btnEliminar.TabIndex = 51;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnHabilitarHabitacion
            // 
            btnHabilitarHabitacion.Anchor = AnchorStyles.None;
            btnHabilitarHabitacion.FlatStyle = FlatStyle.Popup;
            btnHabilitarHabitacion.Image = Properties.Resources.on;
            btnHabilitarHabitacion.Location = new Point(308, 446);
            btnHabilitarHabitacion.Name = "btnHabilitarHabitacion";
            btnHabilitarHabitacion.Size = new Size(71, 71);
            btnHabilitarHabitacion.TabIndex = 53;
            btnHabilitarHabitacion.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(314, 518);
            label12.Name = "label12";
            label12.Size = new Size(65, 17);
            label12.TabIndex = 54;
            label12.Text = "Habilitar ";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(91, 536);
            label13.Name = "label13";
            label13.Size = new Size(76, 17);
            label13.TabIndex = 55;
            label13.Text = "Habitación";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(199, 535);
            label14.Name = "label14";
            label14.Size = new Size(76, 17);
            label14.TabIndex = 56;
            label14.Text = "Habitación";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(307, 535);
            label15.Name = "label15";
            label15.Size = new Size(76, 17);
            label15.TabIndex = 57;
            label15.Text = "Habitación";
            // 
            // btnDeshabHabitacion
            // 
            btnDeshabHabitacion.Anchor = AnchorStyles.None;
            btnDeshabHabitacion.FlatStyle = FlatStyle.Popup;
            btnDeshabHabitacion.Image = Properties.Resources.off1;
            btnDeshabHabitacion.Location = new Point(200, 446);
            btnDeshabHabitacion.Name = "btnDeshabHabitacion";
            btnDeshabHabitacion.Size = new Size(71, 71);
            btnDeshabHabitacion.TabIndex = 58;
            btnDeshabHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.edit2;
            btnEditar.Location = new Point(420, 447);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 71);
            btnEditar.TabIndex = 59;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 575);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(679, 133);
            dataGridView1.TabIndex = 60;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(644, 520);
            label16.Name = "label16";
            label16.Size = new Size(65, 17);
            label16.TabIndex = 62;
            label16.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(641, 446);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 61;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 58);
            label6.Name = "label6";
            label6.Size = new Size(687, 50);
            label6.TabIndex = 63;
            label6.Text = "Administración de habitaciones";
            // 
            // comboBoxTipoHab
            // 
            comboBoxTipoHab.Anchor = AnchorStyles.None;
            comboBoxTipoHab.FormattingEnabled = true;
            comboBoxTipoHab.Location = new Point(290, 198);
            comboBoxTipoHab.Name = "comboBoxTipoHab";
            comboBoxTipoHab.Size = new Size(137, 23);
            comboBoxTipoHab.TabIndex = 64;
            comboBoxTipoHab.SelectedIndexChanged += comboBoxTipoHab_SelectedIndexChanged;
            comboBoxTipoHab.KeyDown += comboBoxTipoHab_SelectedIndexChanged;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.None;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(289, 322);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(138, 23);
            comboBoxEstado.TabIndex = 65;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            comboBoxEstado.KeyDown += comboBoxEstado_SelectedIndexChanged;
            // 
            // administracionHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(799, 749);
            Controls.Add(comboBoxEstado);
            Controls.Add(comboBoxTipoHab);
            Controls.Add(label6);
            Controls.Add(label16);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditar);
            Controls.Add(btnDeshabHabitacion);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnHabilitarHabitacion);
            Controls.Add(label11);
            Controls.Add(btnEliminar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnAgregarHabitac);
            Controls.Add(txtPiso);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtCantCamas);
            Controls.Add(label2);
            Controls.Add(txtNroHab);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "administracionHabitaciones";
            Text = "administracionHabitaciones";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtNroHab;
        private Label label2;
        private TextBox txtCantCamas;
        private Label label3;
        private TextBox txtCosto;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtPiso;
        private Button btnAgregarHabitac;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnEliminar;
        private Button btnHabilitarHabitacion;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btnDeshabHabitacion;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private Label label16;
        private Button btnCancelar;
        private Label label6;
        private ComboBox comboBoxTipoHab;
        private ComboBox comboBoxEstado;
    }
}