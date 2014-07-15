using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    [Serializable()]
    public class BasicUser : AccessLevel
    {

        public BasicUser()
        {
        }

        public override Boolean hasAccess(Object obj)
        {
            if (obj is Report.MetricReporter || obj is Report.DocumentReporter || obj is Report.ScheduleReporter
                || obj is Report.Dashboard)
            {
                return true;
            }

            return false;
        }

        public override Boolean canViewManagementDocs() { return true; }
        public override Boolean canModifyManagementDocs() { return false; }
        public override Boolean canDeleteManagementDocs() { return false; }
        //Executive
        public override Boolean canViewExecutiveDocs() { return true; }
        public override Boolean canModifyExecutiveDocs() { return false; }
        public override Boolean canDeleteExecutiveDocs() { return false; }
        //Audit
        public override Boolean canViewAuditDocs() { return true; }
        public override Boolean canModifyAuditDocs() { return false; }
        public override Boolean canDeleteAuditDocs() { return false; }
        //Report
        public override Boolean canGetReport() { return true; }
        public override Boolean canViewDashboard() { return true; }
        //Admin
        public override Boolean canManageUsers() { return false; }
    }
}
