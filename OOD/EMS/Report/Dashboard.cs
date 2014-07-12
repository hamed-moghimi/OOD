using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Management;
using EMS.Execution;
using EMS.Audit;

namespace EMS.Report
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
