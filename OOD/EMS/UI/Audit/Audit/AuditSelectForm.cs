using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Audit;

namespace OOD.EMS.UI.Audit.Audit
{
    public partial class AuditSelectForm : TemplateDialog
    {
        public AuditSelectForm(object target, IEnumerable<BaseAudit> audits)
        {
            InitializeComponent();
            targetName.Text = target.ToString();
            foreach (var item in audits)
            {
                object[] row = new object[3];
                row[0] = item.Date;
                row[1] = item.Creator;
                row[2] = item;
                list.Rows.Add(row);
            }
            list.Sort(list.Columns[0], ListSortDirection.Descending);
        }

        private BaseAudit audit;
        public BaseAudit Audit { get { return audit; } }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 0)
                MessageBox.Show("لطفا یکی از موارد را برای مشاهده اتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
            else
            {
                this.audit = list.SelectedRows[0].Cells[2].Value as BaseAudit;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
