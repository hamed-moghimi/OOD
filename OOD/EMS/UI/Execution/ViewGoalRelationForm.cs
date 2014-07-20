using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Execution;
using OOD.EMS.UI.Management;

namespace OOD.EMS.UI.Execution
{
    public partial class ViewGoalRelationForm : TemplateDialog
    {
        GeneralGoal genGoal;
        ExecutiveGoal execGoal;
        public ViewGoalRelationForm(GeneralGoal_ExecutiveGoalRelation rel)
        {
            this.genGoal = rel.GenGoal;
            this.execGoal = rel.ExecGoal;
            InitializeComponent();
            shareBox.Text = rel.Contribution.ToString();
            DateBox.Text = rel.getDateString();
            userBox.Text = rel.RelUser.getName();
            viewDoc1.Text = genGoal.Title;
            viewDoc2.Text = execGoal.Title;
        }

        private void viewDoc1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new ViewGeneralGoalForm(genGoal)).ShowDialog();
        }

        private void viewDoc2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new ExecutiveGoalEditForm(false, execGoal)).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
