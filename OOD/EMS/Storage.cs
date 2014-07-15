using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Audit;
using OOD.EMS.Execution;
using OOD.EMS.Management;
using OOD.EMS.Users;


namespace OOD.EMS
{
    public class Storage
    {
        private static Storage instance;

        //Management
        public GeneralGoalStorage generalGoalStorage { get; set; }
        public LegalConstraintStorage legalConstraintStorage { get; set; }
        public EnvironEffectStorage environEffectStorage { get; set; }
        public GeneralGoal_EnvironEffectRelationStorage genGoal_EnvironEffectStorage { get; set; }
        public GeneralGoal_LegalConstraintRelationStorage genGoal_LegalStorage { get; set; }
        public LegalConstraint_EnvironEffectRelationStorage legal_EnvironStorage { get; set; }

        //Execution
        public ResourceStorage resourceStorage { get; set; }
        public OrganizationStructure structure { get; set; }
        public ExecutiveGoalStorage executiveGoalStorage { get; set; }
        public TaskStorage taskStorage { get; set; }
        public GeneralGoal_ExecutiveGoalRelationStorage genGoal_ExecGoalStorage { get; set; }

        //Users
        public UserStorage userStorage { get; set; }

        private Storage()
        {
        }

        public static Storage getInstance()
        {
            if (instance == null) instance = new Storage();
            return instance;
        }

        public void init(String path)
        {
            
        }

        public void save()
        {
        }

        public void load()
        {
        }
    }
}
