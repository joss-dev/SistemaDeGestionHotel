namespace SistemaDeGestionHotel.views
{
    partial class Home
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
            chartRedondo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartRedondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(295, 48);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido ";
            // 
            // chartRedondo
            // 
            chartRedondo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartRedondo.BackColor = Color.SteelBlue;
            chartRedondo.BorderSkin.BorderColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartRedondo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRedondo.Legends.Add(legend1);
            chartRedondo.Location = new Point(24, 286);
            chartRedondo.Name = "chartRedondo";
            series1.BackImageTransparentColor = Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRedondo.Series.Add(series1);
            chartRedondo.Size = new Size(245, 224);
            chartRedondo.TabIndex = 1;
            chartRedondo.Text = "chart1";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chart1.BackColor = Color.SteelBlue;
            chart1.BorderSkin.BorderColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(302, 295);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            chart1.Series.Add(series2);
            chart1.Size = new Size(241, 224);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chart1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chartRedondo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 564);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 249);
            label3.Name = "label3";
            label3.Size = new Size(309, 24);
            label3.TabIndex = 5;
            label3.Text = "Datos y estadisticas : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 87);
            label2.Name = "label2";
            label2.Size = new Size(320, 48);
            label2.TabIndex = 4;
            label2.Text = "Hotel Paraná";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(580, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)chartRedondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRedondo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private Label label3;
        private Label label2;
    }
}