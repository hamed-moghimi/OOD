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
using OOD.EMS.Management;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Execution
{
    public partial class ExecutiveGoal_GeneralGoalRelationForm : TemplateForm
    {
        public ExecutiveGoal_GeneralGoalRelationForm()
        {
            InitializeComponent();
            load_relations();

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyExecutiveDocs())
            {
                addButton.Visible  = false;
                editButton.Location = new System.Drawing.Point(editButton.Location.X, editButton.Location.Y + 40);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            (new AddGoalRelationForm()).ShowDialog();
            load_relations();
        }

        private void load_relations()
        {
            dataGridView1.Rows.Clear();
            
            foreach (GeneralGoal_ExecutiveGoalRelation rel in GeneralGoal_ExecutiveGoalRelationStorage.getInstance().all())
            {
                dataGridView1.Rows.Add(new Object[] { rel.GenGoal.Title, rel.ExecGoal.Title, 
                    rel.Contribution.ToString(), rel.getDateString()});
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            String genName = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            String execName = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value;
            GeneralGoal genGoal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(genName));
            ExecutiveGoal execGoal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(execName));
            GeneralGoal_ExecutiveGoalRelation rel = GeneralGoal_ExecutiveGoalRelationStorage.getInstance().all()
                .Find(x => x.GenGoal.Equals(genGoal) && x.ExecGoal.Equals(execGoal));
            (new ViewGoalRelationForm(rel)).ShowDialog();
            
        }
    }
}
