using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public abstract class BaseAudit
    {
        public User Creator { set; get; }
        public String Description { set; get; }
        public DateTime Date { set; get; }
        public List<Management.Attachment> Attachments { set; get; }

        public BaseAudit(User creator, string description, List<Management.Attachment> attachments)
        {
            Creator = creator;
            Description = description;
            Attachments = attachments;
            Date = DateTime.Today;
        }
    }
}
