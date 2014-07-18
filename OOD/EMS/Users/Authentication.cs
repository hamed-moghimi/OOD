using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Users
{
    [Serializable()]
    class Authentication
    {
        private static Authentication instance;
        public User ActiveUser { set; get; }

        private Authentication()
        {
            
        }

        public static Authentication getInstance()
        {
            if (instance == null)
            {
                instance = new Authentication();
            }
            return instance;
        }

        public bool login(String username)
        {
            //TODO: exception
            if (ActiveUser == null)
            {
                List<User> users = UserStorage.getInstance().all();
                User user = null;
                foreach (User u in users)
                {
                    if (u.Username.Equals(username))
                    {
                        user = u;
                        break;
                    }
                }
                if (user != null)
                {
                    ActiveUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ActiveUserExistsException();
            }
        }

        public void logout()
        {
            ActiveUser = null;
        }

        public Boolean accessRight(Object obj, User user)
        {
            return user.hasAccess(obj);
        }
    }
}
