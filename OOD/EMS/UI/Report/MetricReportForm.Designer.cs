namespace OOD.EMS.UI.Report
{
    partial class MetricReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetricReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toDateBox = new FreeControls.PersianDateTimePicker();
            this.fromDateBox = new FreeControls.PersianDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.metricsBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.metricsBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(615, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش‌گیری از اندازه‌ها و سنجه‌ها";
            // 
            // toDateBox
            // 
            this.toDateBox.BackColor = System.Drawing.Color.White;
            this.toDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toDateBox.Location = new System.Drawing.Point(35, 101);
            this.toDateBox.Name = "toDateBox";
            this.toDateBox.ShowTime = false;
            this.toDateBox.Size = new System.Drawing.Size(115, 27);
            this.toDateBox.TabIndex = 12;
            this.toDateBox.Text = "persianDateTimePicker1";
            this.toDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("toDateBox.Value")));
            // 
            // fromDateBox
            // 
            this.fromDateBox.BackColor = System.Drawing.Color.White;
            this.fromDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fromDateBox.Location = new System.Drawing.Point(35, 60);
            this.fromDateBox.Name = "fromDateBox";
            this.fromDateBox.ShowTime = false;
            this.fromDateBox.Size = new System.Drawing.Size(115, 27);
            this.fromDateBox.TabIndex = 11;
            this.fromDateBox.Text = "persianDateTimePicker1";
            this.fromDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("fromDateBox.Value")));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "برای مقایسه‌ی مقادیر سنجه‌های مختلف، این امکان فراهم است که بیش از یک سنجه را انت" +
    "خاب کرده و مقادیر تمامی\r\nسنجه‌های انتخاب‌شده را در کنار هم مشاهده نمایید.";
            // 
            // metricsBox
            // 
            this.metricsBox.FormattingEnabled = true;
            this.metricsBox.Location = new System.Drawing.Point(234, 60);
            this.metricsBox.Name = "metricsBox";
            this.metricsBox.Size = new System.Drawing.Size(367, 108);
            this.metricsBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(506, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "انتخاب سنجه‌ها";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(13, 134);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(202, 34);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "تولید گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(160, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(160, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "از تاریخ :";
            // 
            // MetricReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(639, 276);
            this.Controls.Add(this.groupBox1);
            this.Name = "MetricReportForm";
            this.Text = "گزارش‌گیری از اندازه‌ها و سنجه‌ها";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox metricsBox;
        private FreeControls.PersianDateTimePicker toDateBox;
        private FreeControls.PersianDateTimePicker fromDateBox;
    }
}
