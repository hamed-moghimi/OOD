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
    public partial class PhysicalReportListForm : TemplateForm
    {
        public PhysicalReportListForm()
        {
            InitializeComponent();
            foreach (var inspection in PhysicalInspectionStorage.getInstance().all())
                addListRow(inspection);

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;

            if (!level.canModifyAuditDocs())
            {
                addButton.Visible = false;
                int Y = (addButton.Location.Y);
                viewButton.Location = new System.Drawing.Point(viewButton.Location.X, Y);
            }
            
        }

        private void addListRow(PhysicalInspection inspection)
        {
            object[] row = new object[3];
            row[0] = inspection;
            row[1] = inspection.ReportDate;
            row[2] = inspection.Inspector;
            list.Rows.Add(row);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new PhysicalReportForm();
                var res = form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                    addListRow(form.Inspection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 0)
            {
                MessageBox.Show("حداقل یکی از موارد را برای مشاهده انتخاب کنید");
                return;
            }
            var item = list.SelectedRows[0].Cells[0].Value as PhysicalInspection;
            (new PhysicalReportForm(item)).Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
