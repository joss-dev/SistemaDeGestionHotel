﻿namespace SistemaDeGestionHotel.views.admin
{
    partial class registrarSsAdicionales
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
            label1 = new Label();
            txtNombSs = new TextBox();
            label4 = new Label();
            txtPrecioTotal = new TextBox();
            label7 = new Label();
            btnEditar = new Button();
            label6 = new Label();
            btnCancelar = new Button();
            label5 = new Label();
            btnRegistrar = new Button();
            pictureBoxSsAdic = new PictureBox();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            btnEliminar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSsAdic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 246);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 23;
            label1.Text = "Nombre del Servicio:";
            // 
            // txtNombSs
            // 
            txtNombSs.Anchor = AnchorStyles.Top;
            txtNombSs.Location = new Point(203, 267);
            txtNombSs.Name = "txtNombSs";
            txtNombSs.Size = new Size(203, 23);
            txtNombSs.TabIndex = 24;
            txtNombSs.KeyDown += ValidacionNombreSs;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(201, 309);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 29;
            label4.Text = "Precio total:";
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Anchor = AnchorStyles.Top;
            txtPrecioTotal.Location = new Point(201, 331);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(203, 23);
            txtPrecioTotal.TabIndex = 30;
            txtPrecioTotal.KeyDown += ValidacionCosto;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(457, 515);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 48;
            label7.Text = "Editar";
            label7.UseWaitCursor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.BackColor = Color.LightGreen;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(443, 442);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 72);
            btnEditar.TabIndex = 47;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(327, 516);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 44;
            label6.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.LightGreen;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.Location = new Point(323, 442);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(71, 71);
            btnCancelar.TabIndex = 43;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(203, 516);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 42;
            label5.Text = "Registrar";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top;
            btnRegistrar.BackColor = Color.LightGreen;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Image = Properties.Resources.registrar;
            btnRegistrar.Location = new Point(201, 442);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(71, 71);
            btnRegistrar.TabIndex = 41;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBoxSsAdic
            // 
            pictureBoxSsAdic.Anchor = AnchorStyles.Top;
            pictureBoxSsAdic.Image = Properties.Resources.servicios_adicionales_hotel1;
            pictureBoxSsAdic.Location = new Point(449, 216);
            pictureBoxSsAdic.Name = "pictureBoxSsAdic";
            pictureBoxSsAdic.Size = new Size(181, 180);
            pictureBoxSsAdic.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSsAdic.TabIndex = 49;
            pictureBoxSsAdic.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 556);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(716, 126);
            dataGridView1.TabIndex = 50;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.PaleGreen;
            label8.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(95, 110);
            label8.Name = "label8";
            label8.Size = new Size(664, 51);
            label8.TabIndex = 51;
            label8.Text = "Registro de Servicios Adicionales";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(569, 514);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 53;
            label9.Text = "Eliminar";
            label9.UseWaitCursor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = Color.PaleGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.Location = new Point(563, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(71, 71);
            btnEliminar.TabIndex = 52;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // registrarSsAdicionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(886, 646);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxSsAdic);
            Controls.Add(label7);
            Controls.Add(btnEditar);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecioTotal);
            Controls.Add(label4);
            Controls.Add(txtNombSs);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarSsAdicionales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Servicios  Adicionales";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSsAdic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNombSs;
        private Label label4;
        private TextBox txtPrecioTotal;
        private Label label7;
        private Button btnEditar;
        private Label label6;
        private Button btnCancelar;
        private Label label5;
        private Button btnRegistrar;
        private PictureBox pictureBoxSsAdic;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label9;
        private Button btnEliminar;
        private ErrorProvider errorProvider1;
    }
}