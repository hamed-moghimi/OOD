using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    [Serializable()]
    public class ExecutionInspection
    {
        public String Title { set; get; }
        public String Description { set; get; }
        public DateTime InspectionDate { set; get; }
        public DateTime ReportDate { set; get; }
        public Users.User Inspector { set; get; }
        public List<Management.Attachment> Attachments { set; get; }

        public ExecutionInspection(String title, String description, DateTime inspectionDate,
                    Users.User inspector, List<Management.Attachment> attachments)
        {
            Title = title;
            Description = description;
            InspectionDate = inspectionDate;
            ReportDate = DateTime.Now;
            Inspector = inspector;
            Attachments = attachments;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
