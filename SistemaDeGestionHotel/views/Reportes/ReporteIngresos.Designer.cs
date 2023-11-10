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
            comboBoxMeses = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CHIngresoMensual).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Bottom;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(301, 448);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series1.LabelForeColor = Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Ingresos";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 276);
            chart1.TabIndex = 0;
            chart1.Text = "Ingresos";
            // 
            // CHIngresoMensual
            // 
            CHIngresoMensual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            CHIngresoMensual.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            CHIngresoMensual.Legends.Add(legend2);
            CHIngresoMensual.Location = new Point(23, 102);
            CHIngresoMensual.Name = "CHIngresoMensual";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            CHIngresoMensual.Series.Add(series2);
            CHIngresoMensual.Size = new Size(871, 246);
            CHIngresoMensual.TabIndex = 1;
            CHIngresoMensual.Text = "chart2";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 51);
            label1.TabIndex = 2;
            label1.Text = "Reporte de Ingresos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(23, 73);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(121, 23);
            comboBoxMeses.TabIndex = 30;
            comboBoxMeses.SelectedIndexChanged += CambiarChartIngresos;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 410);
            label2.Name = "label2";
            label2.Size = new Size(300, 20);
            label2.TabIndex = 31;
            label2.Text = "Reporte de Ingresos por Medio de Pago :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 72);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 32;
            label3.Text = "Reporte de Ingresos por Mes :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 50);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 33;
            label4.Text = "Seleccione el mes :";
            // 
            // ReporteIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGreen;
            ClientSize = new Size(922, 745);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMeses);
            Controls.Add(label1);
            Controls.Add(CHIngresoMensual);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ReporteIngresos";
            Text = "ReporteIngresos";
            Load += CargarDatos;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CHIngresoMensual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHIngresoMensual;
        private Label label1;
        private ComboBox comboBoxMeses;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}