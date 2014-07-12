using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Management
{
    class EnvironEffectStorage
    {
        private static EnvironEffectStorage instance;
        private List<EnvironEffect> environEffects;

        private EnvironEffectStorage()
        {
            environEffects = new List<EnvironEffect>();
        }

        public static EnvironEffectStorage getInstance()
        {
            if (instance == null) instance = new EnvironEffectStorage();
            return instance;
        }

        public List<EnvironEffect> all()
        {
            return environEffects;
        }

        public void create(EnvironEffect doc)
        {
            if (!environEffects.Contains(doc))
            {
                environEffects.Add(doc);
            }
        }
    }
}
