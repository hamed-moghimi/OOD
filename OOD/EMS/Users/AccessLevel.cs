using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    [Serializable()]
    abstract public class AccessLevel
    {
        public abstract Boolean hasAccess(Object obj);
        //Management
        public abstract Boolean canViewManagementDocs();
        public abstract Boolean canModifyManagementDocs();
        public abstract Boolean canDeleteManagementDocs();
        //Executive
        public abstract Boolean canViewExecutiveDocs();
        public abstract Boolean canModifyExecutiveDocs();
        public abstract Boolean canDeleteExecutiveDocs();
        //Audit
        public abstract Boolean canViewAuditDocs();
        public abstract Boolean canModifyAuditDocs();
        public abstract Boolean canDeleteAuditDocs();
        //Report
        public abstract Boolean canGetReport();
        public abstract Boolean canViewDashboard();
        //Admin
        public abstract Boolean canManageUsers();
    }
}
