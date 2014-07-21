using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Audit;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Audit.Audit
{
    public partial class AuditExecutiveForm : TemplateDialog
    {
        private AuditExecutiveForm()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
        private void fillList(IEnumerable<Task> items)
        {
            foreach (var item in items)
            {
                object[] row = new object[2];
                row[0] = item.Title;
                row[1] = item.Progress.ToString() + "٪";
                tasksList.Rows.Add(row);
            }
        }

        public AuditExecutiveForm(ExecutiveGoal goal) : this()
        {
            this.goal = goal;
            targetName.Text = goal.Title;
            if (goal.program != null)
            {
                progressBox.Text = goal.getProgress().ToString() + "٪";
                var tasks =
                    from contrib in goal.program.Tasks
                    select contrib.ContTask;
                fillList(tasks);
            }
            else
            {
                progressBox.Text = "هنوز برنامه‌ی اقدامی برای این هدف تعریف نشده است";
            }
        }

        public AuditExecutiveForm(ExecutiveGoalAudit audit) : this()
        {
            this.goal = audit.Goal;
            targetName.Text = audit.Goal.Title;
            progressBox.Text = audit.Progress.ToString() + "٪";
            descBox.Text = audit.Description;
            descBox.ReadOnly = true;
            OK.Visible = false;
            attachmentBox.populate(audit.Attachments);
            attachmentBox.ViewMode = true;
            if (goal.program != null)
            {
                var tasks =
                        from contrib in audit.Goal.program.Tasks
                        select contrib.ContTask;
                fillList(tasks);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ExecutiveGoal goal;
        private ExecutiveGoalAudit audit;
        public ExecutiveGoalAudit Audit { get { return audit; } }

        private void OK_Click(object sender, EventArgs e)
        {
            if (descBox.Text == "")
            {
                MessageBox.Show("توضیحات برای ثبت حسابرسی الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            this.audit = new ExecutiveGoalAudit(goal, Authentication.getInstance().ActiveUser,
                goal.getProgress(), descBox.Text, attachmentBox.getAttachments());
            ExecutiveGoalAuditStorage.getInstance().create(audit);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AuditExecutiveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
                attachmentBox.getNewlyAdded().ForEach(item => item.delete());
        }
    }
}
