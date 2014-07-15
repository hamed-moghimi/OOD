using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
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
            if (instance == null) instance = new MetricValueStorage();
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
