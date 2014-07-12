namespace OOD.Audit
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attach = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.target_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addAttachment = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "پیشرفت مسئولیت:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 116);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(452, 78);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 83);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(42, 367);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.attach);
            this.groupBox2.Location = new System.Drawing.Point(43, 224);
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
            this.label4.Image = global::OOD.Properties.Resources.delete;
            this.label4.Location = new System.Drawing.Point(396, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "      ";
            // 
            // target_name
            // 
            this.target_name.AutoSize = true;
            this.target_name.Location = new System.Drawing.Point(323, 14);
            this.target_name.Name = "target_name";
            this.target_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.target_name.Size = new System.Drawing.Size(67, 24);
            this.target_name.TabIndex = 12;
            this.target_name.Text = "مسئولیت ۱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 14);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 13;
            // 
            // Audit_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 423);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.target_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "Audit_Task";
            this.Text = "حسابرسی";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.target_name, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button attach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label target_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog addAttachment;
        private System.Windows.Forms.TextBox textBox1;

    }
}