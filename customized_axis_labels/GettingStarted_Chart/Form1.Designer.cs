using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GettingStarted_Chart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public List<String> arrLabel;

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
            Panel panel = new Panel();

            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SuspendLayout();
            panel.SuspendLayout();

            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.IsWindowLess = false;            
            this.chartControl1.TabIndex = 0;            
            this.chartControl1.Skins = Skins.Midnight;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.LightGray, System.Drawing.Color.LightBlue);
          
            ChartTitle title = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            title.ForeColor = System.Drawing.Color.White;
            title.Text = "Watch sales in australia";
            this.chartControl1.Titles.Add(title);
            //
            // PrimaryXAxis
            //
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Category;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.White;
            DateTime dateTime = new DateTime(2020,12,12);

            ChartSeries series = new ChartSeries("Series Name", ChartSeriesType.Column);

            series.Points.Add(15, 43000 );
            series.Points.Add(21, 37000 );
            series.Points.Add(33, 67000);
            series.Points.Add(34, 18000);
            series.Points.Add(56, 22000);
            series.Points.Add(86, 30000);
            series.Points.Add(76, 40000);
            // Add the series to the chart series collection.

            arrLabel = new List<string>();
            arrLabel.Add("Sonata");
            arrLabel.Add("Titan");
            arrLabel.Add("Fastrack");
            arrLabel.Add("Rolex");
            arrLabel.Add("Omega");
            arrLabel.Add("Timex");
            arrLabel.Add("Maruti");

            this.chartControl1.Series.Add(series);

            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Series.Add(series);

            this.chartControl1.ChartFormatAxisLabel += ChartControl1_ChartFormatAxisLabel;
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Tooltip.BackgroundColor = new BrushInfo(Color.White);
            this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            this.chartControl1.Tooltip.Font = new Font("Segoe UI", 10);
            series.PointsToolTipFormat = "{2}";

            this.chartControl1.Size = new System.Drawing.Size(850, 450);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 577);

            panel.AutoSize = true;
            panel.Controls.Add(chartControl1);

            this.Controls.Add(panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private void ChartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            int index = (int)e.Value;
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (index >= 0 && index < arrLabel.Count)
                {
                    e.Label = arrLabel[index].ToString();
                }
            }

            e.Handled = true;
        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
    }
}

