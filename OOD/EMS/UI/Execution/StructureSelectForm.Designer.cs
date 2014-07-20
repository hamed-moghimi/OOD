namespace OOD.EMS.UI.Execution
{
    partial class StructureSelectForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // structureTree
            // 
            this.structureTree.Location = new System.Drawing.Point(12, 12);
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
            this.structureTree.Size = new System.Drawing.Size(325, 247);
            this.structureTree.TabIndex = 4;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 266);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // selectbtn
            // 
            this.selectbtn.Location = new System.Drawing.Point(123, 266);
            this.selectbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(105, 33);
            this.selectbtn.TabIndex = 21;
            this.selectbtn.Text = "انتخاب";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // StructureSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.structureTree);
            this.Name = "StructureSelectForm";
            this.Text = "انتخاب بخش مسئول";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView structureTree;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button selectbtn;
    }
}
