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
    public partial class AuditTaskForm : TemplateDialog
    {
        private Task task;

        public TaskAudit Audit { set; get; }

        public AuditTaskForm(TaskAudit audit)
        {
            InitializeComponent();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.task = audit.AuditTask;
            this.targetName.Text = task.Title;
            this.progressBox.Text = audit.Progress.ToString();
            this.descBox.Text = audit.Description;
            this.attachmentPanel1.populate(audit.Attachments);
            this.attachmentPanel1.ViewMode = true;
            this.progressBox.ReadOnly = true;
            this.descBox.ReadOnly = true;
            this.OK.Visible = false;
        }

        public AuditTaskForm(Task task)
        {
            InitializeComponent();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.task = task;
            this.targetName.Text = task.Title;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            // TODO: validate
            var progress = Int32.Parse(convert(progressBox.Text));
            //////
            Audit = new TaskAudit(task, Authentication.getInstance().ActiveUser,
                descBox.Text, progress, attachmentPanel1.getAttachments());
            TaskAuditStorage.getInstance().create(Audit);
            task.Progress = progress;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void AuditTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
                attachmentPanel1.getNewlyAdded().ForEach(item => item.delete());
        }
    }
}
