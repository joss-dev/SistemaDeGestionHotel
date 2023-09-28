namespace SistemaDeGestionHotel.views.recep
{
    partial class gestionPagos
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
            lTitulo2 = new Label();
            LDni = new Label();
            TDni = new TextBox();
            btnCobrar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dataGridViewFactura = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            Impuestos = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SUBTOTAL = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            errorProviderNumero = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.None;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lTitulo2.Location = new Point(603, 123);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(271, 35);
            lTitulo2.TabIndex = 20;
            lTitulo2.Text = "Registrar Pagos";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.Location = new Point(24, 118);
            LDni.Name = "LDni";
            LDni.Size = new Size(196, 20);
            LDni.TabIndex = 22;
            LDni.Text = "Ingrese D.N.I del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(24, 141);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 21;
            TDni.KeyDown += ValidacionDni;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = Color.DarkTurquoise;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.ImageAlign = ContentAlignment.TopCenter;
            btnCobrar.Location = new Point(804, 610);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(98, 78);
            btnCobrar.TabIndex = 23;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Location = new Point(236, 138);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(85, 31);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 35);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 28;
            label3.Text = "Nombre : ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(323, 35);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 29;
            label4.Text = "Apellido :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 70);
            label5.Name = "label5";
            label5.Size = new Size(45, 18);
            label5.TabIndex = 30;
            label5.Text = "Dni : ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(323, 70);
            label6.Name = "label6";
            label6.Size = new Size(144, 18);
            label6.TabIndex = 31;
            label6.Text = "Fecha de Ingreso :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 103);
            label7.Name = "label7";
            label7.Size = new Size(96, 18);
            label7.TabIndex = 32;
            label7.Text = "Habitación :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(323, 103);
            label8.Name = "label8";
            label8.Size = new Size(190, 18);
            label8.TabIndex = 33;
            label8.Text = "Cantidad de Huespedes :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 133);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Huesped";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(587, 70);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 35;
            label2.Text = "Fecha de Salida :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(587, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 34;
            label1.Text = "Telefono :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dataGridViewFactura);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(856, 290);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Factura";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(323, 261);
            label16.Name = "label16";
            label16.Size = new Size(80, 18);
            label16.TabIndex = 43;
            label16.Text = "TOTAL : $ ";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(75, 261);
            label15.Name = "label15";
            label15.Size = new Size(94, 18);
            label15.TabIndex = 42;
            label15.Text = "SubTotal : $";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(323, 101);
            label14.Name = "label14";
            label14.Size = new Size(159, 18);
            label14.TabIndex = 41;
            label14.Text = "Servicios Utilizados :";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(75, 122);
            label13.Name = "label13";
            label13.Size = new Size(80, 18);
            label13.TabIndex = 40;
            label13.Text = "Monto : $ ";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(587, 29);
            label12.Name = "label12";
            label12.Size = new Size(180, 18);
            label12.TabIndex = 39;
            label12.Text = "Cant. de habitaciones : ";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(323, 29);
            label11.Name = "label11";
            label11.Size = new Size(134, 18);
            label11.TabIndex = 38;
            label11.Text = "Tipo Habitación : ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(75, 71);
            label10.Name = "label10";
            label10.Size = new Size(117, 18);
            label10.TabIndex = 37;
            label10.Text = "Cant. de dias : ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(75, 29);
            label9.Name = "label9";
            label9.Size = new Size(100, 18);
            label9.TabIndex = 36;
            label9.Text = "Habitación : ";
            // 
            // dataGridViewFactura
            // 
            dataGridViewFactura.AllowUserToAddRows = false;
            dataGridViewFactura.AllowUserToDeleteRows = false;
            dataGridViewFactura.AllowUserToOrderColumns = true;
            dataGridViewFactura.Anchor = AnchorStyles.None;
            dataGridViewFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFactura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFactura.Columns.AddRange(new DataGridViewColumn[] { Servicio, Impuestos, Precio, SUBTOTAL });
            dataGridViewFactura.Location = new Point(323, 119);
            dataGridViewFactura.Name = "dataGridViewFactura";
            dataGridViewFactura.ReadOnly = true;
            dataGridViewFactura.RowTemplate.Height = 25;
            dataGridViewFactura.Size = new Size(511, 93);
            dataGridViewFactura.TabIndex = 35;
            dataGridViewFactura.CellContentClick += dataGridViewFactura_CellContentClick;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Servicio";
            Servicio.Name = "Servicio";
            Servicio.ReadOnly = true;
            // 
            // Impuestos
            // 
            Impuestos.HeaderText = "Impuestos";
            Impuestos.Name = "Impuestos";
            Impuestos.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // SUBTOTAL
            // 
            SUBTOTAL.HeaderText = "SUBTOTAL";
            SUBTOTAL.Name = "SUBTOTAL";
            SUBTOTAL.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(12, 610);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 78);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 79, 193);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 86);
            panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(375, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // gestionPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(914, 695);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCobrar);
            Controls.Add(LDni);
            Controls.Add(TDni);
            Controls.Add(lTitulo2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionPagos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTitulo2;
        private Label LDni;
        private TextBox TDni;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private Button btnBuscar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewFactura;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private ErrorProvider errorProviderNumero;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Impuestos;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SUBTOTAL;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label label14;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}