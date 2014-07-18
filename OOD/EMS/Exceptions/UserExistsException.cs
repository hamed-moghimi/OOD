using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class UserExistsException : EMSException
    {
        public UserExistsException()
            : base("کاربری با این نام کاربری پیش از این ثبت شده است")
        {
        }
    }
}
