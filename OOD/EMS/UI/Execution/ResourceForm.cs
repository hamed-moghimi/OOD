using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.EMS.UI.ExecutiveForms
{
    public partial class ResourceForm : TemplateForm
    {
        public ResourceForm()
        {
            InitializeComponent();
        }

        private void ResourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach(object[] row in StaticData.resources)
                dataGridView1.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);
            StaticData.resources.RemoveAt(i);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            new ResourceEditForm(false, StaticData.resources[dataGridView1.SelectedRows[0].Index]).ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ResourceEditForm f = new ResourceEditForm(true, StaticData.resources[dataGridView1.SelectedRows[0].Index]);
            f.ShowDialog();
            StaticData.resources[dataGridView1.SelectedRows[0].Index] = f.Resource;
            ResourseForm_Load(this, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ResourceEditForm f = new ResourceEditForm(true, null);
            f.ShowDialog();
            StaticData.resources.Add(f.Resource);
            ResourseForm_Load(this, null);
        }
    }
}
