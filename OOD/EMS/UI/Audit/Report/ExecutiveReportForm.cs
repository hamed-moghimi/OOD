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
    public partial class ExecutiveReportForm : TemplateDialog
    {
        public ExecutiveReportForm()
        {
            InitializeComponent();
        }

        private void attach_Click(object sender, EventArgs e)
        {
            this.addAttachment.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
