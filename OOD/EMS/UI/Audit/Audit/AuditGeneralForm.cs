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
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            progressBox.Text = goal.getProgress().ToString() + "٪";
            fillList(goal.getExecutiveGoals());
        }

        public AuditGeneralForm(GeneralGoalAudit audit) : this()
        {
            this.goal = audit.Goal;
            targetName.Text = audit.Goal.Title;
            progressBox.Text = audit.Progress.ToString() + "٪";
            descBox.Text = audit.Description;
            descBox.ReadOnly = true;
            OK.Visible = false;
            attachmentPanel1.populate(audit.Attachments);
            attachmentPanel1.ViewMode = true;
            fillList(goal.getExecutiveGoals());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private GeneralGoal goal;
        private GeneralGoalAudit audit;
        public GeneralGoalAudit Audit { get { return audit; } }

        private void OK_Click(object sender, EventArgs e)
        {
            if (descBox.Text == "")
            {
                MessageBox.Show("توضیحات برای ثبت حسابرسی الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            this.audit = new GeneralGoalAudit(goal, Authentication.getInstance().ActiveUser,
                descBox.Text, goal.getProgress(), attachmentPanel1.getAttachments());
            GeneralGoalAuditStorage.getInstance().create(audit);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AuditGeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
                attachmentPanel1.getNewlyAdded().ForEach(item => item.delete());
        }
    }
}
