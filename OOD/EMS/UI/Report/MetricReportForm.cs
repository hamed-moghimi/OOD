using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Audit;
using OOD.EMS.Report;

namespace OOD.EMS.UI.Report
{
    public partial class MetricReportForm : TemplateForm
    {
        public MetricReportForm()
        {
            InitializeComponent();
            toDateBox.Text = fromDateBox.Text = DateTime.Today.ToLongDateString();
            var metrics = MetricStorage.getInstance().all().ToArray();
            metricsBox.Items.AddRange(metrics);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = DateTime.Parse(fromDateBox.Text);
                DateTime toDate = DateTime.Parse(toDateBox.Text);
                if (metricsBox.CheckedItems.Count == 0)
                    throw new ArgumentNullException();
                var metrics = new Metric[metricsBox.CheckedItems.Count];
                metricsBox.CheckedItems.CopyTo(metrics, 0);
                MetricReporter reporter = new MetricReporter();
                MetricReport report = reporter.report(metrics, fromDate, toDate);
                (new MetricReportResultForm(report)).Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("تاریخ شروع یا پایان گزارش نادرست است");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("حداقل یکی از سنجه‌ها را باید انتخاب کنید");
            }
        }
    }
}
