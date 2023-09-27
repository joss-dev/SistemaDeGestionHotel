namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionMediosPago
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
            label2 = new Label();
            txtNombMP = new TextBox();
            label3 = new Label();
            comboBoxTipoMP = new ComboBox();
            label4 = new Label();
            comboBoxEstadoMP = new ComboBox();
            label5 = new Label();
            txtBuscarMP = new TextBox();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnEditar = new Button();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 116);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(185, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 131);
            label1.Name = "label1";
            label1.Size = new Size(306, 29);
            label1.TabIndex = 22;
            label1.Text = "CRUD Medios de Pago";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 187);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 23;
            label2.Text = "Nombre: ";
            // 
            // txtNombMP
            // 
            txtNombMP.Anchor = AnchorStyles.None;
            txtNombMP.Location = new Point(223, 188);
            txtNombMP.Name = "txtNombMP";
            txtNombMP.Size = new Size(141, 23);
            txtNombMP.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(169, 230);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 25;
            label3.Text = "Tipo: ";
            // 
            // comboBoxTipoMP
            // 
            comboBoxTipoMP.Anchor = AnchorStyles.None;
            comboBoxTipoMP.FormattingEnabled = true;
            comboBoxTipoMP.Location = new Point(223, 231);
            comboBoxTipoMP.Name = "comboBoxTipoMP";
            comboBoxTipoMP.Size = new Size(121, 23);
            comboBoxTipoMP.TabIndex = 26;
            comboBoxTipoMP.SelectedIndexChanged += comboBoxTipoMP_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(150, 273);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 27;
            label4.Text = "Estado: ";
            // 
            // comboBoxEstadoMP
            // 
            comboBoxEstadoMP.Anchor = AnchorStyles.None;
            comboBoxEstadoMP.FormattingEnabled = true;
            comboBoxEstadoMP.Location = new Point(223, 273);
            comboBoxEstadoMP.Name = "comboBoxEstadoMP";
            comboBoxEstadoMP.Size = new Size(121, 23);
            comboBoxEstadoMP.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(433, 209);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 29;
            label5.Text = "Buscar: ";
            // 
            // txtBuscarMP
            // 
            txtBuscarMP.Anchor = AnchorStyles.None;
            txtBuscarMP.Location = new Point(500, 209);
            txtBuscarMP.Name = "txtBuscarMP";
            txtBuscarMP.Size = new Size(141, 23);
            txtBuscarMP.TabIndex = 30;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.BackgroundColor = Color.MediumSeaGreen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(91, 378);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(603, 152);
            dataGridView2.TabIndex = 43;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(588, 357);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 49;
            label9.Text = "Eliminar";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(528, 357);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 48;
            label10.Text = "Editar";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(446, 357);
            label11.Name = "label11";
            label11.Size = new Size(67, 17);
            label11.TabIndex = 45;
            label11.Text = "Registrar";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.LightSalmon;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.edit11;
            btnEditar.Location = new Point(522, 305);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(55, 50);
            btnEditar.TabIndex = 52;
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
            btnEliminar.Location = new Point(590, 305);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(55, 50);
            btnEliminar.TabIndex = 51;
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
            btnRegistrar.Location = new Point(450, 305);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(56, 50);
            btnRegistrar.TabIndex = 50;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // gestionMediosPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(804, 542);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(dataGridView2);
            Controls.Add(txtBuscarMP);
            Controls.Add(label5);
            Controls.Add(comboBoxEstadoMP);
            Controls.Add(label4);
            Controls.Add(comboBoxTipoMP);
            Controls.Add(label3);
            Controls.Add(txtNombMP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionMediosPago";
            Text = "gestionMediosPago";
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
        private Label label2;
        private TextBox txtNombMP;
        private Label label3;
        private ComboBox comboBoxTipoMP;
        private Label label4;
        private ComboBox comboBoxEstadoMP;
        private Label label5;
        private TextBox txtBuscarMP;
        private DataGridView dataGridView2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
    }
}