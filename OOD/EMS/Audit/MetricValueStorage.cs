using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class MetricValueStorage
    {
        private static MetricValueStorage instance;
        private List<MetricValue> values;

        protected MetricValueStorage()
        {
            values = new List<MetricValue>();
        }

        public static MetricValueStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().metricValueStorage == null)
                    instance = new MetricValueStorage();
                else instance = Storage.getInstance().metricValueStorage;
            }

            return instance;
        }

        public List<MetricValue> all()
        {
            return values;
        }

        public void create(MetricValue value)
        {
            values.Add(value);
        }

        public void remove(MetricValue value)
        {
            values.Remove(value);
        }

        public void addAll(List<MetricValue> list)
        {
            foreach (MetricValue item in list)
            {
                create(item);
            }
        }
    }
}
