using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    public class ExecutionProgram
    {
        public String Title { set; get; }
        public String Description { set; get; }
        public DateTime Date { set; get; }
        public List<Contribution> Tasks { set; get; }
        public List<Allocation> Resources { set; get; }

        public ExecutionProgram(String title, String descp)
        {
            Title = title;
            Description = descp;
            Date = DateTime.Now;
            Tasks = new List<Contribution>();
            Resources = new List<Allocation>();
        }

        public int getProgress()
        {
            double progress = 0;
            foreach (Contribution cont in Tasks)
            {
                progress += cont.ContTask.Progress * (cont.Share / 100.0);
            }
            return (int)progress;
        }

        public void addTask(Task task, int share)
        {
            Contribution cont = new Contribution(task, this, share);
            if (!Tasks.Contains(cont))
            {
                Tasks.Add(cont);
            }
        }

        public void remove(Task task)
        {
            Tasks.Remove(new Contribution(task, this, 0));
        }

        public List<Task> getTasks()
        {
            List<Task> tasks = new List<Task>();
            foreach (Contribution cont in Tasks)
            {
                tasks.Add(cont.ContTask);
            }
            return tasks;
        }

        public void addResource(Resource r, int amount, DateTime from, DateTime to)
        {
            Allocation l = new Allocation(from, to, r, this, amount);
            if (ResourceAllocator.getInstance().isConsistent(l))
            {
                Resources.Add(l);
            }
        }

        public List<Allocation> getAllocations()
        {
            return Resources;
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
