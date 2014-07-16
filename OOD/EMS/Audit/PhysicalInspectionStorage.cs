using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class PhysicalInspectionStorage
    {
        private static PhysicalInspectionStorage instance;
        private List<PhysicalInspection> audits;

        private PhysicalInspectionStorage()
        {
        }

        public static PhysicalInspectionStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().physInspectionStorage == null)
                    instance = new PhysicalInspectionStorage();
                else instance = Storage.getInstance().physInspectionStorage;
            }
            return instance;
        }

        public List<PhysicalInspection> all()
        {
            return audits;
        }

        public void create(PhysicalInspection item)
        {
            audits.Add(item);
        }

        public void remove(PhysicalInspection item)
        {
            audits.Remove(item);
        }
    }
}
