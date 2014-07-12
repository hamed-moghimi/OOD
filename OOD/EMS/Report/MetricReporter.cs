using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Audit;

namespace OOD.EMS.Report
{
    class MetricReporter
    {
        public MetricReport report()
        {
            var report = new MetricReport();
            var metrics = MetricStorage.getInstance().all();
            var metricValues = MetricValueStorage.getInstance().all();
            // set report values
            return report;
        }
    }
}
