using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Execution
{
    public class GeneralGoal_ExecutiveGoalRelation : IEquatable<GeneralGoal_ExecutiveGoalRelation>
    {
        public Management.GeneralGoal GenGoal { set; get; }
        public ExecutiveGoal ExecGoal { set; get; }
        public DateTime Date { set; get; }
        public Users.User RelUser { set; get; }
        public int Contribution { set; get; }


        public GeneralGoal_ExecutiveGoalRelation(Management.GeneralGoal genGoal, ExecutiveGoal execGoal, int contribution)
        {
            GenGoal = genGoal;
            ExecGoal = execGoal;
            Date = DateTime.Now;
            RelUser = Authentication.getInstance().ActiveUser;
            Contribution = contribution;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            GeneralGoal_ExecutiveGoalRelation rel = obj as GeneralGoal_ExecutiveGoalRelation;
            if (rel == null) return false;
            return GenGoal.Equals(rel.GenGoal) && ExecGoal.Equals(rel.ExecGoal) && (Contribution == rel.Contribution);
        }

        public bool Equals(GeneralGoal_ExecutiveGoalRelation rel)
        {
            if (rel == null) return false;
            return GenGoal.Equals(rel.GenGoal) && ExecGoal.Equals(rel.ExecGoal) && (Contribution == rel.Contribution);
        }

    }
}
