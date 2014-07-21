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
        }

        public List<LegalConstraint> all()
        {
            return legalConstraints;
        }

        public static LegalConstraintStorage getInstance()
        {
            if (instance == null)
            {
                if (Storage.getInstance().legalConstraintStorage == null)
                {
                    instance = new LegalConstraintStorage();
                }
                else
                {
                    instance = Storage.getInstance().legalConstraintStorage;
                }
            }
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
