using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Audit
{
    public partial class Audit_Kalan : Template
    {
        public Audit_Kalan()
        {
            this.menu.Visible = false;
            InitializeComponent();
            this.dataGridView1.Rows.Add("هدف اجرایی ۱", "۳۰٪");
            this.dataGridView1.Rows.Add("هدف اجرایی ۲", "۴۰٪");
            this.dataGridView1.Rows.Add("هدف اجرایی ۳", "۵۰٪");
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void attach_Click(object sender, EventArgs e)
        {
            this.addAttachment.ShowDialog();
        }

        
       
        
    }
}
