using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Audit
{
    class TaskAudit
    {
        public User Creator { set; get; }
        public String Description { set; get; }
        public int Progress { set; get; }
        public Task AuditTask { set; get; }
        public List<Management.Attachment> Attachments { set; get; }

        public TaskAudit(User creator, String description, int progress, Task auditTask, List<Management.Attachment> attachments)
        {
            Creator = creator;
            Description = description;
            Progress = progress;
            AuditTask = auditTask;
            Attachments = attachments;
        }
    }
}
