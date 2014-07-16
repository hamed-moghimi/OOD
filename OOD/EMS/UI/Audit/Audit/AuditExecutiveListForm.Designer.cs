namespace OOD.EMS.UI.Audit.Audit
{
    partial class AuditExecutiveListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.list = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.targetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAudit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetName,
            this.lastAudit});
            this.list.Location = new System.Drawing.Point(14, 59);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list.RowHeadersVisible = false;
            this.list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list.Size = new System.Drawing.Size(599, 196);
            this.list.TabIndex = 5;
            this.list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(14, 262);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // viewButton
            // 
            this.viewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewButton.Image = global::OOD.Properties.Resources.search;
            this.viewButton.Location = new System.Drawing.Point(627, 93);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(38, 37);
            this.viewButton.TabIndex = 16;
            this.viewButton.Text = "   ";
            this.toolTip.SetToolTip(this.viewButton, "مشاهده لیست حسابرسی‌ها");
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::OOD.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(627, 136);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 37);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "   ";
            this.toolTip.SetToolTip(this.addButton, "حسابرسی جدید");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // targetName
            // 
            this.targetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetName.HeaderText = "عنوان هدف اجرایی";
            this.targetName.Name = "targetName";
            this.targetName.ReadOnly = true;
            this.targetName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lastAudit
            // 
            this.lastAudit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.NullValue = "-";
            this.lastAudit.DefaultCellStyle = dataGridViewCellStyle1;
            this.lastAudit.HeaderText = "تاریخ آخرین حسابرسی";
            this.lastAudit.Name = "lastAudit";
            this.lastAudit.ReadOnly = true;
            this.lastAudit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.lastAudit.Width = 148;
            // 
            // AuditExecutiveListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 305);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.list);
            this.Name = "AuditExecutiveListForm";
            this.Text = "حسابرسی اهداف اجرایی";
            this.Controls.SetChildIndex(this.list, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.viewButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAudit;
    }
}