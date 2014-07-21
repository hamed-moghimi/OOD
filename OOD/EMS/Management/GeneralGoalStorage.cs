using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;
using OOD.EMS;

namespace OOD.EMS.Management
{
    [Serializable()]
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
            if (instance == null)
            {
                if (Storage.getInstance().generalGoalStorage == null)
                {
                    instance = new GeneralGoalStorage();
                }
                else
                {
                    instance = Storage.getInstance().generalGoalStorage;
                }
            }
            return instance;
        }

        public List<GeneralGoal> all()
        {
            generalGoals.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            return generalGoals;
        }

        public void create(GeneralGoal g)
        {
            if (!generalGoals.Contains(g))
            {
                generalGoals.Add(g);
            }
            else
            {
                throw new GeneralGoalExists();
            }

        }

    }
}
