namespace OOD.ExecutiveForms
{
    partial class StructureForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("اداره کل امور اداری");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("اداره کل رفاه");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("اداره کل کارگزینی");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("معاونت اداری مالی", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("اداره کل ایمنی");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("اداره کل تجهیزات");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("معاونت فنی مهندسی", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("اداره کل بندر شهید رجایی");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("اداره کل بندر امام خمینی");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("اداره کل بندر انزلی");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("معاونت بندری", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("اداره کل ترانزیت");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("معاونت دریایی", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("روابط عمومی و امور بین الملل");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("سازمان بنادر و دریانوردی", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode11,
            treeNode13,
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 45);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "اداره کل امور اداری";
            treeNode2.Name = "Node8";
            treeNode2.Text = "اداره کل رفاه";
            treeNode3.Name = "Node9";
            treeNode3.Text = "اداره کل کارگزینی";
            treeNode4.Name = "Node1";
            treeNode4.Text = "معاونت اداری مالی";
            treeNode5.Name = "Node10";
            treeNode5.Text = "اداره کل ایمنی";
            treeNode6.Name = "Node11";
            treeNode6.Text = "اداره کل تجهیزات";
            treeNode7.Name = "Node3";
            treeNode7.Text = "معاونت فنی مهندسی";
            treeNode8.Name = "Node0";
            treeNode8.Text = "اداره کل بندر شهید رجایی";
            treeNode9.Name = "Node1";
            treeNode9.Text = "اداره کل بندر امام خمینی";
            treeNode10.Name = "Node2";
            treeNode10.Text = "اداره کل بندر انزلی";
            treeNode11.Name = "Node4";
            treeNode11.Text = "معاونت بندری";
            treeNode12.Name = "Node3";
            treeNode12.Text = "اداره کل ترانزیت";
            treeNode13.Name = "Node5";
            treeNode13.Text = "معاونت دریایی";
            treeNode14.Name = "Node14";
            treeNode14.Text = "روابط عمومی و امور بین الملل";
            treeNode15.Name = "Node0";
            treeNode15.Text = "سازمان بنادر و دریانوردی";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(325, 302);
            this.treeView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(344, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(237, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت بخش‌های سازمانی";
            // 
            // button4
            // 
            this.button4.Image = global::OOD.Properties.Resources.up;
            this.button4.Location = new System.Drawing.Point(167, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 2;
            this.toolTip.SetToolTip(this.button4, "بردن به بالا");
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::OOD.Properties.Resources.down;
            this.button3.Location = new System.Drawing.Point(94, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 1;
            this.toolTip.SetToolTip(this.button3, "بردن به پایین");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::OOD.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(25, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 0;
            this.toolTip.SetToolTip(this.button2, "حذف بخش");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(343, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(238, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اضافه‌کردن بخش جدید";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "اضافه کردن در کنار بخش";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "اضافه کردن زیربخش";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام بخش";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 31);
            this.textBox1.TabIndex = 3;
            // 
            // StructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "StructureForm";
            this.Text = "مدیریت ساختار سازمانی";
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}