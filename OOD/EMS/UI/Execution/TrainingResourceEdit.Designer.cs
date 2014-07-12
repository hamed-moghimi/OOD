namespace OOD.ExecutiveForms
{
    partial class TrainingResourceEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.descBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::OOD.Properties.Resources.ok;
            this.button1.Location = new System.Drawing.Point(170, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(12, 135);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descBox.Size = new System.Drawing.Size(505, 181);
            this.descBox.TabIndex = 25;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(12, 57);
            this.amountBox.Name = "amountBox";
            this.amountBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountBox.Size = new System.Drawing.Size(451, 31);
            this.amountBox.TabIndex = 24;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 10);
            this.titleBox.Name = "titleBox";
            this.titleBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleBox.Size = new System.Drawing.Size(451, 31);
            this.titleBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(450, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "توضیحات :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(474, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "زمینه :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(471, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "عنوان :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrainingResourceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.ClientSize = new System.Drawing.Size(529, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrainingResourceEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingResourceEdit_FormClosing);
            this.Load += new System.EventHandler(this.TrainingResourceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
