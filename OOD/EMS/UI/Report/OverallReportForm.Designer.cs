namespace OOD.EMS.UI.Report
{
    partial class OverallReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.generalGoalBox = new System.Windows.Forms.DataGridView();
            this.execGoalBox = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executive_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generalGoalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execGoalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(608, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "اهداف کلان";
            // 
            // generalGoalBox
            // 
            this.generalGoalBox.AllowUserToAddRows = false;
            this.generalGoalBox.AllowUserToDeleteRows = false;
            this.generalGoalBox.AllowUserToResizeColumns = false;
            this.generalGoalBox.AllowUserToResizeRows = false;
            this.generalGoalBox.BackgroundColor = System.Drawing.SystemColors.Window;
            this.generalGoalBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.generalGoalBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalGoalBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.executive_target,
            this.Date,
            this.execs});
            this.generalGoalBox.Location = new System.Drawing.Point(12, 38);
            this.generalGoalBox.MultiSelect = false;
            this.generalGoalBox.Name = "generalGoalBox";
            this.generalGoalBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.generalGoalBox.RowHeadersVisible = false;
            this.generalGoalBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.generalGoalBox.Size = new System.Drawing.Size(671, 145);
            this.generalGoalBox.TabIndex = 6;
            // 
            // execGoalBox
            // 
            this.execGoalBox.AllowUserToAddRows = false;
            this.execGoalBox.AllowUserToDeleteRows = false;
            this.execGoalBox.BackgroundColor = System.Drawing.SystemColors.Window;
            this.execGoalBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.execGoalBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.startDate,
            this.progress,
            this.responsible});
            this.execGoalBox.Location = new System.Drawing.Point(12, 219);
            this.execGoalBox.Name = "execGoalBox";
            this.execGoalBox.ReadOnly = true;
            this.execGoalBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.execGoalBox.RowHeadersVisible = false;
            this.execGoalBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.execGoalBox.Size = new System.Drawing.Size(671, 131);
            this.execGoalBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(597, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "اهداف اجرایی";
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "تاریخ ثبت";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // progress
            // 
            this.progress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.progress.HeaderText = "درصد پیشرفت";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            this.progress.Width = 107;
            // 
            // responsible
            // 
            this.responsible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.responsible.HeaderText = "بخش مسئول";
            this.responsible.Name = "responsible";
            this.responsible.ReadOnly = true;
            // 
            // executive_target
            // 
            this.executive_target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.executive_target.HeaderText = "عنوان";
            this.executive_target.Name = "executive_target";
            this.executive_target.ReadOnly = true;
            this.executive_target.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Date
            // 
            this.Date.HeaderText = "تاریخ ثبت";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // execs
            // 
            this.execs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.execs.HeaderText = "اهداف اجرایی";
            this.execs.Name = "execs";
            this.execs.ToolTipText = "تعداد اهداف اجرایی مرتبط";
            // 
            // OverallReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(695, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.execGoalBox);
            this.Controls.Add(this.generalGoalBox);
            this.Controls.Add(this.label1);
            this.Name = "OverallReportForm";
            this.Text = "گزارش سند زیست‌محیطی";
            ((System.ComponentModel.ISupportInitialize)(this.generalGoalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execGoalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView generalGoalBox;
        private System.Windows.Forms.DataGridView execGoalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn executive_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn execs;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;

    }
}
