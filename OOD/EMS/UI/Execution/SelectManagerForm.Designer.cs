namespace OOD.EMS.UI.Execution
{
    partial class SelectManagerForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.managerList = new System.Windows.Forms.DataGridView();
            this.managerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.managerList)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 202);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(123, 202);
            this.ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(105, 33);
            this.ok.TabIndex = 19;
            this.ok.Text = "انتخاب";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // managerList
            // 
            this.managerList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.managerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.managerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerName});
            this.managerList.Location = new System.Drawing.Point(12, 12);
            this.managerList.Name = "managerList";
            this.managerList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.managerList.RowHeadersVisible = false;
            this.managerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.managerList.Size = new System.Drawing.Size(318, 183);
            this.managerList.TabIndex = 21;
            // 
            // managerName
            // 
            this.managerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.managerName.HeaderText = "نام و نام خانوادگی مدیران";
            this.managerName.Name = "managerName";
            this.managerName.ReadOnly = true;
            // 
            // SelectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(342, 243);
            this.Controls.Add(this.managerList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ok);
            this.Name = "SelectManagerForm";
            this.Text = "مدیران";
            ((System.ComponentModel.ISupportInitialize)(this.managerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridView managerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerName;
    }
}
