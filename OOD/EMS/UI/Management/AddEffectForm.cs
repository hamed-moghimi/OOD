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
    public partial class AddEffectForm : TemplateDialog
    {
        public AddEffectForm()
        {
            InitializeComponent();
        }

        public string name { set; get; }
        public string dscp { set; get; }
        public List<Attachment> attachments { get; set; }

        public AddEffectForm(string name, string dscp)
        {
            InitializeComponent();
            this.name_box.Text = name;
            this.dscp_box.Text = dscp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = this.name_box.Text;
            if (name.Trim().Count() == 0)
            {
                MessageBox.Show(new IncompleteFormException().Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            dscp = this.dscp_box.Text;
            attachments = attachmentPanel1.getAttachments();
            if (EnvironEffectStorage.getInstance().all().Contains(new EnvironEffect(name, dscp)))
            {
                MessageBox.Show(new DocumentExsitsException().Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
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
            foreach (Attachment attach in attachmentPanel1.getNewlyAdded())
            {
                attach.delete();
            }
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
