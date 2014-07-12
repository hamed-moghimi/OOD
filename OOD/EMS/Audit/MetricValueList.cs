using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    public class MetricValueList : MetricValueStorage
    {
        public MetricValueList()
        {
        }

        public void update(double value)
        {
            create(value);
        }
    }
}
