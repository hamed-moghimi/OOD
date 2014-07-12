using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    class PhysicalInspectionStorage
    {
        private PhysicalInspectionStorage instance;
        private List<PhysicalInspection> audits;

        private PhysicalInspectionStorage()
        {
        }

        public PhysicalInspectionStorage getInstance()
        {
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
