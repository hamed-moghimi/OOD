using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OOD.EMS.UI.Execution;
using OOD.EMS.UI.Report;
using OOD.EMS.UI.Audit.Audit;
using OOD.EMS.UI.Audit.Report;
using OOD.EMS.UI.Audit.Metric;
using OOD.EMS.UI.Management;
using OOD.EMS.UI.Users;
using OOD.EMS.Users;

namespace OOD.EMS.UI
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
            
            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyAuditDocs())
            {
                transformAuditMenu();
            }
            if (!level.canModifyExecutiveDocs())
            {
                transformExecutiveMenu();
            }
            
        }

        // fields
        private TemplateForm parent;
        private int childrenNum = 0;

        /// <summary>
        /// This function get a form, show it and hide this.
        /// It also sets parent field of the form to this.
        /// </summary>
        private void newChild(TemplateForm childForm)
        {
            TemplateForm parent = this.parent == null ? this : this.parent;
            childForm.parent = parent;
            parent.childrenNum++;
            parent.Hide();
            childForm.Show();
        }

        /// <summary>
        /// This function gets a form, decrement children and show this form
        /// if there is no children
        /// </summary>
        /// <param name="childForm"></param>
        private void closeChild(TemplateForm childForm)
        {
            this.childrenNum--;
            if (childrenNum == 0)
                this.Show();
        }

        private void Template_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.parent != null)
                this.parent.closeChild(this);
        }

        public static DialogResult ask_confirm()
        {
            return MessageBox.Show("آیا مطمئن هستید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            

        }

        protected String convert(String old)
        {
            String res = old;
            char[][] numbers = new char[][]
            {
                "0123456789".ToCharArray(),"۰۱۲۳۴۵۶۷۸۹".ToCharArray()
            };
            for (int x = 0; x <= 9; x++)
            {
                res = res.Replace(numbers[1][x], numbers[0][x]);
            }
            return res;
        }

        // ------------------------------------------------------------------

        private void structureSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new StructureForm());
        }

        private void resourcesSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new ResourceForm());
        }

        private void executiveSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new ExecutiveGoalForm());
        }

        private void scheduleSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new ScheduleForm());
        }

        private void documentReport_Click(object sender, EventArgs e)
        {
            (new OverallReportForm()).ShowDialog();
        }

        private void scheduleReport_Click(object sender, EventArgs e)
        {
            newChild(new ScheduleReportForm());
        }

        private void generalGoalAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new AuditGeneralListForm());
        }

        private void executiveGoalAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new AuditExecutiveListForm());
        }

        private void controlAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new PhysicalReportListForm());
        }

        private void executiveDocumentAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new ExecutiveReportListForm());
        }

        private void metricsCRUDSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new MetricListForm());
        }

        private void metricsEvaluationSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new MetricValueListForm());
        }

        private void generalGoalsSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new GeneralGoalsForm());
        }

        private void obligationSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new LegalReqForm());
        }

        private void effectSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new EffectForm());
        }

        private void conventionSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new ConventionForm());
        }

        private void viewAccountSubmenu_Click(object sender, EventArgs e)
        {
            (new ViewUserForm(OOD.EMS.Users.Authentication.getInstance().ActiveUser)).ShowDialog();
        }

        private void exitSubmenu_Click(object sender, EventArgs e)
        {
            ask_confirm();
            System.Windows.Forms.Application.Exit();
        }

        private void relationsSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new RelationForm());
        }

        private void responsibilitySubmenu_Click(object sender, EventArgs e)
        {
            newChild(new AuditTaskListForm());
        }

        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm.getInstance().Show();
            DashboardForm.getInstance().Activate();
        }

        private void metricsReport_Click(object sender, EventArgs e)
        {
            newChild(new MetricReportForm());
        }

        private void TaskManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newChild(new TaskForm());
        }

        private void GoalsRelationManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newChild(new ExecutiveGoal_GeneralGoalRelationForm());
        }

        private void transformExecutiveMenu()
        {
            resourcesSubmenu.Text = "مشاهده‌ی منابع";
            structureSubmenu.Text = "مشاهده‌ی ساختار";
            executiveSubmenu.Text = "مشاهده‌ی اهداف اجرایی";
            scheduleSubmenu.Text = "مشاهده‌ی برنامه‌های اقدام";
            TaskSubmenu.Text = "مشاهده‌ی مسئولیت‌ها";
            GoalRelationSubmenu.Text = "مشاهده‌ی ارتباط اهداف";
        }

        private void transformAuditMenu()
        {
            auditGoalSubmenu.Text = "مشاهده‌ی حسابرسی";
            reportAuditSubmenu.Text = "مشاهده‌ی گزارش";
            metricsAuditSubmenu.Visible = false;
        }
    }
}
