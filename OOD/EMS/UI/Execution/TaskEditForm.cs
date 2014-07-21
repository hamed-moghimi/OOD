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
using OOD.EMS.Management;

namespace OOD.EMS.UI.Execution
{
    public partial class TaskEditForm : TemplateDialog
    {
        public String name, fromDate, toDate, dscp;
        public Department manager;
        public List<Attachment> attachments;
        private String prevTitle;

        public TaskEditForm(EMS.Execution.Task t)
        {
            InitializeComponent();
            if (t != null)
            {
                name_box.Text = t.Title;
                fromDateBox.Value = t.StartDate;
                toDateBox.Value = t.DueDate;
                dscp_box.Text = t.Description;
                prevTitle = t.Title;
                manager = t.department;
                respBox.Text = manager.Name;
                attachmentPanel1.populate(t.attachments);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            foreach (Attachment attach in attachmentPanel1.getNewlyAdded())
            {
                attach.delete();
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (manager == null)
            {
                MessageBox.Show(new IncompleteFormException().Message);
                return;
            }

            EMS.Execution.Task res = TaskStorage.getInstance().all().Find(x => x.Title.Equals(name_box.Text));
            if ((prevTitle == null || !prevTitle.Equals(name_box.Text) ) && res != null)
            {
                MessageBox.Show(new TaskExistsException().Message);
            }
            else
            {
                try
                {
                    if (toDateBox.Value < fromDateBox.Value)
                    {
                        MessageBox.Show("بازه‌ی زمانی صحیح نمی‌باشد");
                        return;
                    }
                
                    name = name_box.Text;
                    toDate = convert(toDateBox.Value.ToString());
                    Convert.ToDateTime(toDate);
                    fromDate = convert(fromDateBox.Value.ToString());
                    Convert.ToDateTime(fromDate);
                    dscp = dscp_box.Text;
                    attachments = attachmentPanel1.getAttachments();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(new IncompleteFormException().Message);
                }
                
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            StructureSelectForm f = new StructureSelectForm();
            DialogResult res2 = f.ShowDialog();
            if (res2 == DialogResult.OK)
            {
                manager = f.Section;
                respBox.Text = manager.Name;
            }
        }


    }
}
