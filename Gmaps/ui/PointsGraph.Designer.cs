﻿
namespace Gmaps.ui
{
    partial class PointsGraph
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
            this.pointsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pointsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pointsChart.ChartAreas.Add(chartArea1);
            this.pointsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.pointsChart.Legends.Add(legend1);
            this.pointsChart.Location = new System.Drawing.Point(0, 0);
            this.pointsChart.Name = "pointsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Poblacion";
            this.pointsChart.Series.Add(series1);
            this.pointsChart.Size = new System.Drawing.Size(800, 450);
            this.pointsChart.TabIndex = 0;
            this.pointsChart.Text = "chart1";
            // 
            // Points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pointsChart);
            this.Name = "Points";
            this.Text = "Points";
            ((System.ComponentModel.ISupportInitialize)(this.pointsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart pointsChart;
    }
}