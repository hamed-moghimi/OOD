﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    public abstract class ManagementDocumentRelation
    {
        public DateTime Date { set; get; }
        public Users.User RelationUser { set; get; }        
    }
}
