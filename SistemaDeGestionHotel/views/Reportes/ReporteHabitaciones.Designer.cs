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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            label2 = new Label();
            ChartTotalHab = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            DTPDesde = new DateTimePicker();
            DTPHasta = new DateTimePicker();
            ChartReservas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(123, 36);
            label1.Name = "label1";
            label1.Size = new Size(558, 42);
            label1.TabIndex = 1;
            label1.Text = "Situación de estado y ocupación\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 95);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // ChartTotalHab
            // 
            ChartTotalHab.Anchor = AnchorStyles.None;
            ChartTotalHab.BackColor = Color.LightSkyBlue;
            ChartTotalHab.BorderlineColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            ChartTotalHab.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartTotalHab.Legends.Add(legend1);
            ChartTotalHab.Location = new Point(369, 133);
            ChartTotalHab.Name = "ChartTotalHab";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.Legend = "Legend1";
            series1.Name = "EstadoHabitaciones";
            series1.YValuesPerPoint = 2;
            ChartTotalHab.Series.Add(series1);
            ChartTotalHab.Size = new Size(272, 273);
            ChartTotalHab.TabIndex = 4;
            ChartTotalHab.Text = "chart2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(141, 107);
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
            label4.Location = new Point(56, 428);
            label4.Name = "label4";
            label4.Size = new Size(259, 25);
            label4.TabIndex = 6;
            label4.Text = "Estado de reservas entre:";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Salmon;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(668, 784);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(55, 50);
            iconButton1.TabIndex = 64;
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(664, 837);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 63;
            label6.Text = "Volver";
            // 
            // DTPDesde
            // 
            DTPDesde.Anchor = AnchorStyles.None;
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(271, 473);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(95, 23);
            DTPDesde.TabIndex = 65;
            DTPDesde.ValueChanged += ActualizarGraficoChart;
            // 
            // DTPHasta
            // 
            DTPHasta.Anchor = AnchorStyles.None;
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(440, 473);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(95, 23);
            DTPHasta.TabIndex = 66;
            DTPHasta.ValueChanged += ActualizarGraficoChart;
            // 
            // ChartReservas
            // 
            chartArea2.Name = "ChartArea1";
            ChartReservas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartReservas.Legends.Add(legend2);
            ChartReservas.Location = new Point(56, 504);
            ChartReservas.Name = "ChartReservas";
            ChartReservas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "CantidadReservas";
            ChartReservas.Series.Add(series2);
            ChartReservas.Size = new Size(683, 259);
            ChartReservas.TabIndex = 67;
            ChartReservas.Text = "chart2";
            // 
            // ReporteHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 877);
            Controls.Add(ChartReservas);
            Controls.Add(DTPHasta);
            Controls.Add(DTPDesde);
            Controls.Add(iconButton1);
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
            ((System.ComponentModel.ISupportInitialize)ChartReservas).EndInit();
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
        private DateTimePicker DTPDesde;
        private DateTimePicker DTPHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReservas;
    }
}