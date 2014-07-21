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
    public partial class ScheduleForm : TemplateForm
    {
        public ScheduleForm()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            load_programs();

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyExecutiveDocs())
            {
                addButton.Visible = editButton.Visible = deleteButton.Visible = false ;
                ViewButton.Location = new System.Drawing.Point(ViewButton.Location.X, ViewButton.Location.Y + 80);
            }
        }

        private void load_programs()
        {
            dataGridView1.Rows.Clear();
            foreach (ExecutiveGoal goal in ExecutiveGoalStorage.getInstance().all())
            {
                if (goal.program != null)
                {
                    dataGridView1.Rows.Add(new Object[]{goal.Title, goal.program.getStartDateString(),
                        goal.program.getEndDateString(), goal.getProgress().ToString()});
                }
            }
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            SelectExecutiveGoalForm f = new SelectExecutiveGoalForm();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                ScheduleEditForm f2 = new ScheduleEditForm(true, f.goal);
                DialogResult res2 = f2.ShowDialog();
                if (res2 == DialogResult.OK)
                {
                    load_programs();
                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                ExecutiveGoal goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                if (goal.Manager.Manager.Equals(Authentication.getInstance().ActiveUser))
                {
                    ScheduleEditForm f2 = new ScheduleEditForm(true, goal);
                    DialogResult res2 = f2.ShowDialog();
                    if (res2 == DialogResult.OK)
                    {
                        load_programs();
                    }
                }
                else
                {
                    MessageBox.Show("تنها مسئول هدف می‌تواند برنامه‌ی آن را ویرایش کند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                ExecutiveGoal goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                if (goal.Manager.Manager.Equals(Authentication.getInstance().ActiveUser))
                {
                    DialogResult res = ask_confirm();
                    if (res == DialogResult.Yes)
                    {
                        foreach (Allocation alloc in goal.program.Resources)
                        {
                            AllocationStorage.getInstance().remove(alloc);
                        }

                        goal.program = null;
                        load_programs();
                    }
                }
                else
                {
                    MessageBox.Show("تنها مسئول هدف می‌تواند برنامه‌ی آن را حذف کند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                }
            }
            
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                ExecutiveGoal goal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                ScheduleEditForm f2 = new ScheduleEditForm(false, goal);
                DialogResult res2 = f2.ShowDialog();
            }
           
                        
        }
    }
}
