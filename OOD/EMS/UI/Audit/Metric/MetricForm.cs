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
    public partial class MetricForm : TemplateDialog
    {
        public Metric Metric { get; set; }
        
        public MetricForm(Metric metric)
        {
            InitializeComponent();
            Metric = metric;
            titleBox.Text = metric.Name;
            unitBox.Text = metric.Unit;
            this.Text = "تغییر سنجه";
        }

        public MetricForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Equals("") || unitBox.Text.Equals(""))
            {
                MessageBox.Show("فرم را درست و کامل پر کنید");
                return;
            }
            
            if (Metric == null)
            {
                Metric = new Metric(titleBox.Text, unitBox.Text);
                if (MetricStorage.getInstance().all().Contains(Metric))
                {
                    MessageBox.Show("سنجه‌ای با این نام پیش از این در سیستم ثبت شده است");
                    return;
                }
                MetricStorage.getInstance().create(Metric);
            }
            else
            {
                Metric.Name = titleBox.Text;
                Metric.Unit = unitBox.Text;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
