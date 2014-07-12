using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class TrainingResourceForm : Template
    {
        public TrainingResourceForm()
        {
            InitializeComponent();
        }

        private void TrainingResourceForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.trainings)
                dataGridView1.Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);
            StaticData.trainings.RemoveAt(i);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            new TrainingResourceEdit(false, StaticData.trainings[dataGridView1.SelectedRows[0].Index]).ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            TrainingResourceEdit f = new TrainingResourceEdit(true, StaticData.trainings[dataGridView1.SelectedRows[0].Index]);
            f.ShowDialog();
            StaticData.trainings[dataGridView1.SelectedRows[0].Index] = f.Item;
            TrainingResourceForm_Load(this, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TrainingResourceEdit f = new TrainingResourceEdit(true, null);
            f.ShowDialog();
            StaticData.trainings.Add(f.Item);
            TrainingResourceForm_Load(this, null);
        }
    }
}
