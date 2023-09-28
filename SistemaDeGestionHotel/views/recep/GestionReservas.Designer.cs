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
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox1.Location = new Point(76, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 316);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Huesped";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lApellido
            // 
            lApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lApellido.AutoSize = true;
            lApellido.BorderStyle = BorderStyle.FixedSingle;
            lApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lApellido.Location = new Point(26, 37);
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
            label1.Location = new Point(338, 37);
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
            label5.Location = new Point(338, 247);
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
            label2.Location = new Point(26, 110);
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
            label3.Location = new Point(338, 110);
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
            label4.Location = new Point(26, 247);
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
            label6.Location = new Point(490, 149);
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
            btnConfirmaLLegada.Location = new Point(793, 450);
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
            btnBuscar.Location = new Point(327, 161);
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
            LDni.Location = new Point(76, 146);
            LDni.Name = "LDni";
            LDni.Size = new Size(189, 20);
            LDni.TabIndex = 28;
            LDni.Text = "Ingrese DNI del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(76, 169);
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
            panel1.Size = new Size(909, 113);
            panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoHotel;
            pictureBox1.Location = new Point(384, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 182);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 24;
            label7.Text = "Telefono :";
            // 
            // GestionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(909, 553);
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
    }
}