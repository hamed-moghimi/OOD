namespace OOD.EMS.UI.Users
{
    partial class EditUserForm
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
            this.username_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.familiy_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accessLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.Location = new System.Drawing.Point(11, 14);
            this.username_label.Name = "username_label";
            this.username_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username_label.Size = new System.Drawing.Size(168, 24);
            this.username_label.TabIndex = 29;
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(12, 58);
            this.name_box.Name = "name_box";
            this.name_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_box.Size = new System.Drawing.Size(165, 31);
            this.name_box.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 61);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "نام:";
            // 
            // familiy_box
            // 
            this.familiy_box.Location = new System.Drawing.Point(12, 102);
            this.familiy_box.Name = "familiy_box";
            this.familiy_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.familiy_box.Size = new System.Drawing.Size(165, 31);
            this.familiy_box.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 105);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "نام خانوادگی:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(24, 194);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accessLevel
            // 
            this.accessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessLevel.FormattingEnabled = true;
            this.accessLevel.Items.AddRange(new object[] {
            "کاربر میانی",
            "کاربر ارشد",
            "بازرس"});
            this.accessLevel.Location = new System.Drawing.Point(11, 148);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accessLevel.Size = new System.Drawing.Size(165, 32);
            this.accessLevel.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 148);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "سطح دسترسی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "نام کاربری:";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 238);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.familiy_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.accessLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "EditUserForm";
            this.Text = "ویرایش کاربر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox familiy_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox accessLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_label;

    }
}