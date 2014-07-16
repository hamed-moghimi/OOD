using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class GeneralGoal_LegalConstraintRelationStorage
    {
        private static GeneralGoal_LegalConstraintRelationStorage instance;
        private List<GeneralGoal_LegalConstraintRelation> relations;

        private GeneralGoal_LegalConstraintRelationStorage()
        {
            relations = new List<GeneralGoal_LegalConstraintRelation>();
        }

        public static GeneralGoal_LegalConstraintRelationStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().genGoal_LegalStorage == null)
                    instance = new GeneralGoal_LegalConstraintRelationStorage();
                else instance = Storage.getInstance().genGoal_LegalStorage;
            }
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
            else
            {
                throw new RelationExistsException();
            }
        }
    }
}
