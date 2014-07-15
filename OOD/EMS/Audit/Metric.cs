using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    public class Metric
    {
        public String Name { set; get; }

        public String Unit { set; get; }

        public Metric(String name, String unit)
        {
            Name = name;
            Unit = unit;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
