using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class EnvironEffect : ManagementDocument, IEquatable<EnvironEffect>
    {
        public EnvironEffect(String title, String description)
        {
            Title = title;
            Description = description;
            Date = DateTime.Now;
            DocUser = Authentication.getInstance().ActiveUser;
            attachments = new List<Attachment>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            EnvironEffect doc = obj as EnvironEffect;
            if (doc == null)
            {
                return false;
            }
            else return Title.Equals(doc.Title);
            
        }

        public bool Equals(EnvironEffect doc)
        {
            if (doc == null)
            {
                return false;
            }
            else return Title.Equals(doc.Title);

        }

        public String getDateString()
        {
            return Date.ToString("yyyy/MM/dd");
        }
    }
}
