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
    public partial class Executive_Report_List : Template
    {
        public Executive_Report_List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new View_Executive_Report()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Executive_Report()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
