using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class TrainingResourceEdit : OOD.DialogTemplate
    {
        private object[] item;
        private bool canEdit = false;

        public TrainingResourceEdit(bool canEdit, object[] resource)
        {
            this.item = resource;
            this.canEdit = canEdit;
            InitializeComponent();
        }

        public object[] Item
        {
            get { return item; }
        }

        private void TrainingResourceEdit_Load(object sender, EventArgs e)
        {
            if (item != null)
            {
                titleBox.Text = (string)item[0];
                amountBox.Text = (string)item[1];
                descBox.Text = (string)item[2];
            }
            else
                item = new object[5];
            titleBox.ReadOnly = amountBox.ReadOnly = descBox.ReadOnly = !canEdit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrainingResourceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            item[0] = titleBox.Text;
            item[1] = amountBox.Text;
            item[2] = descBox.Text;
            item[3] = "تدارد";
        }

    }
}
