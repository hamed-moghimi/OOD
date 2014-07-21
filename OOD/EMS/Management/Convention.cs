using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class Convention
    {
        public String Policy { set; get; }
        public DateTime Date { set; get; }
        public String Description { set; get; }
        public List<Attachment> attachments { set; get; }
        public Users.User DocUser { set; get; }

        private static Convention instance;

        private Convention(String policy, String description)
        {
            Policy = policy;
            Date = DateTime.Now;
            Description = description;
            DocUser = Authentication.getInstance().ActiveUser;
            attachments = new List<Attachment>();
        }

        public static Convention getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().convention == null)
                {
                    instance = new Convention("", "");
                }
                else
                {
                    instance = Storage.getInstance().convention;
                }
            }
            return instance;
        }

        public void addAttachment(Attachment attach)
        {
            attachments.Add(attach);
        }

        
    }
}
