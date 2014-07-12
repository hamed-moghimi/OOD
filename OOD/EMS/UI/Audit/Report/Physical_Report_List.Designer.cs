namespace OOD.Audit.Report
{
    partial class Physical_Report_List
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
            this.ReportList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportList
            // 
            this.ReportList.FormattingEnabled = true;
            this.ReportList.ItemHeight = 24;
            this.ReportList.Items.AddRange(new object[] {
            "گزارش ۱۰ اردیبهشت ۱۳۹۱",
            "گزارش ۱۰ شهریور ۱۳۹۱",
            "گزارش ۲۰ بهمن ۱۳۹۱",
            "گزارش ۱۰ اردیبهشت ۱۳۹۲"});
            this.ReportList.Location = new System.Drawing.Point(43, 60);
            this.ReportList.Name = "ReportList";
            this.ReportList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReportList.Size = new System.Drawing.Size(452, 172);
            this.ReportList.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.button1.Location = new System.Drawing.Point(148, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "مشاهده";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.button2.Location = new System.Drawing.Point(43, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "بازگشت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.button3.Location = new System.Drawing.Point(252, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "ثبت گزارش جدید";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Physical_Report_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 321);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReportList);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "Physical_Report_List";
            this.Text = "گزارش‌های بازرسی فیزیکی";
            this.Controls.SetChildIndex(this.ReportList, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ReportList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}