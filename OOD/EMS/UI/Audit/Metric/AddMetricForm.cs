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
    public partial class AddMetricForm : TemplateForm
    {
        public string name
        { get; set; }
        public AddMetricForm(string nameText)
        {
            this.menu.Visible = false;
            InitializeComponent();
            this.name_box.Text = nameText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.name = this.name_box.Text;
            this.Close();
        }
    }
}
