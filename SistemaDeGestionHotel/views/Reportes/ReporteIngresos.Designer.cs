namespace SistemaDeGestionHotel.views.Reportes
{
    partial class ReporteIngresos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CHIngresoMensual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            dateTimeInicio = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CHIngresoMensual).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(405, 546);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series1.LabelForeColor = Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Ingresos";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 0;
            chart1.Text = "Ingresos";
            // 
            // CHIngresoMensual
            // 
            chartArea2.Name = "ChartArea1";
            CHIngresoMensual.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            CHIngresoMensual.Legends.Add(legend2);
            CHIngresoMensual.Location = new Point(113, 155);
            CHIngresoMensual.Name = "CHIngresoMensual";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            CHIngresoMensual.Series.Add(series2);
            CHIngresoMensual.Size = new Size(300, 300);
            CHIngresoMensual.TabIndex = 1;
            CHIngresoMensual.Text = "chart2";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 32.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(215, 22);
            label1.Name = "label1";
            label1.Size = new Size(450, 50);
            label1.TabIndex = 2;
            label1.Text = "Reporte de Ingresos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Anchor = AnchorStyles.None;
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            dateTimeInicio.Location = new Point(405, 493);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(95, 23);
            dateTimeInicio.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(610, 493);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 30;
            // 
            // ReporteIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 877);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimeInicio);
            Controls.Add(label1);
            Controls.Add(CHIngresoMensual);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ReporteIngresos";
            Text = "ReporteIngresos";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CHIngresoMensual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHIngresoMensual;
        private Label label1;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}