using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Audit.Metric
{
    public partial class MetricForm : TemplateForm
    {
        public MetricForm()
        {
            InitializeComponent();
            load_metrics();
        }

        private void load_metrics()
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.Metrics)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new AuditTaskForm()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddMetricForm add = new AddMetricForm("");
            add.ShowDialog();
            this.dataGridView1.Rows.Add(add.name);
            object[] row = { add.name };
            StaticData.Metrics.Add(row);
            load_metrics();
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            AddMetricForm add = new AddMetricForm((string)(StaticData.Metrics[dataGridView1.SelectedRows[0].Index][0]));
            add.ShowDialog();
            StaticData.Metrics[dataGridView1.SelectedRows[0].Index][0] = add.name;
            load_metrics();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ask_confirm();
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);
            
        }
    }
}
