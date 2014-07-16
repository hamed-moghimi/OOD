namespace OOD.EMS.UI.Audit.Audit
{
    partial class AuditSelectForm
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.targetName = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(123, 243);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 33);
            this.OK.TabIndex = 4;
            this.OK.Text = "مشاهده";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 243);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(339, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "مورد حسابرسی :";
            // 
            // targetName
            // 
            this.targetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetName.AutoEllipsis = true;
            this.targetName.Location = new System.Drawing.Point(12, 10);
            this.targetName.Name = "targetName";
            this.targetName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.targetName.Size = new System.Drawing.Size(321, 24);
            this.targetName.TabIndex = 13;
            this.targetName.Text = "نام مورد";
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
            this.date,
            this.inspector,
            this.auditObject});
            this.list.Location = new System.Drawing.Point(12, 41);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list.RowHeadersVisible = false;
            this.list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list.Size = new System.Drawing.Size(430, 196);
            this.list.TabIndex = 14;
            this.list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OK_Click);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "تاریخ حسابرسی";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date.Width = 112;
            // 
            // inspector
            // 
            this.inspector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "-";
            this.inspector.DefaultCellStyle = dataGridViewCellStyle1;
            this.inspector.HeaderText = "حسابرس";
            this.inspector.Name = "inspector";
            this.inspector.ReadOnly = true;
            this.inspector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // auditObject
            // 
            this.auditObject.HeaderText = "حسابرسی";
            this.auditObject.Name = "auditObject";
            this.auditObject.ReadOnly = true;
            this.auditObject.Visible = false;
            // 
            // AuditSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 283);
            this.Controls.Add(this.list);
            this.Controls.Add(this.targetName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "AuditSelectForm";
            this.Text = "مشاهده حسابرسی‌ها";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label targetName;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditObject;

    }
}