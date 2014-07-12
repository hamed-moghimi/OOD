using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace EMS.User
{
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

        public void login(User user)
        {
            //TODO: exception
            if (ActiveUser == null)
            {
                List<User> users = UserStorage.getInstance().all();
                if (users.Contains(user))
                {
                    ActiveUser = user;
                }
                else
                {
                    throw new NoSuchUserException();
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
