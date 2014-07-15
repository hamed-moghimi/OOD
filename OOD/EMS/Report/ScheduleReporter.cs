using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Report;
using OOD.EMS.Execution;

namespace OOD.EMS.Report
{
    class ScheduleReporter
    {
        public ScheduleReport report(ExecutionProgram program, DateTime fromDate, DateTime toDate)
        {
            var report = new ScheduleReport(fromDate, toDate);
            var tasks = 
                (from task in program.Tasks
                where   (fromDate <= task.ContTask.StartDate && task.ContTask.StartDate <= toDate) ||
                        (fromDate <= task.ContTask.DueDate && task.ContTask.DueDate <= toDate)
                select task).OrderBy(item => item.ContTask.StartDate).ToArray();
            report.tasks = tasks;
            return report;
        }
    }
}
