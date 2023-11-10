namespace SistemaDeGestionHotel.views.Reportes
{
    partial class ReporteSsAdicionales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            chartCantidadServicios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBoxMeses = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartCantidadServicios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 32);
            label1.Name = "label1";
            label1.Size = new Size(642, 37);
            label1.TabIndex = 0;
            label1.Text = "Reporte de servicios adicionales solicitados:";
            // 
            // chartCantidadServicios
            // 
            chartArea1.Name = "ChartArea1";
            chartCantidadServicios.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCantidadServicios.Legends.Add(legend1);
            chartCantidadServicios.Location = new Point(80, 233);
            chartCantidadServicios.Name = "chartCantidadServicios";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Servicios";
            chartCantidadServicios.Series.Add(series1);
            chartCantidadServicios.Size = new Size(300, 300);
            chartCantidadServicios.TabIndex = 1;
            chartCantidadServicios.Text = "chart1";
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(163, 190);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(121, 23);
            comboBoxMeses.TabIndex = 36;
            comboBoxMeses.SelectedIndexChanged += CargarDatosIngresos;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(163, 161);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 37;
            label6.Text = "Selecione período: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 101);
            label2.Name = "label2";
            label2.Size = new Size(336, 25);
            label2.TabIndex = 2;
            label2.Text = "Cantidades por servicio adicional:";
            // 
            // ReporteSsAdicionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 597);
            Controls.Add(label6);
            Controls.Add(comboBoxMeses);
            Controls.Add(label2);
            Controls.Add(chartCantidadServicios);
            Controls.Add(label1);
            Name = "ReporteSsAdicionales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteSsAdicionales";
            ((System.ComponentModel.ISupportInitialize)chartCantidadServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantidadServicios;
        private ComboBox comboBoxMeses;
        private Label label6;
        private Label label2;
    }
}