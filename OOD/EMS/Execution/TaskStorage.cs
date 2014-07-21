using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Execution
{
    [Serializable()]
    public class TaskStorage
    {
        private static TaskStorage instance;
        private List<Task> tasks;

        private TaskStorage()
        {
            tasks = new List<Task>();
        }

        public static TaskStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().taskStorage == null)
                    instance = new TaskStorage();
                else instance = Storage.getInstance().taskStorage;
            }
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
            else
            {
                throw new TaskExistsException();
            }
        }

        public void remove(Task task)
        {
            tasks.Remove(task);
        }
    }
}
