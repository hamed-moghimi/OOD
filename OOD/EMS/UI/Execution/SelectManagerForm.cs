using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;
using OOD.EMS.Users;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Execution
{
    public partial class SelectManagerForm : TemplateDialog
    {

        public User selectedUser { get; set; }

        public SelectManagerForm()
        {
            InitializeComponent();
            managerList.Rows.Clear();
            foreach(User user in UserStorage.getInstance().all()){
                if(user.ALevel is BasicUser){
                    managerList.Rows.Add(new Object[]{user.getName()});
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (managerList.SelectedRows == null)
            {
                MessageBox.Show(new IncompleteFormException().Message);
            }
            else
            {
                String name = (string)managerList.Rows[managerList.SelectedRows[0].Index].Cells[0].Value;
                String[] namePart = name.Split();
                selectedUser = UserStorage.getInstance().all().Find(x => x.Firstname.Equals(namePart[0]) &&
                                                                        x.Lastname.Equals(namePart[1]));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
