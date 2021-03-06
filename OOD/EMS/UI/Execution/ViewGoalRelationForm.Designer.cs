﻿namespace OOD.EMS.UI.Execution
{
    partial class ViewGoalRelationForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewDoc2 = new System.Windows.Forms.LinkLabel();
            this.viewDoc1 = new System.Windows.Forms.LinkLabel();
            this.Cancel = new System.Windows.Forms.Button();
            this.shareBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 79);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "کاربر ثبت‌کننده:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(12, 45);
            this.DateBox.Name = "DateBox";
            this.DateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateBox.Size = new System.Drawing.Size(244, 24);
            this.DateBox.TabIndex = 29;
            this.DateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "تاریخ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewDoc2);
            this.groupBox2.Controls.Add(this.viewDoc1);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(335, 101);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اهداف";
            // 
            // viewDoc2
            // 
            this.viewDoc2.Location = new System.Drawing.Point(19, 66);
            this.viewDoc2.Name = "viewDoc2";
            this.viewDoc2.Size = new System.Drawing.Size(311, 24);
            this.viewDoc2.TabIndex = 3;
            this.viewDoc2.TabStop = true;
            this.viewDoc2.Text = "مشاهده";
            this.viewDoc2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewDoc2_LinkClicked);
            // 
            // viewDoc1
            // 
            this.viewDoc1.Location = new System.Drawing.Point(19, 32);
            this.viewDoc1.Name = "viewDoc1";
            this.viewDoc1.Size = new System.Drawing.Size(311, 24);
            this.viewDoc1.TabIndex = 2;
            this.viewDoc1.TabStop = true;
            this.viewDoc1.Text = "مشاهده";
            this.viewDoc1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewDoc1_LinkClicked);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 230);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 26;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // shareBox
            // 
            this.shareBox.Location = new System.Drawing.Point(12, 10);
            this.shareBox.Name = "shareBox";
            this.shareBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shareBox.Size = new System.Drawing.Size(244, 24);
            this.shareBox.TabIndex = 32;
            this.shareBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 10);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "سهم (درصد):";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(12, 79);
            this.userBox.Name = "userBox";
            this.userBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userBox.Size = new System.Drawing.Size(244, 24);
            this.userBox.TabIndex = 33;
            this.userBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewGoalRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 272);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.shareBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Name = "ViewGoalRelationForm";
            this.Text = "مشاهده‌ی ارتباط اهداف";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel viewDoc2;
        private System.Windows.Forms.LinkLabel viewDoc1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label shareBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userBox;
    }
}