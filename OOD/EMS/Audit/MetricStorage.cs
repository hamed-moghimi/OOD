using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    class MetricStorage
    {
        private static MetricStorage instance;
        private List<Metric> metrics;

        private MetricStorage()
        {
        }

        public static MetricStorage getInstance()
        {
            return instance;
        }

        public List<Metric> all()
        {
            return metrics;
        }

        public void create(Metric item)
        {
            metrics.Add(item);
        }

        public void remove(Metric item)
        {
            metrics.Remove(item);
        }
    }
}
