namespace OOD.EMS.UI.Audit.Audit
{
    partial class AuditTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.targetName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addAttachment = new System.Windows.Forms.OpenFileDialog();
            this.progressBox = new System.Windows.Forms.TextBox();
            this.attachmentPanel1 = new OOD.EMS.UI.AttachmentPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "پیشرفت مسئولیت:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(12, 108);
            this.descBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descBox.Name = "descBox";
            this.descBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descBox.Size = new System.Drawing.Size(461, 100);
            this.descBox.TabIndex = 0;
            this.descBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 80);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "توضیحات:";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(123, 410);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(105, 33);
            this.OK.TabIndex = 8;
            this.OK.Text = "ثبت";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 410);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // targetName
            // 
            this.targetName.Location = new System.Drawing.Point(20, 13);
            this.targetName.Name = "targetName";
            this.targetName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.targetName.Size = new System.Drawing.Size(350, 24);
            this.targetName.TabIndex = 12;
            this.targetName.Text = "مسئولیت ۱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 13);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "نام مسئولیت:";
            // 
            // addAttachment
            // 
            this.addAttachment.FileName = "openFileDialog1";
            // 
            // progressBox
            // 
            this.progressBox.Location = new System.Drawing.Point(325, 46);
            this.progressBox.Name = "progressBox";
            this.progressBox.Size = new System.Drawing.Size(44, 31);
            this.progressBox.TabIndex = 13;
            this.progressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attachmentPanel1
            // 
            this.attachmentPanel1.Changed = false;
            this.attachmentPanel1.Location = new System.Drawing.Point(12, 215);
            this.attachmentPanel1.Name = "attachmentPanel1";
            this.attachmentPanel1.Size = new System.Drawing.Size(461, 188);
            this.attachmentPanel1.TabIndex = 14;
            this.attachmentPanel1.ViewMode = false;
            // 
            // AuditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.attachmentPanel1);
            this.Controls.Add(this.progressBox);
            this.Controls.Add(this.targetName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "AuditTaskForm";
            this.Text = "حسابرسی مسئولیت";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuditTaskForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label targetName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog addAttachment;
        private System.Windows.Forms.TextBox progressBox;
        private AttachmentPanel attachmentPanel1;

    }
}