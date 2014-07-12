using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Management
{
    public partial class ConventionForm : TemplateForm
    {
        public ConventionForm()
        {
            InitializeComponent();
        }

        private void attach_Click(object sender, EventArgs e)
        {
            addAtachment.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
