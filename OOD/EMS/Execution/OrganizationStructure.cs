using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class OrganizationStructure
    {
        private static OrganizationStructure instance;
        private List<Department> departments;
        private Department root;

        private OrganizationStructure()
        {
            departments = new List<Department>();
        }

        public static OrganizationStructure getInstance()
        {
            if (instance == null) instance = new OrganizationStructure();
            return instance;
        }

        public List<Department> all()
        {
            return departments;
        }

        public void create(Department dept)
        {
            if (root == null && dept.Supervisor == null)
            {
                root = dept;
                departments.Add(dept);
            }
            else if (root != null && dept.Supervisor != null && departments.Contains(dept.Supervisor) && !departments.Contains(dept))
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
