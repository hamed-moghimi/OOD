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
    public partial class AddMetricEntryForm : TemplateForm
    {

        public string name { get; set; }
        public string val { get; set; }
        public AddMetricEntryForm(string name, string value)
        {
            this.menu.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.name = (string)(StaticData.Metrics[dataGridView1.SelectedRows[0].Index][0]);
            this.val = value_box.Text;
            this.Close();
        }
    }
}
