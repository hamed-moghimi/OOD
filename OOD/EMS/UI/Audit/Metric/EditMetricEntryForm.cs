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
    public partial class EditMetricEntryForm : TemplateForm
    {
        public string name {get; set;}
        

        public EditMetricEntryForm(string name, string val)
        {
            this.menu.Visible = false;
            InitializeComponent();
            this.name_box.Text = name;
            this.value_box.Text = val;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.name = this.value_box.Text;
            this.Close();
        }

    }
}
