using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOD.EMS.Execution;
using OOD.EMS.Users;

namespace OOD.EMS.Audit
{
    public class TaskAudit : BaseAudit
    {
        public int Progress { set; get; }
        public Task AuditTask { set; get; }

        public TaskAudit(Task auditTask, User creator, String description,
            int progress, List<Management.Attachment> attachments)
            : base(creator, description, attachments)
        {
            Progress = progress;
            AuditTask = auditTask;
        }
    }
}
