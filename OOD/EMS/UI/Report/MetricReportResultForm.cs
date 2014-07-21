using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OOD.EMS.Report;

namespace OOD.EMS.UI.Report
{
    public partial class MetricReportResultForm : TemplateDialog
    {
        private MetricReport report;
        
        public MetricReportResultForm(MetricReport report)
        {
            InitializeComponent();
            this.report = report;
            fromDateBox.Text = report.fromDate.ToShortDateString();
            toDateBox.Text = report.toDate.ToShortDateString();
            Color[] colors = new Color[] {Color.Red, Color.Blue, Color.Green, Color.Violet, Color.Cyan};
            int i = 0;
            foreach (var record in report.data)
            {
                var metric = record.Key;
                var values = record.Value;
                var series = chart.Series.Add(metric.Name);
                series.BorderWidth = 2;
                series.ChartArea = chart.ChartAreas[0].Name;
                series.ChartType = SeriesChartType.Line;
                series.IsValueShownAsLabel = true;
                series.Color = colors[i];
                i = (i + 1) % colors.Count();
                foreach (var value in values)
                    series.Points.AddXY(value.Date, value.Value);
                foreach (DataPoint p in series.Points)
                {
                    p.MarkerStyle = MarkerStyle.Circle;
                    p.MarkerSize = 5;
                }
            }
        }
    }
}
