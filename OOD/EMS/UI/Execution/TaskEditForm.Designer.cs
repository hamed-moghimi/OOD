namespace OOD.EMS.UI.Execution
{
    partial class TaskEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEditForm));
            this.label5 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dscp_box = new System.Windows.Forms.RichTextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.respBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.attachmentPanel1 = new OOD.EMS.UI.AttachmentPanel();
            this.fromDateBox = new FreeControls.PersianDateTimePicker();
            this.toDateBox = new FreeControls.PersianDateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 22);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام مسئولیت:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(37, 503);
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
            this.button2.Location = new System.Drawing.Point(158, 503);
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
            this.label3.Location = new System.Drawing.Point(437, 191);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "توضیحات:";
            // 
            // dscp_box
            // 
            this.dscp_box.Location = new System.Drawing.Point(38, 224);
            this.dscp_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dscp_box.Name = "dscp_box";
            this.dscp_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscp_box.Size = new System.Drawing.Size(452, 78);
            this.dscp_box.TabIndex = 15;
            this.dscp_box.Text = "";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(182, 19);
            this.name_box.Name = "name_box";
            this.name_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_box.Size = new System.Drawing.Size(222, 31);
            this.name_box.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "تاریخ شروع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 102);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "تاریخ پایان:";
            // 
            // respBox
            // 
            this.respBox.Location = new System.Drawing.Point(244, 142);
            this.respBox.Name = "respBox";
            this.respBox.ReadOnly = true;
            this.respBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.respBox.Size = new System.Drawing.Size(160, 31);
            this.respBox.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 145);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "بخش مسئول:";
            // 
            // selectButton
            // 
            this.selectButton.Image = global::OOD.Properties.Resources.edit;
            this.selectButton.Location = new System.Drawing.Point(182, 137);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(40, 40);
            this.selectButton.TabIndex = 27;
            this.toolTip.SetToolTip(this.selectButton, "ویرایش");
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // attachmentPanel1
            // 
            this.attachmentPanel1.Changed = false;
            this.attachmentPanel1.Location = new System.Drawing.Point(34, 303);
            this.attachmentPanel1.Name = "attachmentPanel1";
            this.attachmentPanel1.Size = new System.Drawing.Size(461, 188);
            this.attachmentPanel1.TabIndex = 28;
            this.attachmentPanel1.ViewMode = false;
            // 
            // fromDateBox
            // 
            this.fromDateBox.BackColor = System.Drawing.Color.White;
            this.fromDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fromDateBox.Location = new System.Drawing.Point(289, 60);
            this.fromDateBox.Name = "fromDateBox";
            this.fromDateBox.ShowTime = false;
            this.fromDateBox.Size = new System.Drawing.Size(115, 27);
            this.fromDateBox.TabIndex = 29;
            this.fromDateBox.Text = "persianDateTimePicker1";
            this.fromDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("fromDateBox.Value")));
            // 
            // toDateBox
            // 
            this.toDateBox.BackColor = System.Drawing.Color.White;
            this.toDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toDateBox.Location = new System.Drawing.Point(289, 99);
            this.toDateBox.Name = "toDateBox";
            this.toDateBox.ShowTime = false;
            this.toDateBox.Size = new System.Drawing.Size(115, 27);
            this.toDateBox.TabIndex = 30;
            this.toDateBox.Text = "persianDateTimePicker1";
            this.toDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("toDateBox.Value")));
            // 
            // TaskEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 553);
            this.Controls.Add(this.toDateBox);
            this.Controls.Add(this.fromDateBox);
            this.Controls.Add(this.attachmentPanel1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.respBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dscp_box);
            this.Controls.Add(this.label5);
            this.Name = "TaskEditForm";
            this.Text = "مسئولیت";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dscp_box, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.name_box, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.respBox, 0);
            this.Controls.SetChildIndex(this.selectButton, 0);
            this.Controls.SetChildIndex(this.attachmentPanel1, 0);
            this.Controls.SetChildIndex(this.fromDateBox, 0);
            this.Controls.SetChildIndex(this.toDateBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dscp_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox respBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button selectButton;
        private AttachmentPanel attachmentPanel1;
        private FreeControls.PersianDateTimePicker fromDateBox;
        private FreeControls.PersianDateTimePicker toDateBox;
    }
}