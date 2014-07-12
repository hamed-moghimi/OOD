using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    class ExecutiveGoalAudit
    {
        public String Title { set; get; }
        public String Description { set; get; }
        public int Progress { set; get; }
        public Execution.ExecutiveGoal Goal { set; get; }
        public List<Management.Attachment> Attachments { set; get; }

        public ExecutiveGoalAudit(String title, String description, List<Management.Attachment> attachments, int progress,
                Execution.ExecutiveGoal goal)
        {
            Title = title;
            Description = description;
            Progress = progress;
            Attachments = attachments;
            Goal = goal;
        }

    }
}
