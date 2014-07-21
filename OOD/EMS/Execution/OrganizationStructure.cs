using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Execution
{
    [Serializable()]
    public class OrganizationStructure
    {
        private static OrganizationStructure instance;
        private List<Department> departments;
        public Department Root { get; set; }

        private OrganizationStructure()
        {
            departments = new List<Department>();

            Department root = new Department("سازمان", null, null);
            this.create(root);
        }

        public static OrganizationStructure getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().structure == null)
                    instance = new OrganizationStructure();
                else instance = Storage.getInstance().structure;
            }
            return instance;
        }

        public List<Department> all()
        {
            return departments;
        }

        public void create(Department dept)
        {
            if (Root == null && dept.Supervisor == null)
            {
                Root = dept;
                departments.Add(dept);
            }
            else if (Root != null && dept.Supervisor != null && departments.Contains(dept.Supervisor) && !departments.Contains(dept))
            {
                departments.Add(dept);
            }
        }

        public void remove(Department d)
        {
            foreach (Department child in d.getChildren())
            {
                remove(child);
            }
            departments.Remove(d);
        }

    }
}
