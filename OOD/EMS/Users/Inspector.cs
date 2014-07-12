using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    public class Inspector : BasicUser
    {
        public Inspector()
        {
        }

        public Boolean hasAccess(Object obj)
        {
            if (obj is Audit.ExecutionInspection || obj is Audit.ExecutiveGoalAudit || obj is Audit.GeneralGoalAudit
                || obj is Audit.Metric || obj is Audit.MetricValue || obj is Audit.PhysicalInspection)
            {
                return false;
            }
            return true;
        }

        public override Boolean canModifyAuditDocs() { return true; }
        public override Boolean canDeleteAuditDocs() { return true; }
        
    }
}
