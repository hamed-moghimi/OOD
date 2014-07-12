using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Management;
using OOD.EMS.Execution;
using OOD.EMS.Audit;

namespace OOD.EMS.Report
{
    class Dashboard
    {
        private void collectInfo()
        {
            var generals = GeneralGoalStorage.getInstance().all();
            var execs = ExecutiveGoalStorage.getInstance().all();
            var metricValues = MetricValueStorage.getInstance().all();
            // do some queries on lists
        }
        
        public void show()
        {
            collectInfo();
        }

        public void refresh()
        {
            collectInfo();
        }
    }
}
