using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.User
{
    public class Administrator : AccessLevel
    {
        public override Boolean hasAccess(Object obj)
        {
            if(obj is User || obj is AccessLevel){
                return true;
            }
            return false;
        }

        //Management
        public override Boolean canViewManagementDocs() { return false; }
        public override Boolean canModifyManagementDocs() { return false; }
        public override Boolean canDeleteManagementDocs() { return false; }
        //Executive
        public override Boolean canViewExecutiveDocs() { return false; }
        public override Boolean canModifyExecutiveDocs() { return false; }
        public override Boolean canDeleteExecutiveDocs() { return false; }
        //Audit
        public override Boolean canViewAuditDocs() { return false; }
        public override Boolean canModifyAuditDocs() { return false; }
        public override Boolean canDeleteAuditDocs() { return false; }
        //Report
        public override Boolean canGetReport() { return false; }
        public override Boolean canViewDashboard() { return false; }
        //Admin
        public override Boolean canManageUsers() { return true; }
    }
}
