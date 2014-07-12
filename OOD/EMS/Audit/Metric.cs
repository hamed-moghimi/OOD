using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    public class Metric
    {
        public String Name { set; get; }

        public Metric(String name)
        {
            Name = name;
        }
    }
}
