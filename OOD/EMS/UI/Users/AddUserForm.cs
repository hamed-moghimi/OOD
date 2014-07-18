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
    public partial class AddUserForm : TemplateDialog
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username_box.Text.Trim().Count() == 0 || name_box.Text.Trim().Count() == 0 || familiy_box.Text.Trim().Count() == 0 || accessLevel.SelectedItem == null)
            {
                MessageBox.Show(new IncompleteFormException().Message);
            }
            User user = UserStorage.getInstance().all().Find(x => x.Username.Equals(username_box.Text));
            if (user != null)
            {
                MessageBox.Show(new UserExistsException().Message);
            }
            else
            {
                String alevel = accessLevel.SelectedText;
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
                User new_user = new User(name_box.Text, familiy_box.Text, username_box.Text, access_Level);
                UserStorage.getInstance().create(new_user);
                this.Close();
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
