namespace SistemaDeGestionHotel.views.recep
{
    partial class ConsultaDni
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
            TDni = new TextBox();
            label8 = new Label();
            btnBuscar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            labelNroPiso = new Label();
            labelCantidadCamas = new Label();
            labelPrecio = new Label();
            labelTipo = new Label();
            labelNroHabitacion = new Label();
            label6 = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(229, 253);
            TDni.MaxLength = 8;
            TDni.Name = "TDni";
            TDni.PlaceholderText = "Solo números";
            TDni.Size = new Size(214, 23);
            TDni.TabIndex = 33;
            TDni.KeyDown += ValidarDni;
            TDni.Validating += ValidarLonguitudDni;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(229, 232);
            label8.Name = "label8";
            label8.Size = new Size(194, 18);
            label8.TabIndex = 34;
            label8.Text = "Ingrese el DNI del Huesped :";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(276, 292);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 38);
            btnBuscar.TabIndex = 35;
            btnBuscar.Text = "Continuar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelNroPiso);
            groupBox2.Controls.Add(labelCantidadCamas);
            groupBox2.Controls.Add(labelPrecio);
            groupBox2.Controls.Add(labelTipo);
            groupBox2.Controls.Add(labelNroHabitacion);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 118);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Habitación";
            // 
            // labelNroPiso
            // 
            labelNroPiso.AutoSize = true;
            labelNroPiso.Location = new Point(274, 36);
            labelNroPiso.Name = "labelNroPiso";
            labelNroPiso.Size = new Size(0, 18);
            labelNroPiso.TabIndex = 40;
            // 
            // labelCantidadCamas
            // 
            labelCantidadCamas.AutoSize = true;
            labelCantidadCamas.Location = new Point(161, 77);
            labelCantidadCamas.Name = "labelCantidadCamas";
            labelCantidadCamas.Size = new Size(0, 18);
            labelCantidadCamas.TabIndex = 39;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(414, 36);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(0, 18);
            labelPrecio.TabIndex = 38;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(268, 77);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(0, 18);
            labelTipo.TabIndex = 37;
            // 
            // labelNroHabitacion
            // 
            labelNroHabitacion.AutoSize = true;
            labelNroHabitacion.Location = new Point(92, 36);
            labelNroHabitacion.Name = "labelNroHabitacion";
            labelNroHabitacion.Size = new Size(0, 18);
            labelNroHabitacion.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(347, 36);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 35;
            label6.Text = "Precio : $ ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 77);
            label1.Name = "label1";
            label1.Size = new Size(135, 18);
            label1.TabIndex = 32;
            label1.Text = "Cantidad de camas : ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(223, 36);
            label9.Name = "label9";
            label9.Size = new Size(45, 18);
            label9.TabIndex = 31;
            label9.Text = "Piso : ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(222, 77);
            label10.Name = "label10";
            label10.Size = new Size(46, 18);
            label10.TabIndex = 30;
            label10.Text = "Tipo : ";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(20, 36);
            label12.Name = "label12";
            label12.Size = new Size(66, 18);
            label12.TabIndex = 29;
            label12.Text = "Numero : ";
            // 
            // ConsultaDni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(707, 371);
            Controls.Add(groupBox2);
            Controls.Add(btnBuscar);
            Controls.Add(TDni);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConsultaDni";
            Text = "ConsultaDni";
            Load += CargarDATOS;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TDni;
        private Label label8;
        private Button btnBuscar;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox2;
        private Label labelNroPiso;
        private Label labelCantidadCamas;
        private Label labelPrecio;
        private Label labelTipo;
        private Label labelNroHabitacion;
        private Label label6;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label12;
    }
}