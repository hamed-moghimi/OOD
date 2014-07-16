using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Execution;
using OOD.EMS.Audit;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Audit.Audit
{
    public partial class AuditGeneralForm : TemplateDialog
    {
        private AuditGeneralForm()
        {
            InitializeComponent();
        }
        
        private void fillList(IEnumerable<ExecutiveGoal> items)
        {
            foreach (var item in items)
            {
                object[] row = new object[2];
                row[0] = item.Title;
                row[1] = item.getProgress().ToString() + "٪";
                tasksList.Rows.Add(row);
            }
        }

        public AuditGeneralForm(GeneralGoal goal) : this()
        {
            this.goal = goal;
            targetName.Text = goal.Title;
            fillList(goal.getExecutiveGoals());
        }

        public AuditGeneralForm(GeneralGoalAudit audit)
            : this()
        {
            this.goal = audit.Goal;
            targetName.Text = audit.Goal.Title;
            descBox.Text = audit.Description;
            descBox.ReadOnly = true;
            OK.Visible = false;
            attach.Visible = false;
            fillList(goal.getExecutiveGoals());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private GeneralGoal goal;
        private GeneralGoalAudit audit;
        public GeneralGoalAudit Audit { get { return audit; } }

        private void OK_Click(object sender, EventArgs e)
        {
            if (descBox.Text == "")
            {
                MessageBox.Show("توضیحات برای ثبت حسابرسی الزامی است");
                return;
            }
            this.audit = new GeneralGoalAudit(goal, Authentication.getInstance().ActiveUser,
                descBox.Text, null);
            GeneralGoalAuditStorage.getInstance().create(audit);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
