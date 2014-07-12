using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class ExecutiveGoal : IEquatable<ExecutiveGoal>
    {
        public String Title { set; get; }
        public String Description { set; get; }
        public DateTime Date { set; get; }
        public List<Management.Attachment> attachments { set; get; }
        public ExecutionProgram program { set; get; }

        public ExecutiveGoal(String title, String description)
        {
            Title = title;
            Description = description;
            Date = DateTime.Now;
        }

        public int getProgress()
        {
            return program.getProgress();
        }

        public List<Contribution> getAuditInfo()
        {
            return program.Tasks;
        }

        public ExecutionProgram getProgram()
        {
            return program;
        }

        public void addAttachment(Management.Attachment attach)
        {
            attachments.Add(attach);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ExecutiveGoal goal = obj as ExecutiveGoal;
            if (goal == null) return false;
            return Title.Equals(goal.Title);
        }

        public bool Equals(ExecutiveGoal goal)
        {
            if (goal == null) return false;
            return Title.Equals(goal.Title);
        }
    }
}
