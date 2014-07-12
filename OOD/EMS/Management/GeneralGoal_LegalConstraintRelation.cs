using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Management
{
    public class GeneralGoal_LegalConstraintRelation : ManagementDocumentRelation, IEquatable<GeneralGoal_LegalConstraintRelation>
    {
        public GeneralGoal GenGoal { set; get; }
        public LegalConstraint LegConst { set; get; }

        public GeneralGoal_LegalConstraintRelation(GeneralGoal genGoal, LegalConstraint legConst)
        {
            GenGoal = genGoal;
            LegConst = legConst;
            Date = DateTime.Now;
            RelationUser = User.Authentication.getInstance().ActiveUser;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            GeneralGoal_LegalConstraintRelation rel = obj as GeneralGoal_LegalConstraintRelation;
            if (rel == null) return false;
            return GenGoal.Equals(rel.GenGoal) && LegConst.Equals(rel.LegConst);
        }

        public bool Equals(GeneralGoal_LegalConstraintRelation rel)
        {
            if (rel == null) return false;
            return GenGoal.Equals(rel.GenGoal) && LegConst.Equals(rel.LegConst);
        }
    }
}
