namespace OOD.EMS.UI.Management
{
    partial class ViewEffectForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dscp_box = new System.Windows.Forms.RichTextBox();
            this.GoalNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attachmentPanel1 = new OOD.EMS.UI.AttachmentPanel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام سند:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 442);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 118);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "توضیحات:";
            // 
            // dscp_box
            // 
            this.dscp_box.Enabled = false;
            this.dscp_box.Location = new System.Drawing.Point(12, 155);
            this.dscp_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dscp_box.Name = "dscp_box";
            this.dscp_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscp_box.Size = new System.Drawing.Size(456, 85);
            this.dscp_box.TabIndex = 15;
            this.dscp_box.Text = "باید آلاینده‌ها را کاهش دهیم.";
            // 
            // GoalNameLabel
            // 
            this.GoalNameLabel.Location = new System.Drawing.Point(133, 9);
            this.GoalNameLabel.Name = "GoalNameLabel";
            this.GoalNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GoalNameLabel.Size = new System.Drawing.Size(244, 24);
            this.GoalNameLabel.TabIndex = 20;
            this.GoalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(133, 44);
            this.DateBox.Name = "DateBox";
            this.DateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateBox.Size = new System.Drawing.Size(244, 24);
            this.DateBox.TabIndex = 22;
            this.DateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(133, 78);
            this.userBox.Name = "userBox";
            this.userBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userBox.Size = new System.Drawing.Size(244, 24);
            this.userBox.TabIndex = 24;
            this.userBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 78);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "کاربر ثبت‌کننده:";
            // 
            // attachmentPanel1
            // 
            this.attachmentPanel1.Changed = false;
            this.attachmentPanel1.Location = new System.Drawing.Point(12, 247);
            this.attachmentPanel1.Name = "attachmentPanel1";
            this.attachmentPanel1.Size = new System.Drawing.Size(461, 188);
            this.attachmentPanel1.TabIndex = 25;
            this.attachmentPanel1.ViewMode = false;
            // 
            // ViewEffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 488);
            this.Controls.Add(this.attachmentPanel1);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoalNameLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dscp_box);
            this.Controls.Add(this.label5);
            this.Name = "ViewEffectForm";
            this.Text = "مشاهده‌ی سند تاثیرات زیست‌محیطی";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dscp_box;
        private System.Windows.Forms.Label GoalNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateBox;
        private System.Windows.Forms.Label userBox;
        private System.Windows.Forms.Label label4;
        private AttachmentPanel attachmentPanel1;
    }
}