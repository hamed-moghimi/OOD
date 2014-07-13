using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class IncompleteFormException : EMSException
    {
        public IncompleteFormException() 
            : base("فرم را کامل کنید") 
        { 
        }

    }
}
