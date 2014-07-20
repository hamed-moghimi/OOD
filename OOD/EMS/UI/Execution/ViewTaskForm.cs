using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Execution
{
    public partial class ViewTaskForm : TemplateDialog
    {
        public String name, fromDate, toDate, dscp;
        public Department manager;
        private String prevTitle;

        public ViewTaskForm(EMS.Execution.Task t)
        {
            InitializeComponent();
            attachmentPanel1.ViewMode = true;
            if (t != null)
            {
                name_label.Text = t.Title;
                fromDate_label.Text = t.getStartDateString();
                toDate_label.Text = t.getDueDateString();
                manager_label.Text = t.department.Name;
                progress_label.Text = t.Progress.ToString();
                dscp_box.Text = t.Description;
                attachmentPanel1.populate(t.attachments);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
