using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    public class ManagementDocument
    {
        public String Description { set; get; }
        public String Title { set; get; }
        public DateTime Date { set; get; }
        public Users.User DocUser { set; get; }
        public List<Attachment> attachments {set; get;}

        public void addAttachment(Attachment attach)
        {
            attachments.Add(attach);
        }
    }
}
