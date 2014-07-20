using System.Windows.Forms;

namespace OOD.EMS.UI
{
    partial class TemplateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        public static void setHeader(Form form, string header)
        {
            form.Text = header;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.managementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generalGoalsSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.obligationSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.effectSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.relationsSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conventionSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.executiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.structureSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.executiveSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GoalRelationSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.auditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.auditGoalSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generalGoalAuditSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.executiveGoalAuditSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.responsibilitySubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAuditSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.controlAuditSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.executiveDocumentAuditSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metricsAuditSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metricsCRUDSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metricsEvaluationSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.documentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleReport = new System.Windows.Forms.ToolStripMenuItem();
            this.metricsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementMenu,
            this.executiveMenu,
            this.auditMenu,
            this.reportMenu,
            this.AccountMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(676, 32);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // managementMenu
            // 
            this.managementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalGoalsSubmenu,
            this.obligationSubmenu,
            this.effectSubmenu,
            this.toolStripSeparator1,
            this.relationsSubmenu,
            this.toolStripSeparator2,
            this.conventionSubmenu});
            this.managementMenu.Name = "managementMenu";
            this.managementMenu.Size = new System.Drawing.Size(96, 28);
            this.managementMenu.Text = "اسناد مدیریتی";
            // 
            // generalGoalsSubmenu
            // 
            this.generalGoalsSubmenu.Name = "generalGoalsSubmenu";
            this.generalGoalsSubmenu.Size = new System.Drawing.Size(191, 28);
            this.generalGoalsSubmenu.Text = "اهداف کلان";
            this.generalGoalsSubmenu.Click += new System.EventHandler(this.generalGoalsSubmenu_Click);
            // 
            // obligationSubmenu
            // 
            this.obligationSubmenu.Name = "obligationSubmenu";
            this.obligationSubmenu.Size = new System.Drawing.Size(191, 28);
            this.obligationSubmenu.Text = "الزامات قانونی";
            this.obligationSubmenu.Click += new System.EventHandler(this.obligationSubmenu_Click);
            // 
            // effectSubmenu
            // 
            this.effectSubmenu.Name = "effectSubmenu";
            this.effectSubmenu.Size = new System.Drawing.Size(191, 28);
            this.effectSubmenu.Text = "تاثیرات زیست‌محیطی";
            this.effectSubmenu.Click += new System.EventHandler(this.effectSubmenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // relationsSubmenu
            // 
            this.relationsSubmenu.Name = "relationsSubmenu";
            this.relationsSubmenu.Size = new System.Drawing.Size(191, 28);
            this.relationsSubmenu.Text = "ارتباطات";
            this.relationsSubmenu.Click += new System.EventHandler(this.relationsSubmenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // conventionSubmenu
            // 
            this.conventionSubmenu.Name = "conventionSubmenu";
            this.conventionSubmenu.Size = new System.Drawing.Size(191, 28);
            this.conventionSubmenu.Text = "میثاق‌نامه";
            this.conventionSubmenu.Click += new System.EventHandler(this.conventionSubmenu_Click);
            // 
            // executiveMenu
            // 
            this.executiveMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourcesSubmenu,
            this.structureSubmenu,
            this.toolStripSeparator3,
            this.executiveSubmenu,
            this.scheduleSubmenu,
            this.TaskSubmenu,
            this.GoalRelationSubmenu});
            this.executiveMenu.Name = "executiveMenu";
            this.executiveMenu.Size = new System.Drawing.Size(104, 28);
            this.executiveMenu.Text = "اسناد عملکردی";
            // 
            // resourcesSubmenu
            // 
            this.resourcesSubmenu.Name = "resourcesSubmenu";
            this.resourcesSubmenu.Size = new System.Drawing.Size(202, 28);
            this.resourcesSubmenu.Text = "مدیریت منابع";
            this.resourcesSubmenu.Click += new System.EventHandler(this.resourcesSubmenu_Click);
            // 
            // structureSubmenu
            // 
            this.structureSubmenu.Name = "structureSubmenu";
            this.structureSubmenu.Size = new System.Drawing.Size(202, 28);
            this.structureSubmenu.Text = "ساختار سازمان";
            this.structureSubmenu.Click += new System.EventHandler(this.structureSubmenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // executiveSubmenu
            // 
            this.executiveSubmenu.Name = "executiveSubmenu";
            this.executiveSubmenu.Size = new System.Drawing.Size(202, 28);
            this.executiveSubmenu.Text = "مدیریت اهداف اجرایی";
            this.executiveSubmenu.Click += new System.EventHandler(this.executiveSubmenu_Click);
            // 
            // scheduleSubmenu
            // 
            this.scheduleSubmenu.Name = "scheduleSubmenu";
            this.scheduleSubmenu.Size = new System.Drawing.Size(202, 28);
            this.scheduleSubmenu.Text = "مدیریت برنامه‌های اقدام";
            this.scheduleSubmenu.Click += new System.EventHandler(this.scheduleSubmenu_Click);
            // 
            // TaskSubmenu
            // 
            this.TaskSubmenu.Name = "TaskSubmenu";
            this.TaskSubmenu.Size = new System.Drawing.Size(202, 28);
            this.TaskSubmenu.Text = "مدیریت مسئولیت‌ها";
            this.TaskSubmenu.Click += new System.EventHandler(this.TaskManagementToolStripMenuItem_Click);
            // 
            // GoalRelationSubmenu
            // 
            this.GoalRelationSubmenu.Name = "GoalRelationSubmenu";
            this.GoalRelationSubmenu.Size = new System.Drawing.Size(202, 28);
            this.GoalRelationSubmenu.Text = "مدیریت ارتباط اهداف";
            this.GoalRelationSubmenu.Click += new System.EventHandler(this.GoalsRelationManagementToolStripMenuItem_Click);
            // 
            // auditMenu
            // 
            this.auditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditGoalSubmenu,
            this.reportAuditSubmenu,
            this.metricsAuditSubmenu});
            this.auditMenu.Name = "auditMenu";
            this.auditMenu.Size = new System.Drawing.Size(74, 28);
            this.auditMenu.Text = "حسابرسی";
            // 
            // auditGoalSubmenu
            // 
            this.auditGoalSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalGoalAuditSubmenu,
            this.executiveGoalAuditSubmenu,
            this.responsibilitySubmenu});
            this.auditGoalSubmenu.Name = "auditGoalSubmenu";
            this.auditGoalSubmenu.Size = new System.Drawing.Size(173, 28);
            this.auditGoalSubmenu.Text = "ثبت حسابرسی";
            // 
            // generalGoalAuditSubmenu
            // 
            this.generalGoalAuditSubmenu.Name = "generalGoalAuditSubmenu";
            this.generalGoalAuditSubmenu.Size = new System.Drawing.Size(150, 28);
            this.generalGoalAuditSubmenu.Text = "اهداف کلان";
            this.generalGoalAuditSubmenu.Click += new System.EventHandler(this.generalGoalAuditSubmenu_Click);
            // 
            // executiveGoalAuditSubmenu
            // 
            this.executiveGoalAuditSubmenu.Name = "executiveGoalAuditSubmenu";
            this.executiveGoalAuditSubmenu.Size = new System.Drawing.Size(150, 28);
            this.executiveGoalAuditSubmenu.Text = "اهداف اجرایی";
            this.executiveGoalAuditSubmenu.Click += new System.EventHandler(this.executiveGoalAuditSubmenu_Click);
            // 
            // responsibilitySubmenu
            // 
            this.responsibilitySubmenu.Name = "responsibilitySubmenu";
            this.responsibilitySubmenu.Size = new System.Drawing.Size(150, 28);
            this.responsibilitySubmenu.Text = "مسئولیت‌ها";
            this.responsibilitySubmenu.Click += new System.EventHandler(this.responsibilitySubmenu_Click);
            // 
            // reportAuditSubmenu
            // 
            this.reportAuditSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlAuditSubmenu,
            this.executiveDocumentAuditSubmenu});
            this.reportAuditSubmenu.Name = "reportAuditSubmenu";
            this.reportAuditSubmenu.Size = new System.Drawing.Size(173, 28);
            this.reportAuditSubmenu.Text = "ثبت گزارش";
            // 
            // controlAuditSubmenu
            // 
            this.controlAuditSubmenu.Name = "controlAuditSubmenu";
            this.controlAuditSubmenu.Size = new System.Drawing.Size(200, 28);
            this.controlAuditSubmenu.Text = " بازرسی فیزیکی";
            this.controlAuditSubmenu.Click += new System.EventHandler(this.controlAuditSubmenu_Click);
            // 
            // executiveDocumentAuditSubmenu
            // 
            this.executiveDocumentAuditSubmenu.Name = "executiveDocumentAuditSubmenu";
            this.executiveDocumentAuditSubmenu.Size = new System.Drawing.Size(200, 28);
            this.executiveDocumentAuditSubmenu.Text = "بررسی اسناد عملکردی";
            this.executiveDocumentAuditSubmenu.Click += new System.EventHandler(this.executiveDocumentAuditSubmenu_Click);
            // 
            // metricsAuditSubmenu
            // 
            this.metricsAuditSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metricsCRUDSubmenu,
            this.metricsEvaluationSubmenu});
            this.metricsAuditSubmenu.Name = "metricsAuditSubmenu";
            this.metricsAuditSubmenu.Size = new System.Drawing.Size(173, 28);
            this.metricsAuditSubmenu.Text = "اندازه‌ها و سنجه‌ها";
            // 
            // metricsCRUDSubmenu
            // 
            this.metricsCRUDSubmenu.Name = "metricsCRUDSubmenu";
            this.metricsCRUDSubmenu.Size = new System.Drawing.Size(195, 28);
            this.metricsCRUDSubmenu.Text = "ثبت سنجه";
            this.metricsCRUDSubmenu.Click += new System.EventHandler(this.metricsCRUDSubmenu_Click);
            // 
            // metricsEvaluationSubmenu
            // 
            this.metricsEvaluationSubmenu.Name = "metricsEvaluationSubmenu";
            this.metricsEvaluationSubmenu.Size = new System.Drawing.Size(195, 28);
            this.metricsEvaluationSubmenu.Text = "ارزیابی بر اساس سنجه";
            this.metricsEvaluationSubmenu.Click += new System.EventHandler(this.metricsEvaluationSubmenu_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentReport,
            this.scheduleReport,
            this.metricsReport,
            this.toolStripSeparator4,
            this.DashboardToolStripMenuItem});
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(69, 28);
            this.reportMenu.Text = "گزارش‌ها";
            // 
            // documentReport
            // 
            this.documentReport.Name = "documentReport";
            this.documentReport.Size = new System.Drawing.Size(175, 28);
            this.documentReport.Text = "پرونده الکترونیکی";
            this.documentReport.Click += new System.EventHandler(this.documentReport_Click);
            // 
            // scheduleReport
            // 
            this.scheduleReport.Name = "scheduleReport";
            this.scheduleReport.Size = new System.Drawing.Size(175, 28);
            this.scheduleReport.Text = "برنامه‌های اقدام";
            this.scheduleReport.Click += new System.EventHandler(this.scheduleReport_Click);
            // 
            // metricsReport
            // 
            this.metricsReport.Name = "metricsReport";
            this.metricsReport.Size = new System.Drawing.Size(175, 28);
            this.metricsReport.Text = "اندازه‌ها و سنجه‌ها";
            this.metricsReport.Click += new System.EventHandler(this.metricsReport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // DashboardToolStripMenuItem
            // 
            this.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem";
            this.DashboardToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.DashboardToolStripMenuItem.Text = "نمایشگر بهنگام";
            this.DashboardToolStripMenuItem.Click += new System.EventHandler(this.DashboardToolStripMenuItem_Click);
            // 
            // AccountMenu
            // 
            this.AccountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccountSubmenu,
            this.exitSubmenu});
            this.AccountMenu.Name = "AccountMenu";
            this.AccountMenu.Size = new System.Drawing.Size(95, 28);
            this.AccountMenu.Text = "حساب کاربری";
            // 
            // viewAccountSubmenu
            // 
            this.viewAccountSubmenu.Name = "viewAccountSubmenu";
            this.viewAccountSubmenu.Size = new System.Drawing.Size(197, 28);
            this.viewAccountSubmenu.Text = "مشاهده حساب کاربری";
            this.viewAccountSubmenu.Click += new System.EventHandler(this.viewAccountSubmenu_Click);
            // 
            // exitSubmenu
            // 
            this.exitSubmenu.Name = "exitSubmenu";
            this.exitSubmenu.Size = new System.Drawing.Size(197, 28);
            this.exitSubmenu.Text = "خروج";
            this.exitSubmenu.Click += new System.EventHandler(this.exitSubmenu_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(676, 68);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "TemplateForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سامانه مدیریت زیست‌محیطی";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Template_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem managementMenu;
        private ToolStripMenuItem generalGoalsSubmenu;
        private ToolStripMenuItem obligationSubmenu;
        private ToolStripMenuItem effectSubmenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem executiveMenu;
        private ToolStripMenuItem auditMenu;
        private ToolStripMenuItem reportMenu;
        private ToolStripMenuItem AccountMenu;
        private ToolStripMenuItem viewAccountSubmenu;
        private ToolStripMenuItem exitSubmenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem conventionSubmenu;
        private ToolStripMenuItem documentReport;
        private ToolStripMenuItem scheduleReport;
        private ToolStripMenuItem metricsReport;
        private ToolStripMenuItem auditGoalSubmenu;
        private ToolStripMenuItem generalGoalAuditSubmenu;
        private ToolStripMenuItem executiveGoalAuditSubmenu;
        private ToolStripMenuItem reportAuditSubmenu;
        private ToolStripMenuItem controlAuditSubmenu;
        private ToolStripMenuItem executiveDocumentAuditSubmenu;
        private ToolStripMenuItem metricsAuditSubmenu;
        private ToolStripMenuItem metricsCRUDSubmenu;
        private ToolStripMenuItem metricsEvaluationSubmenu;
        private ToolStripMenuItem resourcesSubmenu;
        private ToolStripMenuItem structureSubmenu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem executiveSubmenu;
        private ToolStripMenuItem scheduleSubmenu;
        protected ToolTip toolTip;
        protected MenuStrip menu;
        private ToolStripMenuItem relationsSubmenu;
        private ToolStripMenuItem responsibilitySubmenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem DashboardToolStripMenuItem;
        private ToolStripMenuItem TaskSubmenu;
        private ToolStripMenuItem GoalRelationSubmenu;
    }
}

