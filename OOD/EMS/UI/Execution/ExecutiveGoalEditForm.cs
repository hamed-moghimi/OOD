using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;

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
            }
            else
            {
                dateBox.Text = DateTime.Now.ToString("yyyy/MM/dd");
                prevTitle = null;
            }
            dateBox.ReadOnly = true;
            titleBox.ReadOnly  = responsibleBox.ReadOnly = dscp_box.ReadOnly = !canEdit;
            button2.Visible = canEdit;
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecutiveGoal goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(titleBox.Text));
            if ((prevTitle == null || !prevTitle.Equals(titleBox.Text)) && goal != null)
            {
                MessageBox.Show(new ExecutiveGoalExistsException().Message);
            }
            else
            {
                ExecutiveGoalStorage.getInstance().create(new ExecutiveGoal(titleBox.Text, dscp_box.Text, dept));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
        
    }
}
