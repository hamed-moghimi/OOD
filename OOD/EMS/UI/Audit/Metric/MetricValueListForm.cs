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

namespace OOD.EMS.UI.Audit.Metric
{
    using Metric = OOD.EMS.Audit.Metric;
    public partial class MetricValueListForm : TemplateForm
    {
        private MetricValueList audit;
        
        public MetricValueListForm()
        {
            InitializeComponent();
            audit = new MetricValueList();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadValues()
        {
            list.Rows.Clear();
            foreach (MetricValue item in audit.all())
            {
                var row = new object[] { item.Date, item.pairMetric,
                    string.Format("{0} {1}", item.Value.ToString(), item.pairMetric.Unit.ToString()),
                    item };
                this.list.Rows.Add(row);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MetricValueForm form = new MetricValueForm();
            var res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                audit.create(form.Value);
                loadValues();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 0)
            {
                MessageBox.Show("حداقل یکی از موارد را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            var item = list.SelectedRows[0].Cells[3].Value as MetricValue;
            var form = new MetricValueForm(item);
            var res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
                loadValues();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 0)
            {
                MessageBox.Show("حداقل یکی از موارد را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            var item = list.SelectedRows[0].Cells[3].Value as MetricValue;
            ask_confirm();
            audit.remove(item);
            loadValues();
        }

        private bool endAudit = false;
        private void OK_Click(object sender, EventArgs e)
        {
            endAudit = true;
            this.Close();
        }

        private void MetricValueListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (endAudit)
            {
                var res = MessageBox.Show("با پایان حسابرسی، تمامی مقادیر واردشده در سیستم ثبت شده و دیگر قادر به تغییر یا حذف آن‌ها نیستید\nآیا مطمئن هستید که می‌خواهید به حسابرسی پایان دهید؟",
                    "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    MetricValueStorage.getInstance().addAll(audit.all());
                }
                else
                    e.Cancel = true;
            }
            else
            {
                e.Cancel =
                    MessageBox.Show("آیا مطمئن هستید که می‌خواهید بدون ثبت مقادیر خارج شوید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                    != System.Windows.Forms.DialogResult.Yes;
            }
        }
    }
}
