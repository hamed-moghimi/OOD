using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    public class MetricValueList : MetricValueStorage
    {
        public MetricValueList()
        {
        }

        // TODO: What is this?!
        public void update(double value)
        {
            create(new MetricValue(null, value, DateTime.Now));
        }
    }
}
