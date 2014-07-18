namespace OOD.EMS.UI.Management
{
    partial class ConventionForm
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
            this.policyBox = new System.Windows.Forms.RichTextBox();
            this.dscpBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.attachmentPanel1 = new OOD.EMS.UI.AttachmentPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "خط‌مشی:";
            // 
            // policyBox
            // 
            this.policyBox.Location = new System.Drawing.Point(12, 67);
            this.policyBox.Name = "policyBox";
            this.policyBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.policyBox.Size = new System.Drawing.Size(461, 96);
            this.policyBox.TabIndex = 4;
            this.policyBox.Text = "";
            this.policyBox.TextChanged += new System.EventHandler(this.policyBox_TextChanged);
            // 
            // dscpBox
            // 
            this.dscpBox.Location = new System.Drawing.Point(12, 193);
            this.dscpBox.Name = "dscpBox";
            this.dscpBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscpBox.Size = new System.Drawing.Size(461, 96);
            this.dscpBox.TabIndex = 6;
            this.dscpBox.Text = "";
            this.dscpBox.TextChanged += new System.EventHandler(this.dscpBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 166);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "توضیحات:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 490);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // attachmentPanel1
            // 
            this.attachmentPanel1.Changed = false;
            this.attachmentPanel1.Location = new System.Drawing.Point(12, 295);
            this.attachmentPanel1.Name = "attachmentPanel1";
            this.attachmentPanel1.Size = new System.Drawing.Size(461, 188);
            this.attachmentPanel1.TabIndex = 13;
            this.attachmentPanel1.ViewMode = false;
            // 
            // ConventionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 533);
            this.Controls.Add(this.attachmentPanel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dscpBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.policyBox);
            this.Controls.Add(this.label1);
            this.Name = "ConventionForm";
            this.Text = "میثاق‌نامه زیست‌محیطی سازمان";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.policyBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dscpBox, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.attachmentPanel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox policyBox;
        private System.Windows.Forms.RichTextBox dscpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button2;
        private AttachmentPanel attachmentPanel1;
    }
}