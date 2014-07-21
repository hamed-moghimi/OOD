using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    [Serializable()]
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
            if (instance == null)
            {
                if (Storage.getInstance().allocationStorage == null)
                {
                    instance = new AllocationStorage();
                }
                else
                {
                    instance = Storage.getInstance().allocationStorage;
                }
            } 
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
