using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Execution
{
    public partial class SelectTaskForm : TemplateDialog
    {

        public Task goal { get; set; }
        public int Cont { get; set; }

        public SelectTaskForm(List<Task> exclude)
        {
            InitializeComponent();
            load_goals(exclude);
        }


        private void load_goals(List<Task> exclude)
        {
            dataGridView1.Rows.Clear();
            foreach (Task goal in TaskStorage.getInstance().all())
            {
                if (!exclude.Contains(goal))
                {
                    dataGridView1.Rows.Add(new Object[] { goal.Title, goal.getStartDateString(), goal.getDueDateString() });
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
            if (cont_box.Text.Trim().Count() == 0)
            {
                MessageBox.Show(new IncompleteFormException().Message);
                return;
            }
            try
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                Cont = Convert.ToInt32(convert(cont_box.Text));
                goal = TaskStorage.getInstance().all().Find(x => x.Title.Equals(name));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(new IncompleteFormException().Message);
                return;
            }
        }



    }
}
