using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    class GeneralGoal_LegalConstraintRelationStorage
    {
        private static GeneralGoal_LegalConstraintRelationStorage instance;
        private List<GeneralGoal_LegalConstraintRelation> relations;

        private GeneralGoal_LegalConstraintRelationStorage()
        {
            relations = new List<GeneralGoal_LegalConstraintRelation>();
        }

        public static GeneralGoal_LegalConstraintRelationStorage getInstance()
        {
            if (instance == null) instance = new GeneralGoal_LegalConstraintRelationStorage();
            return instance;
        }

        public List<GeneralGoal_LegalConstraintRelation> all()
        {
            return relations;
        }

        public void create(GeneralGoal_LegalConstraintRelation rel)
        {
            if (!relations.Contains(rel))
            {
                relations.Add(rel);
            }
        }
    }
}
