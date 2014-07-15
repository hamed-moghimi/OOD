using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class DepartmentExistsException : EMSException
    {
        public DepartmentExistsException()
            : base("چنین سازمانی پیش از این ثبت شده است")
        {
        }
    }
}
