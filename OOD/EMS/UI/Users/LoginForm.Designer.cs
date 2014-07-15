namespace OOD.EMS.UI.Users
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label4 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام کاربری :";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(20, 81);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameBox.Size = new System.Drawing.Size(159, 31);
            this.usernameBox.TabIndex = 6;
            this.usernameBox.Text = "minmit";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(20, 138);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(105, 33);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "خروج";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "ورود";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Roya", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 53);
            this.label1.TabIndex = 20;
            this.label1.Text = "سامانه مدیریت زیست‌محیطی";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(363, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "LoginForm";
            this.Text = "ورود کاربران";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}