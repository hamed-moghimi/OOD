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
        public ScheduleReport report()
        {
            var report = new ScheduleReport();
            var goals = ExecutiveGoalStorage.getInstance().all();
            var tasks = TaskStorage.getInstance().all();
            // set report values
            return report;
        }
    }
}
