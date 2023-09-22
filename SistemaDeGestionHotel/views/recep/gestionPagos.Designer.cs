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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridViewFactura = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Impuestos = new DataGridViewTextBoxColumn();
            Habitacion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).BeginInit();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.Top;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lTitulo2.Location = new Point(290, 20);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(271, 35);
            lTitulo2.TabIndex = 20;
            lTitulo2.Text = "Registrar Pagos";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LDni.AutoSize = true;
            LDni.BorderStyle = BorderStyle.FixedSingle;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.Location = new Point(46, 102);
            LDni.Name = "LDni";
            LDni.Size = new Size(185, 22);
            LDni.TabIndex = 22;
            LDni.Text = "Ingrese dni del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(254, 103);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 21;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = Color.LawnGreen;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.ImageAlign = ContentAlignment.TopCenter;
            btnCobrar.Location = new Point(793, 485);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(85, 67);
            btnCobrar.TabIndex = 23;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.Location = new Point(476, 98);
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
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(22, 485);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 67);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
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
            groupBox1.Location = new Point(22, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 133);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Huesped";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(dataGridViewFactura);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(22, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(856, 167);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Factura";
            // 
            // dataGridViewFactura
            // 
            dataGridViewFactura.AllowUserToOrderColumns = true;
            dataGridViewFactura.Anchor = AnchorStyles.None;
            dataGridViewFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFactura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFactura.Columns.AddRange(new DataGridViewColumn[] { Servicio, Descripcion, Impuestos, Habitacion, Precio, SubTotal, Total });
            dataGridViewFactura.Location = new Point(75, 41);
            dataGridViewFactura.Name = "dataGridViewFactura";
            dataGridViewFactura.RowTemplate.Height = 25;
            dataGridViewFactura.Size = new Size(747, 120);
            dataGridViewFactura.TabIndex = 35;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Servicio";
            Servicio.Name = "Servicio";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Impuestos
            // 
            Impuestos.HeaderText = "Impuestos";
            Impuestos.Name = "Impuestos";
            // 
            // Habitacion
            // 
            Habitacion.HeaderText = "Habitacion";
            Habitacion.Name = "Habitacion";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(587, 29);
            label1.Name = "label1";
            label1.Size = new Size(130, 18);
            label1.TabIndex = 34;
            label1.Text = "Tipo Habitacion :";
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
            // gestionPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(890, 564);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).EndInit();
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
        private FontAwesome.Sharp.IconButton btnCancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewFactura;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Impuestos;
        private DataGridViewTextBoxColumn Habitacion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Total;
        private Label label2;
        private Label label1;
    }
}