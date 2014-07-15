namespace OOD.EMS.UI.Management
{
    partial class ViewRelationForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doc1 = new System.Windows.Forms.Label();
            this.doc2 = new System.Windows.Forms.Label();
            this.viewDoc1 = new System.Windows.Forms.LinkLabel();
            this.viewDoc2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewDoc2);
            this.groupBox2.Controls.Add(this.viewDoc1);
            this.groupBox2.Controls.Add(this.doc2);
            this.groupBox2.Controls.Add(this.doc1);
            this.groupBox2.Location = new System.Drawing.Point(39, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(452, 130);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسناد";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(39, 248);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(154, 17);
            this.DateBox.Name = "DateBox";
            this.DateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateBox.Size = new System.Drawing.Size(244, 24);
            this.DateBox.TabIndex = 22;
            this.DateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(154, 54);
            this.userBox.Name = "userBox";
            this.userBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userBox.Size = new System.Drawing.Size(244, 24);
            this.userBox.TabIndex = 26;
            this.userBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 53);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "کاربر ثبت‌کننده:";
            // 
            // doc1
            // 
            this.doc1.Location = new System.Drawing.Point(100, 38);
            this.doc1.Name = "doc1";
            this.doc1.Size = new System.Drawing.Size(317, 27);
            this.doc1.TabIndex = 0;
            this.doc1.Text = "سند ۱";
            this.doc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doc2
            // 
            this.doc2.Location = new System.Drawing.Point(100, 69);
            this.doc2.Name = "doc2";
            this.doc2.Size = new System.Drawing.Size(317, 27);
            this.doc2.TabIndex = 1;
            this.doc2.Text = "سند ۲";
            this.doc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewDoc1
            // 
            this.viewDoc1.AutoSize = true;
            this.viewDoc1.Location = new System.Drawing.Point(25, 38);
            this.viewDoc1.Name = "viewDoc1";
            this.viewDoc1.Size = new System.Drawing.Size(47, 24);
            this.viewDoc1.TabIndex = 2;
            this.viewDoc1.TabStop = true;
            this.viewDoc1.Text = "مشاهده";
            this.viewDoc1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewDoc1_LinkClicked);
            // 
            // viewDoc2
            // 
            this.viewDoc2.AutoSize = true;
            this.viewDoc2.Location = new System.Drawing.Point(25, 72);
            this.viewDoc2.Name = "viewDoc2";
            this.viewDoc2.Size = new System.Drawing.Size(47, 24);
            this.viewDoc2.TabIndex = 3;
            this.viewDoc2.TabStop = true;
            this.viewDoc2.Text = "مشاهده";
            this.viewDoc2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewDoc2_LinkClicked);
            // 
            // ViewRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 294);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Name = "ViewRelationForm";
            this.Text = "مشاهده‌ی ارتباط اسناد مدیریتی";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DateBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.userBox, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateBox;
        private System.Windows.Forms.Label userBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label doc2;
        private System.Windows.Forms.Label doc1;
        private System.Windows.Forms.LinkLabel viewDoc2;
        private System.Windows.Forms.LinkLabel viewDoc1;
    }
}