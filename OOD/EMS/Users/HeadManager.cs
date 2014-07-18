using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    [Serializable()]
    public class HeadManager : BasicUser
    {
        public HeadManager()
        {
        }

        public Boolean hasAccess(Object obj)
        {
            if (obj is Management.ManagementDocument || obj is Management.ManagementDocumentRelation)
            {
                return true;
            }
            return false;
        }

        public override Boolean canModifyManagementDocs() { return true; }
        public override Boolean canDeleteManagementDocs() { return true; }
        public override string ToString()
        {
            return "کاربر ارشد";
        }        
    }
}
