using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOD.EMS.Execution
{
    public class Task : IEquatable<Task>
    {
        public String Title { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime DueDate { set; get; }
        public int Progress { set; get; }
        public Department department { set; get; }
        public List<Management.Attachment> attachments { set; get; }
        public String Description { set; get; }

        public Task(String title, DateTime startDate, DateTime dueDate, int progress, Department responsible, String dscp)
        {
            Title = title;
            StartDate = startDate;
            DueDate = dueDate;
            Progress = progress;
            department = responsible;
            Description = dscp;
        }

        public void addAttachment(Management.Attachment attach)
        {
            attachments.Add(attach);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Task task = obj as Task;
            if (task == null) return false;
            return Title.Equals(task.Title);
        }

        public bool Equals(Task task)
        {
            if (task == null) return false;
            return Title.Equals(task.Title);
        }

        public String getStartDateString()
        {
            return StartDate.ToString("yyyy/MM/dd");
        }

        public String getDueDateString()
        {
            return DueDate.ToString("yyyy/MM/dd");
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
