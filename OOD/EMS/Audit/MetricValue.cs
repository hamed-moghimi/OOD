using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    public class MetricValue
    {
        public Metric pairMetric { set; get; }
        public double Value { set; get; }

        public MetricValue(Metric metric, double value)
        {
            pairMetric = metric;
            Value = value;
        }
    }
}
