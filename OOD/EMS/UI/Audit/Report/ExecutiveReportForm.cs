using System;
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
    public partial class ExecutiveReportForm : TemplateDialog
    {
        public ExecutiveReportForm()
        {
            InitializeComponent();
        }

        public ExecutiveReportForm(ExecutionInspection item) : this()
        {
            titleBox.ReadOnly = true;
            titleBox.Text = item.Title;
            descBox.ReadOnly = true;
            descBox.Text = item.Description;
            dateBox.Enabled = false;
            dateBox.Value = item.InspectionDate;
            OK.Visible = false;
            attach.Visible = false;
        }

        private void attach_Click(object sender, EventArgs e)
        {
            this.addAttachment.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private ExecutionInspection inspection;
        public ExecutionInspection Inspection { get { return inspection; } }

        private void OK_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Equals("") || descBox.Text.Equals(""))
            {
                MessageBox.Show("فرم را درست و کامل پر کنید");
                return;
            }
            inspection = new ExecutionInspection(titleBox.Text, descBox.Text, dateBox.Value,
                Authentication.getInstance().ActiveUser, null);
            ExecutionInspectionStorage.getInstance().create(inspection);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
