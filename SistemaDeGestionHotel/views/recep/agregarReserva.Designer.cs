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
            label5 = new Label();
            dateTimeSalida = new DateTimePicker();
            errorProviderNumero = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            SuspendLayout();
            // 
            // TApellido
            // 
            TApellido.BorderStyle = BorderStyle.FixedSingle;
            TApellido.Location = new Point(176, 96);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(206, 23);
            TApellido.TabIndex = 0;
            TApellido.KeyDown += ValidarApellido;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(176, 139);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(206, 23);
            TNombre.TabIndex = 1;
            TNombre.KeyDown += ValidarNombre;
            // 
            // TDni
            // 
            TDni.Location = new Point(176, 187);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 2;
            TDni.KeyDown += ValidarDni;
            // 
            // TCantidadHuespedes
            // 
            TCantidadHuespedes.Location = new Point(221, 241);
            TCantidadHuespedes.Name = "TCantidadHuespedes";
            TCantidadHuespedes.Size = new Size(206, 23);
            TCantidadHuespedes.TabIndex = 3;
            TCantidadHuespedes.KeyDown += ValidarCantidadHuespedes;
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lApellido.Location = new Point(90, 99);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(67, 20);
            lApellido.TabIndex = 4;
            lApellido.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 142);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 187);
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
            label3.Location = new Point(29, 240);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad de huespedes";
            // 
            // dateTimeIngreso
            // 
            dateTimeIngreso.Format = DateTimePickerFormat.Short;
            dateTimeIngreso.Location = new Point(178, 295);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(98, 23);
            dateTimeIngreso.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 295);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 9;
            label4.Text = "Fecha de Ingreso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 334);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 11;
            label5.Text = "Fecha de Salida";
            // 
            // dateTimeSalida
            // 
            dateTimeSalida.Format = DateTimePickerFormat.Short;
            dateTimeSalida.Location = new Point(178, 338);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(98, 23);
            dateTimeSalida.TabIndex = 10;
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // agregarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(1, 110, 180);
            ClientSize = new Size(580, 564);
            Controls.Add(TCantidadHuespedes);
            Controls.Add(label3);
            Controls.Add(TApellido);
            Controls.Add(label5);
            Controls.Add(TNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeSalida);
            Controls.Add(label4);
            Controls.Add(dateTimeIngreso);
            Controls.Add(TDni);
            Controls.Add(lApellido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "agregarReserva";
            Text = "agregarReserva";
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
        private Label label5;
        private DateTimePicker dateTimeSalida;
        private ErrorProvider errorProviderNumero;
    }
}