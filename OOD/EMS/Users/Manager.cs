using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    [Serializable()]
    public class Manager : BasicUser
    {
        public Manager()
        {
        }

        public Boolean hasAccess(Object obj)
        {
            if (obj is Execution.ExecutiveGoal || obj is Execution.ExecutionProgram 
                || obj is Execution.GeneralGoal_ExecutiveGoalRelation)
            {
                return true;
            }
            return false;
        }

        public override Boolean canModifyExecutiveDocs() { return true; }
        public override Boolean canDeleteExecutiveDocs() { return true; }
        
    }
}
