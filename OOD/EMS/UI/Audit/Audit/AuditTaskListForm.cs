using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Audit;
using OOD.EMS.Execution;

namespace OOD.EMS.UI.Audit
{
    public partial class AuditTaskListForm : TemplateForm
    {
        public AuditTaskListForm()
        {
            InitializeComponent();
            // fill list with tasks
            foreach (Task task in TaskStorage.getInstance().all())
            {
                object[] row = new object[2];
                row[0] = task.Progress;
                row[1] = task.Title;
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new AuditTaskForm()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
