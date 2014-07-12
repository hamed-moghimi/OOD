namespace OOD.ExecutiveForms
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
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
            this.treeView1.TabIndex = 4;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // StructureSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(352, 321);
            this.Controls.Add(this.treeView1);
            this.Name = "StructureSelect";
            this.Text = "انتخاب بخش مسئول";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}
