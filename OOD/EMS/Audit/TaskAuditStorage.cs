using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    class TaskAuditStorage
    {
        private static TaskAuditStorage instance;
        private List<TaskAudit> audits;

        private TaskAuditStorage()
        {
            audits = new List<TaskAudit>();
        }

        public static TaskAuditStorage getInstance()
        {
            if (instance == null)
                instance = new TaskAuditStorage();
            return instance;
        }

        public List<TaskAudit> all()
        {
            return audits;
        }

        public void create(TaskAudit item)
        {
            audits.Add(item);
        }

        public void remove(TaskAudit item)
        {
            audits.Remove(item);
        }
    }
}
