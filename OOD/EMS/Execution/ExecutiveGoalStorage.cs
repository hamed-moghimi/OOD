using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class ExecutiveGoalStorage
    {
        private static ExecutiveGoalStorage instance;
        private List<ExecutiveGoal> goals;

        private ExecutiveGoalStorage()
        {
            goals = new List<ExecutiveGoal>();
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
