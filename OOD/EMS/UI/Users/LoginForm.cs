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
            Authentication.getInstance().login(null);
            (new MainForm()).Show();
            this.Hide();
        }
    }
}
