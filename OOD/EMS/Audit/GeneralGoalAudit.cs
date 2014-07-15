using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class GeneralGoalAudit
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public int Progress { get; set; }
        public List<Management.Attachment> Attachments { get; set; }
        public Management.GeneralGoal Goal { get; set; }

        public GeneralGoalAudit(String title, String description, List<Management.Attachment> attachments, int progress,
                Management.GeneralGoal goal)
        {
            Title = title;
            Description = description;
            Progress = progress;
            Attachments = attachments;
            Goal = goal;
        }
    }
}
