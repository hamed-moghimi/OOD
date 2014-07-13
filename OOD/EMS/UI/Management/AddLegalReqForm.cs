﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Management
{
    public partial class AddLegalReqForm : TemplateForm
    {
        public string name { set; get; }
        public string dscp { set; get; }
        public AddLegalReqForm(string name, string dscp)
        {
            this.menu.Visible = false;
            InitializeComponent();
            this.name_box.Text = name;
            this.dscp_box.Text = dscp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = this.name_box.Text;
            dscp = this.dscp_box.Text;
            if (LegalConstraintStorage.getInstance().all().Contains(new LegalConstraint(name, dscp)))
            {
                MessageBox.Show(new DocumentExsitsException().Message);
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
