using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;

namespace OOD.EMS.UI.Management
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
            foreach (EnvironEffect goal in EnvironEffectStorage.getInstance().all())
            {
                object[] row = new object[] { goal.Title, goal.getDateString(), goal.Description };
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
            DialogResult res = add.ShowDialog();
            if (res == DialogResult.OK)
            {
                EnvironEffect goal = new EnvironEffect(add.name, add.dscp);
                foreach (Attachment attach in add.attachments)
                {
                    goal.addAttachment(attach);
                }
                EnvironEffectStorage.getInstance().create(goal);
            }
            load_goals();
        }

        private void view_Click(object sender, EventArgs e)
        {
            String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            EnvironEffect goal = null;
            try
            {
                goal = EnvironEffectStorage.getInstance().all().Find(x => x.Title.Equals(name));
            }
            catch (Exception)
            {
            }

            if (goal != null)
            {
                (new ViewEffectForm(goal)).ShowDialog();
            }
        }

        
    }
}
