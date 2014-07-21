using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Execution;
using Braincase.GanttChart;
using OOD.EMS.Report;

namespace OOD.EMS.UI.Report
{
    public partial class TimeReportForm : TemplateDialog
    {
        public TimeReportForm(ExecutionProgram program)
        {
            InitializeComponent();
            List<EMS.Execution.Task> tasks = program.getTasks();
            ProjectManager manager = new ProjectManager();
            DateTime Start = program.getStartDate();
            
            foreach (EMS.Execution.Task t in tasks)
            {
                Braincase.GanttChart.Task chart_task = new Braincase.GanttChart.Task();
                chart_task.Name = t.Title;
                manager.Add(chart_task);
                //manager.SetStart(chart_task, (int)Math.Ceiling((t.StartDate.d - Start).TotalDays));
                manager.SetEnd(chart_task, (int)Math.Ceiling((t.DueDate - Start).TotalDays));
                manager.SetComplete(chart_task, (float)(t.Progress / 100.0));
                
            }

            manager.Start = program.getStartDate().AddDays(10);

            manager.TimeScale = TimeScale.Day;
            var span = DateTime.Today - manager.Start;
            manager.Now = (int)Math.Ceiling(span.TotalDays + 10);
            chart1.Init(manager);
            chart1.TimeScaleDisplay = TimeScaleDisplay.DayOfMonth;
        }
    }
}
