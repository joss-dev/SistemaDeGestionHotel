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
            label5 = new Label();
            ComboAños = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CHIngresoMensual).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(309, 508);
            chart1.Name = "chart1";
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
            CHIngresoMensual.Anchor = AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            CHIngresoMensual.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            CHIngresoMensual.Legends.Add(legend2);
            CHIngresoMensual.Location = new Point(33, 205);
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
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(288, 31);
            label1.Name = "label1";
            label1.Size = new Size(411, 51);
            label1.TabIndex = 2;
            label1.Text = "Reporte de Ingresos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.Anchor = AnchorStyles.None;
            comboBoxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(37, 123);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(121, 23);
            comboBoxMeses.TabIndex = 30;
            comboBoxMeses.SelectedIndexChanged += CambiarChartIngresos;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(262, 476);
            label2.Name = "label2";
            label2.Size = new Size(420, 24);
            label2.TabIndex = 31;
            label2.Text = "Reporte de Ingresos por Medio de Pago :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(329, 163);
            label3.Name = "label3";
            label3.Size = new Size(312, 24);
            label3.TabIndex = 32;
            label3.Text = "Reporte de Ingresos por Mes :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 100);
            label4.Name = "label4";
            label4.Size = new Size(161, 18);
            label4.TabIndex = 33;
            label4.Text = "Seleccione el mes :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(200, 101);
            label5.Name = "label5";
            label5.Size = new Size(156, 18);
            label5.TabIndex = 35;
            label5.Text = "Seleccione el Año:";
            // 
            // ComboAños
            // 
            ComboAños.Anchor = AnchorStyles.None;
            ComboAños.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboAños.FormattingEnabled = true;
            ComboAños.Location = new Point(204, 124);
            ComboAños.Name = "ComboAños";
            ComboAños.Size = new Size(121, 23);
            ComboAños.TabIndex = 34;
            // 
            // ReporteIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(922, 796);
            Controls.Add(label5);
            Controls.Add(ComboAños);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMeses);
            Controls.Add(label1);
            Controls.Add(CHIngresoMensual);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
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
        private Label label5;
        private ComboBox ComboAños;
    }
}