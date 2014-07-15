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
    public partial class SelectResourceForm : TemplateForm
    {

        public Allocation alloc { set; get; }

        public SelectResourceForm(List<Resource> exclude)
        {
            InitializeComponent();
            load_goals(exclude);
        }


        private void load_goals(List<Resource> exclude)
        {
            dataGridView1.Rows.Clear();
            foreach (Resource goal in ResourceStorage.getInstance().all())
            {
                if (!exclude.Contains(goal))
                {
                    dataGridView1.Rows.Add(new Object[] { goal.Title, goal.Amount.ToString() });
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
            String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            Resource r = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(name));
            alloc = new Allocation(Convert.ToDateTime(fromDateBox.Text), Convert.ToDateTime(toDateBox.Text),
                                    r, null, Convert.ToInt32(cont_box.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



    }
}
