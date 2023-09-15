namespace SistemaDeGestionHotel.views.recep
{
    partial class agregarReserva
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
            TApellido = new TextBox();
            TNombre = new TextBox();
            TDni = new TextBox();
            TCantidadHuespedes = new TextBox();
            lApellido = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimeIngreso = new DateTimePicker();
            label4 = new Label();
            errorProviderNumero = new ErrorProvider(components);
            lTitulo = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            btnGuardarReserva = new FontAwesome.Sharp.IconButton();
            dateTimeSalida = new DateTimePicker();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TApellido.BorderStyle = BorderStyle.FixedSingle;
            TApellido.Location = new Point(206, 182);
            TApellido.MaximumSize = new Size(206, 23);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(206, 23);
            TApellido.TabIndex = 0;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyDown += ValidarApellido;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(206, 222);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(206, 23);
            TNombre.TabIndex = 1;
            TNombre.KeyDown += ValidarNombre;
            // 
            // TDni
            // 
            TDni.Location = new Point(205, 265);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 2;
            TDni.KeyDown += ValidarDni;
            // 
            // TCantidadHuespedes
            // 
            TCantidadHuespedes.Location = new Point(205, 304);
            TCantidadHuespedes.Name = "TCantidadHuespedes";
            TCantidadHuespedes.Size = new Size(206, 23);
            TCantidadHuespedes.TabIndex = 3;
            TCantidadHuespedes.KeyDown += ValidarCantidadHuespedes;
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lApellido.Location = new Point(129, 185);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(67, 20);
            lApellido.TabIndex = 4;
            lApellido.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 222);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 268);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 6;
            label2.Text = "DNI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 307);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad de huespedes";
            // 
            // dateTimeIngreso
            // 
            dateTimeIngreso.Format = DateTimePickerFormat.Short;
            dateTimeIngreso.Location = new Point(232, 351);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(98, 23);
            dateTimeIngreso.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 354);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 9;
            label4.Text = "Fecha de Ingreso";
            label4.Click += label4_Click;
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // lTitulo
            // 
            lTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lTitulo.Location = new Point(188, 77);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(204, 32);
            lTitulo.TabIndex = 12;
            lTitulo.Text = "Registrar Reserva";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.Transparent;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnVolver.IconSize = 40;
            btnVolver.ImageAlign = ContentAlignment.TopCenter;
            btnVolver.Location = new Point(29, 496);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(74, 61);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += iconButton1_Click;
            // 
            // btnGuardarReserva
            // 
            btnGuardarReserva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarReserva.BackColor = Color.Transparent;
            btnGuardarReserva.Cursor = Cursors.Hand;
            btnGuardarReserva.FlatAppearance.BorderSize = 0;
            btnGuardarReserva.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnGuardarReserva.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnGuardarReserva.ForeColor = Color.Black;
            btnGuardarReserva.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardarReserva.IconColor = SystemColors.ActiveCaptionText;
            btnGuardarReserva.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardarReserva.IconSize = 40;
            btnGuardarReserva.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarReserva.Location = new Point(431, 496);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(74, 61);
            btnGuardarReserva.TabIndex = 15;
            btnGuardarReserva.Text = "Registrar";
            btnGuardarReserva.TextAlign = ContentAlignment.BottomCenter;
            btnGuardarReserva.UseVisualStyleBackColor = false;
            // 
            // dateTimeSalida
            // 
            dateTimeSalida.Format = DateTimePickerFormat.Short;
            dateTimeSalida.Location = new Point(232, 380);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(98, 23);
            dateTimeSalida.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(78, 383);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 11;
            label5.Text = "Fecha de Salida";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(159, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 50);
            panel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(73, 19);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // agregarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(532, 564);
            Controls.Add(panel1);
            Controls.Add(lApellido);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardarReserva);
            Controls.Add(TCantidadHuespedes);
            Controls.Add(TDni);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Controls.Add(label3);
            Controls.Add(lTitulo);
            Controls.Add(label4);
            Controls.Add(dateTimeIngreso);
            Controls.Add(dateTimeSalida);
            FormBorderStyle = FormBorderStyle.None;
            Name = "agregarReserva";
            Text = "agregarReserva";
            Load += agregarReserva_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TDni;
        private TextBox TCantidadHuespedes;
        private Label lApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimeIngreso;
        private Label label4;
        private ErrorProvider errorProviderNumero;
        private Label lTitulo;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnGuardarReserva;
        private Label label5;
        private DateTimePicker dateTimeSalida;
        private Panel panel1;
        private Label label6;
    }
}