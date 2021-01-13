# How-to-change-the-axis-labels-of-Windows-Forms-Charts
This article explains how to change the axis labels in [WinForms Charts]. For below tabulated data points with column series , will be populated in WinForms Chart as like in below


**Data points:**

X	Y
15	43000
21	37000
33	67000
34	18000
56	22000
86	30000
76	40000

**Output:**

![](https://github.com/SyncfusionExamples/How-to-change-the-axis-labels-of-Windows-Forms-Charts/blob/main/default_chart.png)
  

If you want to change the axis label with your desired text, it has been achieved by using ChartFormatAxisLabel event of chart control. Default axis label has been changed by assigning your desired text in Label property from the argument of ChartFormatAxisLabel as per in below code example.

[C#]

```
this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.Skins = Skins.Midnight;
            
            // Add the axis to the chart primary x-axis collection. 
            arrLabel = new List<string>();
            arrLabel.Add("Sonata");
            arrLabel.Add("Titan");
            arrLabel.Add("Fastrack");
            arrLabel.Add("Rolex");
            arrLabel.Add("Omega");
            arrLabel.Add("Timex");
            arrLabel.Add("Maruti");

            this.chartControl1.ChartFormatAxisLabel += ChartControl1_ChartFormatAxisLabel; 
            panel.Controls.Add(chartControl1);
. . . . 
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
```

![](https://github.com/SyncfusionExamples/How-to-change-the-axis-labels-of-Windows-Forms-Charts/blob/main/customized_axis_label_chart.png)
 
# See also 

[How to save the chart template without getting a popup in WF Chart](https://www.syncfusion.com/kb/11853/how-to-save-the-chart-template-without-getting-a-popup-in-wf-chart)

[How to create Chart in VB .NET Windows Forms](https://www.syncfusion.com/kb/10806/how-to-create-chart-in-vb-net-windows-forms)

[How to enable or disable the data points in HistogramSeries](https://www.syncfusion.com/kb/9349/how-to-enable-or-disable-the-data-points-in-histogramseries)

[How to bind the data source via chart wizard](https://www.syncfusion.com/kb/7680/how-to-bind-the-data-source-via-chart-wizard)
