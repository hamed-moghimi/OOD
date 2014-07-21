using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Management
{
    public partial class ConventionForm : TemplateForm
    {
        bool changed;
        public ConventionForm()
        {
            changed = false;
            InitializeComponent();
            Convention conv = Convention.getInstance();
            policyBox.Text = conv.Policy;
            dscpBox.Text = conv.Description;
            attachmentPanel1.populate(conv.attachments);

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyManagementDocs())
            {
                policyBox.ReadOnly = dscpBox.ReadOnly = true;
                attachmentPanel1.ViewMode = true;
                button2.Visible = false;
                Cancel.Text = "بازگشت";
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (changed || attachmentPanel1.Changed)
            {
                Convention conv = Convention.getInstance();
                conv.Policy = policyBox.Text;
                conv.Description = dscpBox.Text;
                conv.Date = DateTime.Today;
                conv.DocUser = Authentication.getInstance().ActiveUser;
                conv.attachments = attachmentPanel1.getAttachments();
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            foreach (Attachment attach in attachmentPanel1.getNewlyAdded())
            {
                attach.delete();
            }
            this.Close();
        }

        private void policyBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void dscpBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }



    }
}
