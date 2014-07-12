using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    class ExecutionInspectionStorage
    {
        private ExecutionInspectionStorage instance;
        private List<ExecutionInspection> audits;

        private ExecutionInspectionStorage()
        {
        }

        public ExecutionInspectionStorage getInstance()
        {
            return instance;
        }

        public List<ExecutionInspection> all()
        {
            return audits;
        }

        public void create(ExecutionInspection item)
        {
            audits.Add(item);
        }

        public void remove(ExecutionInspection item)
        {
            audits.Remove(item);
        }
    }
}
