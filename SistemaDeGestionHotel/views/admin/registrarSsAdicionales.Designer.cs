namespace SistemaDeGestionHotel.views.admin
{
    partial class registrarSsAdicionales
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
            txtNombSs = new TextBox();
            label4 = new Label();
            txtPrecioTotal = new TextBox();
            label7 = new Label();
            btnEditar = new Button();
            label6 = new Label();
            btnCancelar = new Button();
            label5 = new Label();
            btnRegistrar = new Button();
            pictureBoxSsAdic = new PictureBox();
            dataGridView1 = new DataGridView();
            idServicioAdic = new DataGridViewTextBoxColumn();
            NombServicio = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviciosAdicionaleBindingSource = new BindingSource(components);
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnDeshabHabitacion = new Button();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            btnHabilitarHabitacion = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSsAdic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviciosAdicionaleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 131);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 23;
            label1.Text = "Nombre del Servicio:";
            // 
            // txtNombSs
            // 
            txtNombSs.Anchor = AnchorStyles.None;
            txtNombSs.Location = new Point(165, 152);
            txtNombSs.Name = "txtNombSs";
            txtNombSs.Size = new Size(203, 23);
            txtNombSs.TabIndex = 24;
            txtNombSs.KeyDown += ValidacionNombreSs;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(163, 194);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 29;
            label4.Text = "Precio total:";
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Anchor = AnchorStyles.None;
            txtPrecioTotal.Location = new Point(163, 216);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(203, 23);
            txtPrecioTotal.TabIndex = 30;
            txtPrecioTotal.KeyDown += ValidacionCosto;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(371, 403);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 48;
            label7.Text = "Editar";
            label7.UseWaitCursor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.LightGreen;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(357, 330);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 72);
            btnEditar.TabIndex = 47;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(241, 404);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 44;
            label6.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(237, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 43;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(117, 404);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 42;
            label5.Text = "Registrar";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.LightGreen;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Image = Properties.Resources.registrar;
            btnRegistrar.Location = new Point(115, 330);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(71, 71);
            btnRegistrar.TabIndex = 41;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBoxSsAdic
            // 
            pictureBoxSsAdic.Anchor = AnchorStyles.None;
            pictureBoxSsAdic.Image = Properties.Resources.servicios_adicionales_hotel1;
            pictureBoxSsAdic.Location = new Point(411, 101);
            pictureBoxSsAdic.Name = "pictureBoxSsAdic";
            pictureBoxSsAdic.Size = new Size(181, 180);
            pictureBoxSsAdic.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSsAdic.TabIndex = 49;
            pictureBoxSsAdic.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idServicioAdic, NombServicio, Precio, estadoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = serviciosAdicionaleBindingSource;
            dataGridView1.Location = new Point(102, 457);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(563, 203);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += CargarDataGrid;
            // 
            // idServicioAdic
            // 
            idServicioAdic.DataPropertyName = "IdServicioAdic";
            idServicioAdic.HeaderText = "Id Servicio";
            idServicioAdic.Name = "idServicioAdic";
            idServicioAdic.ReadOnly = true;
            // 
            // NombServicio
            // 
            NombServicio.DataPropertyName = "NombServicio";
            NombServicio.HeaderText = "Nombre Servicio";
            NombServicio.Name = "NombServicio";
            NombServicio.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviciosAdicionaleBindingSource
            // 
            serviciosAdicionaleBindingSource.DataSource = typeof(NEntidades.ServiciosAdicionale);
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.LightGreen;
            label8.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(72, 18);
            label8.Name = "label8";
            label8.Size = new Size(730, 50);
            label8.TabIndex = 51;
            label8.Text = "Registro de Servicios Adicionales";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnDeshabHabitacion
            // 
            btnDeshabHabitacion.Anchor = AnchorStyles.None;
            btnDeshabHabitacion.FlatStyle = FlatStyle.Popup;
            btnDeshabHabitacion.Image = Properties.Resources.off1;
            btnDeshabHabitacion.Location = new Point(469, 331);
            btnDeshabHabitacion.Name = "btnDeshabHabitacion";
            btnDeshabHabitacion.Size = new Size(71, 71);
            btnDeshabHabitacion.TabIndex = 64;
            btnDeshabHabitacion.UseVisualStyleBackColor = true;
            btnDeshabHabitacion.Click += btnDeshabHabitacion_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(583, 420);
            label15.Name = "label15";
            label15.Size = new Size(58, 17);
            label15.TabIndex = 63;
            label15.Text = "Servicio";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(476, 421);
            label14.Name = "label14";
            label14.Size = new Size(58, 17);
            label14.TabIndex = 62;
            label14.Text = "Servicio";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(583, 403);
            label12.Name = "label12";
            label12.Size = new Size(65, 17);
            label12.TabIndex = 61;
            label12.Text = "Habilitar ";
            // 
            // btnHabilitarHabitacion
            // 
            btnHabilitarHabitacion.Anchor = AnchorStyles.None;
            btnHabilitarHabitacion.FlatStyle = FlatStyle.Popup;
            btnHabilitarHabitacion.Image = Properties.Resources.on;
            btnHabilitarHabitacion.Location = new Point(577, 331);
            btnHabilitarHabitacion.Name = "btnHabilitarHabitacion";
            btnHabilitarHabitacion.Size = new Size(71, 71);
            btnHabilitarHabitacion.TabIndex = 60;
            btnHabilitarHabitacion.UseVisualStyleBackColor = true;
            btnHabilitarHabitacion.Click += btnHabilitarHabitacion_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(464, 404);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 59;
            label3.Text = "Deshabilitar";
            // 
            // registrarSsAdicionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(851, 646);
            Controls.Add(btnDeshabHabitacion);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(btnHabilitarHabitacion);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxSsAdic);
            Controls.Add(label7);
            Controls.Add(btnEditar);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecioTotal);
            Controls.Add(label4);
            Controls.Add(txtNombSs);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarSsAdicionales";
            Text = "Registro de Servicios  Adicionales";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSsAdic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviciosAdicionaleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNombSs;
        private Label label4;
        private TextBox txtPrecioTotal;
        private Label label7;
        private Button btnEditar;
        private Label label6;
        private Button btnCancelar;
        private Label label5;
        private Button btnRegistrar;
        private PictureBox pictureBoxSsAdic;
        private DataGridView dataGridView1;
        private Label label8;
        private ErrorProvider errorProvider1;
        private BindingSource serviciosAdicionaleBindingSource;
        private Button btnDeshabHabitacion;
        private Label label15;
        private Label label14;
        private Label label12;
        private Button btnHabilitarHabitacion;
        private Label label3;
        private DataGridViewTextBoxColumn idServicioAdic;
        private DataGridViewTextBoxColumn NombServicio;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}