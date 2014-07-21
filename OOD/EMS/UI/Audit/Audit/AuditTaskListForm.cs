using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Audit;
using OOD.EMS.Execution;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Audit.Audit
{
    public partial class AuditTaskListForm : TemplateForm
    {
        public AuditTaskListForm()
        {
            InitializeComponent();
            // fill list with tasks
            foreach (Task task in TaskStorage.getInstance().all())
            {
                var audits =
                    from audit in TaskAuditStorage.getInstance().all()
                    where audit.AuditTask == task
                    select audit;
                
                object lastAudit;
                if(audits.Count() == 0)
                    lastAudit = "-";
                else
                    lastAudit = audits.Max(item => item.Date);
                
                object[] row = new object[2];
                row[0] = task;
                row[1] = lastAudit == null ? "-" : lastAudit as object;
                this.list.Rows.Add(row);
            }

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;

            if (!level.canModifyAuditDocs())
            {
                addButton.Visible = false;
                int Y = (addButton.Location.Y);
                viewButton.Location = new System.Drawing.Point(viewButton.Location.X, Y);
            }
            
            //list.Sort(list.Columns["lastAudit"], ListSortDirection.Descending);
        }
                
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.SelectedRows.Count == 0)
                    throw new ArgumentException("لطفا یکی از موارد را برای حسابرسی انتخاب کنید");

                var task = list.SelectedRows[0].Cells[0].Value as Task;
                var form = new AuditTaskForm(task);
                var res = form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    list.SelectedRows[0].Cells[1].Value = form.Audit.Date;
                    //list.Sort(list.Columns["lastAudit"], ListSortDirection.Descending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.SelectedRows.Count == 0)
                    throw new ArgumentException("لطفا یکی از موارد را برای حسابرسی انتخاب کنید");

                var task = list.SelectedRows[0].Cells[0].Value as Task;
                var audits =
                    from audit in TaskAuditStorage.getInstance().all()
                    where audit.AuditTask == task
                    select audit;
                var form = new AuditSelectForm(task, audits);
                var res = form.ShowDialog();
                if(res == System.Windows.Forms.DialogResult.OK)
                    (new AuditTaskForm(form.Audit as TaskAudit)).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}