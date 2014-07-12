namespace OOD.Management
{
    partial class AddLegalReqForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dscp_box = new System.Windows.Forms.RichTextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 22);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام سند:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.attach);
            this.groupBox2.Location = new System.Drawing.Point(39, 191);
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
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "ضمیمه‌ی الزامات قانونی";
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
            this.Cancel.Location = new System.Drawing.Point(38, 333);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 333);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 69);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "توضیحات:";
            // 
            // dscp_box
            // 
            this.dscp_box.Location = new System.Drawing.Point(39, 102);
            this.dscp_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dscp_box.Name = "dscp_box";
            this.dscp_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscp_box.Size = new System.Drawing.Size(452, 78);
            this.dscp_box.TabIndex = 15;
            this.dscp_box.Text = "";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(201, 19);
            this.name_box.Name = "name_box";
            this.name_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_box.Size = new System.Drawing.Size(222, 31);
            this.name_box.TabIndex = 20;
            // 
            // AddGeneralGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 387);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dscp_box);
            this.Controls.Add(this.label5);
            this.Name = "AddGeneralGoals";
            this.Text = "اضافه‌کردن الزامات قانونی";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dscp_box, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.name_box, 0);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dscp_box;
        private System.Windows.Forms.TextBox name_box;
    }
}