namespace OOD.EMS.UI.Execution
{
    partial class AddGoalRelationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.execGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genGrid = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.execGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "درصد";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "انصراف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(122, 255);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "ثبت";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "سهم هدف اجرایی در تحقق هدف کلان :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.execGrid);
            this.groupBox2.Location = new System.Drawing.Point(11, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(370, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اهداف اجرایی";
            // 
            // execGrid
            // 
            this.execGrid.AllowUserToAddRows = false;
            this.execGrid.AllowUserToDeleteRows = false;
            this.execGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.execGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.execGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.execGrid.ColumnHeadersVisible = false;
            this.execGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.execGrid.Location = new System.Drawing.Point(13, 30);
            this.execGrid.Name = "execGrid";
            this.execGrid.ReadOnly = true;
            this.execGrid.RowHeadersVisible = false;
            this.execGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.execGrid.Size = new System.Drawing.Size(342, 150);
            this.execGrid.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 182.7411F;
            this.dataGridViewTextBoxColumn1.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genGrid);
            this.groupBox1.Location = new System.Drawing.Point(387, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(370, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اهداف کلان";
            // 
            // genGrid
            // 
            this.genGrid.AllowUserToAddRows = false;
            this.genGrid.AllowUserToDeleteRows = false;
            this.genGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.genGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.genGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genGrid.ColumnHeadersVisible = false;
            this.genGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title});
            this.genGrid.Location = new System.Drawing.Point(13, 30);
            this.genGrid.Name = "genGrid";
            this.genGrid.ReadOnly = true;
            this.genGrid.RowHeadersVisible = false;
            this.genGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genGrid.Size = new System.Drawing.Size(342, 150);
            this.genGrid.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.FillWeight = 182.7411F;
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // shareBox
            // 
            this.shareBox.Location = new System.Drawing.Point(496, 12);
            this.shareBox.MaxLength = 3;
            this.shareBox.Name = "shareBox";
            this.shareBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shareBox.Size = new System.Drawing.Size(52, 31);
            this.shareBox.TabIndex = 20;
            this.shareBox.Text = "100";
            this.shareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddGoalRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 298);
            this.Controls.Add(this.shareBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddGoalRelationForm";
            this.Text = "اضافه‌کردن ارتباط اهداف";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.execGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView genGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView execGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shareBox;
    }
}