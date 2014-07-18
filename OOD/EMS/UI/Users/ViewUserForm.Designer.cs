namespace OOD.EMS.UI.Users
{
    partial class ViewUserForm
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
            this.username_label = new System.Windows.Forms.Label();
            this.level_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.family_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کاربری:";
            // 
            // username_label
            // 
            this.username_label.Location = new System.Drawing.Point(22, 9);
            this.username_label.Name = "username_label";
            this.username_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username_label.Size = new System.Drawing.Size(122, 24);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "حامد مقیمی";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // level_label
            // 
            this.level_label.Location = new System.Drawing.Point(23, 124);
            this.level_label.Name = "level_label";
            this.level_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.level_label.Size = new System.Drawing.Size(121, 24);
            this.level_label.TabIndex = 6;
            this.level_label.Text = "کاربر ارشد";
            this.level_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 124);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "سطح دسترسی:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(83, 171);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // family_label
            // 
            this.family_label.Location = new System.Drawing.Point(22, 86);
            this.family_label.Name = "family_label";
            this.family_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.family_label.Size = new System.Drawing.Size(121, 24);
            this.family_label.TabIndex = 18;
            this.family_label.Text = "کاربر ارشد";
            this.family_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 86);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "نام خانوادگی:";
            // 
            // name_label
            // 
            this.name_label.Location = new System.Drawing.Point(22, 44);
            this.name_label.Name = "name_label";
            this.name_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_label.Size = new System.Drawing.Size(121, 24);
            this.name_label.TabIndex = 20;
            this.name_label.Text = "کاربر ارشد";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 44);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(26, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "نام:";
            // 
            // ViewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 217);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.family_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.level_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.label1);
            this.Name = "ViewUserForm";
            this.Text = "مشاهده‌ی مشخصات کاربری";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.username_label, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.level_label, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.family_label, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.name_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label family_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label8;
    }
}