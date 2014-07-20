namespace OOD.EMS.UI.Report
{
    partial class ScheduleReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.programListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDateBox = new FreeControls.PersianDateTimePicker();
            this.toDateBox = new FreeControls.PersianDateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.toDateBox);
            this.groupBox1.Controls.Add(this.fromDateBox);
            this.groupBox1.Controls.Add(this.programListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(665, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش‌گیری از برنامه اقدام";
            // 
            // programListBox
            // 
            this.programListBox.FormattingEnabled = true;
            this.programListBox.ItemHeight = 24;
            this.programListBox.Location = new System.Drawing.Point(223, 66);
            this.programListBox.Name = "programListBox";
            this.programListBox.Size = new System.Drawing.Size(426, 100);
            this.programListBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(568, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "انتخاب برنامه";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(6, 133);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(202, 33);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "تولید گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(153, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(153, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "از تاریخ :";
            // 
            // fromDateBox
            // 
            this.fromDateBox.BackColor = System.Drawing.Color.White;
            this.fromDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fromDateBox.Location = new System.Drawing.Point(28, 58);
            this.fromDateBox.Name = "fromDateBox";
            this.fromDateBox.ShowTime = false;
            this.fromDateBox.Size = new System.Drawing.Size(115, 27);
            this.fromDateBox.TabIndex = 10;
            this.fromDateBox.Text = "persianDateTimePicker1";
            this.fromDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("fromDateBox.Value")));
            // 
            // toDateBox
            // 
            this.toDateBox.BackColor = System.Drawing.Color.White;
            this.toDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toDateBox.Location = new System.Drawing.Point(28, 91);
            this.toDateBox.Name = "toDateBox";
            this.toDateBox.ShowTime = false;
            this.toDateBox.Size = new System.Drawing.Size(115, 27);
            this.toDateBox.TabIndex = 11;
            this.toDateBox.Text = "persianDateTimePicker2";
            this.toDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("toDateBox.Value")));
            // 
            // ScheduleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(689, 229);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleReportForm";
            this.Text = "گزارش‌گیری از برنامه اقدام";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox programListBox;
        private FreeControls.PersianDateTimePicker toDateBox;
        private FreeControls.PersianDateTimePicker fromDateBox;
    }
}
