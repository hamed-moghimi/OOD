using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Management
{
    public class EnvironEffect : ManagementDocument, IEquatable<EnvironEffect>
    {
        public EnvironEffect(String title, String description)
        {
            Title = title;
            Description = description;
            Date = DateTime.Now;
            DocUser = User.Authentication.getInstance().ActiveUser;
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
    }
}
