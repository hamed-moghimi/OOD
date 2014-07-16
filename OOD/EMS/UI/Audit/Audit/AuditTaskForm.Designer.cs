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
            this.attach = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.targetName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addAttachment = new System.Windows.Forms.OpenFileDialog();
            this.progressBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "پیشرفت مسئولیت:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(13, 109);
            this.descBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descBox.Name = "descBox";
            this.descBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descBox.Size = new System.Drawing.Size(452, 100);
            this.descBox.TabIndex = 0;
            this.descBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 81);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "توضیحات:";
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
            this.attach.Click += new System.EventHandler(this.attach_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(133, 360);
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
            this.Cancel.Location = new System.Drawing.Point(12, 360);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.attach);
            this.groupBox2.Location = new System.Drawing.Point(13, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(452, 123);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ضمیمه‌ها";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "ضمیمه‌ی حسابرسی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::OOD.Properties.Resources.attach;
            this.label4.Location = new System.Drawing.Point(396, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "      ";
            // 
            // targetName
            // 
            this.targetName.Location = new System.Drawing.Point(12, 14);
            this.targetName.Name = "targetName";
            this.targetName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.targetName.Size = new System.Drawing.Size(350, 24);
            this.targetName.TabIndex = 12;
            this.targetName.Text = "مسئولیت ۱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 14);
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
            this.progressBox.Location = new System.Drawing.Point(317, 47);
            this.progressBox.Name = "progressBox";
            this.progressBox.Size = new System.Drawing.Size(44, 31);
            this.progressBox.TabIndex = 13;
            this.progressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 399);
            this.Controls.Add(this.progressBox);
            this.Controls.Add(this.targetName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "AuditTaskForm";
            this.Text = "حسابرسی مسئولیت";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button attach;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label targetName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog addAttachment;
        private System.Windows.Forms.TextBox progressBox;

    }
}