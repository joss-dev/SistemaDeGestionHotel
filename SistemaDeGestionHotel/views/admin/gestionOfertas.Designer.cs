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
            idOfertaRecargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombOfertaRecargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDesdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHastaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            porcentajeDescuentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            porcentajeRecargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ofertasRecargoBindingSource = new BindingSource(components);
            label12 = new Label();
            comboBoxEstado = new ComboBox();
            btnEditar = new Button();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            label11 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnVolver = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            BTNLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ofertasRecargoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 139);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 23;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(194, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 23);
            txtNombre.TabIndex = 24;
            txtNombre.KeyDown += ValidacionNombre;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 216);
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
            label4.Location = new Point(115, 214);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 26;
            label4.Text = "Fecha desde:";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Anchor = AnchorStyles.None;
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            dateTimeInicio.Location = new Point(237, 214);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(95, 23);
            dateTimeInicio.TabIndex = 27;
            dateTimeInicio.ValueChanged += FechaCambia;
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.None;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(462, 216);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 261);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 29;
            label5.Text = "% Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.None;
            txtDescuento.Location = new Point(231, 261);
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
            label6.Location = new Point(533, 141);
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
            label7.Location = new Point(116, 311);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 33;
            label7.Text = "% Recargo:";
            // 
            // txtRecargo
            // 
            txtRecargo.Anchor = AnchorStyles.None;
            txtRecargo.Location = new Point(231, 311);
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
            label8.Location = new Point(113, 178);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 35;
            label8.Text = "Vigencia:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = Color.Gainsboro;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idOfertaRecargoDataGridViewTextBoxColumn, nombOfertaRecargoDataGridViewTextBoxColumn, fechaDesdeDataGridViewTextBoxColumn, fechaHastaDataGridViewTextBoxColumn, porcentajeDescuentoDataGridViewTextBoxColumn, porcentajeRecargoDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dataGridView2.DataSource = ofertasRecargoBindingSource;
            dataGridView2.Location = new Point(70, 395);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(759, 152);
            dataGridView2.TabIndex = 42;
            dataGridView2.CellClick += CargaDatosAlTextBox;
            // 
            // idOfertaRecargoDataGridViewTextBoxColumn
            // 
            idOfertaRecargoDataGridViewTextBoxColumn.DataPropertyName = "IdOfertaRecargo";
            idOfertaRecargoDataGridViewTextBoxColumn.HeaderText = "IdOfertaRecargo";
            idOfertaRecargoDataGridViewTextBoxColumn.Name = "idOfertaRecargoDataGridViewTextBoxColumn";
            idOfertaRecargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombOfertaRecargoDataGridViewTextBoxColumn
            // 
            nombOfertaRecargoDataGridViewTextBoxColumn.DataPropertyName = "NombOfertaRecargo";
            nombOfertaRecargoDataGridViewTextBoxColumn.HeaderText = "NombOfertaRecargo";
            nombOfertaRecargoDataGridViewTextBoxColumn.Name = "nombOfertaRecargoDataGridViewTextBoxColumn";
            nombOfertaRecargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDesdeDataGridViewTextBoxColumn
            // 
            fechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde";
            fechaDesdeDataGridViewTextBoxColumn.HeaderText = "FechaDesde";
            fechaDesdeDataGridViewTextBoxColumn.Name = "fechaDesdeDataGridViewTextBoxColumn";
            fechaDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHastaDataGridViewTextBoxColumn
            // 
            fechaHastaDataGridViewTextBoxColumn.DataPropertyName = "FechaHasta";
            fechaHastaDataGridViewTextBoxColumn.HeaderText = "FechaHasta";
            fechaHastaDataGridViewTextBoxColumn.Name = "fechaHastaDataGridViewTextBoxColumn";
            fechaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeDescuentoDataGridViewTextBoxColumn
            // 
            porcentajeDescuentoDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeDescuento";
            porcentajeDescuentoDataGridViewTextBoxColumn.HeaderText = "PorcentajeDescuento";
            porcentajeDescuentoDataGridViewTextBoxColumn.Name = "porcentajeDescuentoDataGridViewTextBoxColumn";
            porcentajeDescuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeRecargoDataGridViewTextBoxColumn
            // 
            porcentajeRecargoDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeRecargo";
            porcentajeRecargoDataGridViewTextBoxColumn.HeaderText = "PorcentajeRecargo";
            porcentajeRecargoDataGridViewTextBoxColumn.Name = "porcentajeRecargoDataGridViewTextBoxColumn";
            porcentajeRecargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ofertasRecargoBindingSource
            // 
            ofertasRecargoBindingSource.DataSource = typeof(NEntidades.OfertasRecargo);
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = Color.Aquamarine;
            label12.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(231, 40);
            label12.Name = "label12";
            label12.Size = new Size(384, 51);
            label12.TabIndex = 43;
            label12.Text = "Ofertas - Recargos";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.Anchor = AnchorStyles.None;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(607, 140);
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
            btnEditar.Location = new Point(737, 286);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(54, 50);
            btnEditar.TabIndex = 47;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnRegistrar.Location = new Point(661, 286);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(55, 50);
            btnRegistrar.TabIndex = 45;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(743, 339);
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
            label11.Location = new Point(656, 339);
            label11.Name = "label11";
            label11.Size = new Size(67, 17);
            label11.TabIndex = 50;
            label11.Text = "Registrar";
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
            btnVolver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(720, 580);
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
            label2.Location = new Point(725, 633);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 63;
            label2.Text = "Volver";
            // 
            // BTNLimpiar
            // 
            BTNLimpiar.BackColor = Color.DeepSkyBlue;
            BTNLimpiar.FlatStyle = FlatStyle.Popup;
            BTNLimpiar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTNLimpiar.Location = new Point(478, 309);
            BTNLimpiar.Name = "BTNLimpiar";
            BTNLimpiar.Size = new Size(146, 27);
            BTNLimpiar.TabIndex = 65;
            BTNLimpiar.Text = "Limpiar";
            BTNLimpiar.UseVisualStyleBackColor = false;
            BTNLimpiar.Click += BTNLimpiar_Click;
            // 
            // gestionOfertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(873, 711);
            Controls.Add(BTNLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(comboBoxEstado);
            Controls.Add(label12);
            Controls.Add(dataGridView2);
            Controls.Add(label8);
            Controls.Add(txtRecargo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDescuento);
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
            ((System.ComponentModel.ISupportInitialize)ofertasRecargoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNombre;
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
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Label label10;
        private Label label11;
        private ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private BindingSource ofertasRecargoBindingSource;
        private DataGridViewTextBoxColumn idOfertaRecargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombOfertaRecargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn porcentajeDescuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn porcentajeRecargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private Button BTNLimpiar;
    }
}