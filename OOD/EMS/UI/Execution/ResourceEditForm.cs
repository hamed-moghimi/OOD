using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Execution
{
    public partial class ResourceEditForm : TemplateDialog
    {
        private object[] resource;
        private bool canEdit = false;
        private String prevTitle;

        public ResourceEditForm(bool canEdit, object[] resource)
        {
            this.resource = resource;
            this.canEdit = canEdit;
            if (resource != null)
            {
                prevTitle = (string)resource[0];
            }
            else
            {
                prevTitle = null;
            }
            InitializeComponent();
            if (!canEdit)
            {
                this.button2.Visible = false;
                this.Cancel.Text = "بازگشت";
            }
        }

        public object[] Resource
        {
            get { return resource; }
        }

        private void ResourceEdit_Load(object sender, EventArgs e)
        {
            if (resource != null)
            {
                titleBox.Text = (string)resource[0];
                amountBox.Text = (string)resource[1];
                descBox.Text = (string)resource[2];
            }
            else
                resource = new object[3];
            titleBox.ReadOnly = amountBox.ReadOnly = descBox.ReadOnly = !canEdit;
            
        }

        

        private void ResourceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            resource[0] = titleBox.Text;
            resource[1] = amountBox.Text;
            resource[2] = descBox.Text;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resource res = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(titleBox.Text));
            if ((prevTitle == null || !prevTitle.Equals((string)resource[0])) && res != null)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(new ResourceExistsException().Message);
            }
            else
            {
                resource[1] = convert(amountBox.Text);
                try
                {
                    Convert.ToInt32(resource[1]);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(Exception e2)
                {
                    MessageBox.Show(new IncompleteFormException().Message);
                }
                
            }
        }

        
    }
}
