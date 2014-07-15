using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using OOD.EMS.Audit;
using OOD.EMS.Execution;
using OOD.EMS.Management;
using OOD.EMS.Users;


namespace OOD.EMS
{
    [Serializable()]
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

        public void save(String path)
        {
            //Management
            generalGoalStorage = GeneralGoalStorage.getInstance();
            legalConstraintStorage = LegalConstraintStorage.getInstance();
            environEffectStorage = EnvironEffectStorage.getInstance();
            genGoal_EnvironEffectStorage = GeneralGoal_EnvironEffectRelationStorage.getInstance();
            genGoal_LegalStorage = GeneralGoal_LegalConstraintRelationStorage.getInstance();
            legal_EnvironStorage = LegalConstraint_EnvironEffectRelationStorage.getInstance();

            //Execution
            resourceStorage = ResourceStorage.getInstance();
            structure = OrganizationStructure.getInstance();
            executiveGoalStorage = ExecutiveGoalStorage.getInstance();
            taskStorage = TaskStorage.getInstance();
            genGoal_ExecGoalStorage = GeneralGoal_ExecutiveGoalRelationStorage.getInstance();

            //Users
            userStorage = UserStorage.getInstance();

            List<Storage> list = new List<Storage>();
            list.Add(this);
            try
            {
                using (Stream stream = File.Open(path + @"\data.ems", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, list);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("در هنگام ایجاد داده‌ها خطا ایجاد شده است");
            }
        }

     
        public void load(String path)
        {
            try
            {
                using (Stream stream = File.Open(path + @"\data.ems", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var Storage = (List<Storage>)bin.Deserialize(stream);
                    instance = Storage[0];
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
