using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    public class Contribution
    {
        public Task ContTask { set; get; }
        public ExecutionProgram Program { set; get; }
        public int Share { set; get; }

        public Contribution(Task task, ExecutionProgram program, int share)
        {
            ContTask = task;
            Program = program;
            Share = share;
        }

    }
}
