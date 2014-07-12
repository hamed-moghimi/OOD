using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class ExecutiveGoalForm : OOD.TemplateForm
    {
        public ExecutiveGoalForm()
        {
            InitializeComponent();
        }

        private void ExecutiveGoalForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.executiveGoals)
                dataGridView1.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);
            StaticData.executiveGoals.RemoveAt(i);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            new ExecutiveGoalEditForm(false, StaticData.executiveGoals[dataGridView1.SelectedRows[0].Index]).ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ResourceEditForm f = new ResourceEditForm(true, StaticData.executiveGoals[dataGridView1.SelectedRows[0].Index]);
            f.ShowDialog();
            StaticData.executiveGoals[dataGridView1.SelectedRows[0].Index] = f.Resource;
            ExecutiveGoalForm_Load(this, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ResourceEditForm f = new ResourceEditForm(true, null);
            f.ShowDialog();
            StaticData.executiveGoals.Add(f.Resource);
            ExecutiveGoalForm_Load(this, null);
        }
    }
}
