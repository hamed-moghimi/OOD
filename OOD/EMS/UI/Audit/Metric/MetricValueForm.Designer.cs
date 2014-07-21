namespace OOD.EMS.UI.Audit.Metric
{
    partial class MetricValueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetricValueForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metricBox = new System.Windows.Forms.ComboBox();
            this.unitBox = new System.Windows.Forms.Label();
            this.dateBox = new FreeControls.PersianDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "سنجه:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(29, 130);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 30);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "انصراف";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(135, 130);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(102, 30);
            this.OK.TabIndex = 4;
            this.OK.Text = "ثبت";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(135, 54);
            this.valueBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.valueBox.Name = "valueBox";
            this.valueBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.valueBox.Size = new System.Drawing.Size(102, 31);
            this.valueBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "مقدار:";
            // 
            // metricBox
            // 
            this.metricBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metricBox.FormattingEnabled = true;
            this.metricBox.Location = new System.Drawing.Point(12, 12);
            this.metricBox.Name = "metricBox";
            this.metricBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metricBox.Size = new System.Drawing.Size(225, 32);
            this.metricBox.TabIndex = 1;
            this.metricBox.SelectedIndexChanged += new System.EventHandler(this.metricBox_SelectedIndexChanged);
            // 
            // unitBox
            // 
            this.unitBox.AutoEllipsis = true;
            this.unitBox.Location = new System.Drawing.Point(14, 57);
            this.unitBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.unitBox.Name = "unitBox";
            this.unitBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unitBox.Size = new System.Drawing.Size(111, 24);
            this.unitBox.TabIndex = 8;
            this.unitBox.Text = "واحد";
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.White;
            this.dateBox.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateBox.Location = new System.Drawing.Point(122, 94);
            this.dateBox.Name = "dateBox";
            this.dateBox.ShowTime = false;
            this.dateBox.Size = new System.Drawing.Size(115, 27);
            this.dateBox.TabIndex = 3;
            this.dateBox.Text = "persianDateTimePicker1";
            this.dateBox.Value = ((FreeControls.PersianDate)(resources.GetObject("dateBox.Value")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "تاریخ:";
            // 
            // MetricValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.metricBox);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "MetricValueForm";
            this.Text = "مقدار سنجه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox metricBox;
        private System.Windows.Forms.Label unitBox;
        private FreeControls.PersianDateTimePicker dateBox;
        private System.Windows.Forms.Label label3;
    }
}