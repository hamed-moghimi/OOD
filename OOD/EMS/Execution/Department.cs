using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Execution
{
    [Serializable()]
    public class Department : IEquatable<Department>
    {
        public String Name { set; get; }
        public Department Supervisor { set; get; }
        public Users.User Manager { set; get; }

        public Department(String name, Department supervisor, Users.User manager)
        {
            Name = name;
            Supervisor = supervisor;
            Manager = manager;
        }

        public List<Department> getChildren()
        {
            List<Department> res = new List<Department>();
            foreach (Department d in OrganizationStructure.getInstance().all())
            {
                if (d.Supervisor != null && d.Supervisor.Equals(this))
                {
                    res.Add(d);
                }
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Department dept = obj as Department;
            if (dept == null) return false;
            return Name.Equals(dept.Name) && ((Supervisor == null && dept.Supervisor == null) || 
                (Supervisor != null && dept.Supervisor != null && Supervisor.Equals(dept.Supervisor)));
        }

        public bool Equals(Department dept)
        {
            if (dept == null) return false;
            return Name.Equals(dept.Name) && ((Supervisor == null && dept.Supervisor == null) ||
                (Supervisor != null && dept.Supervisor != null && Supervisor.Equals(dept.Supervisor)));
        }

        public Department getResponsible()
        {
            foreach (ExecutiveGoal goal in ExecutiveGoalStorage.getInstance().all())
            {
                if (goal.Manager.Equals(this))
                {
                    return this;
                }
            }
            foreach (EMS.Execution.Task t in TaskStorage.getInstance().all())
            {
                if (t.department.Equals(this))
                {
                    return this;
                }
            }

            foreach (Department child in getChildren())
            {
                Department res = child.getResponsible();
                if (res != null)
                {
                    return res;
                }
            }
            
            return null;
        }
    }
}
