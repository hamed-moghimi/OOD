namespace OOD.EMS.UI.Audit.Metric
{
    partial class MetricListForm
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
            this.executive_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToDeleteRows = false;
            this.list.AllowUserToResizeColumns = false;
            this.list.AllowUserToResizeRows = false;
            this.list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.executive_target,
            this.desp});
            this.list.Location = new System.Drawing.Point(12, 45);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list.RowHeadersVisible = false;
            this.list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list.Size = new System.Drawing.Size(391, 196);
            this.list.TabIndex = 5;
            // 
            // executive_target
            // 
            this.executive_target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.executive_target.HeaderText = "عنوان سنجه";
            this.executive_target.Name = "executive_target";
            this.executive_target.ReadOnly = true;
            this.executive_target.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // desp
            // 
            this.desp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.desp.HeaderText = "واحد اندازه‌گیری";
            this.desp.Name = "desp";
            this.desp.ReadOnly = true;
            this.desp.Width = 114;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 248);
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
            this.editButton.Image = global::OOD.Properties.Resources.edit;
            this.editButton.Location = new System.Drawing.Point(409, 122);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(38, 37);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "   ";
            this.toolTip.SetToolTip(this.editButton, "تغییر سنجه");
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Image = global::OOD.Properties.Resources.remove;
            this.removeButton.Location = new System.Drawing.Point(409, 165);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(38, 37);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "   ";
            this.toolTip.SetToolTip(this.removeButton, "حذف سنجه");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Image = global::OOD.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(409, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 37);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "   ";
            this.toolTip.SetToolTip(this.addButton, "اضافه‌کردن سنجه");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MetricListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 292);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.list);
            this.Name = "MetricListForm";
            this.Text = "مدیریت سنجه‌ها";
            this.Controls.SetChildIndex(this.list, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.removeButton, 0);
            this.Controls.SetChildIndex(this.editButton, 0);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn executive_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp;
    }
}