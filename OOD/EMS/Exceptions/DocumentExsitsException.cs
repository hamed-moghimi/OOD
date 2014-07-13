using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class DocumentExsitsException : EMSException
    {
        public DocumentExsitsException()
            : base("سندی با این نام پیش از این ثبت شده است")
        {
        }
    }
}
