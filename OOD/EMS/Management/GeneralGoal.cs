using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    public class GeneralGoal : ManagementDocument, IEquatable<GeneralGoal>
    {

        public GeneralGoal(String title, String descp)
        {
            Title = title;
            Description = descp;
            Date = DateTime.Now;
            DocUser = User.Authentication.getInstance().ActiveUser;
        }

        private List<Execution.ExecutiveGoal> getExecutiveGoals()
        {
            List<Execution.GeneralGoal_ExecutiveGoalRelation> goals = Execution.GeneralGoal_ExecutiveGoalRelationStorage.getInstance().all();
            List<Execution.ExecutiveGoal> res = new List<Execution.ExecutiveGoal>();
            foreach (Execution.GeneralGoal_ExecutiveGoalRelation rel in goals)
            {
                if (rel.GenGoal.Equals(this))
                {
                    res.Add(rel.ExecGoal);
                }
            }
            return res;
            
        }

        public List<Execution.GeneralGoal_ExecutiveGoalRelation> getAuditInfo()
        {
            List<Execution.GeneralGoal_ExecutiveGoalRelation> goals = Execution.GeneralGoal_ExecutiveGoalRelationStorage.getInstance().all();
            List<Execution.GeneralGoal_ExecutiveGoalRelation> res = new List<Execution.GeneralGoal_ExecutiveGoalRelation>();
            foreach (Execution.GeneralGoal_ExecutiveGoalRelation rel in goals)
            {
                if (rel.GenGoal.Equals(this))
                {
                    res.Add(rel);
                }
            }
            return res;
        }

        public int getProgress()
        {
            double progress = 0;
            List<Execution.GeneralGoal_ExecutiveGoalRelation> rels = getAuditInfo();
            foreach (Execution.GeneralGoal_ExecutiveGoalRelation r in rels)
            {
                progress += r.ExecGoal.getProgress() * ((double)r.Contribution/100.0);
            }
            return (int)progress;
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            GeneralGoal goal = obj as GeneralGoal;
            if (goal == null) return false;
            else return Title.Equals(goal.Title);            
        }

        public bool Equals(GeneralGoal goal)
        {
            if (goal == null) return false;
            else return Title.Equals(goal.Title);
        }
       
    }
}
