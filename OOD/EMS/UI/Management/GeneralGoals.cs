using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Management
{
    public partial class GeneralGoals : Template
    {
        public GeneralGoals()
        {
            InitializeComponent();
            load_goals();
        }
       

        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.generalGoals)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddGeneralGoals add = new AddGeneralGoals("", "");
            add.ShowDialog();
            dataGridView1.Rows.Add(add.name, add.dscp);
            object[] row = {add.name, add.dscp, "file.pdf"};
            StaticData.generalGoals.Add(row);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            AddGeneralGoals add = new AddGeneralGoals((string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value,
                    (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value);
            add.ShowDialog();
            StaticData.generalGoals[dataGridView1.SelectedRows[0].Index][0] = add.name;
            StaticData.generalGoals[dataGridView1.SelectedRows[0].Index][1] = add.dscp;
            load_goals();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ask_confirm();
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ViewGeneralGoal()).ShowDialog();
        }
    }
}
