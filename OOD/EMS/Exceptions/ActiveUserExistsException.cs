using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class ActiveUserExistsException : EMSException
    {
        public ActiveUserExistsException() : base("کاربری پیش از این در سیستم فعال است.")
        {
        }
    }
}
