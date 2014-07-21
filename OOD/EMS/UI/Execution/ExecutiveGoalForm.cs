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
    public partial class ExecutiveGoalForm : TemplateForm
    {
        public ExecutiveGoalForm()
        {
            InitializeComponent();
            load_goals();

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyExecutiveDocs())
            {
                addButton.Visible = false;
                editButton.Location = new System.Drawing.Point(editButton.Location.X, editButton.Location.Y + 80);
            }

        }

        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (ExecutiveGoal goal in ExecutiveGoalStorage.getInstance().all())
            {
                dataGridView1.Rows.Add(new Object[] {goal.Title, goal.getDateString(), goal.Manager.Name });
            }
        }

        
        private void addButton_Click_1(object sender, EventArgs e)
        {
            (new ExecutiveGoalEditForm(true, null)).ShowDialog();
            load_goals();
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (String)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                ExecutiveGoal goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                (new ExecutiveGoalEditForm(false, goal)).ShowDialog();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
