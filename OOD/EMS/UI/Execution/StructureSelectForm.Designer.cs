namespace OOD.EMS.UI.ExecutiveForms
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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("اداره کل امور اداری");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("اداره کل رفاه");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("اداره کل کارگزینی");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("معاونت اداری مالی", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("اداره کل ایمنی");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("اداره کل تجهیزات");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("معاونت فنی مهندسی", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("اداره کل بندر شهید رجایی");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("اداره کل بندر امام خمینی");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("اداره کل بندر انزلی");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("معاونت بندری", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("اداره کل ترانزیت");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("معاونت دریایی", new System.Windows.Forms.TreeNode[] {
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("روابط عمومی و امور بین الملل");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("سازمان بنادر و دریانوردی", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode22,
            treeNode26,
            treeNode28,
            treeNode29});
            this.structureTree = new System.Windows.Forms.TreeView();
            this.Cancel = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // structureTree
            // 
            this.structureTree.Location = new System.Drawing.Point(12, 12);
            this.structureTree.Name = "structureTree";
            treeNode16.Name = "Node7";
            treeNode16.Text = "اداره کل امور اداری";
            treeNode17.Name = "Node8";
            treeNode17.Text = "اداره کل رفاه";
            treeNode18.Name = "Node9";
            treeNode18.Text = "اداره کل کارگزینی";
            treeNode19.Name = "Node1";
            treeNode19.Text = "معاونت اداری مالی";
            treeNode20.Name = "Node10";
            treeNode20.Text = "اداره کل ایمنی";
            treeNode21.Name = "Node11";
            treeNode21.Text = "اداره کل تجهیزات";
            treeNode22.Name = "Node3";
            treeNode22.Text = "معاونت فنی مهندسی";
            treeNode23.Name = "Node0";
            treeNode23.Text = "اداره کل بندر شهید رجایی";
            treeNode24.Name = "Node1";
            treeNode24.Text = "اداره کل بندر امام خمینی";
            treeNode25.Name = "Node2";
            treeNode25.Text = "اداره کل بندر انزلی";
            treeNode26.Name = "Node4";
            treeNode26.Text = "معاونت بندری";
            treeNode27.Name = "Node3";
            treeNode27.Text = "اداره کل ترانزیت";
            treeNode28.Name = "Node5";
            treeNode28.Text = "معاونت دریایی";
            treeNode29.Name = "Node14";
            treeNode29.Text = "روابط عمومی و امور بین الملل";
            treeNode30.Name = "Node0";
            treeNode30.Text = "سازمان بنادر و دریانوردی";
            this.structureTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30});
            this.structureTree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.structureTree.RightToLeftLayout = true;
            this.structureTree.Size = new System.Drawing.Size(325, 302);
            this.structureTree.TabIndex = 4;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(52, 324);
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
            this.selectbtn.Location = new System.Drawing.Point(173, 324);
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
            this.ClientSize = new System.Drawing.Size(352, 374);
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
