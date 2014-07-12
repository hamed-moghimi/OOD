using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    class ExecutiveGoalAuditStorage
    {
        private ExecutiveGoalAuditStorage instance;
        private List<ExecutiveGoalAudit> audits;

        private ExecutiveGoalAuditStorage()
        {
        }

        public ExecutiveGoalAuditStorage getInstance()
        {
            return instance;
        }

        public List<ExecutiveGoalAudit> all()
        {
            return audits;
        }

        public void create(ExecutiveGoalAudit item)
        {
            audits.Add(item);
        }

        public void remove(ExecutiveGoalAudit item)
        {
            audits.Remove(item);
        }
    }
}
