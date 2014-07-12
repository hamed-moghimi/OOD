using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Audit.Report
{
    public partial class PhysicalReportListForm : TemplateForm
    {
        public PhysicalReportListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ViewPhysicalReportForm()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new PhysicalReportForm()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
