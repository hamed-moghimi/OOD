using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Management
{
    public class GeneralGoalStorage
    {
        private static GeneralGoalStorage instance;
        private List<GeneralGoal> generalGoals;

        private GeneralGoalStorage()
        {
            generalGoals = new List<GeneralGoal>();
        }

        public static GeneralGoalStorage getInstance()
        {
            if (instance == null) instance = new GeneralGoalStorage();
            return instance;
        }

        public List<GeneralGoal> all()
        {
            return generalGoals;
        }

        public void create(GeneralGoal g)
        {
            if (!generalGoals.Contains(g))
            {
                generalGoals.Add(g);
            }
        }

    }
}
