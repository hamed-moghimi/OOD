using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    public class RelationExists : EMSException
    {
        public RelationExists() 
            : base("چنین ارتباطی پیش از این ثبت شده است")
        {
        }
    }
}
