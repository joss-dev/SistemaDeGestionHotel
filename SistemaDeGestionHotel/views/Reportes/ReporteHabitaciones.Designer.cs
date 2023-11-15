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
            label1 = new Label();
            label2 = new Label();
            ChartTotalHab = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label6 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(124, 27);
            label1.Name = "label1";
            label1.Size = new Size(558, 42);
            label1.TabIndex = 1;
            label1.Text = "Situación de estado y ocupación\r\n";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(550, 1);
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
            ChartTotalHab.Location = new Point(211, 138);
            ChartTotalHab.Name = "ChartTotalHab";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series1.Legend = "Legend1";
            series1.Name = "EstadoHabitaciones";
            series1.YValuesPerPoint = 2;
            ChartTotalHab.Series.Add(series1);
            ChartTotalHab.Size = new Size(403, 374);
            ChartTotalHab.TabIndex = 4;
            ChartTotalHab.Text = "chart2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(124, 96);
            label3.Name = "label3";
            label3.Size = new Size(225, 25);
            label3.TabIndex = 5;
            label3.Text = "Totales según estado:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(656, 593);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 63;
            label6.Text = "Volver";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Teal;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(661, 540);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(55, 50);
            iconButton1.TabIndex = 64;
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // ReporteHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(800, 689);
            Controls.Add(iconButton1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(ChartTotalHab);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReporteHabitaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteHabitaciones";
            Load += ActualizarGraficoPyramid;
            ((System.ComponentModel.ISupportInitialize)ChartTotalHab).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTotalHab;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}