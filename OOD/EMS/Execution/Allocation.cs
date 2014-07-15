using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    public class Allocation : IEquatable<Allocation>
    {
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public Resource AllocResource { set; get; }
        public ExecutionProgram Program { set; get; }
        public int Amount { set; get; }

        public Allocation(DateTime fromDate, DateTime toDate, Resource resource, ExecutionProgram program, int amount)
        {
            FromDate = fromDate;
            ToDate = toDate;
            AllocResource = resource;
            Program = program;
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Allocation alloc = obj as Allocation;
            if (alloc == null) return false;
            return FromDate.Equals(alloc.FromDate) && ToDate.Equals(alloc.ToDate) && Program.Equals(alloc.Program)
                && (Amount == alloc.Amount) && AllocResource.Equals(alloc.AllocResource);
        }

        public bool Equals(Allocation alloc)
        {
            if (alloc == null) return false;
            return FromDate.Equals(alloc.FromDate) && ToDate.Equals(alloc.ToDate) && Program.Equals(alloc.Program)
                && (Amount == alloc.Amount) && AllocResource.Equals(alloc.AllocResource);
        }

        public String getStartDateString()
        {
            return FromDate.ToString("yyyy/MM/dd");
        }

        public String getDueDateString()
        {
            return ToDate.ToString("yyyy/MM/dd");
        }
    }
}
