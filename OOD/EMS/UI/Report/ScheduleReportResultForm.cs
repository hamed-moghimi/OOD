using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OOD.EMS.Report;
using OOD.EMS.Execution;

namespace OOD.EMS.UI.Report
{
    public partial class ScheduleReportResultForm : TemplateDialog
    {
        private ScheduleReport report;

        public ScheduleReportResultForm(ScheduleReport report)
        {
            InitializeComponent();
            this.report = report;
            // draw chart
            var series = chart.Series[0];
            //var chartArea = chart.ChartAreas[0];
            //series.ChartArea = chartArea;
            //series.
            int i = 1;
            foreach (Contribution task in report.tasks)
            {
                var point = new DataPoint();
                point.XValue = i++;
                var start = (task.ContTask.StartDate - report.fromDate).Days;
                var end = (task.ContTask.DueDate - report.fromDate).Days;
                point.SetValueY(start, end);
                point.Label = task.ContTask.Title;
                series.Points.Add(point);
            }
        }
    }
}
