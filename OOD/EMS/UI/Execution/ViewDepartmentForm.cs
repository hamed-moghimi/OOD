using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Execution;

namespace OOD.EMS.UI.Execution
{
    public partial class ViewDepartmentForm : TemplateDialog
    {
        public ViewDepartmentForm(Department dept)
        {
            InitializeComponent();
            name_label.Text = dept.Name;
            resp_label.Text = dept.Manager.getName();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
