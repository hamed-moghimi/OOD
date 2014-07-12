using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class NoSuchUserException : EMSException
    {

        public NoSuchUserException()
            : base("چنین کاربری در سیستم ثبت نشده است.")
        {
        }
    }
}
