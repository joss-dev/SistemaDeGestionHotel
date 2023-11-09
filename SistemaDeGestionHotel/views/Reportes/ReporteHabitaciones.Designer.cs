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
            dateTimeHasta = new DateTimePicker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            ChartTotalHab.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartTotalHab.Legends.Add(legend1);
            ChartTotalHab.Location = new Point(101, 209);
            ChartTotalHab.Name = "ChartTotalHab";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.Legend = "Legend1";
            series1.Name = "Estado de Habitaciones";
            series1.YValuesPerPoint = 2;
            ChartTotalHab.Series.Add(series1);
            ChartTotalHab.Size = new Size(312, 300);
            ChartTotalHab.TabIndex = 4;
            ChartTotalHab.Text = "chart2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 124);
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
            label4.Location = new Point(432, 124);
            label4.Name = "label4";
            label4.Size = new Size(243, 25);
            label4.TabIndex = 6;
            label4.Text = "Estado de ocupación al:";
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Anchor = AnchorStyles.None;
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(101, 162);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(95, 23);
            dateTimeHasta.TabIndex = 29;
            dateTimeHasta.ValueChanged += CambiarPyramidHabitaciones;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(438, 209);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 621);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(640, 150);
            dataGridView1.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(101, 593);
            label5.Name = "label5";
            label5.Size = new Size(237, 25);
            label5.TabIndex = 31;
            label5.Text = "Detalle de habitaciones";
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
            iconButton1.Location = new Point(668, 777);
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
            label6.Location = new Point(664, 830);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 63;
            label6.Text = "Volver";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(438, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 65;
            // 
            // ReporteHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 862);
            Controls.Add(dateTimePicker1);
            Controls.Add(iconButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimeHasta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ChartTotalHab);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReporteHabitaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteHabitaciones";
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTotalHab;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}