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
    public partial class AuditExecutiveListForm : TemplateForm
    {
        public AuditExecutiveListForm()
        {
            InitializeComponent();
            foreach (object[] row in StaticData.executiveGoals)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new AuditExecutiveForm()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
