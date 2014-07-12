using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class ResourceStorage
    {
        private static ResourceStorage instance;
        private List<Resource> resources;

        private ResourceStorage()
        {
            resources = new List<Resource>();
        }

        public static ResourceStorage getInstance()
        {
            if (instance == null) instance = new ResourceStorage();
            return instance;
        }

        public List<Resource> all()
        {
            return resources;
        }

        public void create(Resource resource)
        {
            if (!resources.Contains(resource))
            {
                resources.Add(resource);
            }
        }

        public void remove(Resource resource)
        {
            resources.Remove(resource);
        }
    }
}
