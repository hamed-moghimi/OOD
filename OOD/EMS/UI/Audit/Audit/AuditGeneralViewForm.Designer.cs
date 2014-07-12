namespace OOD.Audit.Audit
{
    partial class AuditGeneralViewForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Audit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "۱ ادریبهشت ۱۳۹۱",
            "۲ بهمن ۱۳۹۱",
            "۱ اردیبهشت ۱۳۹۲"});
            this.listBox1.Location = new System.Drawing.Point(46, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(452, 196);
            this.listBox1.TabIndex = 3;
            // 
            // Audit
            // 
            this.Audit.Location = new System.Drawing.Point(164, 246);
            this.Audit.Name = "Audit";
            this.Audit.Size = new System.Drawing.Size(105, 33);
            this.Audit.TabIndex = 4;
            this.Audit.Text = "اضافه‌کردن";
            this.Audit.UseVisualStyleBackColor = true;
            this.Audit.Click += new System.EventHandler(this.Audit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(46, 246);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Audit_Kalan_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 295);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Audit);
            this.Controls.Add(this.listBox1);
            this.Name = "Audit_Kalan_View";
            this.Text = "لیست حسابرسی‌ها";
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.Audit, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Audit;
        private System.Windows.Forms.Button Cancel;

    }
}