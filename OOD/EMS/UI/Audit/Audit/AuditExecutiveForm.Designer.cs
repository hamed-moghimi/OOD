namespace OOD.EMS.UI.Audit.Audit
{
    partial class AuditExecutiveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tasksList = new System.Windows.Forms.DataGridView();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBox = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.targetName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addAttachment = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.attachmentBox = new OOD.EMS.UI.AttachmentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tasksList)).BeginInit();
            this.SuspendLayout();
            // 
            // tasksList
            // 
            this.tasksList.AllowUserToAddRows = false;
            this.tasksList.AllowUserToDeleteRows = false;
            this.tasksList.AllowUserToResizeColumns = false;
            this.tasksList.AllowUserToResizeRows = false;
            this.tasksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tasksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tasksList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tasksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.task,
            this.progress});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksList.DefaultCellStyle = dataGridViewCellStyle3;
            this.tasksList.GridColor = System.Drawing.SystemColors.Control;
            this.tasksList.Location = new System.Drawing.Point(19, 97);
            this.tasksList.MultiSelect = false;
            this.tasksList.Name = "tasksList";
            this.tasksList.ReadOnly = true;
            this.tasksList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tasksList.RowHeadersVisible = false;
            this.tasksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tasksList.Size = new System.Drawing.Size(461, 112);
            this.tasksList.TabIndex = 0;
            // 
            // task
            // 
            this.task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.task.HeaderText = "مسئولیت";
            this.task.Name = "task";
            this.task.ReadOnly = true;
            // 
            // progress
            // 
            this.progress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.progress.HeaderText = "پیشرفت";
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            this.progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "پیشرفت هدف:";
            // 
            // progressBox
            // 
            this.progressBox.Location = new System.Drawing.Point(28, 35);
            this.progressBox.Name = "progressBox";
            this.progressBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBox.Size = new System.Drawing.Size(361, 24);
            this.progressBox.TabIndex = 5;
            this.progressBox.Text = "۵۰٪";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(19, 240);
            this.descBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descBox.Name = "descBox";
            this.descBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descBox.Size = new System.Drawing.Size(461, 129);
            this.descBox.TabIndex = 0;
            this.descBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 212);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "توضیحات:";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(130, 571);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 33);
            this.OK.TabIndex = 8;
            this.OK.Text = "ثبت";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(19, 571);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // targetName
            // 
            this.targetName.Location = new System.Drawing.Point(28, 9);
            this.targetName.Name = "targetName";
            this.targetName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.targetName.Size = new System.Drawing.Size(365, 24);
            this.targetName.TabIndex = 12;
            this.targetName.Text = "هدف اجرایی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "نام هدف:";
            // 
            // addAttachment
            // 
            this.addAttachment.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 70);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "پیشرفت برنامه اقدام:";
            // 
            // attachmentBox
            // 
            this.attachmentBox.Changed = false;
            this.attachmentBox.Location = new System.Drawing.Point(19, 376);
            this.attachmentBox.Name = "attachmentBox";
            this.attachmentBox.Size = new System.Drawing.Size(461, 188);
            this.attachmentBox.TabIndex = 14;
            this.attachmentBox.ViewMode = false;
            // 
            // AuditExecutiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 614);
            this.Controls.Add(this.attachmentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tasksList);
            this.Controls.Add(this.targetName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.progressBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "AuditExecutiveForm";
            this.Text = "حسابرسی هدف اجرایی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuditExecutiveForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tasksList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label progressBox;
        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label targetName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tasksList;
        private System.Windows.Forms.OpenFileDialog addAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.Label label2;
        private AttachmentPanel attachmentBox;

    }
}