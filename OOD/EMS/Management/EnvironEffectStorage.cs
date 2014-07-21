using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class EnvironEffectStorage
    {
        private static EnvironEffectStorage instance;
        private List<EnvironEffect> environEffects;

        private EnvironEffectStorage()
        {
            environEffects = new List<EnvironEffect>();
        }

        public static EnvironEffectStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().environEffectStorage == null)
                {
                    instance = new EnvironEffectStorage();
                }
                else
                {
                    instance = Storage.getInstance().environEffectStorage;
                }
            }
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
            else
            {
                throw new DocumentExsitsException();
            }
        }
    }
}
