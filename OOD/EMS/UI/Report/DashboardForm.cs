using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Report;
using OOD.EMS.Execution;
using OOD.EMS.Audit;

namespace OOD.EMS.UI.Report
{
    public partial class DashboardForm : TemplateDialog
    {
        private static DashboardForm instance;
        public static DashboardForm getInstance()
        {
            if(instance == null)
                instance = new DashboardForm();
            return instance;
        }

        private Dashboard dashboard;

        private DashboardForm()
        {
            InitializeComponent();
            dashboard = new Dashboard();

            // fill execution programs
            var execProgs =
                (from goal in ExecutiveGoalStorage.getInstance().all()
                where goal.program != null
                select goal.program).ToArray();
            if (execProgs.Count() != 0)
            {
                executionProgramsBox.Items.AddRange(execProgs);
                executionProgramsBox.SelectedIndex = 0;
            }
            
            // fill metric values
            var metrics = MetricStorage.getInstance().all().ToArray();
            if (metrics.Count() != 0)
            {
                metricBox.Items.AddRange(metrics);
                metricBox.SelectedIndex = 0;
            }
            
            showDashboard();
        }

        private void showDashboard()
        {
            dashboard.show((ExecutionProgram)executionProgramsBox.SelectedItem, (Metric)metricBox.SelectedItem);
            invalidateFields();
        }

        private void refreshDashboard()
        {
            dashboard.refresh();
            invalidateFields();
        }

        private void invalidateFields()
        {
            generalGoalsLabel.Text = dashboard.GeneralGoals.ToString();
            executiveGoalsLabel.Text = dashboard.ExecutiveGoals.ToString();
            tasksLabel.Text = dashboard.Tasks.ToString();

            headManagersLabel.Text = dashboard.HeadManagers.ToString();
            executiveManagersLabel.Text = dashboard.ExecutiveManagers.ToString();
            inspectorsLabel.Text = dashboard.Inspectors.ToString();

            if (dashboard.Program != null)
            {
                progressLabel.Text = dashboard.Progress.ToString() + "٪";
                progressBar.Value = dashboard.Progress;
            }

            if (dashboard.Metric != null)
            {
                metricUnitLabel.Text = dashboard.Metric.Unit;
                var points = metricChart.Series[0].Points;
                points.Clear();
                foreach (MetricValue value in dashboard.MetricValues)
                    points.AddXY(value.Date.ToString("yy/MM/dd"), value.Value);
            }
        }

        private void boxes_change(object sender, EventArgs e)
        {
            showDashboard();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshDashboard();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
