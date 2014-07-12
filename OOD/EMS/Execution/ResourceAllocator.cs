using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class ResourceAllocator
    {
        private static ResourceAllocator instance;

        private ResourceAllocator()
        {
        }

        public static ResourceAllocator getInstance()
        {
            if (instance == null) instance = new ResourceAllocator();
            return instance;
        }

        public Boolean isConsistent(Allocation allocation)
        {
            return false;
        }
    }
}
