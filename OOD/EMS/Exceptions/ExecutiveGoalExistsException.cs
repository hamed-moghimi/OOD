using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class ExecutiveGoalExistsException : EMSException
    {
        public ExecutiveGoalExistsException()
            : base("چنین هدف اجرایی پیش از این ثبت شده است")
        {
        }
    }
}
