using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class GeneralGoal_EnvironEffectRelationStorage
    {
        private static GeneralGoal_EnvironEffectRelationStorage instance;
        private List<GeneralGoal_EnvironEffectRelation> relations;

        private GeneralGoal_EnvironEffectRelationStorage()
        {
            relations = new List<GeneralGoal_EnvironEffectRelation>();
        }

        public static GeneralGoal_EnvironEffectRelationStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().genGoal_EnvironEffectStorage == null)
                {
                    instance = new GeneralGoal_EnvironEffectRelationStorage();
                }
                else
                {
                    instance = Storage.getInstance().genGoal_EnvironEffectStorage;
                }
            }
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
            else
            {
                throw new RelationExistsException();
            }
        }
    }
}
