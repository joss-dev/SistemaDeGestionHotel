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
            btnBuscar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            labelCantHuespedes = new Label();
            labelFechaSalida = new Label();
            labelFechaIngreso = new Label();
            labelDni = new Label();
            labelTelefono = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnReiniciar = new Button();
            labelMontoServicios = new Label();
            labelRecargo = new Label();
            labelOferta = new Label();
            label22 = new Label();
            label21 = new Label();
            comboBoxOfertas = new ComboBox();
            comboBoxRecargos = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label12 = new Label();
            labelPiso = new Label();
            label7 = new Label();
            labelMontoTotal = new Label();
            labelSubtotal = new Label();
            labelMonto = new Label();
            labelPrecioHabitacion = new Label();
            labelCantServicios = new Label();
            labelCantDias = new Label();
            labelTipoHabitacion = new Label();
            labelNroHabitacion = new Label();
            label18 = new Label();
            cbMetodoPago = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dataGridViewFactura = new DataGridView();
            btnCancelar = new Button();
            errorProviderNumero = new ErrorProvider(components);
            btnContinuar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).BeginInit();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.Top;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lTitulo2.Location = new Point(567, 31);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(266, 39);
            lTitulo2.TabIndex = 20;
            lTitulo2.Text = "Registrar Pagos";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.Top;
            LDni.AutoSize = true;
            LDni.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.Location = new Point(34, 31);
            LDni.Name = "LDni";
            LDni.Size = new Size(184, 18);
            LDni.TabIndex = 22;
            LDni.Text = "Ingrese D.N.I del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top;
            TDni.Location = new Point(34, 54);
            TDni.MaxLength = 8;
            TDni.Name = "TDni";
            TDni.PlaceholderText = "Solo Números";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 21;
            TDni.KeyDown += ValidacionDni;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.Location = new Point(246, 51);
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
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 35);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 28;
            label3.Text = "Nombre : ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(323, 35);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 29;
            label4.Text = "Apellido :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 70);
            label5.Name = "label5";
            label5.Size = new Size(38, 18);
            label5.TabIndex = 30;
            label5.Text = "Dni : ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(323, 70);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 31;
            label6.Text = "Fecha de Ingreso :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 105);
            label8.Name = "label8";
            label8.Size = new Size(162, 18);
            label8.TabIndex = 33;
            label8.Text = "Cantidad de Huespedes :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(labelCantHuespedes);
            groupBox1.Controls.Add(labelFechaSalida);
            groupBox1.Controls.Add(labelFechaIngreso);
            groupBox1.Controls.Add(labelDni);
            groupBox1.Controls.Add(labelTelefono);
            groupBox1.Controls.Add(labelApellido);
            groupBox1.Controls.Add(labelNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 133);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Factura";
            // 
            // labelCantHuespedes
            // 
            labelCantHuespedes.AutoSize = true;
            labelCantHuespedes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantHuespedes.Location = new Point(189, 107);
            labelCantHuespedes.Name = "labelCantHuespedes";
            labelCantHuespedes.Size = new Size(0, 16);
            labelCantHuespedes.TabIndex = 42;
            // 
            // labelFechaSalida
            // 
            labelFechaSalida.AutoSize = true;
            labelFechaSalida.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFechaSalida.Location = new Point(707, 72);
            labelFechaSalida.Name = "labelFechaSalida";
            labelFechaSalida.Size = new Size(0, 16);
            labelFechaSalida.TabIndex = 41;
            // 
            // labelFechaIngreso
            // 
            labelFechaIngreso.AutoSize = true;
            labelFechaIngreso.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFechaIngreso.Location = new Point(449, 72);
            labelFechaIngreso.Name = "labelFechaIngreso";
            labelFechaIngreso.Size = new Size(0, 16);
            labelFechaIngreso.TabIndex = 40;
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(68, 72);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(0, 16);
            labelDni.TabIndex = 39;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefono.Location = new Point(662, 37);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(0, 16);
            labelTelefono.TabIndex = 38;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelApellido.Location = new Point(394, 37);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(0, 16);
            labelApellido.TabIndex = 37;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(97, 37);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(0, 16);
            labelNombre.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(587, 70);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 35;
            label2.Text = "Fecha de Salida :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(587, 35);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 34;
            label1.Text = "Telefono :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(btnReiniciar);
            groupBox2.Controls.Add(labelMontoServicios);
            groupBox2.Controls.Add(labelRecargo);
            groupBox2.Controls.Add(labelOferta);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(comboBoxOfertas);
            groupBox2.Controls.Add(comboBoxRecargos);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(labelPiso);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(labelMontoTotal);
            groupBox2.Controls.Add(labelSubtotal);
            groupBox2.Controls.Add(labelMonto);
            groupBox2.Controls.Add(labelPrecioHabitacion);
            groupBox2.Controls.Add(labelCantServicios);
            groupBox2.Controls.Add(labelCantDias);
            groupBox2.Controls.Add(labelTipoHabitacion);
            groupBox2.Controls.Add(labelNroHabitacion);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(cbMetodoPago);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dataGridViewFactura);
            groupBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(856, 393);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Factura";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.Top;
            btnReiniciar.BackColor = Color.ForestGreen;
            btnReiniciar.FlatStyle = FlatStyle.Popup;
            btnReiniciar.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(662, 276);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(98, 31);
            btnReiniciar.TabIndex = 41;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // labelMontoServicios
            // 
            labelMontoServicios.AutoSize = true;
            labelMontoServicios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMontoServicios.Location = new Point(205, 177);
            labelMontoServicios.Name = "labelMontoServicios";
            labelMontoServicios.Size = new Size(0, 16);
            labelMontoServicios.TabIndex = 65;
            // 
            // labelRecargo
            // 
            labelRecargo.AutoSize = true;
            labelRecargo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelRecargo.Location = new Point(157, 317);
            labelRecargo.Name = "labelRecargo";
            labelRecargo.Size = new Size(0, 16);
            labelRecargo.TabIndex = 64;
            // 
            // labelOferta
            // 
            labelOferta.AutoSize = true;
            labelOferta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOferta.Location = new Point(139, 292);
            labelOferta.Name = "labelOferta";
            labelOferta.Size = new Size(0, 16);
            labelOferta.TabIndex = 63;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label22.AutoSize = true;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(322, 251);
            label22.Name = "label22";
            label22.Size = new Size(126, 18);
            label22.TabIndex = 62;
            label22.Text = "Seleccionar Oferta :";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label21.AutoSize = true;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(496, 251);
            label21.Name = "label21";
            label21.Size = new Size(146, 18);
            label21.TabIndex = 61;
            label21.Text = "Seleccionar Recargo : ";
            // 
            // comboBoxOfertas
            // 
            comboBoxOfertas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOfertas.FormattingEnabled = true;
            comboBoxOfertas.Location = new Point(322, 276);
            comboBoxOfertas.Name = "comboBoxOfertas";
            comboBoxOfertas.Size = new Size(121, 32);
            comboBoxOfertas.TabIndex = 60;
            comboBoxOfertas.SelectedIndexChanged += CargarOferta;
            // 
            // comboBoxRecargos
            // 
            comboBoxRecargos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRecargos.FormattingEnabled = true;
            comboBoxRecargos.Location = new Point(495, 276);
            comboBoxRecargos.Name = "comboBoxRecargos";
            comboBoxRecargos.Size = new Size(121, 32);
            comboBoxRecargos.TabIndex = 59;
            comboBoxRecargos.SelectedIndexChanged += CargarRecargo;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label20.AutoSize = true;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(69, 290);
            label20.Name = "label20";
            label20.Size = new Size(66, 18);
            label20.TabIndex = 58;
            label20.Text = "Oferta : %";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(74, 210);
            label19.Name = "label19";
            label19.Size = new Size(97, 18);
            label19.TabIndex = 57;
            label19.Text = "SUBTOTAL : $";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(75, 177);
            label12.Name = "label12";
            label12.Size = new Size(124, 18);
            label12.TabIndex = 56;
            label12.Text = "Monto Servicios : $ ";
            // 
            // labelPiso
            // 
            labelPiso.AutoSize = true;
            labelPiso.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPiso.Location = new Point(638, 41);
            labelPiso.Name = "labelPiso";
            labelPiso.Size = new Size(0, 16);
            labelPiso.TabIndex = 55;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(587, 39);
            label7.Name = "label7";
            label7.Size = new Size(45, 18);
            label7.TabIndex = 54;
            label7.Text = "Piso : ";
            // 
            // labelMontoTotal
            // 
            labelMontoTotal.AutoSize = true;
            labelMontoTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMontoTotal.Location = new Point(205, 357);
            labelMontoTotal.Name = "labelMontoTotal";
            labelMontoTotal.Size = new Size(0, 16);
            labelMontoTotal.TabIndex = 53;
            labelMontoTotal.Click += label22_Click;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubtotal.Location = new Point(177, 212);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(0, 16);
            labelSubtotal.TabIndex = 52;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.Location = new Point(145, 146);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(0, 16);
            labelMonto.TabIndex = 51;
            // 
            // labelPrecioHabitacion
            // 
            labelPrecioHabitacion.AutoSize = true;
            labelPrecioHabitacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecioHabitacion.Location = new Point(725, 83);
            labelPrecioHabitacion.Name = "labelPrecioHabitacion";
            labelPrecioHabitacion.Size = new Size(0, 16);
            labelPrecioHabitacion.TabIndex = 50;
            // 
            // labelCantServicios
            // 
            labelCantServicios.AutoSize = true;
            labelCantServicios.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantServicios.Location = new Point(495, 83);
            labelCantServicios.Name = "labelCantServicios";
            labelCantServicios.Size = new Size(0, 16);
            labelCantServicios.TabIndex = 49;
            // 
            // labelCantDias
            // 
            labelCantDias.AutoSize = true;
            labelCantDias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantDias.Location = new Point(177, 83);
            labelCantDias.Name = "labelCantDias";
            labelCantDias.Size = new Size(0, 16);
            labelCantDias.TabIndex = 48;
            // 
            // labelTipoHabitacion
            // 
            labelTipoHabitacion.AutoSize = true;
            labelTipoHabitacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoHabitacion.Location = new Point(443, 41);
            labelTipoHabitacion.Name = "labelTipoHabitacion";
            labelTipoHabitacion.Size = new Size(0, 16);
            labelTipoHabitacion.TabIndex = 47;
            // 
            // labelNroHabitacion
            // 
            labelNroHabitacion.AutoSize = true;
            labelNroHabitacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNroHabitacion.Location = new Point(189, 41);
            labelNroHabitacion.Name = "labelNroHabitacion";
            labelNroHabitacion.Size = new Size(0, 16);
            labelNroHabitacion.TabIndex = 46;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(381, 357);
            label18.Name = "label18";
            label18.Size = new Size(235, 18);
            label18.TabIndex = 45;
            label18.Text = "Selecciona el método de pago :";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(627, 348);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(182, 32);
            cbMetodoPago.TabIndex = 44;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(587, 81);
            label17.Name = "label17";
            label17.Size = new Size(132, 18);
            label17.TabIndex = 36;
            label17.Text = "Precio Habitación : $";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Microsoft Sans Serif", 9.7F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(68, 357);
            label16.Name = "label16";
            label16.Size = new Size(125, 18);
            label16.TabIndex = 43;
            label16.Text = "MONTO TOTAL : $ ";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(68, 315);
            label15.Name = "label15";
            label15.Size = new Size(83, 18);
            label15.TabIndex = 42;
            label15.Text = "Recargo : %";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(323, 81);
            label14.Name = "label14";
            label14.Size = new Size(166, 18);
            label14.TabIndex = 41;
            label14.Text = "Cant. Servicios Utilizados :";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(74, 144);
            label13.Name = "label13";
            label13.Size = new Size(65, 18);
            label13.TabIndex = 40;
            label13.Text = "Monto : $ ";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(323, 39);
            label11.Name = "label11";
            label11.Size = new Size(114, 18);
            label11.TabIndex = 38;
            label11.Text = "Tipo Habitación : ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(75, 81);
            label10.Name = "label10";
            label10.Size = new Size(96, 18);
            label10.TabIndex = 37;
            label10.Text = "Cant. de dias : ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(75, 39);
            label9.Name = "label9";
            label9.Size = new Size(108, 18);
            label9.TabIndex = 36;
            label9.Text = "Nro Habitación : ";
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
            dataGridViewFactura.Location = new Point(323, 116);
            dataGridViewFactura.Name = "dataGridViewFactura";
            dataGridViewFactura.ReadOnly = true;
            dataGridViewFactura.RowTemplate.Height = 25;
            dataGridViewFactura.Size = new Size(511, 118);
            dataGridViewFactura.TabIndex = 35;
            dataGridViewFactura.CellContentClick += dataGridViewFactura_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.btnCancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(61, 643);
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
            // btnContinuar
            // 
            btnContinuar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnContinuar.BackColor = Color.DarkTurquoise;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.ActiveCaptionText;
            btnContinuar.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnContinuar.IconColor = Color.Black;
            btnContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContinuar.ImageAlign = ContentAlignment.TopCenter;
            btnContinuar.Location = new Point(760, 643);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(98, 78);
            btnContinuar.TabIndex = 40;
            btnContinuar.Text = "Continuar";
            btnContinuar.TextAlign = ContentAlignment.BottomCenter;
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // gestionPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(914, 733);
            Controls.Add(btnContinuar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(LDni);
            Controls.Add(TDni);
            Controls.Add(lTitulo2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionPagos";
            Activated += ReiniciarDatos;
            Load += CargarDatos;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTitulo2;
        private Label LDni;
        private TextBox TDni;
        private Button btnBuscar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelCantDias;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewFactura;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private ErrorProvider errorProviderNumero;
        private Label labelCantServicios;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnContinuar;
        private Label label18;
        private ComboBox cbMetodoPago;
        private Label label26;
        private Label dede;
        private Label labelFechaSalida;
        private Label labelFechaIngreso;
        private Label labelDni;
        private Label labelTelefono;
        private Label labelApellido;
        private Label labelNombre;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label labelNroHabitacion;
        private Label labelCantHuespedes;
        private Label labelTipoHabitacion;
        private Label labelMontoTotal;
        private Label labelSubtotal;
        private Label labelMonto;
        private Label labelPrecioHabitacion;
        private Label labelPiso;
        private Label label7;
        private Label label12;
        private Label label19;
        private Label label20;
        private ComboBox comboBoxRecargos;
        private Label label22;
        private Label label21;
        private ComboBox comboBoxOfertas;
        private Label labelRecargo;
        private Label labelOferta;
        private Label labelMontoServicios;
        private Button btnReiniciar;
    }
}