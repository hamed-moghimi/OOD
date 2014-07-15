using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class ExecutiveGoalAuditStorage
    {
        private static ExecutiveGoalAuditStorage instance;
        private List<ExecutiveGoalAudit> audits;

        private ExecutiveGoalAuditStorage()
        {
        }

        public static ExecutiveGoalAuditStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().executiveGoalAuditStorage == null)
                {
                    instance = new ExecutiveGoalAuditStorage();
                }
                else
                {
                    instance = Storage.getInstance().executiveGoalAuditStorage;
                }
            }
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
