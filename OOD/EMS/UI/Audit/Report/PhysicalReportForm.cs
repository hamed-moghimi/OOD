﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Audit;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Audit.Report
{
    public partial class PhysicalReportForm : TemplateDialog
    {
        public PhysicalReportForm()
        {
            InitializeComponent();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public PhysicalReportForm(PhysicalInspection item) : this()
        {
            titleBox.ReadOnly = true;
            titleBox.Text = item.Title;
            descBox.ReadOnly = true;
            descBox.Text = item.Description;
            dateBox.Enabled = false;
            dateBox.Value = item.InspectionDate;
            OK.Visible = false;
            attachmentPanel1.populate(item.Attachments);
            attachmentPanel1.ViewMode = true;
        }

        private void attach_Click(object sender, EventArgs e)
        {
            this.addAttachment.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PhysicalInspection inspection;
        public PhysicalInspection Inspection { get { return inspection; } }

        private void OK_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Equals("") || descBox.Text.Equals(""))
            {
                MessageBox.Show("فرم را درست و کامل پر کنید");
                return;
            }
            inspection = new PhysicalInspection(titleBox.Text, descBox.Text, dateBox.Value,
                Authentication.getInstance().ActiveUser, attachmentPanel1.getAttachments());
            PhysicalInspectionStorage.getInstance().create(inspection);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void PhysicalReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
                attachmentPanel1.getNewlyAdded().ForEach(item => item.delete());
        }
    }
}
