using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    class GeneralGoalAuditStorage
    {
        private GeneralGoalAuditStorage instance;
        private List<GeneralGoalAudit> audits;

        private GeneralGoalAuditStorage()
        {
        }

        public GeneralGoalAuditStorage getInstance()
        {
            return instance;
        }

        public List<GeneralGoalAudit> all()
        {
            return audits;
        }

        public void create(GeneralGoalAudit item)
        {
            audits.Add(item);
        }

        public void remove(GeneralGoalAudit item)
        {
            audits.Remove(item);
        }
    }
}
