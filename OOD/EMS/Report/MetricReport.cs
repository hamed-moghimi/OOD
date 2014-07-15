using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Audit;

namespace OOD.EMS.Report
{
    public class MetricReport
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public Dictionary<Metric, MetricValue[]> data { get; set; }

        public MetricReport(DateTime fromDate, DateTime toDate)
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            data = new Dictionary<Metric, MetricValue[]>();
        }
    }
}
