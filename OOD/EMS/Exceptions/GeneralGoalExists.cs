using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Exceptions
{
    class GeneralGoalExists : EMSException
    {
        public GeneralGoalExists()
            : base("هدف کلانی با این نام پیش از این تعریف شده است")
        {
        }
    }
}
