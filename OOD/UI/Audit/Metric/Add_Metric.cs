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
    public partial class Add_Metric : Template
    {
        public string name
        { get; set; }
        public Add_Metric(string nameText)
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
