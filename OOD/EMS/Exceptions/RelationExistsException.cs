using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class RelationExistsException : EMSException
    {
        public RelationExistsException()
            : base("چنین ارتباطی پیش از این ثبت شده است")
        {
        }
    }
}
