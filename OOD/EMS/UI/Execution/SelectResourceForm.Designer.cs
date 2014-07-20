namespace OOD.EMS.UI.Execution
{
    partial class SelectResourceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectResourceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cont_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateBox = new FreeControls.PersianDateTimePicker();
            this.toDateBox = new FreeControls.PersianDateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(539, 327);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "منبع مورد نیاز";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.startDate});
            this.dataGridView1.Location = new System.Drawing.Point(16, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(506, 278);
            this.dataGridView1.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.FillWeight = 182.7411F;
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDate.FillWeight = 58.62944F;
            this.startDate.HeaderText = "مقدار";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 383);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(123, 383);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(105, 33);
            this.selectBtn.TabIndex = 15;
            this.selectBtn.Text = "ثبت";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "مقدار:";
            // 
            // cont_box
            // 
            this.cont_box.Location = new System.Drawing.Point(368, 12);
            this.cont_box.Name = "cont_box";
            this.cont_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cont_box.Size = new System.Drawing.Size(118, 31);
            this.cont_box.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 15);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "تا تاریخ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 15);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "از تاریخ:";
            // 
            // fromDateBox
            // 
            this.fromDateBox.BackColor = System.Drawing.Color.White;
            this.fromDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fromDateBox.Location = new System.Drawing.Point(192, 12);
            this.fromDateBox.Name = "fromDateBox";
            this.fromDateBox.ShowTime = false;
            this.fromDateBox.Size = new System.Drawing.Size(115, 27);
            this.fromDateBox.TabIndex = 22;
            this.fromDateBox.Text = "persianDateTimePicker1";
            this.fromDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("fromDateBox.Value")));
            this.fromDateBox.ValueChanged += new FreeControls.PersianDateTimePicker.onValueChanged(this.fromDateBox_ValueChanged);
            // 
            // toDateBox
            // 
            this.toDateBox.BackColor = System.Drawing.Color.White;
            this.toDateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toDateBox.Location = new System.Drawing.Point(12, 12);
            this.toDateBox.Name = "toDateBox";
            this.toDateBox.ShowTime = false;
            this.toDateBox.Size = new System.Drawing.Size(115, 27);
            this.toDateBox.TabIndex = 23;
            this.toDateBox.Text = "persianDateTimePicker2";
            this.toDateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("toDateBox.Value")));
            this.toDateBox.ValueChanged += new FreeControls.PersianDateTimePicker.onValueChanged(this.toDateBox_ValueChanged);
            // 
            // SelectResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(566, 423);
            this.Controls.Add(this.toDateBox);
            this.Controls.Add(this.fromDateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cont_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectResourceForm";
            this.Text = "اختصاص منبع";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cont_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FreeControls.PersianDateTimePicker fromDateBox;
        private FreeControls.PersianDateTimePicker toDateBox;
    }
}
