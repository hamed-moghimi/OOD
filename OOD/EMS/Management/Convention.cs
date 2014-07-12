﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Management
{
    class Convention
    {
        public String Policy { set; get; }
        public DateTime Date { set; get; }
        public String Description { set; get; }
        public List<Attachment> attachments { set; get; }
        public User.User DocUser { set; get; }

        public Convention(String policy, String description)
        {
            Policy = policy;
            Date = DateTime.Now;
            Description = description;
            DocUser = User.Authentication.getInstance().ActiveUser;
            attachments = new List<Attachment>();
        }

        public void addAttachment(Attachment attach)
        {
            attachments.Add(attach);
        }

        
    }
}
