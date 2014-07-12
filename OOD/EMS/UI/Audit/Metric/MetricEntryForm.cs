using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.EMS.UI.Audit.Metric
{
    public partial class MetricEntryForm : TemplateForm
    {
        public MetricEntryForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddMetricEntryForm add = new AddMetricEntryForm("", "");
            add.ShowDialog();
            dataGridView1.Rows.Add(add.name, add.val);
         
        }

        private void edit_Click(object sender, EventArgs e)
        {
            EditMetricEntryForm add = new EditMetricEntryForm((string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value, 
                (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value);
            add.ShowDialog();
            this.dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value = add.name;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ask_confirm();
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);

        }
    }
}
