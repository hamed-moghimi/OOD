using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class ExecutionInspectionStorage
    {
        private static ExecutionInspectionStorage instance;
        private List<ExecutionInspection> audits;

        private ExecutionInspectionStorage()
        {
        }

        public static ExecutionInspectionStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().executionInspectionStorage == null)
                {
                    instance = new ExecutionInspectionStorage();
                }
                else
                {
                    instance = Storage.getInstance().executionInspectionStorage;
                }
            }
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
