using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Users
{
    [Serializable()]
    public class UserStorage
    {
        private static UserStorage instance;
        private List<User> userList;

        private UserStorage()
        {
            userList = new List<User>();

            //TMP
            userList.Add(new User("مینا", "طهماسبی", "minmit", new Manager()));
            userList.Add(new User("حامد", "مقیمی", "shmoghimi70", new HeadManager()));
            userList.Add(new User("بهروز", "ربیعی", "brabiee", new Inspector()));
            userList.Add(new User("فرهاد", "شاه‌محمدی", "farhadfnr", new Administrator()));
        }

        public List<User> all()
        {
            return userList;
        }

        public void create(User user)
        {
            if(!userList.Contains(user)){
                userList.Add(user);
            }
        }

        public void remove(User user)
        {
            userList.Remove(user);
        }

        public static UserStorage getInstance()
        {
            if (instance == null)
            {
                instance = new UserStorage();
            }
            return instance;
        }

    }
}
