namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionImpuestos
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
            impuesto = new Label();
            nombImp = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombImp = new TextBox();
            txtAlicuota = new TextBox();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            txtBuscar = new TextBox();
            dateTimeInicio = new DateTimePicker();
            comboBoxTipoImp = new ComboBox();
            comboBoxEstado = new ComboBox();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // impuesto
            // 
            impuesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            impuesto.AutoSize = true;
            impuesto.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            impuesto.ForeColor = SystemColors.Desktop;
            impuesto.Location = new Point(223, 126);
            impuesto.Name = "impuesto";
            impuesto.Size = new Size(329, 29);
            impuesto.TabIndex = 0;
            impuesto.Text = "Información Impositiva";
            impuesto.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombImp
            // 
            nombImp.AutoSize = true;
            nombImp.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nombImp.Location = new Point(38, 188);
            nombImp.Name = "nombImp";
            nombImp.Size = new Size(116, 21);
            nombImp.TabIndex = 1;
            nombImp.Text = "Nombre Imp.:";
            nombImp.Click += nombImp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 228);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Imp.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(75, 270);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Alícuota:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(383, 228);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 4;
            label4.Text = "Entrada en vigencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(483, 265);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 5;
            label5.Text = "Estado:";
            // 
            // txtNombImp
            // 
            txtNombImp.Location = new Point(160, 188);
            txtNombImp.Name = "txtNombImp";
            txtNombImp.Size = new Size(195, 23);
            txtNombImp.TabIndex = 7;
            // 
            // txtAlicuota
            // 
            txtAlicuota.Location = new Point(160, 270);
            txtAlicuota.Name = "txtAlicuota";
            txtAlicuota.Size = new Size(104, 23);
            txtAlicuota.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SpringGreen;
            btnRegistrar.FlatAppearance.BorderColor = Color.White;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Registered;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnRegistrar.Location = new Point(467, 322);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(56, 50);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(462, 376);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 13;
            label1.Text = "Registrar";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 36;
            btnEliminar.Location = new Point(607, 322);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(55, 50);
            btnEliminar.TabIndex = 15;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(545, 375);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 16;
            label6.Text = "Editar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(605, 375);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 17;
            label7.Text = "Eliminar";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 411);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(767, 138);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(276, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 116);
            panel1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(534, 175);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 21;
            label8.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(608, 175);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(132, 23);
            txtBuscar.TabIndex = 22;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            dateTimeInicio.Location = new Point(558, 228);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(95, 23);
            dateTimeInicio.TabIndex = 28;
            // 
            // comboBoxTipoImp
            // 
            comboBoxTipoImp.FormattingEnabled = true;
            comboBoxTipoImp.Location = new Point(160, 229);
            comboBoxTipoImp.Name = "comboBoxTipoImp";
            comboBoxTipoImp.Size = new Size(121, 23);
            comboBoxTipoImp.TabIndex = 29;
            comboBoxTipoImp.SelectedIndexChanged += comboBoxTipoImp_SelectedIndexChanged;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(558, 263);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 30;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSalmon;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.edit11;
            btnEditar.Location = new Point(539, 322);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(55, 50);
            btnEditar.TabIndex = 31;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // gestionImpuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(757, 547);
            Controls.Add(btnEditar);
            Controls.Add(comboBoxEstado);
            Controls.Add(comboBoxTipoImp);
            Controls.Add(dateTimeInicio);
            Controls.Add(txtBuscar);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(txtAlicuota);
            Controls.Add(txtNombImp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nombImp);
            Controls.Add(impuesto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionImpuestos";
            Text = "Gestión de Impuestos";
            Load += gestionImpuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label impuesto;
        private Label nombImp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombImp;
        private TextBox txtAlicuota;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label8;
        private TextBox txtBuscar;
        private DateTimePicker dateTimeInicio;
        private ComboBox comboBoxTipoImp;
        private ComboBox comboBoxEstado;
        private Button btnEditar;
    }
}