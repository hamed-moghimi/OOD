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
            userList.Add(new User("مینا", "طهماسبی", "tahmasbi", new Manager()));
            userList.Add(new User("حامد", "مقیمی", "moghimi", new HeadManager()));
            userList.Add(new User("بهروز", "ربیعی", "rabiee", new Inspector()));
            userList.Add(new User("", "مدیر سامانه", "administrator", new Administrator()));
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
                if (Storage.getInstance().userStorage == null)
                    instance = new UserStorage();
                else instance = Storage.getInstance().userStorage;
            }
            return instance;
        }

    }
}
