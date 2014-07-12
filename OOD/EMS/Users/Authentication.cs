using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                ActiveUser = user;
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
