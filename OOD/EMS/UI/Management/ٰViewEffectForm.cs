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
    public partial class ViewEffectForm : TemplateForm
    {
        public ViewEffectForm(EnvironEffect goal)
        {
            menu.Visible = false;
            InitializeComponent();
            this.GoalNameLabel.Text = goal.Title;
            this.DateBox.Text = goal.getDateString();
            this.dscp_box.Text = goal.Description;
            this.userBox.Text = goal.DocUser.Firstname + " " + goal.DocUser.Lastname;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userBox_Click(object sender, EventArgs e)
        {

        }

       
    }
}
