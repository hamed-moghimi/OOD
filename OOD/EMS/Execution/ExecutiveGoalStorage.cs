using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Execution;

namespace OOD.EMS.Execution
{
    [Serializable()]
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
            if (instance == null)
            {
                if (Storage.getInstance().executiveGoalStorage == null)
                    instance = new ExecutiveGoalStorage();
                else instance = Storage.getInstance().executiveGoalStorage;
            }
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
