using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Execution;

namespace OOD.EMS.UI.Report
{
    public partial class OverallReportForm : TemplateDialog
    {
        public OverallReportForm()
        {
            InitializeComponent();

            // general goals
            foreach (var goal in GeneralGoalStorage.getInstance().all())
            {
                object[] row = new object[]
                {
                    goal,
                    goal.Date,
                    goal.getExecutiveGoals().Count
                };
                generalGoalBox.Rows.Add(row);
            }

            // exec goals
            foreach (var goal in ExecutiveGoalStorage.getInstance().all())
            {
                object[] row = new object[]
                {
                    goal,
                    goal.Date,
                    goal.getProgress(),
                    goal.Manager
                };
                execGoalBox.Rows.Add(row);
            }
        }
    }
}
