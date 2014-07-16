using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    class ExecutiveGoalAuditStorage
    {
        private static ExecutiveGoalAuditStorage instance;
        private List<ExecutiveGoalAudit> audits;

        private ExecutiveGoalAuditStorage()
        {
            audits = new List<ExecutiveGoalAudit>();
        }

        public static ExecutiveGoalAuditStorage getInstance()
        {
            if (instance == null)
                instance = new ExecutiveGoalAuditStorage();
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
