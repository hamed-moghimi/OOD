using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    class TaskAuditStorage
    {
        private TaskAuditStorage instance;
        private List<TaskAudit> audits;

        private TaskAuditStorage()
        {
        }

        public TaskAuditStorage getInstance()
        {
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
