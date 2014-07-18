using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
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
            Resource res = ResourceStorage.getInstance().all().Find(x => x.Equals(allocation.AllocResource));
            int amount = res.Amount;
            int sum = 0;
            foreach (Allocation alloc in AllocationStorage.getInstance().all())
            {
                if( alloc.AllocResource.Equals(res) &&((alloc.FromDate >= allocation.FromDate && alloc.FromDate <= allocation.ToDate) || 
                    (alloc.ToDate >= allocation.FromDate && alloc.ToDate <= allocation.ToDate)))
                {
                    sum += alloc.Amount;
                }
            }
            if (sum + allocation.Amount > amount)
            {
                return false;
            }
            return true;
        }

        public int getRemainder(Resource r, DateTime from, DateTime to)
        {
            int amount = r.Amount;
            int sum = 0;
            foreach (Allocation alloc in AllocationStorage.getInstance().all())
            {
                if (alloc.AllocResource.Equals(r) && ((alloc.FromDate >= from && alloc.FromDate <= to) ||
                    (alloc.ToDate >= from && alloc.ToDate <= to)))
                {
                    sum += alloc.Amount;
                }
            }
            return amount - sum;
        }
    }
}
