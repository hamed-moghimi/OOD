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
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Users
{
    public partial class EditUserForm : TemplateDialog
    {
        private User user;
        public EditUserForm(User user)
        {
            InitializeComponent();
            if (user != null)
            {
                username_label.Text = user.Username;
                name_box.Text = user.Firstname;
                familiy_box.Text = user.Lastname;
                foreach (Object ob in accessLevel.Items)
                {
                    if(((string)ob).Equals(user.ALevel.ToString())){
                        accessLevel.SelectedItem = ob;
                        break;
                    }
                }
            }
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name_box.Text.Trim().Count() == 0 || familiy_box.Text.Trim().Count() == 0 || accessLevel.SelectedItem == null)
            {
                MessageBox.Show(new IncompleteFormException().Message);
            }
            else
            {
                user.Firstname = name_box.Text.Trim();
                user.Lastname = familiy_box.Text.Trim();
                String alevel = (String)accessLevel.SelectedItem;
                AccessLevel access_Level = null;
                if (alevel.Equals("کاربر میانی"))
                {
                    access_Level = new Manager();
                }
                else if (alevel.Equals("کاربر ارشد"))
                {
                    access_Level = new HeadManager();
                }
                else
                {
                    access_Level = new Inspector();
                }
                user.ALevel = access_Level;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
