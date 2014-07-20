using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Users
{
    public partial class ViewUserForm : TemplateDialog
    {
        public ViewUserForm(User user)
        {
            InitializeComponent();
            if (user != null)
            {
                username_label.Text = user.Username;
                name_label.Text = user.Firstname;
                family_label.Text = user.Lastname;
                level_label.Text = user.ALevel.ToString();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
