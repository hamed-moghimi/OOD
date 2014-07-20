namespace OOD.EMS.UI.Users
{
    partial class UserManagementForm
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
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userGrid
            // 
            this.userGrid.AllowUserToAddRows = false;
            this.userGrid.AllowUserToDeleteRows = false;
            this.userGrid.AllowUserToResizeColumns = false;
            this.userGrid.AllowUserToResizeRows = false;
            this.userGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Role});
            this.userGrid.Location = new System.Drawing.Point(12, 44);
            this.userGrid.MultiSelect = false;
            this.userGrid.Name = "userGrid";
            this.userGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userGrid.RowHeadersVisible = false;
            this.userGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGrid.Size = new System.Drawing.Size(416, 199);
            this.userGrid.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "نام کاربری";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.HeaderText = "سطح دسترسی";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 250);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "خروج";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // edit
            // 
            this.edit.Image = global::OOD.Properties.Resources.edit;
            this.edit.Location = new System.Drawing.Point(434, 206);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(38, 37);
            this.edit.TabIndex = 21;
            this.edit.Text = "   ";
            this.toolTip.SetToolTip(this.edit, "ویرایش");
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Image = global::OOD.Properties.Resources.remove;
            this.delete.Location = new System.Drawing.Point(434, 163);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(38, 37);
            this.delete.TabIndex = 20;
            this.delete.Text = "   ";
            this.toolTip.SetToolTip(this.delete, "حذف");
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Image = global::OOD.Properties.Resources.add;
            this.add.Location = new System.Drawing.Point(434, 120);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(38, 37);
            this.add.TabIndex = 19;
            this.add.Text = "   ";
            this.toolTip.SetToolTip(this.add, "اضافه‌کردن");
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // viewButton
            // 
            this.viewButton.Image = global::OOD.Properties.Resources.search;
            this.viewButton.Location = new System.Drawing.Point(434, 77);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(38, 37);
            this.viewButton.TabIndex = 23;
            this.viewButton.Text = "   ";
            this.toolTip.SetToolTip(this.viewButton, "مشاهده");
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.userGrid);
            this.Name = "UserManagementForm";
            this.Text = "مدیریت کاربران";
            this.Controls.SetChildIndex(this.userGrid, 0);
            this.Controls.SetChildIndex(this.add, 0);
            this.Controls.SetChildIndex(this.delete, 0);
            this.Controls.SetChildIndex(this.edit, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.viewButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button viewButton;
    }
}