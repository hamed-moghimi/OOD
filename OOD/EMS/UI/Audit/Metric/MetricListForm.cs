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
    public partial class MetricListForm : TemplateForm
    {
        public MetricListForm()
        {
            InitializeComponent();
            loadMetrics();
        }

        private void loadMetrics()
        {
            list.Rows.Clear();
            foreach (Metric item in MetricStorage.getInstance().all())
            {
                var row = new object[] { item, item.Unit };
                this.list.Rows.Add(row);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MetricForm form = new MetricForm();
            var res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
                loadMetrics();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 0)
            {
                MessageBox.Show("حداقل یکی از موارد را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            var metric = list.SelectedRows[0].Cells[0].Value as Metric;
            var form = new MetricForm(metric);
            var res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
                loadMetrics();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 0)
            {
                MessageBox.Show("حداقل یکی از موارد را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            var metric = list.SelectedRows[0].Cells[0].Value as Metric;
            var values =
                from value in MetricValueStorage.getInstance().all()
                where value.pairMetric.Equals(metric)
                select value;
            if (values.Count() != 0)
            {
                MessageBox.Show("شما نمی‌توانید سنجه‌ای که برای آن مقدار به ثبت رسیده حذف کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                return;
            }
            ask_confirm();
            MetricStorage.getInstance().remove(metric);
            loadMetrics();
        }
    }
}
