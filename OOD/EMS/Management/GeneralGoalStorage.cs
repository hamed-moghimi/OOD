using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Management
{
    public class GeneralGoalStorage
    {
        private static GeneralGoalStorage instance;
        private List<GeneralGoal> generalGoals;

        private GeneralGoalStorage()
        {
            generalGoals = new List<GeneralGoal>();

            //TMP
            generalGoals.Add(new GeneralGoal("هدف کلان ۱", "توضیحات هدف کلان ۱"));
            generalGoals.Add(new GeneralGoal("هدف کلان ۲", "توضیحات هدف کلان ۲"));
            generalGoals.Add(new GeneralGoal("هدف کلان ۳", "توضیحات هدف کلان ۳"));
        }

        public static GeneralGoalStorage getInstance()
        {
            if (instance == null) instance = new GeneralGoalStorage();
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
