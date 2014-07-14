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

namespace OOD.EMS.UI.ExecutiveForms
{
    public partial class TaskEditForm : TemplateForm
    {
        public String name, fromDate, toDate, dscp;
        public Department manager;
        private String prevTitle;

        public TaskEditForm(EMS.Execution.Task t)
        {
            InitializeComponent();
            this.menu.Visible = false;
            if (t != null)
            {
                name_box.Text = t.Title;
                fromDateBox.Text = t.getStartDateString();
                toDateBox.Text = t.getDueDateString();
                dscp_box.Text = t.Description;
                prevTitle = t.Title;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMS.Execution.Task res = TaskStorage.getInstance().all().Find(x => x.Title.Equals(name_box.Text));
            if ((prevTitle == null || !prevTitle.Equals(name_box.Text) ) && res != null)
            {
                MessageBox.Show(new TaskExistsException().Message);
            }
            else
            {
                StructureSelectForm f = new StructureSelectForm();
                DialogResult res2 = f.ShowDialog();
                if (res2 == DialogResult.OK)
                {
                    manager = f.Section;
                    name = name_box.Text;
                    toDate = toDateBox.Text;
                    fromDate = fromDateBox.Text;
                    dscp = dscp_box.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }


    }
}
