namespace SistemaDeGestionHotel.views.Reportes
{
    partial class ReporteHabitaciones
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            label2 = new Label();
            ChartTotalHab = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            DTPDesde = new DateTimePicker();
            DTPHasta = new DateTimePicker();
            chartReservas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(124, 6);
            label1.Name = "label1";
            label1.Size = new Size(558, 42);
            label1.TabIndex = 1;
            label1.Text = "Situación de estado y ocupación\r\n";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(550, 29);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // ChartTotalHab
            // 
            ChartTotalHab.Anchor = AnchorStyles.Top;
            ChartTotalHab.BackColor = Color.LightSkyBlue;
            ChartTotalHab.BorderlineColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            ChartTotalHab.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            ChartTotalHab.Legends.Add(legend3);
            ChartTotalHab.Location = new Point(251, 86);
            ChartTotalHab.Name = "ChartTotalHab";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series3.Legend = "Legend1";
            series3.Name = "EstadoHabitaciones";
            series3.YValuesPerPoint = 2;
            ChartTotalHab.Series.Add(series3);
            ChartTotalHab.Size = new Size(272, 273);
            ChartTotalHab.TabIndex = 4;
            ChartTotalHab.Text = "chart2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(251, 58);
            label3.Name = "label3";
            label3.Size = new Size(225, 25);
            label3.TabIndex = 5;
            label3.Text = "Totales según estado:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(56, 379);
            label4.Name = "label4";
            label4.Size = new Size(259, 25);
            label4.TabIndex = 6;
            label4.Text = "Estado de reservas entre:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(664, 771);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 63;
            label6.Text = "Volver";
            // 
            // DTPDesde
            // 
            DTPDesde.Anchor = AnchorStyles.None;
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(321, 381);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(95, 23);
            DTPDesde.TabIndex = 65;
            DTPDesde.ValueChanged += ActualizarGraficoChart;
            // 
            // DTPHasta
            // 
            DTPHasta.Anchor = AnchorStyles.None;
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(476, 381);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(95, 23);
            DTPHasta.TabIndex = 66;
            DTPHasta.ValueChanged += ActualizarGraficoChart;
            // 
            // chartReservas
            // 
            chartReservas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea4.Name = "ChartArea1";
            chartReservas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartReservas.Legends.Add(legend4);
            chartReservas.Location = new Point(41, 429);
            chartReservas.Name = "chartReservas";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "CantidadReservas";
            chartReservas.Series.Add(series4);
            chartReservas.Size = new Size(714, 246);
            chartReservas.TabIndex = 67;
            chartReservas.Text = "chart2";
            // 
            // ReporteHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 745);
            Controls.Add(chartReservas);
            Controls.Add(DTPHasta);
            Controls.Add(DTPDesde);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ChartTotalHab);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ReporteHabitaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteHabitaciones";
            Load += ActualizarGraficoPyramid;
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTotalHab;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private DateTimePicker DTPDesde;
        private DateTimePicker DTPHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReservas;
    }
}