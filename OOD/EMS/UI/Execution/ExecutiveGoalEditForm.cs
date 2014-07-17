using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;
using OOD.EMS.Management;

namespace OOD.EMS.UI.Execution
{
    public partial class ExecutiveGoalEditForm : OOD.EMS.UI.TemplateDialog
    {
        private bool canEdit = false;
        private Department dept;
        private String prevTitle;

        public ExecutiveGoalEditForm(bool canEdit, ExecutiveGoal goal)
        {
            this.canEdit = canEdit;
            InitializeComponent();
            if (goal != null)
            {
                titleBox.Text = goal.Title;
                dateBox.Text = goal.getDateString();
                responsibleBox.Text = goal.Manager.Name;
                dscp_box.Text = goal.Description;
                prevTitle = goal.Title;
                dept = goal.Manager;
                attachmentPanel1.populate(goal.attachments);
            }
            else
            {
                dateBox.Text = DateTime.Now.ToString("yyyy/MM/dd");
                prevTitle = null;
                dept = null;
            }
            dateBox.ReadOnly = true;
            titleBox.ReadOnly  =  dscp_box.ReadOnly = !canEdit;
            button2.Visible = button1.Visible = canEdit;
            if (!canEdit)
            {
                Cancel.Text = "بازگشت";
                attachmentPanel1.ViewMode = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StructureSelectForm f = new StructureSelectForm();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                dept = f.Section;
                responsibleBox.Text = dept.Name;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            foreach (Attachment attach in attachmentPanel1.getNewlyAdded())
            {
                attach.delete();
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Trim().Count() == 0 || dept == null)
            {
                MessageBox.Show(new IncompleteFormException().Message);
                return;
            }
            ExecutiveGoal goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(titleBox.Text));
            if ((prevTitle == null || !prevTitle.Equals(titleBox.Text)) && goal != null)
            {
                MessageBox.Show(new ExecutiveGoalExistsException().Message);
            }
            else
            {
                ExecutiveGoal new_goal = new ExecutiveGoal(titleBox.Text, dscp_box.Text, dept);
                new_goal.attachments = attachmentPanel1.getAttachments();
                ExecutiveGoalStorage.getInstance().create(new_goal);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
        
    }
}
