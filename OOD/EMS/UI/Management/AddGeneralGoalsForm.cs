﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OOD.EMS.Management;
using OOD.EMS.Exceptions;


namespace OOD.EMS.UI.Management
{
    public partial class AddGeneralGoalsForm : TemplateForm
    {

        public string name { set; get; }
        public string dscp { set; get; }
        public List<Attachment> attachments { set; get; }

        
        public AddGeneralGoalsForm(string name, string dscp)
        {
            this.menu.Visible = false;
            InitializeComponent();
            this.name_box.Text = name;
            this.dscp_box.Text = dscp;
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            name = this.name_box.Text;
            if (name.Trim().Count() == 0)
            {
                MessageBox.Show(new IncompleteFormException().Message);
                return;
            }
            dscp = this.dscp_box.Text;
            attachments = attachmentPanel1.getAttachments();
            if (GeneralGoalStorage.getInstance().all().Contains(new GeneralGoal(name, dscp)))
            {
                MessageBox.Show(new GeneralGoalExists().Message);
                this.DialogResult = DialogResult.None;
            }
            else
            {
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
