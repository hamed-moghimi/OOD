using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Execution
{
    public partial class ResourceForm : TemplateForm
    {
        public ResourceForm()
        {
            InitializeComponent();
            load_resources();
        }

        private void load_resources()
        {
            dataGridView1.Rows.Clear();
            foreach (Resource r in ResourceStorage.getInstance().all())
            {
                object[] row = new object[] {r.Title, r.getAmountString(), r.Description };
                dataGridView1.Rows.Add(row);
            }

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyExecutiveDocs())
            {
                addButton.Visible = editButton.Visible = deleteButton.Visible = false;
                button2.Location = new System.Drawing.Point(button2.Location.X, button2.Location.Y + 80);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult res = ask_confirm();
                if (res == DialogResult.Yes)
                {
                    String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                    ResourceStorage.getInstance().all().RemoveAll(x => x.Title.Equals(title));
                    AllocationStorage.getInstance().all().RemoveAll(x => x.AllocResource.Title.Equals(title));
                    foreach (ExecutiveGoal goal in ExecutiveGoalStorage.getInstance().all())
                    {
                        if (goal.program != null)
                        {
                            goal.program.Resources.RemoveAll(x => x.AllocResource.Title.Equals(title));
                        }
                    }
                    load_resources();
                }
            }
        }

        

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                Resource prev = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(title));
                ResourceEditForm f = new ResourceEditForm(true, new Object[] { prev.Title, prev.Amount.ToString(), prev.Description, prev.unit });
                DialogResult res = f.ShowDialog();
                if (res == DialogResult.OK)
                {
                    prev.Title = (string)f.Resource[0];
                    prev.Amount = Convert.ToInt32(convert((string)f.Resource[1]));
                    prev.Description = (string)f.Resource[2];
                    prev.unit = (string)f.Resource[3];
                }
                load_resources();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ResourceEditForm f = new ResourceEditForm(true, null);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                ResourceStorage.getInstance().create(new Resource((string)f.Resource[0], Convert.ToInt32((string)f.Resource[1]),
                    (string)f.Resource[2], (string)f.Resource[3]));
            }
            load_resources();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                Resource prev = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(title));
                ResourceEditForm f = new ResourceEditForm(false, new Object[] { prev.Title, prev.Amount.ToString(), prev.Description });
                f.ShowDialog();
            }
        }
    }
}
