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
    public partial class AddGoalRelationForm : TemplateDialog
    {
        GeneralGoal_ExecutiveGoalRelation rel;

        public AddGoalRelationForm()
        {
            InitializeComponent();
            rel = null;
            load_goals();
        }

        private void load_goals()
        {
            genGrid.Rows.Clear();
            foreach (GeneralGoal goal in GeneralGoalStorage.getInstance().all())
            {
                genGrid.Rows.Add(new Object[] { goal.Title});
            }

            execGrid.Rows.Clear();
            foreach(ExecutiveGoal goal in ExecutiveGoalStorage.getInstance().all())
            {
                execGrid.Rows.Add(new Object[] { goal.Title});
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            String genName = (string)genGrid.Rows[genGrid.SelectedRows[0].Index].Cells[0].Value;
            String execName = (string)execGrid.Rows[execGrid.SelectedRows[0].Index].Cells[0].Value;
            GeneralGoal genGoal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(genName));
            ExecutiveGoal execGoal = ExecutiveGoalStorage.getInstance().all().Find(x => x.Title.Equals(execName));
            GeneralGoal_ExecutiveGoalRelation grel = 
                new GeneralGoal_ExecutiveGoalRelation(genGoal, execGoal, Convert.ToInt32(shareBox.Text));
            if (GeneralGoal_ExecutiveGoalRelationStorage.getInstance().all().Contains(grel))
            {
                MessageBox.Show(new RelationExistsException().Message);
            }
            else
            {
                GeneralGoal_ExecutiveGoalRelationStorage.getInstance().create(grel);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
        }
    }
}
