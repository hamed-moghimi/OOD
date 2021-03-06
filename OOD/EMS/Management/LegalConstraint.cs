﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Users;

namespace OOD.EMS.Management
{
    [Serializable()]
    public class LegalConstraint : ManagementDocument, IEquatable<LegalConstraint>
    {
        public LegalConstraint(String title, String descp)
        {
            Title = title;
            Description = descp;
            Date = DateTime.Now;
            DocUser = Authentication.getInstance().ActiveUser;
            attachments = new List<Attachment>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            LegalConstraint doc = obj as LegalConstraint;
            if (doc == null) return false;
            return Title.Equals(doc.Title);
        }

        public bool Equals(LegalConstraint doc)
        {
            if (doc == null) return false;
            return Title.Equals(doc.Title);
        }

        public String getDateString()
        {
            return Date.ToString("yyyy/MM/dd");
        }
    }
}
