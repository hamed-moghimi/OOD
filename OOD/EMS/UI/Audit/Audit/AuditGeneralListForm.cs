using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Audit;
using OOD.EMS.Management;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Audit.Audit
{
    public partial class AuditGeneralListForm : TemplateForm
    {
        public AuditGeneralListForm()
        {
            InitializeComponent();
            // fill list with goals
            foreach (GeneralGoal goal in GeneralGoalStorage.getInstance().all())
            {
                var audits =
                    from audit in GeneralGoalAuditStorage.getInstance().all()
                    where audit.Goal == goal
                    select audit;
                
                object lastAudit;
                if(audits.Count() == 0)
                    lastAudit = "-";
                else
                    lastAudit = audits.Max(item => item.Date);
                
                object[] row = new object[2];
                row[0] = goal;
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

                var goal = list.SelectedRows[0].Cells[0].Value as GeneralGoal;
                var form = new AuditGeneralForm(goal);
                var res = form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    list.SelectedRows[0].Cells[1].Value = form.Audit.Date;
                    //list.Sort(list.Columns["lastAudit"], ListSortDirection.Descending);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (list.SelectedRows.Count == 0)
                    throw new ArgumentException("لطفا یکی از موارد را برای حسابرسی انتخاب کنید");

                var goal = list.SelectedRows[0].Cells[0].Value as GeneralGoal;
                var audits =
                    from audit in GeneralGoalAuditStorage.getInstance().all()
                    where audit.Goal == goal
                    select audit;
                var form = new AuditSelectForm(goal, audits);
                var res = form.ShowDialog();
                if(res == System.Windows.Forms.DialogResult.OK)
                    (new AuditGeneralForm(form.Audit as GeneralGoalAudit)).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
            }
        }
    }
}