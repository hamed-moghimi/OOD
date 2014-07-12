using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Audit.Audit
{
    public partial class Audit_Kalan_View : Template
    {
        public Audit_Kalan_View()
        {
            this.menu.Visible = false;
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new Audit_Kalan()).ShowDialog();
        }
    }
}
