using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class GeneralGoalAuditStorage
    {
        private static GeneralGoalAuditStorage instance;
        private List<GeneralGoalAudit> audits;

        private GeneralGoalAuditStorage()
        {
        }

        public static GeneralGoalAuditStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().generalGoalAuditStorage == null)
                    instance = new GeneralGoalAuditStorage();
                else instance = Storage.getInstance().generalGoalAuditStorage;
            }
            return instance;
        }

        public List<GeneralGoalAudit> all()
        {
            return audits;
        }

        public void create(GeneralGoalAudit item)
        {
            audits.Add(item);
        }

        public void remove(GeneralGoalAudit item)
        {
            audits.Remove(item);
        }
    }
}
