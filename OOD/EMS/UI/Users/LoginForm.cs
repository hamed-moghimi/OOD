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
    public partial class LoginForm : TemplateDialog
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Authentication.getInstance().login(usernameBox.Text);
                (new MainForm()).Show();
                this.Hide();
            }
            catch (ActiveUserExistsException ex)
            {
                MessageBox.Show(ex.Message, "خطا");                
            }
            catch (NoSuchUserException ex)
            {
                MessageBox.Show(ex.Message, "2 خطا");
            }
        }
    }
}
