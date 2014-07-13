using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Management
{
    class LegalConstraint_EnvironEffectRelationStorage
    {
        private static LegalConstraint_EnvironEffectRelationStorage instance;
        private List<LegalConstraint_EnvironEffectRelation> relations;

        private LegalConstraint_EnvironEffectRelationStorage()
        {
            relations = new List<LegalConstraint_EnvironEffectRelation>();
        }

        public static LegalConstraint_EnvironEffectRelationStorage getInstance()
        {
            if (instance == null) instance = new LegalConstraint_EnvironEffectRelationStorage();
            return instance;
        }

        public List<LegalConstraint_EnvironEffectRelation> all()
        {
            return relations;
        }

        public void create(LegalConstraint_EnvironEffectRelation rel)
        {
            if (!relations.Contains(rel))
            {
                relations.Add(rel);
            }
            else
            {
                throw new RelationExistsException();
            }
        }
    }
}
