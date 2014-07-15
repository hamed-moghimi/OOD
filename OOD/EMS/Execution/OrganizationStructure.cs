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

            //TMP
            List<User> users = UserStorage.getInstance().all();
            Department root = new Department("سازمان", null, users[0]);
            Department m1 = new Department("معاونت ۱", root, users[0]);
            Department m2 = new Department("معاونت ۲", root, users[0]);
            Department m11 = new Department("زیربخش ۱", m1, users[0]);
            Department m21 = new Department("زیربخش ۱", m2, users[0]);
            Department m12 = new Department("زیربخش ۲", m1, users[0]);
            Department m22 = new Department("زیربخش ۲", m2, users[0]);
            this.create(root);
            this.create(m1);
            this.create(m2);
            this.create(m11);
            this.create(m21);
            this.create(m12);
            this.create(m22);
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
