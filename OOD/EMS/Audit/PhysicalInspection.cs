using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Audit
{
    class PhysicalInspection
    {
        public String Title { set; get; }
        public String Description { set; get; }
        public DateTime InspectionDate { set; get; }
        public DateTime ReportDate { set; get; }
        public List<Management.Attachment> Attachments { set; get; }

        public PhysicalInspection(String title, String description, DateTime inspectionDate, DateTime reportDate,
                    List<Management.Attachment> attachments)
        {
            Title = title;
            Description = description;
            InspectionDate = inspectionDate;
            ReportDate = reportDate;
            Attachments = attachments;
        }

    }
}
