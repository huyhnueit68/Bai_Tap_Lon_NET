﻿namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class BieuDoTBThanhLy
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
            this.chartThanhLy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartThanhLy)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThanhLy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThanhLy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThanhLy.Legends.Add(legend1);
            this.chartThanhLy.Location = new System.Drawing.Point(12, 12);
            this.chartThanhLy.Name = "chartThanhLy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total";
            this.chartThanhLy.Series.Add(series1);
            this.chartThanhLy.Size = new System.Drawing.Size(776, 389);
            this.chartThanhLy.TabIndex = 0;
            this.chartThanhLy.Text = "chart1";
            this.chartThanhLy.Click += new System.EventHandler(this.chartThanhLy_Click);
            // 
            // BieuDoTBThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.chartThanhLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BieuDoTBThanhLy";
            this.Text = "Biểu Đồ Thống Kê Thiết Bị Thanh Lý Hằng Năm";
            this.Load += new System.EventHandler(this.BieuDoTBThanhLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThanhLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThanhLy;
    }
}