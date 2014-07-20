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
using Braincase.GanttChart;
using System.Linq;

namespace OOD.EMS.UI.Report
{
    public partial class ScheduleReportResultForm : TemplateDialog
    {
        private int dayShift = 9;
        private int MonthShift = 50;

        public ScheduleReportResultForm(ScheduleReport report)
        {
            InitializeComponent();
            List<Contribution> tasks = report.tasks.ToList();
            ProjectManager manager = new ProjectManager();
            DateTime Start = report.fromDate;
            
            foreach (Contribution con in tasks)
            {
                EMS.Execution.Task t = con.ContTask;
                Braincase.GanttChart.Task chart_task = new Braincase.GanttChart.Task();
                chart_task.Name = t.Title;
                manager.Add(chart_task);
                manager.SetStart(chart_task, (int)Math.Floor((t.StartDate.Date - Start.Date).TotalDays));
                manager.SetDuration(chart_task, (int)Math.Floor((t.DueDate.Date - t.StartDate.Date).TotalDays));
                manager.SetComplete(chart_task, (float)(t.Progress / 100.0));
                
            }
            manager.Start = Start.AddDays(dayShift);
            manager.TimeScale = TimeScale.Day;
            var span = DateTime.Today.AddMonths(MonthShift).Date - manager.Start.Date;
            manager.Now = (int)Math.Floor(span.TotalDays + dayShift);
            chart1.Init(manager);
            chart1.TimeScaleDisplay = TimeScaleDisplay.DayOfWeek;
        }

    }
}
