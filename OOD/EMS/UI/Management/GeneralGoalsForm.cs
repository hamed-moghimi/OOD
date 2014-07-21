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
using OOD.EMS.Exceptions;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Management
{
    public partial class GeneralGoalsForm : TemplateForm
    {
        public GeneralGoalsForm()
        {
            InitializeComponent();
            load_goals();

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyManagementDocs())
            {
                add.Visible = false;
                edit.Location = new System.Drawing.Point(edit.Location.X, edit.Location.Y + 45);
            }
        }
       

        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (GeneralGoal goal in GeneralGoalStorage.getInstance().all())
            {
                object[] row = new object[] { goal.Title, goal.getDateString(), goal.Description };
                this.dataGridView1.Rows.Add(row);
            }
        }

        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddGeneralGoalsForm add = new AddGeneralGoalsForm("", "");
            DialogResult res = add.ShowDialog();
            if (res == DialogResult.OK)
            {
                GeneralGoal goal = new GeneralGoal(add.name, add.dscp);
                foreach (Attachment attach in add.attachments)
                {
                    goal.addAttachment(attach);
                }
                GeneralGoalStorage.getInstance().create(goal);
            }
            load_goals();
        }

        /*private void edit_Click(object sender, EventArgs e)
        {
            String goalName = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            String goalDescp = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value;
            GeneralGoal goal = null;
            GeneralGoalStorage goalList = GeneralGoalStorage.getInstance();
            foreach (GeneralGoal g in goalList.all())
            {
                if (g.Title.Equals(goalName))
                {
                    goal = g;
                    break;
                }
            }
            AddGeneralGoalsForm add = new AddGeneralGoalsForm(goalName, goalDescp);
            DialogResult res = add.ShowDialog();
            if (res == DialogResult.OK)
            {
                goal.Title = add.name;
                goal.Description = add.dscp;
                goal.Date = DateTime.Now;
                
            }
            load_goals();
        }*/


        private void view_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                GeneralGoal goal = null;
                try
                {
                    goal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                }
                catch (Exception)
                {
                }

                if (goal != null)
                {
                    (new ViewGeneralGoalForm(goal)).ShowDialog();
                }
            }
        }
    }
}
