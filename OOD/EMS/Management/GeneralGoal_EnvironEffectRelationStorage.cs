using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Management
{
    class GeneralGoal_EnvironEffectRelationStorage
    {
        private static GeneralGoal_EnvironEffectRelationStorage instance;
        private List<GeneralGoal_EnvironEffectRelation> relations;

        private GeneralGoal_EnvironEffectRelationStorage()
        {
            relations = new List<GeneralGoal_EnvironEffectRelation>();
        }

        public static GeneralGoal_EnvironEffectRelationStorage getInstance()
        {
            if (instance == null) instance = new GeneralGoal_EnvironEffectRelationStorage();
            return instance;
        }

        public List<GeneralGoal_EnvironEffectRelation> all()
        {
            return relations;
        }

        public void create(GeneralGoal_EnvironEffectRelation rel)
        {
            if (!relations.Contains(rel))
            {
                relations.Add(rel);
            }
        }
    }
}
