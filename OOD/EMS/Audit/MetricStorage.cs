using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class MetricStorage
    {
        private static MetricStorage instance;
        private List<Metric> metrics;

        private MetricStorage()
        {
            metrics = new List<Metric>();
        }

        public static MetricStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().metricStorage == null)
                    instance = new MetricStorage();
                else instance = Storage.getInstance().metricStorage;
            }
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
