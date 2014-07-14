namespace OOD.EMS.UI.ExecutiveForms
{
    partial class ScheduleEditForm
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
            this.progress_num = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resourceGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.taskGrid = new System.Windows.Forms.DataGridView();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.goal_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // progress_num
            // 
            this.progress_num.AutoSize = true;
            this.progress_num.BackColor = System.Drawing.Color.Transparent;
            this.progress_num.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.progress_num.Location = new System.Drawing.Point(609, 49);
            this.progress_num.Name = "progress_num";
            this.progress_num.Size = new System.Drawing.Size(37, 26);
            this.progress_num.TabIndex = 33;
            this.progress_num.Text = "23%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.resourceGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(722, 246);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "منابع";
            // 
            // button1
            // 
            this.button1.Image = global::OOD.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(666, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 27;
            this.toolTip.SetToolTip(this.button1, "اضافه کردن");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::OOD.Properties.Resources.remove;
            this.button2.Location = new System.Drawing.Point(666, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 25;
            this.toolTip.SetToolTip(this.button2, "حذف");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resourceGrid
            // 
            this.resourceGrid.AllowUserToAddRows = false;
            this.resourceGrid.AllowUserToDeleteRows = false;
            this.resourceGrid.AllowUserToOrderColumns = true;
            this.resourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.fromDate,
            this.toDate,
            this.dataGridViewTextBoxColumn5});
            this.resourceGrid.Location = new System.Drawing.Point(12, 30);
            this.resourceGrid.Name = "resourceGrid";
            this.resourceGrid.ReadOnly = true;
            this.resourceGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resourceGrid.RowHeadersVisible = false;
            this.resourceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resourceGrid.Size = new System.Drawing.Size(639, 202);
            this.resourceGrid.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fromDate
            // 
            this.fromDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fromDate.HeaderText = "تاریخ شروع";
            this.fromDate.Name = "fromDate";
            this.fromDate.ReadOnly = true;
            // 
            // toDate
            // 
            this.toDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.toDate.HeaderText = "تاریخ پایان";
            this.toDate.Name = "toDate";
            this.toDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "مقدار";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.taskGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(722, 238);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وظایف";
            // 
            // addButton
            // 
            this.addButton.Image = global::OOD.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(666, 83);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 27;
            this.toolTip.SetToolTip(this.addButton, "اضافه کردن");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::OOD.Properties.Resources.remove;
            this.deleteButton.Location = new System.Drawing.Point(666, 129);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 25;
            this.toolTip.SetToolTip(this.deleteButton, "حذف");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // taskGrid
            // 
            this.taskGrid.AllowUserToAddRows = false;
            this.taskGrid.AllowUserToDeleteRows = false;
            this.taskGrid.AllowUserToOrderColumns = true;
            this.taskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priority,
            this.title,
            this.amount,
            this.desc,
            this.progress});
            this.taskGrid.Location = new System.Drawing.Point(12, 30);
            this.taskGrid.Name = "taskGrid";
            this.taskGrid.ReadOnly = true;
            this.taskGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taskGrid.RowHeadersVisible = false;
            this.taskGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskGrid.Size = new System.Drawing.Size(639, 181);
            this.taskGrid.TabIndex = 23;
            // 
            // priority
            // 
            this.priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priority.HeaderText = "سهم در برنامه";
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.HeaderText = "تاریخ شروع";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc.HeaderText = "مهلت انجام";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // progress
            // 
            this.progress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.progress.HeaderText = "درصد پیشرفت";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(202, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(401, 23);
            this.progressBar1.TabIndex = 32;
            this.progressBar1.Value = 32;
            // 
            // goal_name
            // 
            this.goal_name.Location = new System.Drawing.Point(405, 19);
            this.goal_name.Name = "goal_name";
            this.goal_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.goal_name.Size = new System.Drawing.Size(237, 25);
            this.goal_name.TabIndex = 28;
            this.goal_name.Text = "نام هدف";
            this.goal_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(668, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "هدف :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(650, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "پیشرفت :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(254, 583);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 29;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(375, 583);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(105, 33);
            this.selectBtn.TabIndex = 28;
            this.selectBtn.Text = "ثبت";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // DefineProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(746, 629);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.progress_num);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.goal_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DefineProgramForm";
            this.Text = "برنامه اقدام";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourceGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView taskGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label goal_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView resourceGrid;
        private System.Windows.Forms.Label progress_num;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button selectBtn;
    }
}
