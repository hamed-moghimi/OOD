using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Exceptions;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class LegalConstraintStorage
    {
        private static LegalConstraintStorage instance;
        private List<LegalConstraint> legalConstraints;

        private LegalConstraintStorage()
        {
            legalConstraints = new List<LegalConstraint>();

            //TMP
            legalConstraints.Add(new LegalConstraint("سند شماره‌ی ۱", "توضیح سند شماره‌ ۱"));
            legalConstraints.Add(new LegalConstraint("سند شماره‌ی ۲", "توضیح سند شماره‌ ۲"));
            legalConstraints.Add(new LegalConstraint("سند شماره‌ی ۳", "توضیح سند شماره‌۳"));
            legalConstraints.Add(new LegalConstraint("سند شماره‌ی ۴", "توضیح سند شماره‌ ۴"));

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
            else
            {
                throw new DocumentExsitsException();
            }
        }
    }
}
