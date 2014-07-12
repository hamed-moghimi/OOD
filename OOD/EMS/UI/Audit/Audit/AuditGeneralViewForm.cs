using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.EMS.UI.Audit.Audit
{
    public partial class AuditGeneralViewForm : TemplateForm
    {
        public AuditGeneralViewForm()
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
            (new AuditGeneralForm()).ShowDialog();
        }
    }
}
