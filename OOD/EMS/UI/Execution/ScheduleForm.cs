using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.EMS.UI.ExecutiveForms
{
    public partial class ScheduleForm : TemplateForm
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.schedules)
                dataGridView1.Rows.Add(row);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            new ScheduleEditForm(false, StaticData.schedules[dataGridView1.SelectedRows[0].Index]).ShowDialog();
        }
    }
}
