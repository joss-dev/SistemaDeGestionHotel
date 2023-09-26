﻿namespace SistemaDeGestionHotel.views.recep
{
    partial class AgregarHuesped
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            lApellido = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            label5 = new Label();
            TCantidadHuespedes = new TextBox();
            TDni = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimeIngreso = new DateTimePicker();
            dateTimeSalida = new DateTimePicker();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            errorProviderNumero = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(95, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Habitación";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 70);
            label4.Name = "label4";
            label4.Size = new Size(161, 18);
            label4.TabIndex = 32;
            label4.Text = "Cantidad de camas : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(463, 23);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 31;
            label2.Text = "Piso : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(308, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 30;
            label1.Text = "Tipo : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 34);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 29;
            label3.Text = "Numero : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lApellido);
            groupBox2.Controls.Add(TApellido);
            groupBox2.Controls.Add(TNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TCantidadHuespedes);
            groupBox2.Controls.Add(TDni);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dateTimeIngreso);
            groupBox2.Controls.Add(dateTimeSalida);
            groupBox2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(95, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(622, 361);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Huesped";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 26);
            comboBox1.TabIndex = 39;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 280);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 38;
            label7.Text = "Forma de Pago :";
            // 
            // lApellido
            // 
            lApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lApellido.Location = new Point(29, 37);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(75, 20);
            lApellido.TabIndex = 30;
            lApellido.Text = "Apellido :";
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TApellido.BorderStyle = BorderStyle.FixedSingle;
            TApellido.Location = new Point(29, 60);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(206, 25);
            TApellido.TabIndex = 26;
            TApellido.KeyDown += ValidacionApellido;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TNombre.Location = new Point(388, 60);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(206, 25);
            TNombre.TabIndex = 27;
            TNombre.KeyDown += ValidacionNombre;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(388, 37);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 31;
            label5.Text = "Nombre :";
            // 
            // TCantidadHuespedes
            // 
            TCantidadHuespedes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TCantidadHuespedes.Location = new Point(388, 133);
            TCantidadHuespedes.Name = "TCantidadHuespedes";
            TCantidadHuespedes.Size = new Size(206, 25);
            TCantidadHuespedes.TabIndex = 29;
            TCantidadHuespedes.KeyDown += ValidacionCantHuesped;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(29, 133);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 25);
            TDni.TabIndex = 28;
            TDni.KeyDown += ValidacionDni;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(388, 183);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 37;
            label6.Text = "Fecha de Salida :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 101);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 32;
            label8.Text = "DNI :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(388, 110);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 33;
            label9.Text = "Cantidad de huespedes :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(29, 183);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 35;
            label10.Text = "Fecha de Ingreso :";
            // 
            // dateTimeIngreso
            // 
            dateTimeIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeIngreso.Format = DateTimePickerFormat.Short;
            dateTimeIngreso.Location = new Point(29, 224);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(135, 25);
            dateTimeIngreso.TabIndex = 34;
            // 
            // dateTimeSalida
            // 
            dateTimeSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeSalida.Format = DateTimePickerFormat.Short;
            dateTimeSalida.Location = new Point(388, 224);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(123, 25);
            dateTimeSalida.TabIndex = 36;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(12, 518);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 79);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Image = Properties.Resources.btn_guardar_;
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(668, 518);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 79);
            btnRegistrar.TabIndex = 32;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // AgregarHuesped
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(783, 600);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarHuesped";
            Text = "AgregarHuesped";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label7;
        private Label lApellido;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label label5;
        private TextBox TCantidadHuespedes;
        private TextBox TDni;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimeIngreso;
        private DateTimePicker dateTimeSalida;
        private ErrorProvider errorProviderNumero;
    }
}