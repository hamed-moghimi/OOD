using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    public class LegalConstraint_EnvironEffectRelation : ManagementDocumentRelation, IEquatable<LegalConstraint_EnvironEffectRelation>
    {
        public EnvironEffect EnvEffect { set; get; }
        public LegalConstraint LegConst { set; get; }

        public LegalConstraint_EnvironEffectRelation(EnvironEffect envEffect, LegalConstraint legConst)
        {
            EnvEffect = envEffect;
            LegConst = legConst;
            Date = DateTime.Now;
            RelationUser = User.Authentication.getInstance().ActiveUser;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            LegalConstraint_EnvironEffectRelation rel = obj as LegalConstraint_EnvironEffectRelation;
            if (rel == null) return false;
            return EnvEffect.Equals(rel.EnvEffect) && LegConst.Equals(rel.LegConst);
        }

        public bool Equals(LegalConstraint_EnvironEffectRelation rel)
        {
            if (rel == null) return false;
            return EnvEffect.Equals(rel.EnvEffect) && LegConst.Equals(rel.LegConst);
        }
    }
}
