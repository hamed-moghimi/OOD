using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class GeneralGoalAudit : BaseAudit
    {
        public Management.GeneralGoal Goal { get; set; }

        public GeneralGoalAudit(Management.GeneralGoal goal, Users.User creator,
            string description, List<Management.Attachment> attachments)
            : base(creator, description, attachments)
        {
            Goal = goal;
        }
    }
}
