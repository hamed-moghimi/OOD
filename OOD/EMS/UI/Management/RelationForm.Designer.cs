namespace OOD.EMS.UI.Management
{
    partial class RelationForm
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
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.tabRelations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabRelations.SuspendLayout();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.Image = global::OOD.Properties.Resources.search;
            this.edit.Location = new System.Drawing.Point(617, 86);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(38, 37);
            this.edit.TabIndex = 18;
            this.edit.Text = "   ";
            this.toolTip.SetToolTip(this.edit, "مشاهده سند");
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Image = global::OOD.Properties.Resources.add;
            this.add.Location = new System.Drawing.Point(617, 129);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(38, 37);
            this.add.TabIndex = 16;
            this.add.Text = "   ";
            this.toolTip.SetToolTip(this.add, "ثبت سند");
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 297);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tabRelations
            // 
            this.tabRelations.Controls.Add(this.tabPage1);
            this.tabRelations.Controls.Add(this.tabPage2);
            this.tabRelations.Controls.Add(this.tabPage3);
            this.tabRelations.Location = new System.Drawing.Point(12, 46);
            this.tabRelations.Name = "tabRelations";
            this.tabRelations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabRelations.RightToLeftLayout = true;
            this.tabRelations.SelectedIndex = 0;
            this.tabRelations.Size = new System.Drawing.Size(599, 244);
            this.tabRelations.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(591, 207);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 339);
            this.Controls.Add(this.tabRelations);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Cancel);
            this.Name = "RelationForm";
            this.Text = "مدیریت ارتباطات اسناد مدیریتی";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.add, 0);
            this.Controls.SetChildIndex(this.edit, 0);
            this.Controls.SetChildIndex(this.tabRelations, 0);
            this.tabRelations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TabControl tabRelations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}