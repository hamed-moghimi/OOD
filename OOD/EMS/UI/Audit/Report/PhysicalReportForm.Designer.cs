namespace OOD.EMS.UI.Audit.Report
{
    partial class PhysicalReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicalReportForm));
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.addAttachment = new System.Windows.Forms.OpenFileDialog();
            this.dateBox = new FreeControls.PersianDateTimePicker();
            this.attachmentPanel1 = new OOD.EMS.UI.AttachmentPanel();
            this.SuspendLayout();
            // 
            // descBox
            // 
            this.descBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descBox.Location = new System.Drawing.Point(12, 115);
            this.descBox.Name = "descBox";
            this.descBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descBox.Size = new System.Drawing.Size(463, 140);
            this.descBox.TabIndex = 16;
            this.descBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 88);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "توضیحات:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 51);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "تاریخ بازرسی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "نام گزارش:";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Cancel.Location = new System.Drawing.Point(12, 455);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 32);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.titleBox.Location = new System.Drawing.Point(25, 11);
            this.titleBox.Name = "titleBox";
            this.titleBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleBox.Size = new System.Drawing.Size(369, 31);
            this.titleBox.TabIndex = 19;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.OK.Location = new System.Drawing.Point(113, 455);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(95, 32);
            this.OK.TabIndex = 22;
            this.OK.Text = "ثبت";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // addAttachment
            // 
            this.addAttachment.FileName = "openFileDialog1";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.White;
            this.dateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateBox.Location = new System.Drawing.Point(279, 48);
            this.dateBox.Name = "dateBox";
            this.dateBox.ShowTime = false;
            this.dateBox.Size = new System.Drawing.Size(115, 27);
            this.dateBox.TabIndex = 23;
            this.dateBox.Text = "persianDateTimePicker1";
            this.dateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("dateBox.Value")));
            // 
            // attachmentPanel1
            // 
            this.attachmentPanel1.Changed = false;
            this.attachmentPanel1.Location = new System.Drawing.Point(12, 261);
            this.attachmentPanel1.Name = "attachmentPanel1";
            this.attachmentPanel1.Size = new System.Drawing.Size(461, 188);
            this.attachmentPanel1.TabIndex = 24;
            this.attachmentPanel1.ViewMode = false;
            // 
            // PhysicalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 496);
            this.Controls.Add(this.attachmentPanel1);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Name = "PhysicalReportForm";
            this.Text = "گزارش بازرسی اسناد عملکردی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhysicalReportForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.OpenFileDialog addAttachment;
        private FreeControls.PersianDateTimePicker dateBox;
        private AttachmentPanel attachmentPanel1;

    }
}