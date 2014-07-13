namespace OOD.EMS.UI.Management
{
    partial class ViewLegalReqForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dscp_box = new System.Windows.Forms.RichTextBox();
            this.GoalNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 22);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام سند:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(39, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(452, 88);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ضمیمه‌ها";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(362, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ضمیمه‌ی سند";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(38, 339);
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
            this.label3.Location = new System.Drawing.Point(438, 101);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "توضیحات:";
            // 
            // dscp_box
            // 
            this.dscp_box.Enabled = false;
            this.dscp_box.Location = new System.Drawing.Point(39, 134);
            this.dscp_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dscp_box.Name = "dscp_box";
            this.dscp_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscp_box.Size = new System.Drawing.Size(452, 78);
            this.dscp_box.TabIndex = 15;
            this.dscp_box.Text = "باید آلاینده‌ها را کاهش دهیم.";
            // 
            // GoalNameLabel
            // 
            this.GoalNameLabel.Location = new System.Drawing.Point(175, 22);
            this.GoalNameLabel.Name = "GoalNameLabel";
            this.GoalNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GoalNameLabel.Size = new System.Drawing.Size(244, 24);
            this.GoalNameLabel.TabIndex = 20;
            this.GoalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(174, 55);
            this.DateBox.Name = "DateBox";
            this.DateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateBox.Size = new System.Drawing.Size(244, 24);
            this.DateBox.TabIndex = 22;
            this.DateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewLegalReqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 386);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoalNameLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dscp_box);
            this.Controls.Add(this.label5);
            this.Name = "ViewLegalReqForm";
            this.Text = "مشاهده‌ی هدف کلان";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dscp_box, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.GoalNameLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DateBox, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dscp_box;
        private System.Windows.Forms.Label GoalNameLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateBox;
    }
}