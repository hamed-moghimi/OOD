using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;

namespace OOD.EMS.UI.Execution
{
    public partial class ScheduleEditForm : TemplateDialog
    {

        public ExecutionProgram program { set; get; }
        private ExecutiveGoal goal;

        public ScheduleEditForm(bool canEdit, ExecutiveGoal goal)
        {
            InitializeComponent();
            goal_name.Text = goal.Title;
            this.goal = goal;
            if (!canEdit)
            {
                addButton.Visible = deleteButton.Visible = button1.Visible = button2.Visible
                   = selectBtn.Visible = false;
                Cancel.Text = "بازگشت";
                Cancel.Location = new System.Drawing.Point(groupBox2.Location.X, Cancel.Location.Y);
            }

            if (goal.program == null)
            {
                program = new ExecutionProgram(goal.Title, "ندارد");
            }
            else
            {
                program = goal.program;
            }
            load_tasks();
            load_allocs();
        }

        private void load_tasks()
        {
            taskGrid.Rows.Clear();
            foreach (Contribution con in program.Tasks)
            {
                Task t = con.ContTask;
                taskGrid.Rows.Add(new Object[] { con.Share.ToString(), t.Title,
                    t.getStartDateString(), t.getDueDateString(), t.Progress.ToString()});
            }
            progress_num.Text = program.getProgress().ToString() + "%";
            progressBar1.Value = program.getProgress();

        }

        private void load_allocs()
        {
            resourceGrid.Rows.Clear();
            foreach (Allocation con in program.Resources)
            {
                resourceGrid.Rows.Add(new Object[] { con.AllocResource.Title, con.getStartDateString(),
                    con.getDueDateString(), con.Amount.ToString() + " " + con.AllocResource.unit});
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectTaskForm f = new SelectTaskForm(program.getTasks());
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                Task t = f.goal;
                int share = f.Cont;
                program.addTask(t, share);
                taskGrid.Rows.Add(new Object[] {share.ToString(), t.Title, t.getStartDateString(), 
                    t.getDueDateString(), t.Progress.ToString() });
                progress_num.Text = program.getProgress().ToString() + "%";
                progressBar1.Value = program.getProgress();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (taskGrid.SelectedRows.Count > 0)
            {
                String name = (string)taskGrid.Rows[taskGrid.SelectedRows[0].Index].Cells[1].Value;
                List<Task> tasks = program.getTasks();
                Task target = tasks.Find(x => x.Title.Equals(name));
                program.remove(target);
                load_tasks();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectResourceForm f = new SelectResourceForm(new List<Resource>());
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                Allocation alloc = f.alloc;
                alloc.Program = program;
                program.addResource(alloc.AllocResource, alloc.Amount, alloc.FromDate, alloc.ToDate);
                load_allocs();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resourceGrid.SelectedRows.Count > 0)
            {
                String name = (string)resourceGrid.Rows[resourceGrid.SelectedRows[0].Index].Cells[0].Value;
                DateTime from = Convert.ToDateTime((string)resourceGrid.Rows[resourceGrid.SelectedRows[0].Index].Cells[1].Value);
                DateTime to = Convert.ToDateTime((string)resourceGrid.Rows[resourceGrid.SelectedRows[0].Index].Cells[2].Value);
                List<Resource> rs = program.getResources();
                Resource target = rs.Find(x => x.Title.Equals(name));
                program.removeResource(target, from, to);
                load_allocs();
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            goal.program = program;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
