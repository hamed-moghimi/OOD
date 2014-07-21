namespace OOD.EMS.UI.Execution
{
    partial class ExecutiveGoalEditForm
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.responsibleBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dscp_box = new System.Windows.Forms.RichTextBox();
            this.attachmentPanel1 = new OOD.EMS.UI.AttachmentPanel();
            this.genGoal = new System.Windows.Forms.GroupBox();
            this.addRelationBtn = new System.Windows.Forms.Button();
            this.genGoalGrid = new System.Windows.Forms.DataGridView();
            this.genGoalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genGoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genGoalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(482, 24);
            this.titleBox.Name = "titleBox";
            this.titleBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleBox.Size = new System.Drawing.Size(358, 31);
            this.titleBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(861, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "تاریخ ثبت :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(882, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "عنوان :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(845, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "بخش مسئول :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(482, 63);
            this.dateBox.Name = "dateBox";
            this.dateBox.ReadOnly = true;
            this.dateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateBox.Size = new System.Drawing.Size(358, 31);
            this.dateBox.TabIndex = 27;
            this.dateBox.Text = "۲۶ / ۲ / ۱۳۹۳";
            // 
            // responsibleBox
            // 
            this.responsibleBox.Location = new System.Drawing.Point(528, 105);
            this.responsibleBox.Name = "responsibleBox";
            this.responsibleBox.ReadOnly = true;
            this.responsibleBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.responsibleBox.Size = new System.Drawing.Size(312, 31);
            this.responsibleBox.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Image = global::OOD.Properties.Resources.edit;
            this.button2.Location = new System.Drawing.Point(482, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 29;
            this.toolTip.SetToolTip(this.button2, "ویرایش");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(15, 376);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 33;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(867, 176);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "توضیحات:";
            // 
            // dscp_box
            // 
            this.dscp_box.Location = new System.Drawing.Point(482, 204);
            this.dscp_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dscp_box.Name = "dscp_box";
            this.dscp_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dscp_box.Size = new System.Drawing.Size(446, 152);
            this.dscp_box.TabIndex = 30;
            this.dscp_box.Text = "";
            // 
            // attachmentPanel1
            // 
            this.attachmentPanel1.Changed = false;
            this.attachmentPanel1.Location = new System.Drawing.Point(14, -3);
            this.attachmentPanel1.Name = "attachmentPanel1";
            this.attachmentPanel1.Size = new System.Drawing.Size(461, 188);
            this.attachmentPanel1.TabIndex = 34;
            this.attachmentPanel1.ViewMode = false;
            // 
            // genGoal
            // 
            this.genGoal.Controls.Add(this.addRelationBtn);
            this.genGoal.Controls.Add(this.genGoalGrid);
            this.genGoal.Location = new System.Drawing.Point(15, 181);
            this.genGoal.Name = "genGoal";
            this.genGoal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.genGoal.Size = new System.Drawing.Size(455, 175);
            this.genGoal.TabIndex = 35;
            this.genGoal.TabStop = false;
            this.genGoal.Text = "اهداف کلان مرتبط";
            // 
            // addRelationBtn
            // 
            this.addRelationBtn.Image = global::OOD.Properties.Resources.add;
            this.addRelationBtn.Location = new System.Drawing.Point(379, 72);
            this.addRelationBtn.Name = "addRelationBtn";
            this.addRelationBtn.Size = new System.Drawing.Size(40, 40);
            this.addRelationBtn.TabIndex = 36;
            this.addRelationBtn.UseVisualStyleBackColor = true;
            this.addRelationBtn.Click += new System.EventHandler(this.addRelationBtn_Click);
            // 
            // genGoalGrid
            // 
            this.genGoalGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.genGoalGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.genGoalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genGoalGrid.ColumnHeadersVisible = false;
            this.genGoalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genGoalCol});
            this.genGoalGrid.Location = new System.Drawing.Point(20, 30);
            this.genGoalGrid.Name = "genGoalGrid";
            this.genGoalGrid.ReadOnly = true;
            this.genGoalGrid.RowHeadersVisible = false;
            this.genGoalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genGoalGrid.Size = new System.Drawing.Size(337, 127);
            this.genGoalGrid.TabIndex = 0;
            // 
            // genGoalCol
            // 
            this.genGoalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genGoalCol.HeaderText = "هدف کلان";
            this.genGoalCol.Name = "genGoalCol";
            this.genGoalCol.ReadOnly = true;
            // 
            // ExecutiveGoalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(941, 425);
            this.Controls.Add(this.attachmentPanel1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dscp_box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.responsibleBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genGoal);
            this.Name = "ExecutiveGoalEditForm";
            this.Text = "هدف اجرایی";
            this.genGoal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genGoalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox responsibleBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox dscp_box;
        private AttachmentPanel attachmentPanel1;
        private System.Windows.Forms.GroupBox genGoal;
        private System.Windows.Forms.DataGridView genGoalGrid;
        private System.Windows.Forms.Button addRelationBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genGoalCol;
    }
}
