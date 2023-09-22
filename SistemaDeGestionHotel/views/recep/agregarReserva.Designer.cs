﻿namespace SistemaDeGestionHotel.views.recep
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
            errorProviderNumero = new ErrorProvider(components);
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            lApellido = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            label1 = new Label();
            TCantidadHuespedes = new TextBox();
            TDni = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimeIngreso = new DateTimePicker();
            dateTimeSalida = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProviderNumero
            // 
            errorProviderNumero.ContainerControl = this;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(906, 0);
            flowLayoutPanel3.TabIndex = 19;
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
            btnRegistrar.Location = new Point(782, 469);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 83);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(12, 469);
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
            label6.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(297, 9);
            label6.Name = "label6";
            label6.Size = new Size(338, 38);
            label6.TabIndex = 22;
            label6.Text = "Registrar Reserva";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lApellido);
            groupBox1.Controls.Add(TApellido);
            groupBox1.Controls.Add(TNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TCantidadHuespedes);
            groupBox1.Controls.Add(TDni);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimeIngreso);
            groupBox1.Controls.Add(dateTimeSalida);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(126, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 359);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Huesped";
            // 
            // lApellido
            // 
            lApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lApellido.Location = new Point(64, 37);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(75, 20);
            lApellido.TabIndex = 16;
            lApellido.Text = "Apellido :";
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TApellido.BorderStyle = BorderStyle.FixedSingle;
            TApellido.Location = new Point(64, 60);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(206, 27);
            TApellido.TabIndex = 12;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TNombre.Location = new Point(423, 60);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(206, 27);
            TNombre.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(423, 37);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 17;
            label1.Text = "Nombre :";
            // 
            // TCantidadHuespedes
            // 
            TCantidadHuespedes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TCantidadHuespedes.Location = new Point(423, 133);
            TCantidadHuespedes.Name = "TCantidadHuespedes";
            TCantidadHuespedes.Size = new Size(206, 27);
            TCantidadHuespedes.TabIndex = 15;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(64, 133);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 27);
            TDni.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(423, 183);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 23;
            label5.Text = "Fecha de Salida :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 101);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 18;
            label2.Text = "DNI :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(423, 110);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 19;
            label3.Text = "Cantidad de huespedes :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 183);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 21;
            label4.Text = "Fecha de Ingreso :";
            // 
            // dateTimeIngreso
            // 
            dateTimeIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeIngreso.Format = DateTimePickerFormat.Short;
            dateTimeIngreso.Location = new Point(64, 224);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(98, 27);
            dateTimeIngreso.TabIndex = 20;
            // 
            // dateTimeSalida
            // 
            dateTimeSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimeSalida.Format = DateTimePickerFormat.Short;
            dateTimeSalida.Location = new Point(423, 224);
            dateTimeSalida.Name = "dateTimeSalida";
            dateTimeSalida.Size = new Size(98, 27);
            dateTimeSalida.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(64, 280);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 24;
            label7.Text = "Forma de Pago :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 25;
            // 
            // agregarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(906, 564);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(flowLayoutPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "agregarReserva";
            Text = "agregarReserva";
            Load += agregarReserva_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProviderNumero;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label label6;
        private GroupBox groupBox1;
        private Label lApellido;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label label1;
        private TextBox TCantidadHuespedes;
        private TextBox TDni;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeIngreso;
        private DateTimePicker dateTimeSalida;
        private ComboBox comboBox1;
        private Label label7;
    }
}