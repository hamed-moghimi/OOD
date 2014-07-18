using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Metric metric = obj as Metric;
            if (metric == null) return false;
            return this.Name.Equals(metric.Name);
        }
    }
}
