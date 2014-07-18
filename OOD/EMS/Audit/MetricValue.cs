using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class MetricValue
    {
        public Metric pairMetric { set; get; }
        public double Value { set; get; }
        public DateTime Date { set; get; }

        public MetricValue(Metric metric, double value, DateTime date)
        {
            pairMetric = metric;
            Value = value;
            Date = date;
        }
    }
}
