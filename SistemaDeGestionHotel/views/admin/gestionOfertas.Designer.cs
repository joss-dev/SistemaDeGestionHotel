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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimeInicio = new DateTimePicker();
            dateTimeFin = new DateTimePicker();
            label5 = new Label();
            txtDescuento = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 116);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(280, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 193);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 23;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 193);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 23);
            txtNombre.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(390, 218);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 25;
            label2.Text = "Buscar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(476, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(258, 270);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 25;
            label3.Text = "Fecha hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 268);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 26;
            label4.Text = "Fecha desde:";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            dateTimeInicio.Location = new Point(149, 268);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(95, 23);
            dateTimeInicio.TabIndex = 27;
            // 
            // dateTimeFin
            // 
            dateTimeFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeFin.Format = DateTimePickerFormat.Short;
            dateTimeFin.Location = new Point(374, 270);
            dateTimeFin.Name = "dateTimeFin";
            dateTimeFin.Size = new Size(95, 23);
            dateTimeFin.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 349);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 29;
            label5.Text = "% Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(149, 347);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(173, 23);
            txtDescuento.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 310);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 31;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 391);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 33;
            label7.Text = "% Recargo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 390);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 232);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 35;
            label8.Text = "Vigencia:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MediumSeaGreen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-8, 468);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(759, 152);
            dataGridView2.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(249, 139);
            label12.Name = "label12";
            label12.Size = new Size(264, 29);
            label12.TabIndex = 43;
            label12.Text = "Ofertas - Recargos";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(149, 310);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 44;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSalmon;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.edit11;
            btnEditar.Location = new Point(519, 363);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(54, 50);
            btnEditar.TabIndex = 47;
            btnEditar.UseVisualStyleBackColor = false;
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
            btnEliminar.Location = new Point(587, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(54, 50);
            btnEliminar.TabIndex = 46;
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnRegistrar.Location = new Point(447, 363);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(55, 50);
            btnRegistrar.TabIndex = 45;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(584, 416);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 52;
            label9.Text = "Eliminar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(525, 416);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 51;
            label10.Text = "Editar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(442, 416);
            label11.Name = "label11";
            label11.Size = new Size(67, 17);
            label11.TabIndex = 50;
            label11.Text = "Registrar";
            // 
            // gestionOfertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(744, 613);
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
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtDescuento);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(dateTimeFin);
            Controls.Add(dateTimeInicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "gestionOfertas";
            Text = "gestionOfertas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeFin;
        private Label label5;
        private TextBox txtDescuento;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
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
    }
}