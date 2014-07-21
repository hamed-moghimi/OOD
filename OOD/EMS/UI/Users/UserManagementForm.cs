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
    public partial class UserManagementForm : TemplateForm
    {
        public UserManagementForm()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManagement_FormClosed);
            load_users();
        }

        private void UserManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void load_users()
        {
            userGrid.Rows.Clear();
            foreach (User user in UserStorage.getInstance().all())
            {
                userGrid.Rows.Add(new Object[] { user.Username, user.ALevel.ToString()});
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count > 0)
            {
                String username = (String)userGrid.Rows[userGrid.SelectedRows[0].Index].Cells[0].Value;
                User user = UserStorage.getInstance().all().Find(x => x.Username.Equals(username));
                if (user != null)
                {
                    if (user.ALevel is Administrator)
                    {
                        MessageBox.Show("مدیر سیستم قابل حذف نیست");
                    }
                    else
                    {
                        DialogResult res = ask_confirm();
                        if (res == DialogResult.Yes)
                        {
                            UserStorage.getInstance().remove(user);
                            load_users();
                        }
                    }
                }
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            (new AddUserForm()).ShowDialog();
            load_users();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count > 0)
            {
                String username = (String)userGrid.Rows[userGrid.SelectedRows[0].Index].Cells[0].Value;
                User user = UserStorage.getInstance().all().Find(x => x.Username.Equals(username));
                if (user != null)
                {
                    if (user.ALevel is Administrator)
                    {
                        MessageBox.Show("مدیر سیستم قابل تغییر نیست");
                    }
                    else
                    {
                        (new EditUserForm(user)).ShowDialog();
                        load_users();
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count > 0)
            {
                String username = (String)userGrid.Rows[userGrid.SelectedRows[0].Index].Cells[0].Value;
                User user = UserStorage.getInstance().all().Find(x => x.Username.Equals(username));
                if (user != null)
                {
                    (new ViewUserForm(user)).ShowDialog();
                }
            }
        }
    }
}
