using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.User
{
    class UserStorage
    {
        private UserStorage instance;
        private List<User> userList;

        private UserStorage()
        {
            userList = new List<User>();
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

        public UserStorage getInstance()
        {
            if (instance == null)
            {
                instance = new UserStorage();
            }
            return instance;
        }

    }
}
