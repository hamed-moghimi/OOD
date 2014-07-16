using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    public class ExecutiveGoalAudit : BaseAudit
    {
        public int Progress { set; get; }
        public Execution.ExecutiveGoal Goal { set; get; }

        public ExecutiveGoalAudit(Execution.ExecutiveGoal goal,
            Users.User creator, int progress, String description,
            List<Management.Attachment> attachments)
            : base(creator, description, attachments)
        {
            Progress = progress;
            Goal = goal;
        }

        public override string ToString()
        {
            return Goal.Title;
        }
    }
}
