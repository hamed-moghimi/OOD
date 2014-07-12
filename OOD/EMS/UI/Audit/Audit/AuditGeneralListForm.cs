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
    public partial class Audit_Kalan_List : Template
    {
        public Audit_Kalan_List()
        {
            InitializeComponent();
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new Audit.Audit_Kalan_View()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
    }
}
