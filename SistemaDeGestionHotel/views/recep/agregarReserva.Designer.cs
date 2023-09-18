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
            dateTimeSalida = new DateTimePicker();
            label5 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            SuspendLayout();
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            TNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TNombre.Location = new Point(206, 222);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(206, 23);
            TNombre.TabIndex = 1;
            TNombre.KeyDown += ValidarNombre;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(205, 265);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 2;
            TDni.KeyDown += ValidarDni;
            // 
            // TCantidadHuespedes
            // 
            TCantidadHuespedes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TCantidadHuespedes.Location = new Point(205, 304);
            TCantidadHuespedes.Name = "TCantidadHuespedes";
            TCantidadHuespedes.Size = new Size(206, 23);
            TCantidadHuespedes.TabIndex = 3;
            TCantidadHuespedes.KeyDown += ValidarCantidadHuespedes;
            // 
            // lApellido
            // 
            lApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            dateTimeIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeIngreso.Format = DateTimePickerFormat.Short;
            dateTimeIngreso.Location = new Point(232, 351);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(98, 23);
            dateTimeIngreso.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            // dateTimeSalida
            // 
            dateTimeSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeSalida.Format = DateTimePickerFormat.Short;
            dateTimeSalida.Location = new Point(232, 398);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(98, 23);
            dateTimeSalida.TabIndex = 10;
            dateTimeSalida.ValueChanged += dateTimeSalida_ValueChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(78, 401);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 11;
            label5.Text = "Fecha de Salida";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(532, 0);
            flowLayoutPanel3.TabIndex = 19;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Image = Properties.Resources.btn_guardar_;
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(129, 462);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 83);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(247, 462);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 83);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(78, 87);
            label6.Name = "label6";
            label6.Size = new Size(394, 45);
            label6.TabIndex = 22;
            label6.Text = "Registrar Reserva";
            // 
            // agregarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(532, 564);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lApellido);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(label1);
            Controls.Add(TCantidadHuespedes);
            Controls.Add(TDni);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dateTimeIngreso);
            Controls.Add(dateTimeSalida);
            Controls.Add(flowLayoutPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "agregarReserva";
            Text = "agregarReserva";
            Load += agregarReserva_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
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
        private Label label5;
        private DateTimePicker dateTimeSalida;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label label6;
    }
}