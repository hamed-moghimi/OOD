using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class GeneralGoal_EnvironEffectRelation : ManagementDocumentRelation, IEquatable<GeneralGoal_EnvironEffectRelation>
    {
        public GeneralGoal GenGoal { set; get; }
        public EnvironEffect EnvEffect { set; get; }

        public GeneralGoal_EnvironEffectRelation(GeneralGoal genGoal, EnvironEffect envEffect)
        {
            GenGoal = genGoal;
            EnvEffect = envEffect;
            Date = DateTime.Now;
            RelationUser = Authentication.getInstance().ActiveUser;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            GeneralGoal_EnvironEffectRelation rel = obj as GeneralGoal_EnvironEffectRelation;
            if (rel == null) return false;
            return GenGoal.Equals(rel.GenGoal) && EnvEffect.Equals(rel.EnvEffect);
        }

        public bool Equals(GeneralGoal_EnvironEffectRelation rel)
        {
            if (rel == null) return false;
            return GenGoal.Equals(rel.GenGoal) && EnvEffect.Equals(rel.EnvEffect);
        }
    }
}
