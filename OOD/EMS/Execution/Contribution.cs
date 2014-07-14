using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    public class Contribution : IEquatable<Contribution>
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Contribution cont = obj as Contribution;
            if (cont == null) return false;
            return ContTask.Title.Equals(cont.ContTask.Title) && Program.Title.Equals(cont.Program.Title) ;
        }

        public bool Equals(Contribution cont)
        {
            if (cont == null) return false;
            return ContTask.Title.Equals(cont.ContTask.Title) && Program.Title.Equals(cont.Program.Title);
        }
    }
}
