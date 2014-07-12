using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class TaskStorage
    {
        private static TaskStorage instance;
        private List<Task> tasks;

        private TaskStorage(){
            tasks = new List<Task>();
        }

        public static TaskStorage getInstance()
        {
            if (instance == null) instance = new TaskStorage();
            return instance;
        }

        public List<Task> all()
        {
            return tasks;
        }

        public void create(Task task)
        {
            if (!tasks.Contains(task))
            {
                tasks.Add(task);
            }
        }

        public void remove(Task task)
        {
            tasks.Remove(task);
        }



    }
}
