using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.UserManagement
{
    public partial class ViewUserForm : TemplateForm
    {
        public ViewUserForm()
        {
            this.menu.Visible = false;
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ask_confirm();
            System.Windows.Forms.Application.Exit();
        }
    }
}
