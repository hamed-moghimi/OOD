namespace OOD.EMS.UI.Audit.Metric
{
    partial class MetricValueListForm
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
            this.list = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executive_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToDeleteRows = false;
            this.list.AllowUserToResizeColumns = false;
            this.list.AllowUserToResizeRows = false;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.executive_target,
            this.value,
            this.metricValue});
            this.list.Location = new System.Drawing.Point(12, 46);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list.RowHeadersVisible = false;
            this.list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list.Size = new System.Drawing.Size(480, 196);
            this.list.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 249);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::OOD.Properties.Resources.edit;
            this.editButton.Location = new System.Drawing.Point(498, 123);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(38, 37);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "   ";
            this.toolTip.SetToolTip(this.editButton, "ویرایش مقدار");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Image = global::OOD.Properties.Resources.remove;
            this.removeButton.Location = new System.Drawing.Point(498, 166);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(38, 37);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "   ";
            this.toolTip.SetToolTip(this.removeButton, "حذف مقدار");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::OOD.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(498, 80);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 37);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "   ";
            this.toolTip.SetToolTip(this.addButton, "ثبت مقدار جدید");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(123, 249);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 33);
            this.OK.TabIndex = 15;
            this.OK.Text = "پایان حسابرسی";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "تاریخ ثبت";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 84;
            // 
            // executive_target
            // 
            this.executive_target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.executive_target.HeaderText = "سنجه";
            this.executive_target.Name = "executive_target";
            this.executive_target.ReadOnly = true;
            this.executive_target.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.value.HeaderText = "مقدار ثبت‌شده";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 105;
            // 
            // metricValue
            // 
            this.metricValue.HeaderText = "";
            this.metricValue.Name = "metricValue";
            this.metricValue.ReadOnly = true;
            this.metricValue.Visible = false;
            // 
            // MetricValueListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 291);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.list);
            this.Name = "MetricValueListForm";
            this.Text = "ارزیابی بر اساس سنجه‌ها";
            this.Controls.SetChildIndex(this.list, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.removeButton, 0);
            this.Controls.SetChildIndex(this.editButton, 0);
            this.Controls.SetChildIndex(this.OK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn executive_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricValue;
    }
}