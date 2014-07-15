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
        public MetricReport report(Metric[] metrics, DateTime fromDate, DateTime toDate)
        {
            var report = new MetricReport(fromDate, toDate);
            foreach (Metric metric in metrics)
            {
                var values =
                    (from value in MetricValueStorage.getInstance().all()
                    where value.pairMetric == metric && fromDate <= value.Date && value.Date <= toDate
                     select value).OrderBy(value => value.Date);
                
                report.data.Add(metric, values.ToArray());
            }            
            return report;
        }
    }
}
