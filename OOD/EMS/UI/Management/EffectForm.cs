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
    public partial class EffectForm : TemplateForm
    {
        public EffectForm()
        {
            InitializeComponent();
            load_goals();
        }
       

        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.effects)
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
            AddEffectForm add = new AddEffectForm("", "");
            add.ShowDialog();
            dataGridView1.Rows.Add(add.name, add.dscp);
            object[] row = {add.name, add.dscp, "file.pdf"};
            StaticData.effects.Add(row);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            AddEffectForm add = new AddEffectForm((string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value,
                    (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value);
            add.ShowDialog();
            StaticData.effects[dataGridView1.SelectedRows[0].Index][0] = add.name;
            StaticData.effects[dataGridView1.SelectedRows[0].Index][1] = add.dscp;
            load_goals();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ask_confirm();
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);

        }
    }
}
