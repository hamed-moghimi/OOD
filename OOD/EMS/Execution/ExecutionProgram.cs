using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    [Serializable()]
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

        public DateTime getStartDate()
        {
            DateTime res = DateTime.MaxValue;
            foreach (Task t in getTasks())
            {
                if (t.StartDate < res)
                {
                    res = t.StartDate;
                }
            }
            if (res.Equals(DateTime.MaxValue))
            {
                res = Date;
            }
            return res;
        }

        public DateTime getEndDate()
        {
            DateTime res = DateTime.MinValue;
            foreach (Task t in getTasks())
            {
                if (t.DueDate > res)
                {
                    res = t.DueDate;
                }
            }
            if (res.Equals(DateTime.MinValue))
            {
                res = Date;
            }
            return res;
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
                AllocationStorage.getInstance().create(l);
            }
        }

        public void removeResource(Resource r, DateTime from, DateTime to)
        {
            Allocation alloc = Resources.Find(x => x.AllocResource.Equals(r) && x.FromDate.Equals(from) &&
                                                x.ToDate.Equals(to));
            AllocationStorage.getInstance().remove(alloc);
        }

        public List<Allocation> getAllocations()
        {
            return Resources;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public List<Resource> getResources()
        {
            List<Resource> rs = new List<Resource>();
            foreach (Allocation alloc in Resources)
            {
                rs.Add(alloc.AllocResource);
            }
            return rs;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ExecutionProgram alloc = obj as ExecutionProgram;
            if (alloc == null) return false;
            return Title.Equals(alloc.Title);
        }

        public bool Equals(ExecutionProgram alloc)
        {
            if (alloc == null) return false;
            return Title.Equals(alloc.Title);
        }

        public String getStartDateString()
        {
            return getStartDate().ToString("yyyy/MM/dd");
        }

        public String getEndDateString()
        {
            return getEndDate().ToString("yyyy/MM/dd");
        }
    }
}
