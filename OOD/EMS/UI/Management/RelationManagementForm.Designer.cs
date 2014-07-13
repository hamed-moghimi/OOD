namespace OOD.EMS.UI.Management
{
    partial class RelationManagementForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.docType2 = new System.Windows.Forms.ComboBox();
            this.docType1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rel1Grid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rel2Grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rel1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rel2Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.docType2);
            this.groupBox1.Controls.Add(this.docType1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(107, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(500, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اسناد طرفین ارتباط";
            // 
            // docType2
            // 
            this.docType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docType2.FormattingEnabled = true;
            this.docType2.Items.AddRange(new object[] {
            "اهداف کلان",
            "الزامات قانونی",
            "تاثیرات زیست‌محیطی"});
            this.docType2.Location = new System.Drawing.Point(54, 63);
            this.docType2.Name = "docType2";
            this.docType2.Size = new System.Drawing.Size(134, 32);
            this.docType2.TabIndex = 3;
            // 
            // docType1
            // 
            this.docType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docType1.FormattingEnabled = true;
            this.docType1.Items.AddRange(new object[] {
            "اهداف کلان",
            "الزامات قانونی",
            "تاثیرات زیست‌محیطی"});
            this.docType1.Location = new System.Drawing.Point(306, 63);
            this.docType1.Name = "docType1";
            this.docType1.Size = new System.Drawing.Size(134, 32);
            this.docType1.TabIndex = 2;
            this.docType1.SelectedIndexChanged += new System.EventHandler(this.docType1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "نوع سند دوم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع سند اول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 199);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "طرف اول ارتباط:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 199);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "طرف دوم ارتباط:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 388);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "انصراف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 388);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(105, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rel1Grid
            // 
            this.rel1Grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rel1Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rel1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rel1Grid.ColumnHeadersVisible = false;
            this.rel1Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.rel1Grid.Location = new System.Drawing.Point(379, 239);
            this.rel1Grid.Name = "rel1Grid";
            this.rel1Grid.ReadOnly = true;
            this.rel1Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rel1Grid.RowHeadersVisible = false;
            this.rel1Grid.Size = new System.Drawing.Size(277, 124);
            this.rel1Grid.TabIndex = 10;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "عنوان";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rel2Grid
            // 
            this.rel2Grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rel2Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rel2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rel2Grid.ColumnHeadersVisible = false;
            this.rel2Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.rel2Grid.Location = new System.Drawing.Point(42, 239);
            this.rel2Grid.Name = "rel2Grid";
            this.rel2Grid.ReadOnly = true;
            this.rel2Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rel2Grid.RowHeadersVisible = false;
            this.rel2Grid.Size = new System.Drawing.Size(277, 124);
            this.rel2Grid.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RelationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 446);
            this.Controls.Add(this.rel2Grid);
            this.Controls.Add(this.rel1Grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelationManagementForm";
            this.Text = "اضافه‌کردن ارتباطات اسناد مدیریتی";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.rel1Grid, 0);
            this.Controls.SetChildIndex(this.rel2Grid, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rel1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rel2Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox docType1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView rel1Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridView rel2Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox docType2;
    }
}