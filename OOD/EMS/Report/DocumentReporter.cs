using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Execution;
using EMS.Audit;
using EMS.Management;
using EMS.Report;

namespace EMS.Report
{
    class DocumentReporter
    {
        public DocumentReport report()
        {
            var report = new DocumentReport();
            var goals = ExecutiveGoalStorage.getInstance().all();
            var tasks = TaskStorage.getInstance().all();
            var metrics = MetricStorage.getInstance().all();
            var metricValues = MetricValueStorage.getInstance().all();
            // set report value
            return report;
        }
    }
}
