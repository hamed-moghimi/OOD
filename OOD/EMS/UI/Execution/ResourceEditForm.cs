using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class ResourceEditForm : OOD.TemplateDialog
    {
        private object[] resource;
        private bool canEdit = false;

        public ResourceEditForm(bool canEdit, object[] resource)
        {
            this.resource = resource;
            this.canEdit = canEdit;
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResourceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            resource[0] = titleBox.Text;
            resource[1] = amountBox.Text;
            resource[2] = descBox.Text;
        }
    }
}
