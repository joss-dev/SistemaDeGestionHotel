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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lTitulo2
            // 
            lTitulo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lTitulo2.AutoSize = true;
            lTitulo2.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lTitulo2.Location = new Point(115, 42);
            lTitulo2.Name = "lTitulo2";
            lTitulo2.Size = new Size(351, 45);
            lTitulo2.TabIndex = 20;
            lTitulo2.Text = "Registrar Pagos";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.Location = new Point(46, 143);
            LDni.Name = "LDni";
            LDni.Size = new Size(183, 20);
            LDni.TabIndex = 22;
            LDni.Text = "Ingrese dni del huesped :";
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TDni.Location = new Point(244, 143);
            TDni.Name = "TDni";
            TDni.Size = new Size(206, 23);
            TDni.TabIndex = 21;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom;
            btnCobrar.BackColor = Color.LawnGreen;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCobrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnCobrar.IconColor = Color.Black;
            btnCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCobrar.ImageAlign = ContentAlignment.TopCenter;
            btnCobrar.Location = new Point(228, 465);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(123, 74);
            btnCobrar.TabIndex = 23;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.BottomCenter;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom;
            btnBuscar.Location = new Point(476, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 213);
            label1.Name = "label1";
            label1.Size = new Size(130, 14);
            label1.TabIndex = 25;
            label1.Text = "Datos del cliente : ";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(522, 48);
            dataGridView1.TabIndex = 26;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(46, 354);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(522, 90);
            dataGridView2.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 327);
            label2.Name = "label2";
            label2.Size = new Size(70, 14);
            label2.TabIndex = 27;
            label2.Text = "Factura : ";
            // 
            // gestionPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(580, 564);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(btnCobrar);
            Controls.Add(LDni);
            Controls.Add(TDni);
            Controls.Add(lTitulo2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "gestionPagos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTitulo2;
        private Label LDni;
        private TextBox TDni;
        private FontAwesome.Sharp.IconButton btnCobrar;
        private Button btnBuscar;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
    }
}