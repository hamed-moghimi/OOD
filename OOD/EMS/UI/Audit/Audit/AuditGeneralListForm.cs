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
    public partial class AuditGeneralListForm : TemplateForm
    {
        public AuditGeneralListForm()
        {
            InitializeComponent();
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new Audit.AuditGeneralViewForm()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
    }
}
