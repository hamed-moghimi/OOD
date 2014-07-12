using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OOD.ExecutiveForms;
using OOD.ReportForms;
using OOD.Audit;
using OOD.Audit.Report;
using OOD.Audit.Metric;
using OOD.Management;
using OOD.UserManagement;

namespace OOD
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
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
            return MessageBox.Show("آیا مطمئن هستید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            newChild(new OverallReportForm());
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
            newChild(new MetricForm());
        }

        private void metricsEvaluationSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new MetricEntryForm());
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
            newChild(new ViewUserForm());
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
    }
}
