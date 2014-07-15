using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Users;

namespace OOD.EMS.UI
{
    public partial class MainForm : TemplateForm
    {
        public MainForm()
        {
            InitializeComponent();
            User active = Authentication.getInstance().ActiveUser;
            NameTextBox.Text = active.Firstname + " " + active.Lastname;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
