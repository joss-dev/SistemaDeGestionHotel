namespace SistemaDeGestionHotel.views.admin
{
    partial class gestionHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionHabitaciones));
            panel1 = new Panel();
            label1 = new Label();
            btnFiltroPiso1 = new Button();
            btnFiltroPiso2 = new Button();
            btnFiltroPiso3 = new Button();
            btnFiltroOcupado = new Button();
            btnFiltroLibre = new Button();
            btnFiltroReservado = new Button();
            btnBuscar = new Button();
            LDni = new Label();
            TNumHabitacion = new TextBox();
            btnFiltroSimple = new Button();
            btnFiltroDoble = new Button();
            btnFiltroTriple = new Button();
            label6 = new Label();
            btnVolver = new Button();
            errorProvider1 = new ErrorProvider(components);
            todasLasHabitaciones = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Location = new Point(21, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 482);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(274, 18);
            label1.Name = "label1";
            label1.Size = new Size(496, 51);
            label1.TabIndex = 1;
            label1.Text = "Gestión de habitaciones ";
            // 
            // btnFiltroPiso1
            // 
            btnFiltroPiso1.BackColor = Color.LightCyan;
            btnFiltroPiso1.FlatStyle = FlatStyle.Flat;
            btnFiltroPiso1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroPiso1.Location = new Point(20, 157);
            btnFiltroPiso1.Name = "btnFiltroPiso1";
            btnFiltroPiso1.Size = new Size(95, 33);
            btnFiltroPiso1.TabIndex = 2;
            btnFiltroPiso1.Text = "Piso 1";
            btnFiltroPiso1.UseVisualStyleBackColor = false;
            btnFiltroPiso1.Click += btnFiltroPiso1_Click;
            // 
            // btnFiltroPiso2
            // 
            btnFiltroPiso2.BackColor = Color.LightCyan;
            btnFiltroPiso2.FlatStyle = FlatStyle.Flat;
            btnFiltroPiso2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroPiso2.Location = new Point(121, 157);
            btnFiltroPiso2.Name = "btnFiltroPiso2";
            btnFiltroPiso2.Size = new Size(95, 33);
            btnFiltroPiso2.TabIndex = 3;
            btnFiltroPiso2.Text = "Piso 2";
            btnFiltroPiso2.UseVisualStyleBackColor = false;
            btnFiltroPiso2.Click += btnFiltroPiso2_Click;
            // 
            // btnFiltroPiso3
            // 
            btnFiltroPiso3.BackColor = Color.LightCyan;
            btnFiltroPiso3.FlatStyle = FlatStyle.Flat;
            btnFiltroPiso3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroPiso3.Location = new Point(224, 157);
            btnFiltroPiso3.Name = "btnFiltroPiso3";
            btnFiltroPiso3.Size = new Size(95, 33);
            btnFiltroPiso3.TabIndex = 4;
            btnFiltroPiso3.Text = "Piso 3";
            btnFiltroPiso3.UseVisualStyleBackColor = false;
            btnFiltroPiso3.Click += btnFiltroPiso3_Click;
            // 
            // btnFiltroOcupado
            // 
            btnFiltroOcupado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltroOcupado.BackColor = Color.Red;
            btnFiltroOcupado.FlatStyle = FlatStyle.Flat;
            btnFiltroOcupado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroOcupado.Location = new Point(740, 157);
            btnFiltroOcupado.Name = "btnFiltroOcupado";
            btnFiltroOcupado.Size = new Size(95, 33);
            btnFiltroOcupado.TabIndex = 5;
            btnFiltroOcupado.Text = "Ocupado";
            btnFiltroOcupado.UseVisualStyleBackColor = false;
            btnFiltroOcupado.Click += btnFiltroOcupado_Click;
            // 
            // btnFiltroLibre
            // 
            btnFiltroLibre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltroLibre.BackColor = Color.MediumSpringGreen;
            btnFiltroLibre.FlatStyle = FlatStyle.Flat;
            btnFiltroLibre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroLibre.Location = new Point(841, 157);
            btnFiltroLibre.Name = "btnFiltroLibre";
            btnFiltroLibre.Size = new Size(95, 33);
            btnFiltroLibre.TabIndex = 6;
            btnFiltroLibre.Text = "Libre";
            btnFiltroLibre.UseVisualStyleBackColor = false;
            btnFiltroLibre.Click += btnFiltroLibre_Click;
            // 
            // btnFiltroReservado
            // 
            btnFiltroReservado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltroReservado.BackColor = Color.SandyBrown;
            btnFiltroReservado.FlatStyle = FlatStyle.Flat;
            btnFiltroReservado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroReservado.Location = new Point(639, 157);
            btnFiltroReservado.Name = "btnFiltroReservado";
            btnFiltroReservado.Size = new Size(95, 33);
            btnFiltroReservado.TabIndex = 7;
            btnFiltroReservado.Text = "Reservado";
            btnFiltroReservado.UseVisualStyleBackColor = false;
            btnFiltroReservado.Click += btnFiltroReservado_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(866, 116);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 29);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LDni.AutoSize = true;
            LDni.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.Location = new Point(735, 96);
            LDni.Name = "LDni";
            LDni.Size = new Size(119, 18);
            LDni.TabIndex = 31;
            LDni.Text = "Nro Habitación : ";
            // 
            // TNumHabitacion
            // 
            TNumHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TNumHabitacion.Location = new Point(735, 119);
            TNumHabitacion.MaxLength = 3;
            TNumHabitacion.Name = "TNumHabitacion";
            TNumHabitacion.PlaceholderText = "Solo Números";
            TNumHabitacion.Size = new Size(126, 23);
            TNumHabitacion.TabIndex = 30;
            TNumHabitacion.KeyDown += ValidarTextboxNroHabitacion;
            // 
            // btnFiltroSimple
            // 
            btnFiltroSimple.Anchor = AnchorStyles.Top;
            btnFiltroSimple.BackColor = Color.Yellow;
            btnFiltroSimple.FlatStyle = FlatStyle.Flat;
            btnFiltroSimple.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroSimple.Location = new Point(332, 157);
            btnFiltroSimple.Name = "btnFiltroSimple";
            btnFiltroSimple.Size = new Size(95, 33);
            btnFiltroSimple.TabIndex = 33;
            btnFiltroSimple.Text = "Simple";
            btnFiltroSimple.UseVisualStyleBackColor = false;
            btnFiltroSimple.Click += btnFiltroSimple_Click;
            // 
            // btnFiltroDoble
            // 
            btnFiltroDoble.Anchor = AnchorStyles.Top;
            btnFiltroDoble.BackColor = Color.Yellow;
            btnFiltroDoble.FlatStyle = FlatStyle.Flat;
            btnFiltroDoble.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroDoble.Location = new Point(431, 157);
            btnFiltroDoble.Name = "btnFiltroDoble";
            btnFiltroDoble.Size = new Size(95, 33);
            btnFiltroDoble.TabIndex = 34;
            btnFiltroDoble.Text = "Doble";
            btnFiltroDoble.UseVisualStyleBackColor = false;
            btnFiltroDoble.Click += btnFiltroDoble_Click;
            // 
            // btnFiltroTriple
            // 
            btnFiltroTriple.Anchor = AnchorStyles.Top;
            btnFiltroTriple.BackColor = Color.Yellow;
            btnFiltroTriple.FlatStyle = FlatStyle.Flat;
            btnFiltroTriple.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltroTriple.Location = new Point(530, 157);
            btnFiltroTriple.Name = "btnFiltroTriple";
            btnFiltroTriple.Size = new Size(95, 33);
            btnFiltroTriple.TabIndex = 35;
            btnFiltroTriple.Text = "Triple";
            btnFiltroTriple.UseVisualStyleBackColor = false;
            btnFiltroTriple.Click += btnFiltroTriple_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(56, 805);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 70;
            label6.Text = "Volver";
            label6.Click += label6_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.BackColor = Color.CornflowerBlue;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(44, 696);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(71, 71);
            btnVolver.TabIndex = 69;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // todasLasHabitaciones
            // 
            todasLasHabitaciones.BackColor = Color.Turquoise;
            todasLasHabitaciones.FlatStyle = FlatStyle.Flat;
            todasLasHabitaciones.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            todasLasHabitaciones.Location = new Point(21, 96);
            todasLasHabitaciones.Name = "todasLasHabitaciones";
            todasLasHabitaciones.Size = new Size(95, 33);
            todasLasHabitaciones.TabIndex = 71;
            todasLasHabitaciones.Text = "Todos";
            todasLasHabitaciones.UseVisualStyleBackColor = false;
            todasLasHabitaciones.Click += todasLasHabitaciones_Click;
            // 
            // gestionHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(963, 788);
            Controls.Add(todasLasHabitaciones);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(btnFiltroTriple);
            Controls.Add(btnFiltroDoble);
            Controls.Add(btnFiltroSimple);
            Controls.Add(btnBuscar);
            Controls.Add(LDni);
            Controls.Add(TNumHabitacion);
            Controls.Add(btnFiltroReservado);
            Controls.Add(btnFiltroLibre);
            Controls.Add(btnFiltroOcupado);
            Controls.Add(btnFiltroPiso3);
            Controls.Add(btnFiltroPiso2);
            Controls.Add(btnFiltroPiso1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionHabitaciones";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registraciones y Reservas";
            Load += gestionHabitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnFiltroPiso1;
        private Button btnFiltroPiso2;
        private Button btnFiltroPiso3;
        private Button btnFiltroOcupado;
        private Button btnFiltroLibre;
        private Button btnFiltroReservado;
        private Button btnBuscar;
        private Label LDni;
        private TextBox TNumHabitacion;
        private Button btnFiltroSimple;
        private Button btnFiltroDoble;
        private Button btnFiltroTriple;
        private Label label6;
        private Button btnVolver;
        private ErrorProvider errorProvider1;
        private Button todasLasHabitaciones;
    }
}