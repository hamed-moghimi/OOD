using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Report;

namespace OOD.EMS.UI.Report
{
    public partial class ScheduleReportForm : TemplateForm
    {
        public ScheduleReportForm()
        {
            InitializeComponent();
            toDateBox.Text = fromDateBox.Text = DateTime.Today.ToLongDateString();
            var programs = 
                (from goal in ExecutiveGoalStorage.getInstance().all()
                where goal.program != null
                select goal.program).ToArray();

            programListBox.Items.AddRange(programs);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = fromDateBox.Value;
                DateTime toDate = toDateBox.Value;
                ExecutionProgram program = programListBox.SelectedItem as ExecutionProgram;
                if(program == null)
                    throw new ArgumentNullException();
                var reporter = new ScheduleReporter();
                var report = reporter.report(program, fromDate, toDate);
                (new ScheduleReportResultForm(report)).Show();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("تاریخ شروع یا پایان گزارش نادرست است");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("لطفا برنامه اقدام موردنظر خود را انتخاب کنید");
            }
        }
    }
}
