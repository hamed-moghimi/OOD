using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    public class MetricValueStorage
    {
        private static MetricValueStorage instance;
        private List<MetricValue> values;

        protected MetricValueStorage()
        {
        }

        public static MetricValueStorage getInstance()
        {
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
