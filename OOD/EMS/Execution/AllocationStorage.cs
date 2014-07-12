using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class AllocationStorage
    {
        private static AllocationStorage instance;
        private List<Allocation> allocations;

        private AllocationStorage()
        {
            allocations = new List<Allocation>();
        }

        public static AllocationStorage getInstance()
        {
            if (instance == null) instance = new AllocationStorage();
            return instance;
        }

        public List<Allocation> all()
        {
            return allocations;
        }

        public void create(Allocation alloc)
        {
            if (!allocations.Contains(alloc))
            {
                allocations.Add(alloc);
            }
        }

        public void remove(Allocation allocation){
            allocations.Remove(allocation);
        }
    }
}
