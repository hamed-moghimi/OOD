namespace OOD.EMS.UI.Execution
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
            this.structureTree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deptName = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // structureTree
            // 
            this.structureTree.Location = new System.Drawing.Point(12, 45);
            this.structureTree.Name = "structureTree";
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
            this.structureTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.structureTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.structureTree.RightToLeftLayout = true;
            this.structureTree.Size = new System.Drawing.Size(325, 302);
            this.structureTree.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewButton);
            this.groupBox1.Controls.Add(this.prev);
            this.groupBox1.Controls.Add(this.next);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Location = new System.Drawing.Point(344, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(237, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت بخش‌های سازمانی";
            // 
            // prev
            // 
            this.prev.Image = global::OOD.Properties.Resources.up;
            this.prev.Location = new System.Drawing.Point(167, 42);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(40, 40);
            this.prev.TabIndex = 2;
            this.toolTip.SetToolTip(this.prev, "بردن به بالا");
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Image = global::OOD.Properties.Resources.down;
            this.next.Location = new System.Drawing.Point(121, 42);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(40, 40);
            this.next.TabIndex = 1;
            this.toolTip.SetToolTip(this.next, "بردن به پایین");
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // delete
            // 
            this.delete.Image = global::OOD.Properties.Resources.delete;
            this.delete.Location = new System.Drawing.Point(75, 42);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(40, 40);
            this.delete.TabIndex = 0;
            this.toolTip.SetToolTip(this.delete, "حذف بخش");
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addDepartment);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.deptName);
            this.groupBox2.Location = new System.Drawing.Point(343, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(238, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اضافه‌کردن بخش جدید";
            // 
            // addDepartment
            // 
            this.addDepartment.Location = new System.Drawing.Point(40, 113);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(159, 30);
            this.addDepartment.TabIndex = 5;
            this.addDepartment.Text = "اضافه کردن زیربخش";
            this.addDepartment.UseVisualStyleBackColor = true;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
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
            // deptName
            // 
            this.deptName.Location = new System.Drawing.Point(6, 65);
            this.deptName.Name = "deptName";
            this.deptName.Size = new System.Drawing.Size(222, 31);
            this.deptName.TabIndex = 3;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 354);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "بازگشت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Image = global::OOD.Properties.Resources.search;
            this.ViewButton.Location = new System.Drawing.Point(29, 42);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(40, 40);
            this.ViewButton.TabIndex = 3;
            this.toolTip.SetToolTip(this.ViewButton, "حذف بخش");
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // StructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 400);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.structureTree);
            this.Name = "StructureForm";
            this.Text = "مدیریت ساختار سازمانی";
            this.Controls.SetChildIndex(this.structureTree, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView structureTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptName;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button ViewButton;
    }
}