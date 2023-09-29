namespace SistemaDeGestionHotel.views.recep
{
    partial class GestionReservas
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
            label7 = new Label();
            lApellido = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnConfirmaLLegada = new Button();
            btnBuscar = new Button();
            LDni = new Label();
            TDni = new TextBox();
            errorProviderNumero = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lApellido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(91, 265);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 284);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Huesped";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 182);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 24;
            label7.Text = "Telefono :";
            // 
            // lApellido
            // 
            lApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lApellido.AutoSize = true;
            lApellido.BorderStyle = BorderStyle.FixedSingle;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lApellido.Location = new Point(18, 37);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(77, 22);
            lApellido.TabIndex = 16;
            lApellido.Text = "Apellido :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(330, 37);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 17;
            label1.Text = "Nombre :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(330, 247);
            label5.Name = "label5";
            label5.Size = new Size(125, 22);
            label5.TabIndex = 23;
            label5.Text = "Fecha de Salida :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 110);
            label2.Name = "label2";
            label2.Size = new Size(47, 22);
            label2.TabIndex = 18;
            label2.Text = "DNI :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(330, 110);
            label3.Name = "label3";
            label3.Size = new Size(180, 22);
            label3.TabIndex = 19;
            label3.Text = "Cantidad de huespedes :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 247);
            label4.Name = "label4";
            label4.Size = new Size(137, 22);
            label4.TabIndex = 21;
            label4.Text = "Fecha de Ingreso :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(541, 94);
            label6.Name = "label6";
            label6.Size = new Size(328, 38);
            label6.TabIndex = 24;
            label6.Text = "Gestion Reservas";
            // 
            // btnConfirmaLLegada
            // 
            btnConfirmaLLegada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmaLLegada.BackColor = Color.PowderBlue;
            btnConfirmaLLegada.BackgroundImageLayout = ImageLayout.None;
            btnConfirmaLLegada.Cursor = Cursors.Hand;
            btnConfirmaLLegada.FlatAppearance.BorderSize = 0;
            btnConfirmaLLegada.FlatStyle = FlatStyle.Popup;
            btnConfirmaLLegada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmaLLegada.Image = Properties.Resources.btn_guardar_;
            btnConfirmaLLegada.ImageAlign = ContentAlignment.TopCenter;
            btnConfirmaLLegada.Location = new Point(776, 454);
            btnConfirmaLLegada.Name = "btnConfirmaLLegada";
            btnConfirmaLLegada.Size = new Size(104, 91);
            btnConfirmaLLegada.TabIndex = 26;
            btnConfirmaLLegada.Text = "Registrar Asistencia";
            btnConfirmaLLegada.TextAlign = ContentAlignment.BottomCenter;
            btnConfirmaLLegada.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Location = new Point(305, 106);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(85, 31);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.Location = new Point(81, 88);
            LDni.Name = "LDni";
            LDni.Size = new Size(189, 20);
            LDni.TabIndex = 28;
            LDni.Text = "Ingrese DNI del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(81, 111);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 27;
            TDni.KeyDown += ValidacionDni;
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
            panel1.Size = new Size(892, 86);
            panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(389, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(91, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 118);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Habitación";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(450, 36);
            label13.Name = "label13";
            label13.Size = new Size(76, 18);
            label13.TabIndex = 34;
            label13.Text = "Precio : $";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 77);
            label8.Name = "label8";
            label8.Size = new Size(161, 18);
            label8.TabIndex = 32;
            label8.Text = "Cantidad de camas : ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(298, 77);
            label9.Name = "label9";
            label9.Size = new Size(52, 18);
            label9.TabIndex = 31;
            label9.Text = "Piso : ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(298, 36);
            label10.Name = "label10";
            label10.Size = new Size(52, 18);
            label10.TabIndex = 30;
            label10.Text = "Tipo : ";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(18, 36);
            label12.Name = "label12";
            label12.Size = new Size(79, 18);
            label12.TabIndex = 29;
            label12.Text = "Numero : ";
            // 
            // GestionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(892, 557);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Controls.Add(LDni);
            Controls.Add(TDni);
            Controls.Add(btnConfirmaLLegada);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionReservas";
            Text = "GestionReservas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lApellido;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnConfirmaLLegada;
        private Button btnBuscar;
        private Label LDni;
        private TextBox TDni;
        private ErrorProvider errorProviderNumero;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private GroupBox groupBox2;
        private Label label13;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
    }
}