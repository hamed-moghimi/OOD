using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Execution
{
    public class TaskStorage
    {
        private static TaskStorage instance;
        private List<Task> tasks;

        private TaskStorage(){
            tasks = new List<Task>();

            //TMP
            Department dept = OrganizationStructure.getInstance().Root;
            tasks.Add(new Task("مسئولیت ۱", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7), 10,  dept, "توضیحات"));
            tasks.Add(new Task("مسئولیت ۲", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7), 20, dept, "توضیحات"));
            tasks.Add(new Task("مسئولیت ۳", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7), 5, dept, "توضیحات"));
            tasks.Add(new Task("مسئولیت ۴", DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7), 100, dept, "توضیحات"));
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
