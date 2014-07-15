using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    [Serializable()]
    public class User : IEquatable<User>
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public AccessLevel ALevel { get; set; }

        public User(String firstname, String lastname, String username, AccessLevel accessLevel)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            ALevel = accessLevel;
        }

        public Boolean hasAccess(Object obj)
        {
            return ALevel.hasAccess(obj);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null) return false;
            User objAsUser = obj as User;
            if (objAsUser == null) return false;
            else return this.Username.Equals(objAsUser.Username); 
        }

        public bool Equals(User user)
        {
            if (user == null) return false;
            return this.Username.Equals(user.Username);
        }

        public String getName()
        {
            return Firstname + " " + Lastname;
        }
    }
}
