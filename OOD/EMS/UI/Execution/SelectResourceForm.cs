using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Execution
{
    public partial class SelectResourceForm : TemplateForm
    {

        public Allocation alloc { set; get; }
        private List<Resource> exclude;

        public SelectResourceForm(List<Resource> exclude)
        {
            InitializeComponent();
            load_resources(exclude);
            this.exclude = exclude;
        }


        private void load_resources(List<Resource> exclude)
        {
            dataGridView1.Rows.Clear();
            DateTime from = fromDateBox.Value;
            DateTime to = toDateBox.Value;
            foreach (Resource r in ResourceStorage.getInstance().all())
            {
                if (!exclude.Contains(r))
                {
                    dataGridView1.Rows.Add(new Object[] { r.Title, ResourceAllocator.getInstance().getRemainder(r, from, to) });
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            Resource r = ResourceStorage.getInstance().all().Find(x => x.Title.Equals(name));
            try
            {
                int amount = Convert.ToInt32(convert(cont_box.Text));
                DateTime fromDate = fromDateBox.Value;
                DateTime toDate = toDateBox.Value;
                if (toDate < fromDate)
                {
                    MessageBox.Show("بازه‌ی زمانی صحیح نمی‌باشد");
                }
                alloc = new Allocation(fromDate, toDate, r, null, amount);
                if (ResourceAllocator.getInstance().isConsistent(alloc))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("منبع کافی نمی‌باشد");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(new IncompleteFormException().Message);
            }
        }

        private void fromDateBox_ValueChanged(object sender, FreeControls.PersianMonthCalendarEventArgs e)
        {
            load_resources(exclude);
        }

        private void toDateBox_ValueChanged(object sender, FreeControls.PersianMonthCalendarEventArgs e)
        {
            load_resources(exclude);
        }



    }
}
