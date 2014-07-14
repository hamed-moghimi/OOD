using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class TaskExistsException : EMSException
    {
        public TaskExistsException()
            : base("چنین مسئولیتی پیش از این ثب شده است")
        {
        }
    }
}
