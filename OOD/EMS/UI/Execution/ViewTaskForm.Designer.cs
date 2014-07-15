namespace OOD.EMS.UI.Execution
{
    partial class ViewTaskForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attach = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dscp_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.toDate_label = new System.Windows.Forms.Label();
            this.fromDate_label = new System.Windows.Forms.Label();
            this.manager_label = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 22);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام مسئولیت:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.attach);
            this.groupBox2.Location = new System.Drawing.Point(38, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(452, 123);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ضمیمه‌ها";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "ضمیمه‌ی مسئولیت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::OOD.Properties.Resources.delete;
            this.label4.Location = new System.Drawing.Point(396, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "      ";
            // 
            // attach
            // 
            this.attach.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.attach.Location = new System.Drawing.Point(329, 76);
            this.attach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(105, 33);
            this.attach.TabIndex = 7;
            this.attach.Text = "اضافه‌کردن ضمیمه";
            this.attach.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(37, 499);
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
            this.label3.Location = new System.Drawing.Point(437, 235);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "توضیحات:";
            // 
            // dscp_box
            // 
            this.dscp_box.Location = new System.Drawing.Point(38, 268);
            this.dscp_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dscp_box.Name = "dscp_box";
            this.dscp_box.ReadOnly = true;
            this.dscp_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscp_box.Size = new System.Drawing.Size(452, 78);
            this.dscp_box.TabIndex = 15;
            this.dscp_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ شروع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 102);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "تاریخ پایان:";
            // 
            // name_label
            // 
            this.name_label.Location = new System.Drawing.Point(158, 22);
            this.name_label.Name = "name_label";
            this.name_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_label.Size = new System.Drawing.Size(258, 24);
            this.name_label.TabIndex = 24;
            this.name_label.Text = "نام مسئولیت:";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toDate_label
            // 
            this.toDate_label.Location = new System.Drawing.Point(158, 102);
            this.toDate_label.Name = "toDate_label";
            this.toDate_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toDate_label.Size = new System.Drawing.Size(258, 24);
            this.toDate_label.TabIndex = 25;
            this.toDate_label.Text = "نام مسئولیت:";
            this.toDate_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fromDate_label
            // 
            this.fromDate_label.Location = new System.Drawing.Point(158, 63);
            this.fromDate_label.Name = "fromDate_label";
            this.fromDate_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate_label.Size = new System.Drawing.Size(258, 24);
            this.fromDate_label.TabIndex = 26;
            this.fromDate_label.Text = "نام مسئولیت:";
            this.fromDate_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // manager_label
            // 
            this.manager_label.Location = new System.Drawing.Point(146, 140);
            this.manager_label.Name = "manager_label";
            this.manager_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manager_label.Size = new System.Drawing.Size(258, 24);
            this.manager_label.TabIndex = 30;
            this.manager_label.Text = "نام مسئولیت:";
            this.manager_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progress_label
            // 
            this.progress_label.Location = new System.Drawing.Point(143, 179);
            this.progress_label.Name = "progress_label";
            this.progress_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progress_label.Size = new System.Drawing.Size(258, 24);
            this.progress_label.TabIndex = 29;
            this.progress_label.Text = "نام مسئولیت:";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 179);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "درصد پیشرفت:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 140);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "بخش مسئول:";
            // 
            // ViewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 552);
            this.Controls.Add(this.manager_label);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fromDate_label);
            this.Controls.Add(this.toDate_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dscp_box);
            this.Controls.Add(this.label5);
            this.Name = "ViewTaskForm";
            this.Text = "مشاهده‌ی مسئولیت";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dscp_box, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.name_label, 0);
            this.Controls.SetChildIndex(this.toDate_label, 0);
            this.Controls.SetChildIndex(this.fromDate_label, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.progress_label, 0);
            this.Controls.SetChildIndex(this.manager_label, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button attach;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dscp_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label toDate_label;
        private System.Windows.Forms.Label fromDate_label;
        private System.Windows.Forms.Label manager_label;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}