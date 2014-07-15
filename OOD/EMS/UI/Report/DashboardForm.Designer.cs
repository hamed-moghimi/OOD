namespace OOD.EMS.UI.Report
{
    partial class DashboardForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.executiveGoalsLabel = new System.Windows.Forms.Label();
            this.generalGoalsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inspectorsLabel = new System.Windows.Forms.Label();
            this.executiveManagersLabel = new System.Windows.Forms.Label();
            this.headManagersLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.execPanel = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.executionProgramsBox = new System.Windows.Forms.ComboBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.metricPanel = new System.Windows.Forms.GroupBox();
            this.metricChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metricUnitLabel = new System.Windows.Forms.Label();
            this.metricBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.execPanel.SuspendLayout();
            this.metricPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metricChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tasksLabel);
            this.groupBox1.Controls.Add(this.executiveGoalsLabel);
            this.groupBox1.Controls.Add(this.generalGoalsLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(279, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(309, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " اهداف و مسئولیت‌ها ";
            // 
            // tasksLabel
            // 
            this.tasksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksLabel.Location = new System.Drawing.Point(30, 98);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(69, 24);
            this.tasksLabel.TabIndex = 5;
            this.tasksLabel.Text = "۱۵ مورد";
            // 
            // executiveGoalsLabel
            // 
            this.executiveGoalsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executiveGoalsLabel.Location = new System.Drawing.Point(30, 65);
            this.executiveGoalsLabel.Name = "executiveGoalsLabel";
            this.executiveGoalsLabel.Size = new System.Drawing.Size(69, 24);
            this.executiveGoalsLabel.TabIndex = 4;
            this.executiveGoalsLabel.Text = "۱۵ مورد";
            // 
            // generalGoalsLabel
            // 
            this.generalGoalsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalGoalsLabel.Location = new System.Drawing.Point(30, 32);
            this.generalGoalsLabel.Name = "generalGoalsLabel";
            this.generalGoalsLabel.Size = new System.Drawing.Size(69, 24);
            this.generalGoalsLabel.TabIndex = 3;
            this.generalGoalsLabel.Text = "۱۵ مورد";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 98);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "مسئولیت‌های تعریف شده در سیستم :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 65);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "اهداف اجرایی تعریف شده در سیستم :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اهداف کلان تعریف شده در سیستم :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inspectorsLabel);
            this.groupBox2.Controls.Add(this.executiveManagersLabel);
            this.groupBox2.Controls.Add(this.headManagersLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(261, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " کاربران سیستم ";
            // 
            // inspectorsLabel
            // 
            this.inspectorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inspectorsLabel.Location = new System.Drawing.Point(20, 98);
            this.inspectorsLabel.Name = "inspectorsLabel";
            this.inspectorsLabel.Size = new System.Drawing.Size(86, 24);
            this.inspectorsLabel.TabIndex = 5;
            this.inspectorsLabel.Text = "۱۵ کاربر";
            // 
            // executiveManagersLabel
            // 
            this.executiveManagersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executiveManagersLabel.Location = new System.Drawing.Point(20, 65);
            this.executiveManagersLabel.Name = "executiveManagersLabel";
            this.executiveManagersLabel.Size = new System.Drawing.Size(86, 24);
            this.executiveManagersLabel.TabIndex = 4;
            this.executiveManagersLabel.Text = "۱۵ کاربر";
            // 
            // headManagersLabel
            // 
            this.headManagersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headManagersLabel.Location = new System.Drawing.Point(20, 32);
            this.headManagersLabel.Name = "headManagersLabel";
            this.headManagersLabel.Size = new System.Drawing.Size(86, 24);
            this.headManagersLabel.TabIndex = 3;
            this.headManagersLabel.Text = "۱۵ کاربر";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 98);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "کاربران حسابرس سیستم :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 65);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "کاربران اجرایی سیستم :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 32);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "کاربران ارشد سیستم :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // execPanel
            // 
            this.execPanel.Controls.Add(this.progressBar);
            this.execPanel.Controls.Add(this.label13);
            this.execPanel.Controls.Add(this.executionProgramsBox);
            this.execPanel.Controls.Add(this.progressLabel);
            this.execPanel.Controls.Add(this.label18);
            this.execPanel.Location = new System.Drawing.Point(12, 156);
            this.execPanel.Name = "execPanel";
            this.execPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.execPanel.Size = new System.Drawing.Size(576, 119);
            this.execPanel.TabIndex = 3;
            this.execPanel.TabStop = false;
            this.execPanel.Text = " پیشرفت برنامه‌های اقدام ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 77);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(399, 23);
            this.progressBar.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(474, 77);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(89, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "پیشرفت برنامه :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // executionProgramsBox
            // 
            this.executionProgramsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.executionProgramsBox.Location = new System.Drawing.Point(16, 29);
            this.executionProgramsBox.Name = "executionProgramsBox";
            this.executionProgramsBox.Size = new System.Drawing.Size(460, 32);
            this.executionProgramsBox.TabIndex = 4;
            this.executionProgramsBox.SelectedIndexChanged += new System.EventHandler(this.boxes_change);
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.Location = new System.Drawing.Point(421, 77);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(47, 24);
            this.progressLabel.TabIndex = 3;
            this.progressLabel.Text = "۱۰۰٪";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(482, 32);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(81, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "برنامه‌ی اقدام :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metricPanel
            // 
            this.metricPanel.Controls.Add(this.metricChart);
            this.metricPanel.Controls.Add(this.metricUnitLabel);
            this.metricPanel.Controls.Add(this.metricBox);
            this.metricPanel.Controls.Add(this.label17);
            this.metricPanel.Controls.Add(this.label21);
            this.metricPanel.Location = new System.Drawing.Point(12, 281);
            this.metricPanel.Name = "metricPanel";
            this.metricPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metricPanel.Size = new System.Drawing.Size(576, 282);
            this.metricPanel.TabIndex = 4;
            this.metricPanel.TabStop = false;
            this.metricPanel.Text = " مقادیر سنجه‌ها ";
            // 
            // metricChart
            // 
            this.metricChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.metricChart.ChartAreas.Add(chartArea1);
            this.metricChart.Location = new System.Drawing.Point(16, 67);
            this.metricChart.Name = "metricChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.metricChart.Series.Add(series1);
            this.metricChart.Size = new System.Drawing.Size(543, 209);
            this.metricChart.TabIndex = 7;
            this.metricChart.Text = "chart1";
            // 
            // metricUnitLabel
            // 
            this.metricUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metricUnitLabel.Location = new System.Drawing.Point(16, 32);
            this.metricUnitLabel.Name = "metricUnitLabel";
            this.metricUnitLabel.Size = new System.Drawing.Size(182, 24);
            this.metricUnitLabel.TabIndex = 6;
            // 
            // metricBox
            // 
            this.metricBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metricBox.FormattingEnabled = true;
            this.metricBox.Location = new System.Drawing.Point(290, 29);
            this.metricBox.Name = "metricBox";
            this.metricBox.Size = new System.Drawing.Size(221, 32);
            this.metricBox.TabIndex = 5;
            this.metricBox.SelectedIndexChanged += new System.EventHandler(this.boxes_change);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Location = new System.Drawing.Point(204, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 24);
            this.label17.TabIndex = 3;
            this.label17.Text = "واحد مقادیر :";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(517, 32);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(46, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "سنجه :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(603, 575);
            this.Controls.Add(this.metricPanel);
            this.Controls.Add(this.execPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایشگر بهنگام اطلاعات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.execPanel.ResumeLayout(false);
            this.execPanel.PerformLayout();
            this.metricPanel.ResumeLayout(false);
            this.metricPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metricChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Label executiveGoalsLabel;
        private System.Windows.Forms.Label generalGoalsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label inspectorsLabel;
        private System.Windows.Forms.Label executiveManagersLabel;
        private System.Windows.Forms.Label headManagersLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox execPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox metricPanel;
        private System.Windows.Forms.Label metricUnitLabel;
        private System.Windows.Forms.ComboBox metricBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataVisualization.Charting.Chart metricChart;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.ComboBox executionProgramsBox;


    }
}
