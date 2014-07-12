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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        // fields
        private Template parent;
        private int childrenNum = 0;

        /// <summary>
        /// This function get a form, show it and hide this.
        /// It also sets parent field of the form to this.
        /// </summary>
        private void newChild(Template childForm)
        {
            Template parent = this.parent == null ? this : this.parent;
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
        private void closeChild(Template childForm)
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

        private void trainingResourceSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new TrainingResourceForm());
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

        private void trainingResourceReport_Click(object sender, EventArgs e)
        {
            newChild(new TrainingResourceReport());
        }

        private void generalGoalAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Audit_Kalan_List());
        }

        private void executiveGoalAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Audit_Executive_List());
        }

        private void controlAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Physical_Report_List());
        }

        private void executiveDocumentAuditSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Executive_Report_List());
        }

        private void metricsCRUDSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Metric());
        }

        private void metricsEvaluationSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Metric_Entry());
        }

        private void generalGoalsSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new GeneralGoals());
        }

        private void obligationSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new LegalReq());
        }

        private void effectSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Effect());
        }

        private void conventionSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Misaghname());
        }

        private void viewAccountSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new View_User());
        }

        private void exitSubmenu_Click(object sender, EventArgs e)
        {
            ask_confirm();
            System.Windows.Forms.Application.Exit();
        }

        private void relationsSubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Relation());
        }

        private void responsibilitySubmenu_Click(object sender, EventArgs e)
        {
            newChild(new Audit_Task_List());
        }
    }
}
