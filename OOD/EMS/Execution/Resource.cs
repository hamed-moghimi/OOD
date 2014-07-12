using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Execution
{
    public class Resource : IEquatable<Resource>
    {
        public String Title { set; get; }
        public int Amount { set; get; }
        public String Description { set; get; }

        public Resource(String title, int amount, string description)
        {
            Title = title;
            Amount = amount;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Resource res = obj as Resource;
            if (res == null) return false;
            return Title.Equals(res.Title);
        }

        public bool Equals(Resource res)
        {
            if (res == null) return false;
            return Title.Equals(res.Title);
        }
    }
}
