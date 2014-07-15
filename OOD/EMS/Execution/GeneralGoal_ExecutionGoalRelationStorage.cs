using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Execution
{
    [Serializable()]
    public class GeneralGoal_ExecutiveGoalRelationStorage
    {
        private static GeneralGoal_ExecutiveGoalRelationStorage instance;
        private List<GeneralGoal_ExecutiveGoalRelation> relations;

        private GeneralGoal_ExecutiveGoalRelationStorage()
        {
            relations = new List<GeneralGoal_ExecutiveGoalRelation>();
        }

        public static GeneralGoal_ExecutiveGoalRelationStorage getInstance()
        {
            if (instance == null) instance = new GeneralGoal_ExecutiveGoalRelationStorage();
            return instance;
        }

        public List<GeneralGoal_ExecutiveGoalRelation> all()
        {
            return relations;
        }

        public void create(GeneralGoal_ExecutiveGoalRelation rel)
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
