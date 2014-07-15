using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class ResourceExistsException : EMSException
    {
        public ResourceExistsException()
            : base("منبعی با این عنوان پیش از این ثبت شده است")
        {
        }
    }
}
