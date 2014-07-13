using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;

namespace OOD.EMS.UI.Management
{
    public partial class ViewLegalReqForm : TemplateForm
    {
        public ViewLegalReqForm(LegalConstraint goal)
        {
            menu.Visible = false;
            InitializeComponent();
            this.GoalNameLabel.Text = goal.Title;
            this.DateBox.Text = goal.getDateString();
            this.dscp_box.Text = goal.Description;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
