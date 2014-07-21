using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Execution
{
    public partial class SelectExecutiveGoalForm : TemplateDialog
    {

        public ExecutiveGoal goal { get; set; }
        public SelectExecutiveGoalForm()
        {
            InitializeComponent();
            load_goals();
        }


        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (ExecutiveGoal goal in ExecutiveGoalStorage.getInstance().all())
            {
                if (goal.program == null && goal.Manager.Manager.Equals(Authentication.getInstance().ActiveUser))
                {
                    dataGridView1.Rows.Add(new Object[] { goal.Title, goal.getDateString() });
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        
    }
}
