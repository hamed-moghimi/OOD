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
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Audit.Metric
{
    using Metric = OOD.EMS.Audit.Metric;
    public partial class MetricValueForm : TemplateDialog
    {
        public MetricValue Value { get; set; }

        private void loadMetrics()
        {
            metricBox.Items.Clear();
            metricBox.Items.AddRange(MetricStorage.getInstance().all().ToArray());
            if (metricBox.Items.Count != 0)
                metricBox.SelectedIndex = 0;
        }
        
        public MetricValueForm()
        {
            InitializeComponent();
            loadMetrics();
        }

        public MetricValueForm(MetricValue item)
        {
            InitializeComponent();
            loadMetrics();
            metricBox.SelectedItem = item.pairMetric;
            valueBox.Text = item.Value.ToString();
            dateBox.Value = item.Date;
            Value = item;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {

            try
            {
                if (Value == null)
                    Value = new MetricValue(null, 0, DateTime.Now);
                Value.Date = dateBox.Value;
                Value.pairMetric = metricBox.SelectedItem as Metric;
                if (Value.pairMetric == null)
                {
                    throw new IncompleteFormException();
                }
                //TODO: convert number
                Value.Value = double.Parse(convert(valueBox.Text));
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(new IncompleteFormException().Message, "خطا");
            }
        }

        private void metricBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitBox.Text = (metricBox.SelectedItem as Metric).Unit.ToString();
        }
    }
}
