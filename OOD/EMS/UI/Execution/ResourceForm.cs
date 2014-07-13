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

namespace OOD.EMS.UI.ExecutiveForms
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
                object[] row = new object[] {r.Title, r.Amount, r.Description };
                dataGridView1.Rows.Add(row);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = ask_confirm();
            if (res == DialogResult.Yes)
            {
                String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                ResourceStorage.getInstance().all().RemoveAll(x => x.Title.Equals(title));
                load_resources();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            new ResourceEditForm(false, StaticData.resources[dataGridView1.SelectedRows[0].Index]).ShowDialog();
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            Resource prev = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(title));
            ResourceEditForm f = new ResourceEditForm(true, new Object[]{prev.Title, prev.Amount.ToString(), prev.Description});
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                prev.Title = (string)f.Resource[0];
                prev.Amount = Convert.ToInt32((string)f.Resource[1]);
                prev.Description = (string)f.Resource[2];
            }
            load_resources();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ResourceEditForm f = new ResourceEditForm(true, null);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                ResourceStorage.getInstance().create(new Resource((string)f.Resource[0], Convert.ToInt32((string)f.Resource[1]),
                    (string)f.Resource[2]));
            }
            load_resources();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            Resource prev = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(title));
            ResourceEditForm f = new ResourceEditForm(false, new Object[] { prev.Title, prev.Amount.ToString(), prev.Description });
            f.ShowDialog();
        }
    }
}
