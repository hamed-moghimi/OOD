using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Report
{
    class DocumentReport
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public int generalGoals { get; set; }
        public int executiveGoals { get; set; }
        public double averageProgramProgress { get; set; }
        // some more fields
    }
}
