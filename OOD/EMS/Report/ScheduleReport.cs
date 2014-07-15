using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOD.EMS.Execution;

namespace OOD.EMS.Report
{
    public class ScheduleReport
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public Contribution[] tasks { get; set; }

        public ScheduleReport(DateTime fromDate, DateTime toDate)
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
        }
    }
}
