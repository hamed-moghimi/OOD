using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Audit
{
    class TaskAudit
    {
        public String Title { set; get; }
        public String Description { set; get; }
        public int Progress { set; get; }
        public Task AuditTask { set; get; }
        public List<Management.Attachment> Attachments { set; get; }

        public TaskAudit(String title, String description, int progress, Task auditTask, List<Management.Attachment> attachments)
        {
            Title = title;
            Description = description;
            Progress = progress;
            AuditTask = auditTask;
            Attachments = attachments;
        }
    }
}
