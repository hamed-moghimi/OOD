namespace OOD.EMS.UI
{
    partial class AttachmentPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attachPanel = new System.Windows.Forms.GroupBox();
            this.removeButon = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.attachmentGrid = new System.Windows.Forms.DataGridView();
            this.attachment_filename = new System.Windows.Forms.DataGridViewLinkColumn();
            this.hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // attachPanel
            // 
            this.attachPanel.Controls.Add(this.removeButon);
            this.attachPanel.Controls.Add(this.add);
            this.attachPanel.Controls.Add(this.attachmentGrid);
            this.attachPanel.Location = new System.Drawing.Point(3, 4);
            this.attachPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attachPanel.Name = "attachPanel";
            this.attachPanel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attachPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.attachPanel.Size = new System.Drawing.Size(452, 180);
            this.attachPanel.TabIndex = 20;
            this.attachPanel.TabStop = false;
            this.attachPanel.Text = "ضمیمه‌ها";
            // 
            // removeButon
            // 
            this.removeButon.Image = global::OOD.Properties.Resources.remove;
            this.removeButon.Location = new System.Drawing.Point(378, 92);
            this.removeButon.Name = "removeButon";
            this.removeButon.Size = new System.Drawing.Size(40, 40);
            this.removeButon.TabIndex = 23;
            this.removeButon.UseVisualStyleBackColor = true;
            this.removeButon.Click += new System.EventHandler(this.removeButon_Click);
            // 
            // add
            // 
            this.add.Image = global::OOD.Properties.Resources.add;
            this.add.Location = new System.Drawing.Point(378, 47);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(40, 40);
            this.add.TabIndex = 22;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // attachmentGrid
            // 
            this.attachmentGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.attachmentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.attachmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachmentGrid.ColumnHeadersVisible = false;
            this.attachmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachment_filename,
            this.hash});
            this.attachmentGrid.Location = new System.Drawing.Point(18, 31);
            this.attachmentGrid.Name = "attachmentGrid";
            this.attachmentGrid.RowHeadersVisible = false;
            this.attachmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attachmentGrid.Size = new System.Drawing.Size(336, 130);
            this.attachmentGrid.TabIndex = 21;
            // 
            // attachment_filename
            // 
            this.attachment_filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attachment_filename.HeaderText = "نام";
            this.attachment_filename.Name = "attachment_filename";
            this.attachment_filename.ReadOnly = true;
            this.attachment_filename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachment_filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hash
            // 
            this.hash.HeaderText = "hash";
            this.hash.Name = "hash";
            this.hash.ReadOnly = true;
            this.hash.Visible = false;
            // 
            // AttachmentPanel
            // 
            this.Controls.Add(this.attachPanel);
            this.Name = "AttachmentPanel";
            this.Size = new System.Drawing.Size(461, 188);
            this.attachPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox attachPanel;
        private System.Windows.Forms.Button removeButon;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView attachmentGrid;
        private System.Windows.Forms.DataGridViewLinkColumn attachment_filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash;



    }
}
