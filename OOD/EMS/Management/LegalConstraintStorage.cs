using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    public class LegalConstraintStorage
    {
        private static LegalConstraintStorage instance;
        private List<LegalConstraint> legalConstraints;

        private LegalConstraintStorage()
        {
            legalConstraints = new List<LegalConstraint>();
        }

        public List<LegalConstraint> all()
        {
            return legalConstraints;
        }

        public static LegalConstraintStorage getInstance()
        {
            if (instance == null) instance = new LegalConstraintStorage();
            return instance;
        }

        public void create(LegalConstraint doc)
        {
            if (!legalConstraints.Contains(doc))
            {
                legalConstraints.Add(doc);
            }
        }
    }
}
