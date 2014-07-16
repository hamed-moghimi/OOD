using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Execution
{
    [Serializable()]
    public class ResourceStorage
    {
        private static ResourceStorage instance;
        private List<Resource> resources;

        private ResourceStorage()
        {
            resources = new List<Resource>();

            //TMP
            resources.Add(new Resource("منبع ۱", 12, "توضیحات منبع ۱"));
            resources.Add(new Resource("منبع ۲", 12, "توضیحات منبع ۲"));
            resources.Add(new Resource("منبع ۳", 12, "توضیحات منبع ۳"));
            resources.Add(new Resource("منبع ۴", 12, "توضیحات منبع ۴"));
        }

        public static ResourceStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().resourceStorage == null)
                    instance = new ResourceStorage();
                else instance = Storage.getInstance().resourceStorage;
            }
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
            else
            {
                throw new ResourceExistsException();
            }
            
        }

        public void remove(Resource resource)
        {
            resources.Remove(resource);
        }
    }
}
