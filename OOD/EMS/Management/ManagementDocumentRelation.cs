﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    [Serializable()]
    public abstract class ManagementDocumentRelation
    {
        public DateTime Date { set; get; }
        public Users.User RelationUser { set; get; }

        public String getDateString()
        {
            return Date.ToString("yyyy/MM/dd");
        }
    }
}
