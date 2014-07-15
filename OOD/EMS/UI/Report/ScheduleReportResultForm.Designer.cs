namespace OOD.EMS.UI.Report
{
    partial class ScheduleReportResultForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.LightGoldenrodYellow;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(12, 21);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.CustomProperties = "IsXAxisQuantitative=True, DrawingStyle=Emboss, MinPixelPointWidth=10, MaxPixelPoi" +
    "ntWidth=50";
            series1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.MarkerSize = 3;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(980, 422);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // ScheduleReportResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(1004, 455);
            this.Controls.Add(this.chart);
            this.Name = "ScheduleReportResultForm";
            this.Text = "گزارش روندهای زمانی";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
