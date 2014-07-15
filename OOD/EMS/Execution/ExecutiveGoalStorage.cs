using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Execution;

namespace OOD.EMS.Execution
{
    public class ExecutiveGoalStorage
    {
        private static ExecutiveGoalStorage instance;
        private List<ExecutiveGoal> goals;

        private ExecutiveGoalStorage()
        {
            goals = new List<ExecutiveGoal>();

            //TMP
            Department dept = OrganizationStructure.getInstance().Root;
            goals.Add(new ExecutiveGoal("هدف اجرایی ۱", "توضیحات", dept));
            goals.Add(new ExecutiveGoal("هدف اجرایی ۲", "توضیحات", dept));
            goals.Add(new ExecutiveGoal("هدف اجرایی ۳", "توضیحات", dept));
            goals.Add(new ExecutiveGoal("هدف اجرایی ۴", "توضیحات", dept));
        }

        public static ExecutiveGoalStorage getInstance()
        {
            if (instance == null) instance = new ExecutiveGoalStorage();
            return instance;
        }

        public List<ExecutiveGoal> all()
        {
            return goals;
        }

        public void create(ExecutiveGoal goal)
        {
            if (!goals.Contains(goal))
            {
                goals.Add(goal);
            }
        }
    }
}
